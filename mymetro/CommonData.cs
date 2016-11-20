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
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace mymetro
{
	//在此定义全局的数据
	public abstract class CommonData
	{
		public static string user_id;//用户名
		public static string user_password;//密码
		public static string user_name;//用户姓名
		public static string user_idnum;//用户身份证号
		public static string user_tel;//用户电话
		public static string user_add;//用户住址
	}
}
