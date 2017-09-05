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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace BlendWpfApplication1
{
    /// <summary>
    /// SlideTest.xaml 的交互逻辑
    /// </summary>
    public partial class SlideTest : Window
    {
        private DoubleAnimation c_daListAnimation;
        public bool c_bState = true;//记录菜单栏状态 false隐藏 true显示
        public SlideTest()
        {
            InitializeComponent();
        }

        private void No_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (c_bState)
            {

                c_bState = false;
                c_daListAnimation.From = 0;
                c_daListAnimation.To = -154;
                cd.Width = new GridLength(0);
            }
            else
            {
                c_bState = true;
                c_daListAnimation.From = -154;
                c_daListAnimation.To = 0;
                cd.Width = new GridLength(154);
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            c_daListAnimation = new DoubleAnimation();
        }
    }
}
