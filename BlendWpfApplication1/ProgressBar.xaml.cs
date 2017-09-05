using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BlendWpfApplication1
{
    /// <summary>
    /// ProgressBar.xaml 的交互逻辑
    /// </summary>
    public partial class ProgressBar : Window
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        private void beginImport()
        {
            double value = 0;
            double total = 100d;//得到循环次数
            while (value < total)
            {
                double jd = Math.Round(((value + 1) * (pb_import.Maximum / total)), 4);
                //pb_import.Dispatcher.Invoke(new Action<System.Windows.DependencyProperty, object>(pb_import.SetValue),
                //    System.Windows.Threading.DispatcherPriority.Background,
                //    ProgressBar.ValueProperty,jd);
                //这里是加数据或费时的操作，我这里让它挂起300毫秒
                Thread.Sleep(300);
                txtJD.Text = "当前的进度是:" + (value + 1) + "(实际值)" + jd + "(百分比)";
                value++;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            beginImport();
            ////new Thread(new ThreadStart(beginImport)).Start();


        }
    }
}
