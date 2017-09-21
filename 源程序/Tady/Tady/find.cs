using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Tady
{
    public partial class find : Form
    {
        public find()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("您的密码是XXX请记好！");
            if (textBox1.Text==""|| textBox4.Text==""|| textBox5.Text=="")
            {
                MessageBox.Show("输入信息框不能为空！");
            }
            else
            {
                List<string> list1 = new List<string>();
                List<string> list2 = new List<string>();
                List<string> list3 = new List<string>();
                List<string> list4 = new List<string>();
                string strConn = @"server=TRAVELERS;uid=sa;pwd=1234567890;database=Tady";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
                SqlConnection ConnSql = new SqlConnection(strConn);//Sql链接类的实例化
                ConnSql.Open();//打开数据库
                string strSQL = "select * from Register ";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, ConnSql);//创建DataAdapter数据适配器实例
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    list1.Add(row["Number"].ToString());
                    list2.Add(row["Id_card"].ToString());
                    list3.Add(row["Account"].ToString());
                    list4.Add(row["Password"].ToString());
                }
                String[] s1 = list1.ToArray();
                String[] s2 = list2.ToArray();
                String[] s3 = list3.ToArray();
                String[] s4 = list4.ToArray();
                for (int i = s1.Length - 1; i >= 0; i--)
                {
                    if (s1[i].Equals(textBox1.Text) && s2[i].Equals(textBox4.Text) && s3[i].Equals(textBox5.Text))
                    {
                        MessageBox.Show("您的密码是:" + s4[i] + " 请记好！");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
           // new Thread(() => Application.Run(new denglu())).Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
