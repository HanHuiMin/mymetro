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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
namespace mymetro
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow:MetroWindow
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, RoutedEventArgs e)
		{
			dataWindow dw = new dataWindow();
			dw.Show();
			Tools.showDatabase(dw.dataGrid,"passenger",0);
			
		}
	}
}