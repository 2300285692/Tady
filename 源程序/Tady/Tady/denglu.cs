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
    public partial class denglu : Form
    {
        public denglu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            string strConn = @"server=TRAVELERS;uid=sa;pwd=1234567890;database=Tady";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
            SqlConnection ConnSql = new SqlConnection(strConn);//Sql链接类的实例化
            ConnSql.Open();//打开数据库
            string strSQL = "select * from Register ";//要执行的SQL语句
            SqlDataAdapter da = new SqlDataAdapter(strSQL, ConnSql);//创建DataAdapter数据适配器实例
            SqlConnection mycon = new SqlConnection(strConn);
            // mycon.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);//填充数据到dt
            foreach (DataRow row in dt.Rows)
            {
                list1.Add(row["Account"].ToString());
                list2.Add(row["Password"].ToString());
            }
            String[] s1 = list1.ToArray();
            String[] s2 = list2.ToArray();
            int flag = 0;
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                if (s1[i].Equals(textBox1.Text) && s2[i].Equals(textBox2.Text))
                {
                    flag = 1;
                    break;
                }
            }
            ConnSql.Close();//关闭数据库
            if (flag == 1)
            {
                this.Close();
                new Thread(() => Application.Run(new main())).Start();
            }
            else
            {
                MessageBox.Show("输入有误，请重新输入");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Form3 f = new Form3();
            //f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //this.Close();
           // new Thread(() => Application.Run(new zhuce())).Start();
            zhuce c = new zhuce();
            c.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Close();
            //new Thread(() => Application.Run(new find())).Start();
            find a = new find();
            a.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
