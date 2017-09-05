using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CoreAudio;
using System.Management;
using System.Runtime.InteropServices;

namespace BlendWpfApplication1
{
    /// <summary>
    /// ScreenLight.xaml 的交互逻辑
    /// </summary>
    public partial class ScreenLight : Window
    {
        byte[] bLevels;
        private MMDevice device;
        public ScreenLight()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Window_Load);

        }
        private void Window_Load(object sender, RoutedEventArgs e)
        {

            //亮度
            bLevels = GetBrightnessLevels();
            if (bLevels.Count() == 0)
            {
                this.brightnessSlider.Maximum = 256;
                this.brightnessSlider.LargeChange = 1;
            }
            else
            {
                brightnessSlider.Value = GetBrightness();
                brightnessSlider.Maximum = bLevels.Count() - 1;
            }

            this.brightnessSlider.ValueChanged += new RoutedPropertyChangedEventHandler<double>(brightnessSlider_ValueChanged);

            //音量
            this.volumeSlider.Maximum = 100;
            this.volumeSlider.LargeChange = 1;

            MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
            device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
            this.volumeSlider.Value = (int)(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
            device.AudioEndpointVolume.OnVolumeNotification += new AudioEndpointVolumeNotificationDelegate(AudioEndpointVolume_OnVolumeNotification);
            this.volumeSlider.ValueChanged += new RoutedPropertyChangedEventHandler<double>(volumeSlider_ValueChanged);

        }

        private void brightnessSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (bLevels.Count() == 0)
            {
                SetGamma((int)this.brightnessSlider.Value);
            }
            else
            {
                SetBrightness(bLevels[(int)this.brightnessSlider.Value]);
            }
        }

        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            device.AudioEndpointVolume.MasterVolumeLevelScalar = ((float)this.volumeSlider.Value / 100.0f);
        }

        #region 音量信息
        void AudioEndpointVolume_OnVolumeNotification(AudioVolumeNotificationData data)
        {
            if (this.CheckAccess())
            {
                object[] Params = new object[1];
                Params[0] = data;
                this.Dispatcher.Invoke(new AudioEndpointVolumeNotificationDelegate(AudioEndpointVolume_OnVolumeNotification), Params);
            }
            else
            {
                this.volumeSlider.Dispatcher.Invoke(new Action(() => { this.volumeSlider.Value = (int)(data.MasterVolume * 100); }));
            }
        }
        #endregion

        #region 亮度调节

        #region WMI方式(笔记本等）
        private byte[] GetBrightnessLevels()
        {
            ManagementScope s = new ManagementScope("root\\WMI");

            SelectQuery q = new SelectQuery("WmiMonitorBrightness");

            ManagementObjectSearcher mos = new ManagementObjectSearcher(s, q);

            byte[] BrightnessLevels = new byte[0];

            try
            {
                ManagementObjectCollection moc = mos.Get();

                foreach (ManagementObject o in moc)
                {
                    BrightnessLevels = (byte[])o.GetPropertyValue("Level");
                    break;
                }

                moc.Dispose();
                mos.Dispose();
            }
            catch
            {

            }

            return BrightnessLevels;
        }

        private void SetBrightness(byte targetBrightness)
        {
            ManagementScope s = new ManagementScope("root\\WMI");

            SelectQuery q = new SelectQuery("WmiMonitorBrightnessMethods");

            ManagementObjectSearcher mos = new ManagementObjectSearcher(s, q);

            ManagementObjectCollection moc = mos.Get();

            foreach (ManagementObject o in moc)
            {
                o.InvokeMethod("WmiSetBrightness", new Object[] { UInt32.MaxValue, targetBrightness });
                break;
            }

            moc.Dispose();
            mos.Dispose();
        }

        private int GetBrightness()
        {
            ManagementScope s = new ManagementScope("root\\WMI");

            SelectQuery q = new SelectQuery("WmiMonitorBrightness");

            ManagementObjectSearcher mos = new ManagementObjectSearcher(s, q);

            ManagementObjectCollection moc = mos.Get();

            byte curBrightness = 0;
            foreach (ManagementObject o in moc)
            {
                curBrightness = (byte)o.GetPropertyValue("CurrentBrightness");
                break;
            }

            moc.Dispose();
            mos.Dispose();

            return (int)curBrightness;
        }
        #endregion

        #region Gamma方式(台式机显示器等）
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll")]
        public static extern int GetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);

        [DllImport("gdi32.dll")]
        public static extern bool SetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct RAMP
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Red;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Green;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Blue;
        }

        public static void SetGamma(int gamma)
        {
            if (gamma <= 256 && gamma >= 1)
            {
                RAMP ramp = new RAMP();
                ramp.Red = new ushort[256];
                ramp.Green = new ushort[256];
                ramp.Blue = new ushort[256];
                for (int i = 1; i < 256; i++)
                {
                    int iArrayValue = i * (gamma + 128);

                    if (iArrayValue > 65535)
                        iArrayValue = 65535;
                    ramp.Red[i] = ramp.Blue[i] = ramp.Green[i] = (ushort)iArrayValue;
                }
                SetDeviceGammaRamp(GetDC(IntPtr.Zero), ref ramp);
            }
        }

        #endregion

        #endregion
    }
}
