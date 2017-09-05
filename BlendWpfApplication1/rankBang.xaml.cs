using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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


namespace BlendWpfApplication1
{
    /// <summary>
    /// bang.xaml 的交互逻辑
    /// </summary>
    /// 

    //枚举
    public enum sexual_enum
    {
        Boy, Girl
    }
    public enum dep_enum
    {
        Chinese, Math, English, Software, Manage
    }

    public class people
    {
        public string Name { get; set; }
        public sexual_enum sexual { get; set; }
        public dep_enum dep { get; set; }
        public bool mar { get; set; }
        public Uri Email { get; set; }
    }

    public partial class rankBang : Window
    {


        ObservableCollection<people> peopleList = new ObservableCollection<people>();
        //DataTable dtt;
        public rankBang()
        {
            InitializeComponent();
            //gettable();
            //datagrid1.ItemsSource = dtt.DefaultView;          
            peopleList.Add(new people()
            {
                Name = "Eric",
                sexual = sexual_enum.Boy,
                dep = dep_enum.Manage,
                mar = true,
                Email = new Uri("mailto:cq_12@hotmail.com")
            });
            peopleList.Add(new people()
            {
                Name = "Hank",
                sexual = sexual_enum.Boy,
                dep = dep_enum.Manage,
                mar = true,
                Email = new Uri("mailto:172637192@qq.com")
            });

            peopleList.Add(new people()
            {
                Name = "Misaki-阿叮",
                sexual = sexual_enum.Girl,
                dep = dep_enum.Chinese,
                mar = true,
                Email = new Uri("mailto:489545737@qq.com")
            });

            peopleList.Add(new people()
            {
                Name = "邓天宝",
                sexual = sexual_enum.Boy,
                dep = dep_enum.Math,
                mar = false,
                Email = new Uri("mailto:854413848@qq.com")
            });
            peopleList.Add(new people()
            {
                Name = "张红云",
                sexual = sexual_enum.Girl,
                dep = dep_enum.Chinese,
                mar = false,
                Email = new Uri("mailto:1255688344@qq.com")
            });
            peopleList.Add(new people()
            {
                Name = "邓晶晶",
                sexual = sexual_enum.Girl,
                dep = dep_enum.English,
                mar = false,
                Email = new Uri("mailto:1284885587@qq.com")
            });
            peopleList.Add(new people()
            {
                Name = "龚怡桔",
                sexual = sexual_enum.Girl,
                dep = dep_enum.English,
                mar = false,
                Email = new Uri("mailto:1437993657@qq.com")
            });
            peopleList.Add(new people()
            {
                Name = "谈咏洁",
                sexual = sexual_enum.Girl,
                dep = dep_enum.English,
                mar = false,
                Email = new Uri("mailto:2824471689@qq.com")
            });
            peopleList.Add(new people()
            {
                Name = "赵梦苑",
                sexual = sexual_enum.Girl,
                dep = dep_enum.Math,
                mar = false,
                Email = new Uri("mailto:1142049350@qq.com")
            });
            peopleList.Add(new people()
            {
                Name = "张蒙蒙",
                sexual = sexual_enum.Girl,
                dep = dep_enum.English,
                mar = false,
                Email = new Uri("mailto:zhangmengmeng@qq.com")
            });
            peopleList.Add(new people()
            {
                Name = "rosem",
                sexual = sexual_enum.Girl,
                dep = dep_enum.Software,
                mar = false,
                Email = new Uri("mailto:rose_rosem@163.com")
            });

            datagrid1.DataContext = peopleList;

        }
        private void gettable()
        {
            //dtt = new DataTable();   
            //dtt.Columns.Add("排名");
            //DataRow dr1 = dtt.NewRow();
            //dr1[0] = "NO1";
            //dtt.Rows.Add(dr1);
        }



    }
}
