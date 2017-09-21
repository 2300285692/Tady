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
    public partial class kuncun1 : Form
    {
        public kuncun1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list1 = new List<string>();
            string strConn = @"server=TRAVELERS;uid=sa;pwd=1234567890;database=Tady";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
            SqlConnection ConnSql = new SqlConnection(strConn);//Sql链接类的实例化
            ConnSql.Open();//打开数据库
            string strSQL = "select * from Factory ";//要执行的SQL语句
            SqlDataAdapter da = new SqlDataAdapter(strSQL, ConnSql);//创建DataAdapter数据适配器实例
            SqlConnection mycon = new SqlConnection(strConn);
            // mycon.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);//填充数据到dt
            foreach (DataRow row in dt.Rows)
            {
                list1.Add(row["Factory_ID"].ToString());
            }
            String[] s1 = list1.ToArray();
            int flag = 0, j = 0;
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                if (s1[i].Equals(tb1.Text))
                {
                    flag = 1;
                    j = i;
                    break;
                }
            }
         if (tb1.Text == "" || tb2.Text == "" || tb3.Text == "" || tb4.Text == "")
            {
                MessageBox.Show("企业信息不能为空！");
            }
          else
            {
                if (flag==1)
                {
                    MessageBox.Show("该企业已存在！");
                }
                else
                {
                    string sql4 = "insert into Factory values ('" + tb1.Text + "','" + tb2.Text + "','" + tb3.Text + "','" + tb4.Text + "')";
                    SqlCommand com = new SqlCommand(sql4, ConnSql);
                    SqlDataReader dr = com.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("添加成功！");
                }

            }
        }
    }
}
