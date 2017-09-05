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

namespace BlendWpfApplication1
{
	/// <summary>
	/// Window1.xaml 的交互逻辑
	/// </summary>
	public partial class Window1 : Window
	{
        DispatcherTimer _timer刷新电池状态 = new DispatcherTimer();
		public Window1()
		{
			this.InitializeComponent();
            _timer刷新电池状态.Start();
			// 在此点之下插入创建对象所需的代码。
		}


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //GetPowerStatus();
            _timer刷新电池状态.Interval = TimeSpan.FromMilliseconds(100);
            _timer刷新电池状态.Tick += _timer刷新电池状态_Tick;
        }

        void _timer刷新电池状态_Tick(object sender, EventArgs e)
        {
            //GetPowerStatus();
        }

        //private void GetPowerStatus()
        //{
        //    battery.Visibility = System.Windows.Visibility.Hidden;
        //    batterypercentage.Visibility = System.Windows.Visibility.Hidden;
        //    powerProgressBar.Visibility = System.Windows.Visibility.Visible;

        //    Type t = typeof(System.Windows.Forms.PowerStatus);
        //    PropertyInfo[] pi = t.GetProperties();

        //    //将PowerStatus的5个属性的状态值转成字符串
        //    string PowerLineStatus = pi[0].GetValue(SystemInformation.PowerStatus, null).ToString();
        //    string BatteryLifePercent = pi[3].GetValue(SystemInformation.PowerStatus, null).ToString();


        //    //判断是否是充电状态
        //    if (PowerLineStatus == "Offline")
        //    {
        //        this.powerProgressBar.Value = Convert.ToDouble(BatteryLifePercent) * 100;
        //        if (this.powerProgressBar.Value <= 70 )
        //        {
        //            powerProgressBar.Foreground = new SolidColorBrush(Color.FromRgb(244, 180, 89));
        //        }
        //        else if(this.powerProgressBar.Value <= 30)
        //        {
        //            powerProgressBar.Foreground = new SolidColorBrush(Color.FromRgb(226, 87, 76));
        //        }
        //        if (this.powerProgressBar.Value <= 20)
        //        {
        //            System.Windows.MessageBox.Show("电量不足20%了，记得及时充电哦");

        //            batterypercentage.Visibility = System.Windows.Visibility.Visible;
        //            batterypercentage.Text = (this.powerProgressBar.Value.ToString()) + "%";
        //        }
        //    }
        //    else
        //    {
        //        powerProgressBar.Visibility = System.Windows.Visibility.Hidden;
        //        battery.Visibility = System.Windows.Visibility.Visible;
        //    }
        //}

	}
}