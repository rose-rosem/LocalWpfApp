using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;

namespace BlendWpfApplication1
{
    /// <summary>
    /// Slide.xaml 的交互逻辑
    /// </summary>
    public partial class Slide : Window
    {

        DispatcherTimer timer = new DispatcherTimer();
        string currentPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "AdvertisingImages";
        public List<Photo> photos = new List<Photo>();
        public Slide()
        {
            this.InitializeComponent();
            GetAllImagePath(currentPath);
            listBox1.ItemsSource = photos;
            // 在此点之下插入创建对象所需的代码。
        }
        public class Photo
        {
            public string FullPath { get; set; }
        }


        public void GetAllImagePath(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles("*.*", SearchOption.AllDirectories);
            if (files != null && files.Length > 0)
            {
                foreach (var file in files)
                {
                    if (file.Extension == (".jpg") ||
                        file.Extension == (".png") ||
                        file.Extension == (".bmp") ||
                        file.Extension == (".gif"))
                    {
                        photos.Add(new Photo()
                        {
                            FullPath = file.FullName
                        });
                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {

                if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
                {
                    listBox1.SelectedIndex = 0;

                }
                else
                {
                    listBox1.SelectedIndex += 1;
                    listBox1.ScrollIntoView(listBox1.Items[listBox1.SelectedIndex]);
                }
            }
        }

        //下面这个是ListBox的两个事件Unload和Load
        private void listBox1_Unloaded(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void listBox1_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Interval = TimeSpan.FromMilliseconds(2000);
            timer.Tick += new EventHandler(timer_Tick);
            listBox1.SelectedIndex = 0;
            timer.Start();
        }
    }
}

