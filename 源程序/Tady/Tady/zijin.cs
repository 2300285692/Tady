using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tady
{
    public partial class zijin : Form
    {
        public zijin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbyanzheng.Text.Trim() == "yzxx")
            {
                if (tb1.Text.Trim() == "")
                {
                    MessageBox.Show("输入资金不能为空！");
                }
                else
                {
                    string strConn = @"server=TRAVELERS;uid=sa;pwd=1234567890;database=Tady";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
                    SqlConnection ConnSql = new SqlConnection(strConn);//Sql链接类的实例化
                    ConnSql.Open();//打开数据库
                    string sql4 = "update  Zjin set zijin+=" + tb1.Text.Trim() + "where id=1";
                    SqlCommand com = new SqlCommand(sql4, ConnSql);
                    SqlDataReader dr = com.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("添加成功！");
                }
            }
            else
            {
                MessageBox.Show("输入正确的验证码！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系老板，电话XXX-XXX-XXX");
        }
    }
}
