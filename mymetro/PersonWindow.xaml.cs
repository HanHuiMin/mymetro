using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.ComponentModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Data;

namespace mymetro
{
	/// <summary>
	/// PersonWindow.xaml 的交互逻辑
	/// </summary>
	//public class userMessage : INotifyPropertyChanged
	//{
	//	public string user_id;//用户名
	//	public string user_password;//密码
	//	public string user_name;//用户姓名
	//	public string user_idnum;//用户身份证号
	//	public string user_tel;//用户电话
	//	public string user_add;//用户住址
	//	public string _id
	//	{
	//		set
	//		{
	//			user_id = value;
	//			NotifyPropertyChanged("Id");
	//		}
	//		get { return user_id; }
	//	}

	//	public event PropertyChangedEventHandler PropertyChanged;
	//	private void NotifyPropertyChanged(string propertyId)
	//	{
	//		if (PropertyChanged != null)
	//		{
	//			PropertyChanged(this, new PropertyChangedEventArgs(propertyId));
	//		}
	//	}
	//}
	public partial class PersonWindow : MetroWindow
	{
		//public string userName;//用户名
		//public string userPassword;//登录密码
		//public userMessage user;
		public PersonWindow()
		{
			InitializeComponent();
			//user = new userMessage();
			////设置用户信息
			//user.user_id = CommonData.user_id;
			//user.user_password = CommonData.user_password;
			////数据绑定
			//Binding binding1 = new Binding();
			//binding1.Source = user;
			//binding1.Path = new PropertyPath("Text");
			//BindingOperations.SetBinding(this.passenger_id, TextBox.TextProperty, binding1);

			//查询数据库，输出此用户是否存在
			DataTable dt = Tools.getDataTable("select * from passenger " + "where passenger_id=\"" + CommonData.user_id + "\"",0);
			if (dt.Rows.Count == 0)
			{
				queryStatusLabel.Content = "[仅在开发阶段显示]很抱歉，" + CommonData.user_id + ",我们在数据库中没有找到您的信息";
			}
			else
			{
				//填写用户信息
				CommonData.user_password = dt.Rows[0][1].ToString();
				CommonData.user_name = dt.Rows[0][2].ToString();
				CommonData.user_idnum = dt.Rows[0][3].ToString();
				CommonData.user_tel = dt.Rows[0][4].ToString();
				CommonData.user_add = dt.Rows[0][5].ToString();

				queryStatusLabel.Content = "欢迎您使用飞哪儿机票管理系统," + CommonData.user_name;
				//填写个人信息页面
				passenger_id.Text = CommonData.user_id;
				passenger_password.Text = CommonData.user_password;
				passenger_Idnum.Text = CommonData.user_idnum;
				passenger_Name.Text = CommonData.user_name;
				passenger_tel.Text = CommonData.user_tel;
				passenger_add.Text = CommonData.user_add;
			}
			
		}

		private void button1_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			//下面是示例，可以删除
			//textBox1.Text = "[示例]用户名：" + userName + " 密码：" + userPassword;
		}

		private void add_change_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
