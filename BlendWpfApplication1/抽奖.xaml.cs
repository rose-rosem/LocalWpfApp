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
using System.Windows.Threading;

namespace BlendWpfApplication1
{
    /// <summary>
    /// Gift.xaml 的交互逻辑
    /// </summary>
    public partial class Gift : Window
    {

        //Random rdSwitch = new Random();
        //Random rdResult = new Random();

        DispatcherTimer timerReward = new DispatcherTimer();

        private int timeSwtich;

        int num = 1;      
        public Gift()
        {
            InitializeComponent();
            timerReward.Interval = TimeSpan.FromMilliseconds(150);
            timerReward.Tick += timerReward_Tick;
        }


        void timerReward_Tick(object sender, EventArgs e)
        {
            timeSwtich++;
            RewardClear();   
            //匹配名为 “Reward（？）”的grid 并加入最外层的border
            if (num < 9)
            {
                string rewardGridName = "Reward" + num.ToString();
                Grid gridReward = this.FindName(rewardGridName) as Grid;
                if (gridReward != null)
                {
                    Border outborder = new Border();
                    outborder.Background = new SolidColorBrush(Color.FromArgb(95, 0, 0, 0));
                    if (num == 1)
                    {
                        outborder.CornerRadius = new CornerRadius(15, 0, 0, 0);

                    }
                    if (num == 3)
                    {
                        outborder.CornerRadius = new CornerRadius(0, 0, 0, 15);

                    }
                    if (num == 5)
                    {
                        outborder.CornerRadius = new CornerRadius(0, 0, 15, 0);

                    }
                    if (num == 7)
                    {
                        outborder.CornerRadius = new CornerRadius(0, 15, 0, 0);

                    }
                    gridReward.Children.Add(outborder);
                }
                num++;
            }
            else
            {
                num = 1;
                //string rewardGridName = "Reward" + num.ToString();
                //Grid gridReward = this.FindName(rewardGridName) as Grid;
                //if (gridReward != null)
                //{
                //    Border outborder = new Border();
                //    outborder.Background = new SolidColorBrush(Color.FromArgb(95, 0, 0, 0));
                //    gridReward.Children.Add(outborder);
                //}
                //num++;
            }
            


            if (timeSwtich > 40)
            {
                //Finish();
                timerReward.Stop();
            }

        }

        private void RewardClear()
        {
            //循环找到8个奖品的grid并删除最外层的boder
            for (int i = 1; i < 9; i++)
            {
                string rewardGridName = "Reward" + i.ToString();
                Grid gridReward = this.FindName(rewardGridName) as Grid;
                if (gridReward != null)
                {
                    gridReward.Children.RemoveRange(3, 1);
                }
            }
        }




        //private void Finish()
        //{
        //    RewardClear();
        //    int i = rdResult.Next(0, 100);
        //    int rewardID = -1;
        //    try
        //    {
        //        if (i < 5)
        //        {
        //            Reward1.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
        //            rewardID = Int32.Parse(Reward1.Tag.ToString());
        //        }
        //        else if (i >= 5 && i < 20)
        //        {
        //            Reward2.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
        //            rewardID = Int32.Parse(Reward2.Tag.ToString()) ;

        //        }
        //        else if (i >= 20 && i < 50)
        //        {
        //            Reward3.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
        //            rewardID = Int32.Parse(Reward3.Tag.ToString());

        //        }
        //        else if (i > 50)
        //        {
        //            Reward4.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
        //            rewardID = Int32.Parse(Reward4.Tag.ToString());

        //        }
        //        Dictionary<string,string> dic = new Dictionary<string,string>();
        //        dic.Add("pStudentID",hankFile.studentID.ToString());
        //        dic.Add("pRewardID", rewardID.ToString());
        //        HankWcf.returnDsDt("usp_lucky_draw_play_log", dic);
        //        if (HankWcf.returnFlag == false)
        //        {
        //            RewardClear();
        //            MessageBox.Show("网络故障，请重新抽奖" +　HankWcf.wcfError);
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        RewardClear();
        //        MessageBox.Show("网络故障，请重新抽奖" + ex.ToString()); 
        //    }

        //}
        private void BtnStartDraw_click(object sender, RoutedEventArgs e)
        {
            timeSwtich = 0;
            timerReward.Start();

        }

    }
}
