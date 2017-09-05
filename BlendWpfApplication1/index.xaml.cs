using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Reflection;
using System.Windows.Threading;
using CoreAudio;
using NativeWifi;


namespace BlendWpfApplication1
{
    /// <summary>
    /// index.xaml 的交互逻辑
    /// </summary>
    public partial class index : Window
    {
        DispatcherTimer _timer刷新电池状态 = new DispatcherTimer();

        public class WlanInfo
        {
            public string SSID { get; set; }
            public int WlanSignalQuality { get; set; }
        }

        public index()
        {
            InitializeComponent();
            this.InitializeComponent();
            _timer刷新电池状态.Start();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GetPowerStatus();
            GetWifiInfo();
            _timer刷新电池状态.Interval = TimeSpan.FromMilliseconds(100);
            _timer刷新电池状态.Tick += _timer刷新电池状态_Tick;
        }

        void _timer刷新电池状态_Tick(object sender, EventArgs e)
        {
            GetPowerStatus();
        }



        private void GetPowerStatus()
        {
            battery.Visibility = System.Windows.Visibility.Hidden;
            batterypercentage.Visibility = System.Windows.Visibility.Hidden;
            batteryPowerProgressBar.Visibility = System.Windows.Visibility.Visible;

            Type t = typeof(System.Windows.Forms.PowerStatus);
            PropertyInfo[] pi = t.GetProperties();

            //将PowerStatus的5个属性的状态值转成字符串
            string PowerLineStatus = pi[0].GetValue(SystemInformation.PowerStatus, null).ToString();
            string BatteryLifePercent = pi[3].GetValue(SystemInformation.PowerStatus, null).ToString();


            //判断是否是充电状态
            if (PowerLineStatus == "Offline")
            {
                this.batteryPowerProgressBar.Value = Convert.ToDouble(BatteryLifePercent) * 100;
                if (this.batteryPowerProgressBar.Value <= 70)
                {
                    batteryPowerProgressBar.Foreground = new SolidColorBrush(Color.FromRgb(244, 180, 89));
                }
                else if (this.batteryPowerProgressBar.Value <= 30)
                {
                    batteryPowerProgressBar.Foreground = new SolidColorBrush(Color.FromRgb(226, 87, 76));
                }
                if (this.batteryPowerProgressBar.Value <= 20)
                {
                    System.Windows.MessageBox.Show("电量不足20%了，记得及时充电哦");

                    batterypercentage.Visibility = System.Windows.Visibility.Visible;
                    batterypercentage.Text = (this.batteryPowerProgressBar.Value.ToString()) + "%";
                }
            }
            else
            {
                batteryPowerProgressBar.Visibility = System.Windows.Visibility.Hidden;
                battery.Visibility = System.Windows.Visibility.Visible;
            }
        }


        #region wlan信息

        private void GetWifiInfo()
        {
            WlanClient client = new WlanClient();
            IList<WlanInfo> wlanList = new List<WlanInfo>();
            foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
            {
                Wlan.WlanAvailableNetwork[] networks = wlanIface.GetAvailableNetworkList(0);

                foreach (Wlan.WlanAvailableNetwork network in networks)
                {
                    this.wifiProgressBar.Value = (int)network.wlanSignalQuality;
                    wlanList.Add(new WlanInfo() { SSID = GetStringForSSID(network.dot11Ssid), WlanSignalQuality = (int)network.wlanSignalQuality });
                }
            }
            if (wlanList.Count < 0)
            {
                System.Windows.MessageBox.Show("网络连接出错啦！");
            }
        }
        private string GetStringForSSID(Wlan.Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        }

        #endregion

    }
}
