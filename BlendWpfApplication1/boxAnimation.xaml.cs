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
    /// boxAnimation.xaml 的交互逻辑
    /// </summary>
    ///

    public partial class boxAnimation : Window
    {

        System.Windows.Media.Animation.Storyboard storyboard = null;
        public boxAnimation()
        {
            InitializeComponent();
            storyboard = (System.Windows.Media.Animation.Storyboard)this.Resources["box"];
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            storyboard.Begin();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            storyboard.Pause();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            storyboard.Resume();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            storyboard.Stop();
        }

        private void btnReward1_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Name);
            btn.Name = "rebox";
            MessageBox.Show(btn.Name);
        }

    }
}
