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
    public partial class main : Form
    {


        public main()
        {
            InitializeComponent();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage2;
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage3;
        }

       

        private void 库存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage4;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //this.tabControl1.SelectedTab = this.tabPage1;
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int t;
            t = Convert.ToInt32 (textBox3.Text )* Convert.ToInt32 (comboBox22.Text);
            textBox1.Text =Convert.ToString(t);
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //Product_total 
            int t;
            t = Convert.ToInt32(textBox4.Text) * Convert.ToInt32(comboBox2.Text);
            textBox6.Text = Convert.ToString(t);
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //this.tabControl1.SelectedTab = this.tabPage1;
        }
        private void menuStrip7_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage8;
        }

        private void 生产厂家信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage10;
        }

        private void 买家信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage11;
        }

        private void 员工信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage5;
        }

        private void 库存信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage9;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }
        private void 销售报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage14;
        }

        private void 采购报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage15;
        }

        private void menuStrip8_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip9_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage7;
        }

        private void menuStrip11_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
            new Thread(() => Application.Run(new denglu())).Start();
        }

        private void menuStrip5_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip13_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“tadyDataSet23.Purchase”中。您可以根据需要移动或删除它。
            this.purchaseTableAdapter1.Fill(this.tadyDataSet23.Purchase);
            // TODO: 这行代码将数据加载到表“tadyDataSet22.Sell”中。您可以根据需要移动或删除它。
            this.sellTableAdapter.Fill(this.tadyDataSet22.Sell);
            // TODO: 这行代码将数据加载到表“tadyDataSet19.Product”中。您可以根据需要移动或删除它。
            this.productTableAdapter6.Fill(this.tadyDataSet19.Product);
            // TODO: 这行代码将数据加载到表“tadyDataSet18.Buyer”中。您可以根据需要移动或删除它。
            this.buyerTableAdapter2.Fill(this.tadyDataSet18.Buyer);
            // TODO: 这行代码将数据加载到表“tadyDataSet17.Buyer”中。您可以根据需要移动或删除它。
            this.buyerTableAdapter1.Fill(this.tadyDataSet17.Buyer);
            // TODO: 这行代码将数据加载到表“tadyDataSet16.Product”中。您可以根据需要移动或删除它。
            this.productTableAdapter5.Fill(this.tadyDataSet16.Product);
            // TODO: 这行代码将数据加载到表“tadyDataSet15.Inventory”中。您可以根据需要移动或删除它。
            this.inventoryTableAdapter2.Fill(this.tadyDataSet15.Inventory);
            // TODO: 这行代码将数据加载到表“tadyDataSet14.Inventory”中。您可以根据需要移动或删除它。
            this.inventoryTableAdapter1.Fill(this.tadyDataSet14.Inventory);
            // TODO: 这行代码将数据加载到表“tadyDataSet13.Product”中。您可以根据需要移动或删除它。
            this.productTableAdapter4.Fill(this.tadyDataSet13.Product);
            // TODO: 这行代码将数据加载到表“tadyDataSet12.Product”中。您可以根据需要移动或删除它。
            this.productTableAdapter3.Fill(this.tadyDataSet12.Product);
            // TODO: 这行代码将数据加载到表“tadyDataSet11.Register”中。您可以根据需要移动或删除它。
            this.registerTableAdapter1.Fill(this.tadyDataSet11.Register);
            // TODO: 这行代码将数据加载到表“tadyDataSet10.Buyer”中。您可以根据需要移动或删除它。
            this.buyerTableAdapter.Fill(this.tadyDataSet10.Buyer);
            // TODO: 这行代码将数据加载到表“tadyDataSet9.Product”中。您可以根据需要移动或删除它。
            this.productTableAdapter2.Fill(this.tadyDataSet9.Product);
            // TODO: 这行代码将数据加载到表“tadyDataSet8.Factory”中。您可以根据需要移动或删除它。
            this.factoryTableAdapter1.Fill(this.tadyDataSet8.Factory);
            // TODO: 这行代码将数据加载到表“tadyDataSet7.Inventory”中。您可以根据需要移动或删除它。
            this.inventoryTableAdapter.Fill(this.tadyDataSet7.Inventory);
            // TODO: 这行代码将数据加载到表“tadyDataSet6.xin_xi”中。您可以根据需要移动或删除它。
            this.xin_xiTableAdapter1.Fill(this.tadyDataSet6.xin_xi);
            // TODO: 这行代码将数据加载到表“tadyDataSet5.xin_xi”中。您可以根据需要移动或删除它。
            this.xin_xiTableAdapter.Fill(this.tadyDataSet5.xin_xi);
            // TODO: 这行代码将数据加载到表“tadyDataSet4.Factory”中。您可以根据需要移动或删除它。
            this.factoryTableAdapter.Fill(this.tadyDataSet4.Factory);
            // TODO: 这行代码将数据加载到表“tadyDataSet3.Product”中。您可以根据需要移动或删除它。
            this.productTableAdapter1.Fill(this.tadyDataSet3.Product);
            // TODO: 这行代码将数据加载到表“tadyDataSet2.Product”中。您可以根据需要移动或删除它。
            this.productTableAdapter.Fill(this.tadyDataSet2.Product);
            // TODO: 这行代码将数据加载到表“tadyDataSet1.Purchase”中。您可以根据需要移动或删除它。
            this.purchaseTableAdapter.Fill(this.tadyDataSet1.Purchase);
            // TODO: 这行代码将数据加载到表“tadyDataSet.Register”中。您可以根据需要移动或删除它。
            this.registerTableAdapter.Fill(this.tadyDataSet.Register);
        }

        private void 计量信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage12;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text == "" || comboBox1.Text == "" || textBox3.Text == "" || comboBox22.Text == "" || comboBox3.Text == ""|| textBox1.Text == "")
            {
                MessageBox.Show("输入框的信息不能为空！");
            }
            else
            {
                string strConn = @"server=TRAVELERS;uid=sa;pwd=1234567890;database=Tady";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
                SqlConnection ConnSql = new SqlConnection(strConn);//Sql链接类的实例化
                ConnSql.Open();//打开数据库
                string sql4 = "insert into Purchase values ('" + comboBox7.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + comboBox22.Text + "','" + comboBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox1.Text + "')";
                SqlCommand com = new SqlCommand(sql4, ConnSql);
                SqlDataReader dr = com.ExecuteReader();
                dr.Close();
                MessageBox.Show("采购成功！");
            }
        }
        //入库
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox17.Text == "" || comboBox18.Text == "" || textBox7.Text == "" || comboBox21.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("输入框的信息不能为空！");
            }
            else
            {
                List<string> list1 = new List<string>();
                List<string> list3 = new List<string>();
                string strConn = @"server=TRAVELERS;uid=sa;pwd=1234567890;database=Tady";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
                SqlConnection ConnSql = new SqlConnection(strConn);//Sql链接类的实例化
                ConnSql.Open();//打开数据库
                string strSQL = "select * from Inventory ";//要执行的SQL语句
                SqlDataAdapter da = new SqlDataAdapter(strSQL, ConnSql);//创建DataAdapter数据适配器实例
                SqlConnection mycon = new SqlConnection(strConn);
                DataTable dt = new DataTable();
                da.Fill(dt);//填充数据到dt
                foreach (DataRow row in dt.Rows)
                {
                    list1.Add(row["Product_ID"].ToString());
                    list3.Add(row["Product_ku"].ToString());
                }
                String[] s1 = list1.ToArray();
                String[] s3 = list3.ToArray();
                int flag = 0, j = 0;
                for (int i = s1.Length - 1; i >= 0; i--)
                {
                    if (s1[i].Equals(comboBox17.Text))
                    {
                        flag = 1;
                        j = i;
                        break;
                    }
                }
                if (flag == 1)
                {
                    int sum = 0;
                    sum = Convert.ToInt32(s3[j]) + Convert.ToInt32(textBox7.Text);
                    s3[j] = Convert.ToString(sum);
                    string sql4 = "update Inventory set Product_ku ='" + s3[j] + "',Product_Di ='" + textBox8.Text + "',Number ='" + comboBox21.Text + "'where Product_ID ='" + comboBox17.Text + "'";
                    SqlCommand com = new SqlCommand(sql4, ConnSql);
                    SqlDataReader dr = com.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    string sql4 = "insert into Inventory values ('" + comboBox17.Text + "','" + comboBox18.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + comboBox21.Text + "')";
                    SqlCommand com = new SqlCommand(sql4, ConnSql);
                    SqlDataReader dr = com.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("添加成功！");
                }
                ConnSql.Close();//关闭数据库
            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            new Thread(() => Application.Run(new main())).Start();
            this.tabControl1.SelectedTab = this.tabPage9;
        }
        //销售
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox16.Text == "" || comboBox8.Text == "" || textBox4.Text == "" || comboBox2.Text == "" || comboBox12.Text == "" || comboBox13.Text == "" || comboBox14.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("输入框的信息不能为空！");
            }
            else
            {
                List<string> list1 = new List<string>();
                List<string> list2 = new List<string>();
                string strConn = @"server=TRAVELERS;uid=sa;pwd=1234567890;database=Tady";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
                SqlConnection ConnSql = new SqlConnection(strConn);//Sql链接类的实例化
                ConnSql.Open();//打开数据库
                string strSQL = "select * from Inventory ";//要执行的SQL语句
                SqlDataAdapter da = new SqlDataAdapter(strSQL, ConnSql);//创建DataAdapter数据适配器实例
                SqlConnection mycon = new SqlConnection(strConn);
                DataTable dt = new DataTable();
                da.Fill(dt);//填充数据到dt
                foreach (DataRow row in dt.Rows)
                {
                    list1.Add(row["Product_ID"].ToString());
                    list2.Add(row["Product_ku"].ToString());
                }
                String[] s1 = list1.ToArray();
                String[] s2 = list2.ToArray();
                //int flag = 0,
                int j = 0;
                for (int i = s1.Length - 1; i >= 0; i--)
                {
                    if (s1[i].Equals(comboBox8.Text))
                    {
                      //flag = 1;
                        j = i;
                        break;
                    }
                }
                //更新库存数据
                int sum = 0;
                sum = Convert.ToInt32(s2[j]) -Convert.ToInt32(textBox4.Text);
                s2[j] = Convert.ToString(sum);
                string sql3 = "update Inventory set Product_ku ='" + s2[j] +  "'where Product_ID ='" + comboBox8.Text + "'";
                SqlCommand com1 = new SqlCommand(sql3, ConnSql);
                SqlDataReader dr1 = com1.ExecuteReader();
                dr1.Close();
                ConnSql.Close();
                //在销售表中添加数据
                string strConn1 = @"server=TRAVELERS;uid=sa;pwd=1234567890;database=Tady";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
                SqlConnection ConnSql1 = new SqlConnection(strConn1);//Sql链接类的实例化
                ConnSql1.Open();//打开数据库
                string sql4 = "insert into Sell values ('"+comboBox16.Text+"','" + comboBox8.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + comboBox12.Text +  "','" + comboBox13.Text + "','"+ dateTimePicker2.Text + "','" + textBox6.Text + "','" + comboBox14.Text + "')";
                SqlCommand com = new SqlCommand(sql4, ConnSql1);
                SqlDataReader dr = com.ExecuteReader();
                dr.Close();
                if (Convert.ToInt32(s2[j]) < 0)
                {
                    MessageBox.Show("销售订单创建成功，但库存不足，请及时补货！");
                }
                else
                {
                    MessageBox.Show("销售订单创建成功！");
                }
                ConnSql1.Close();//关闭数据库
            }
         }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            //商品编号Product_ID
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           // Product_Nu1
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Product_Di
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Buyer_Nu
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Buyer_name
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //X_date	
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Buyer_mail
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Number	
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kucun a = new kucun();
            a.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kuncun1 a = new kuncun1();
            a.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            new Thread(() => Application.Run(new main())).Start();
            this.tabControl1.SelectedTab = this.tabPage9;
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }
        //资金
        private void button10_Click(object sender, EventArgs e)
        {
            zijin a = new zijin();
            a.ShowDialog();
        }

        private void 资金ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabPage6;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3= new List<string>();
            //总资金
            string strConn1 = @"server=TRAVELERS;uid=sa;pwd=1234567890;database=Tady";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
            SqlConnection ConnSql1 = new SqlConnection(strConn1);//Sql链接类的实例化
            ConnSql1.Open();//打开数据库
            string strSQL1 = "select * from Zjin ";//要执行的SQL语句
            SqlDataAdapter da1 = new SqlDataAdapter(strSQL1, ConnSql1);//创建DataAdapter数据适配器实例
            SqlConnection mycon1 = new SqlConnection(strConn1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);//填充数据到dt
            foreach (DataRow row in dt1.Rows)
            {
                list1.Add(row["zijin"].ToString());
            }
            String[] s1 = list1.ToArray();
            lbzijin.Text = Convert.ToString(s1[0]);
            ConnSql1.Close();//关闭数据库

            //销售
            string strConn2= @"server=TRAVELERS;uid=sa;pwd=1234567890;database=Tady";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
            SqlConnection ConnSql2 = new SqlConnection(strConn2);//Sql链接类的实例化
            ConnSql2.Open();//打开数据库
            string strSQL2 = "select * from Sell ";//要执行的SQL语句
            SqlDataAdapter da2 = new SqlDataAdapter(strSQL2, ConnSql2);//创建DataAdapter数据适配器实例
            SqlConnection mycon2 = new SqlConnection(strConn2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);//填充数据到dt
            foreach (DataRow row in dt2.Rows)
            {
                list2.Add(row["Product_total"].ToString());
            }
            String[] s2 = list2.ToArray();
            int j = 0;
            for (int i = s2.Length - 1; i >= 0; i--)
            {
                j = Convert.ToInt32(s2[i]) + j;
            }
            lbxiaoshou.Text = Convert.ToString(j);
            ConnSql2.Close();

            //采购
            string strConn3 = @"server=TRAVELERS;uid=sa;pwd=1234567890;database=Tady";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
            SqlConnection ConnSql3= new SqlConnection(strConn3);//Sql链接类的实例化
            ConnSql3.Open();//打开数据库
            string strSQL3= "select * from Purchase";//要执行的SQL语句
            SqlDataAdapter da3 = new SqlDataAdapter(strSQL3, ConnSql3);//创建DataAdapter数据适配器实例
            SqlConnection mycon3= new SqlConnection(strConn3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);//填充数据到dt
            foreach (DataRow row in dt3.Rows)
            {
                list3.Add(row["Product_total"].ToString());
            }
            String[] s3 = list3.ToArray();
            int j3 = 0;
            for (int i = s3.Length - 1; i >= 0; i--)
            {
                j3 = Convert.ToInt32(s3[i]) + j3;
            }
            lbcaigou.Text = Convert.ToString(j3);
            ConnSql3.Close();
            //盈利
            int y=0;
            y = Convert.ToInt32(lbxiaoshou.Text) - Convert.ToInt32(lbcaigou.Text);
            lbyingli.Text = Convert.ToString(y);
            //资金剩余
            int s = 0;
            s= Convert.ToInt32(lbzijin.Text) + Convert.ToInt32(y);
            lbshengyu.Text = Convert.ToString(s);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            maijiaxinxi a = new maijiaxinxi();
            a.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            new Thread(() => Application.Run(new main())).Start();
            this.tabControl1.SelectedTab = this.tabPage9;
        }

        private void bt14_Click(object sender, EventArgs e)
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
                list1.Add(row["Buyer_name"].ToString());
            }
            String[] s1 = list1.ToArray();
            int flag = 0;//判断是否存在
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                if (s1[i].Equals(tbmaijiabianhao.Text.Trim()))
                {
                    flag = 1;
                    break;
                }
            }
            if (tbmaijiabianhao.Text == "")
            {
                MessageBox.Show("客户姓名不能为空！");
            }
            else
            {

                if (flag == 1)
                {
                    try
                    {
                        string sql4 = "delete from  Buyer where Buyer_name='" + tbmaijiabianhao.Text.Trim() + "'";
                        SqlCommand com = new SqlCommand(sql4, ConnSql);
                        SqlDataReader dr = com.ExecuteReader();
                        dr.Close();
                        MessageBox.Show("删除成功！");
                    }
                    catch
                    {
                        MessageBox.Show("操作失败！");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("该买家信息不存在，请刷新后尝试！");
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            List<string> list1 = new List<string>();
            string strConn = @"server=TRAVELERS;uid=sa;pwd=1234567890;database=Tady";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
            SqlConnection ConnSql = new SqlConnection(strConn);//Sql链接类的实例化
            ConnSql.Open();//打开数据库
            string strSQL = "select * from Inventory ";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, ConnSql);//创建DataAdapter数据适配器实例
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                list1.Add(row["Product_ID"].ToString());
            }
            String[] s1 = list1.ToArray();
            int flag = 0;//判断是否存在
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                if (s1[i].Equals(tbsname.Text.Trim()))
                {
                    flag = 1;
                    break;
                }
            }
            if (tbsname.Text == "")
            {
                MessageBox.Show("客户编号不能为空！");
            }
            else
            {

                if (flag == 1)
                {
                    try
                    {
                        string sql4 = "delete from  Inventory where Product_ID='" + tbsname.Text.Trim() + "'";
                        SqlCommand com = new SqlCommand(sql4, ConnSql);
                        SqlDataReader dr = com.ExecuteReader();
                        dr.Close();
                        MessageBox.Show("删除成功！");
                    }
                    catch
                    {
                        MessageBox.Show("操作失败！");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("该库存信息不存在，请刷新后尝试！");
                }
            }
        }
    }
}


