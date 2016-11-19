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
	/// <summary>
	/// 工具集，包含数据库的操作以及各种工具
	/// </summary>
	public abstract class Tools
	{
		/// <summary>
		/// 连接数据库，将要显示的表显示在dataGrid中
		/// </summary>
		/// <param name="dataGrid">显示数据表的区域</param>
		/// <param name="tableName">表的名称</param>
		/// <param name="tableIndex">表的序号，从0开始</param>
		public static void showDatabase(DataGrid dataGrid,String tableName,int tableIndex)//显示数据库
		{
			//自动连接数据库
			dataGrid.DataContext= MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "select * from "+tableName, null).Tables[tableIndex].DefaultView;
		}
		/// <summary>
		/// 通过sql命令插入数据，插入成功返回true，不成功返回false
		/// </summary>
		/// <param name="sqlcmd"></param>
		/// <returns></returns>
		public static bool insertData(String sqlcmd)
		{
			try
			{
				MySqlHelper.ExecuteNonQuery(MySqlHelper.Conn, CommandType.Text, sqlcmd, null);
			}
			catch (Exception e1)
			{
				return false;
			}
			return true;
		}
		/// <summary>
		/// 弹出提示框，输入的提示信息
		/// </summary>
		/// <param name="str"></param>
		public static void messageBox(String str)
		{
			MessageBox.Show(str);
		}
	}
}
