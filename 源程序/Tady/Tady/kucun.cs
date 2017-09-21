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
    public partial class kucun : Form
    {
        public kucun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = @"server=TRAVELERS;uid=sa;pwd=1234567890;database=Tady";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
            SqlConnection ConnSql = new SqlConnection(strConn);//Sql链接类的实例化
            ConnSql.Open();//打开数据库
            if ( tb1.Text == "" || tb2.Text == "" || tb3.Text == "" || cb1.Text=="")
            {
                MessageBox.Show("商品信息不能为空！");
            }
            else
            {
               string sql4 = "insert into Product values ('" + cb1.Text + "','" + tb1.Text + "','" + tb2.Text  + "','" + tb3.Text +  "')";
               SqlCommand com = new SqlCommand(sql4, ConnSql);
               SqlDataReader dr = com.ExecuteReader();
               dr.Close();
               MessageBox.Show("添加成功！");
                    
            }
        }

        private void kucun_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“tadyDataSet21.Factory”中。您可以根据需要移动或删除它。
            this.factoryTableAdapter.Fill(this.tadyDataSet21.Factory);

        }
    }
}
