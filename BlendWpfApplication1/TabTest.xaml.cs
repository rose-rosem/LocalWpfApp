﻿using System;
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

namespace BlendWpfApplication1
{
    /// <summary>
    /// TabTest.xaml 的交互逻辑
    /// </summary>
    public partial class TabTest : Window
    {
        public TabTest()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TabControl2 item = new TabControl2();
            item.Header = string.Format("Header{0}", tab_Main.Items.Count);
            item.ToolTip = string.Format("Header{0}", tab_Main.Items.Count);
            item.Margin = new Thickness(0, 0, 1, 0);
            item.Height = 28;
            Label lbl = new Label() { Content = string.Format("Label{0}", tab_Main.Items.Count) };
            Button btn = new Button() { Width = 132, Height = 32, Content = string.Format("Button{0}", tab_Main.Items.Count) };
            StackPanel sPanel = new StackPanel();
            sPanel.Children.Add(lbl);
            sPanel.Children.Add(btn);
            item.Content = sPanel;
            tab_Main.Items.Add(item);
        }
    }
}
