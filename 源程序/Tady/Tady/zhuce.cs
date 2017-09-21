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
    public partial class zhuce : Form
    {
        public zhuce()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //new Thread(() => Application.Run(new denglu())).Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("注册成功！");
            List<string> list1 = new List<string>();
            string strConn = @"server=TRAVELERS;uid=sa;pwd=1234567890;database=Tady";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
            SqlConnection ConnSql = new SqlConnection(strConn);//Sql链接类的实例化
            ConnSql.Open();//打开数据库
            string strSQL = "select * from Register ";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, ConnSql);//创建DataAdapter数据适配器实例
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                list1.Add(row["Account"].ToString());
            }
            String[] s1 = list1.ToArray();
            int flag = 0;//判断账号是否存在
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                if (s1[i].Equals(textBox5.Text) )
                {
                    flag = 1;
                    break;
                }
            }
            if (maskedTextBox1.Text == "" ||textBox2.Text == ""||textBox3.Text == "" || textBox8.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||textBox6.Text == "" ||textBox1.Text == "")
            {
                MessageBox.Show("注册信息不能为空！");
            }
            else
            {
                if (textBox1.Text == "123456")
                {
                    if (flag == 1)
                    {
                        MessageBox.Show("该账号已存在，请输入新账号！");
                    }
                    else
                    {
                        string sql4 = "insert into Register values ('" + maskedTextBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox8.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                        SqlCommand com = new SqlCommand(sql4, ConnSql);
                        SqlDataReader dr = com.ExecuteReader();
                        dr.Close();
                        MessageBox.Show("注册成功！");
                    }
                }
                else
                {
                    MessageBox.Show("注册失败，请输入正确的本公司验证信息！");
                }
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
