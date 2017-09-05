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
using System.Drawing;
using System.Windows.Shapes;
using System.IO;

namespace BlendWpfApplication1
{
    /// <summary>
    /// Window2.xaml 的交互逻辑
    /// </summary>
    public partial class Window2 : Window
    {            
        string pathL = @"C:\img\1.jpg";
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                screenShot(pathL);
            }
            catch (Exception ee)
            {

                System.Windows.MessageBox.Show(ee.ToString());
            }
            
        }
        public static void screenShot(string localPath)
        {
            System.Drawing.Rectangle rc = new System.Drawing.Rectangle(100, 0, 100, 100);
            var bitmap = new Bitmap(rc.Width, rc.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics memoryGrahics = Graphics.FromImage(bitmap))
            {
                memoryGrahics.CopyFromScreen(rc.X, rc.Y, 0, 0, rc.Size, CopyPixelOperation.SourceCopy);
            }
            if (File.Exists(localPath) == false)
                bitmap.Save(localPath, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
