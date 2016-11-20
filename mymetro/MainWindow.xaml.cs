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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.Collections;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
namespace mymetro
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow:MetroWindow
	{
		public dataWindow dw;//数据表窗口
		public PersonWindow pw;//个人用户界面
		public MainWindow()
		{
			InitializeComponent();
		}
		
		private void button1_Click(object sender, RoutedEventArgs e)//查看数据表
		{
			//dw = new dataWindow();
			//dw.Show();
			//Tools.showDatabase(dw.dataGrid,"passenger",0);
			DataTable dt = Tools.getDataTable("select * from passenger",0);
			Console.WriteLine(dt.Rows[1][0]);
		}

		private void login_button_Click(object sender, RoutedEventArgs e)//显示个人页面
		{
			CommonData.user_id = userId_text.Text;//传递用户名和密码
			CommonData.user_password = password_text.Password;
			status_text.Text = "[debug]用户名:"+userId_text.Text +" 密码:"+ password_text.Password;
			pw = new PersonWindow();//创建一个新的窗口
			pw.Show();//显示窗口
		}

		private void comein_button_Click(object sender, RoutedEventArgs e)
		{
			status_text.Text = admin_text.Text +" "+ adminPassword_text.Password;
		}

		private void mytest_button_Click(object sender, RoutedEventArgs e)//test按钮
		{

			//设置数据库连接
			if (dataBaseName_text.Text.Equals("") == false)//如果数据库名称不为空，否则使用默认连接
			{
				MySqlHelper.Conn = "Database='" + dataBaseName_text.Text + "';Data Source='localhost';User Id='root';Password='" + dataBasePassword_text.Password + "';charset='utf8';pooling=true";
			}
			//清空数据表
			for(int i = 0; i < listBox.Items.Count; i++)
			{
				listBox.Items.RemoveAt(i);
			}
			//重新获取数据表
			DataTable dt = Tools.getDataTable("show tables", 0);
			listBox.Items.Add("数据库中现有的表有：");
			for(int i = 0; i < dt.Rows.Count; i++)
			{
				listBox.Items.Add(dt.Rows[i][0]);
			}
			//显示查询窗口
			dw = new dataWindow();
			dw.Show();
			
		}

		private void cmd_button_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
