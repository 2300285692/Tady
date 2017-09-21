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
    public partial class maijiaxinxi : Form
    {
        public maijiaxinxi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list1 = new List<string>();
            string strConn = @"server=TRAVELERS;uid=sa;pwd=1234567890;database=Tady";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
            SqlConnection ConnSql = new SqlConnection(strConn);//Sql链接类的实例化
            ConnSql.Open();//打开数据库
            string strSQL = "select * from Buyer ";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, ConnSql);//创建DataAdapter数据适配器实例
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                list1.Add(row["Buyer_Nu"].ToString());
            }
            String[] s1 = list1.ToArray();
            int flag = 0;//判断账号是否存在
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                if (s1[i].Equals(tbbianhao.Text.Trim()))
                {
                    flag = 1;
                    break;
                }
            }
            if (tbbianhao.Text == "" || tbmaijianame.Text == "" || tblianxifangshi.Text == "")
            {
                MessageBox.Show("添加客户信息不能为空！");
            }
            else
             {
                if (flag == 1)
                {
                    MessageBox.Show("该账号已存在，请输入新账号！");
                }
                else
                {
                    string sql4 = "insert into Buyer values ('" + tbbianhao.Text.Trim() + "','" + tbmaijianame.Text.Trim() + "','" + tblianxifangshi.Text.Trim() + "')";
                    SqlCommand com = new SqlCommand(sql4, ConnSql);
                    SqlDataReader dr = com.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("添加成功！");
                }
             }
            }

        }
    }
