using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace MainForm
{
    public partial class cafeMenuList : Form
    {
        public cafeMenuList()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
        PictureBox pic;
        Label price;
        Label FName;
        NumericUpDown count;
        Label Fcount;
        Button takeOrder;
        Panel oneItem;
        MemoryStream ms;
        
        
        double total;
        double dailyTotalIncome = 0;
       
        private void button1_Click(object sender, EventArgs e)
        {
            Button b = addMenuItem();
            flowLayoutPanel1.Controls.Add(b);
        }
        Button addMenuItem()
        {
            Button b = new Button();
            
            return b;
        }
        //ComboBox cbPrevTotalPrice = new ComboBox();
        private void cafeMenuList_Load(object sender, EventArgs e)
        {
            
            getMenuItem("");
            con.Open();
            SqlDataAdapter ada = new SqlDataAdapter("select DailyTotal from cafeBillings where TName = '" + lbTableID.Text + "' and TId = '"+lbID.Text+"'",con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            if (dt.Rows.Count > 0)
                lbDailyTotal.Text =  dt.Rows[(dt.Rows.Count)-1][0].ToString();
            else
                lbDailyTotal.Text = "0";
            con.Close();
            dailyTotalIncome = double.Parse(lbDailyTotal.Text);
            total = dailyTotalIncome;
        }
        private void picHover_mouseHover(string c)
        {
           
        }
        
       
       
        private void getFoodCount(object sender,EventArgs e)
        {

            Fcount.Text = count.Value.ToString();
            
        }

        private void takeorder_click(object sender, EventArgs e)
        {
            string tag = ((PictureBox)sender).Tag.ToString();
           
            
            count.ValueChanged += new EventHandler(getFoodCount);

            
          
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from cafeMenuItem where No like '" + tag + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int foodTotal = Convert.ToInt32(dr["Price"].ToString()) * (Convert.ToInt32(count.Value));
            if(dr.HasRows)
            {
                
                dataGridView1.Rows.Add(dataGridView1.Rows.Count,dr["Name"].ToString(),dr["Size"].ToString(),count.Value,foodTotal.ToString(),"-");
                total = total + double.Parse(foodTotal.ToString());
               
                lbTotal.Text = total.ToString();
               
            }

            //total = dailyTotalIncome;
            //dailyTotalIncome = total + double.Parse(lbDailyTotal.Text);
            //lbDailyTotal.Text = dailyTotalIncome.ToString();
                con.Close();
          
        }
        
        private void getMenuItem(string valueToFind)
        {
            
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select FoodPic,PicURL,Name,Price,Type,Size,No from cafeMenuItem where Name like '"+valueToFind+"%'", con);
            SqlDataReader dr = cmd.ExecuteReader();
          
            while(dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));

                oneItem = new Panel();
                oneItem.Width = 150;
                oneItem.Height = 200;
                oneItem.BackgroundImageLayout = ImageLayout.Stretch;
                oneItem.BorderStyle = BorderStyle.FixedSingle;
                oneItem.Margin = new Padding(10,10,10,10);
               
                
                
                

                
                pic = new PictureBox();
                //pic.Width = 100;
              //  pic.Height = 100;
                Byte[] img = (byte[])dr["FoodPic"];
                ms = new MemoryStream(img);
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                pic.BorderStyle = BorderStyle.FixedSingle;
                pic.Dock = DockStyle.Fill;
                pic.Tag = dr["No"].ToString();
                string url = dr["PicURL"].ToString();
                //pic.Layout = ImageLayout.Stretch;
                //pic.Image = Image.FromFile(url);
                pic.BackgroundImage = Image.FromFile(url);
                
                 
                

                FName = new Label();
                FName.Text = dr["Name"].ToString();
                FName.BackColor = Color.FromArgb(46,134,222);
                FName.Dock = DockStyle.Top;
                FName.TextAlign = ContentAlignment.MiddleCenter;
                FName.Width = 50;
                

                Fcount = new Label();
                Fcount.Text = "2";

                price = new Label();
                price.Text = dr["Price"].ToString();
                price.BackColor = Color.FromArgb(192, 255, 255);
                price.Dock = DockStyle.Bottom;
                price.Width = 50;
                price.TextAlign = ContentAlignment.MiddleCenter;
                

                count = new NumericUpDown();
                count.BackColor = Color.FromArgb(192, 255, 255);
                count.TextAlign = HorizontalAlignment.Center;
                count.Width = 40;
                count.Value = 1;
                count.Height = 23;
                
                count.Dock = DockStyle.Bottom;
               
               
                oneItem.Tag = count.Value.ToString();

                takeOrder = new Button();
                takeOrder.Text = "Take Order";
                takeOrder.BackColor = Color.FromArgb(46, 134, 222);
                takeOrder.Dock = DockStyle.Bottom;
                takeOrder.TextAlign = ContentAlignment.MiddleCenter;
                takeOrder.Width = 50;
                takeOrder.FlatStyle = FlatStyle.Flat;
               

                
               
                flowLayoutPanel1.Controls.Add(oneItem);
                oneItem.Controls.Add(pic);
                oneItem.Controls.Add(price);
                oneItem.Controls.Add(FName);
                oneItem.Controls.Add(Fcount);
                oneItem.Controls.Add(count);
               
                pic.Click += new EventHandler(takeorder_click);
            }
            dr.Close();
            con.Close();
        }

        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbMenuNameSearch_TextChanged(object sender, EventArgs e)
        {
            getMenuItem(tbMenuNameSearch.Text);
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void lbDailyTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnSendOrders_Click(object sender, EventArgs e)
        {

            cafeSale sale = new cafeSale();
            sale.lbDailyTotal.Text = total.ToString();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                SqlCommand cmdd = new SqlCommand(@"insert into cafeSale (TId,TName,FoodName,FoodSize,FoodCount,Total,UserReq) values ('" + lbID.Text + "','" + lbTableID.Text + "','" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "')", con);

                con.Open();
                cmdd.ExecuteNonQuery();
                con.Close();


            }


            /*con.Open();
            SqlDataAdapter ada = new SqlDataAdapter("select * from cafeBillings where TName = '" + lbTableID.Text + "'", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            if (dt.Rows.Count > 0)
                dataGridView1.DataSource = dt;
            else
                dataGridView1.DataSource = dt;
            con.Close();*/


            //for total row
            //available = 1 means table is taken
            SqlCommand cmd = new SqlCommand(@"insert into cafeSale (TId,TName,Total) values('" + lbID.Text + "','" + lbTableID.Text + "','" + lbTotal.Text + "')", con);
            SqlCommand cmd2 = new SqlCommand(@"insert into cafeBillings(TId,TName,DailyTotal) values('"+lbID.Text+"' ,'"+lbTableID.Text+"', '"+lbTotal.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
            //dataGridView1.Rows.Clear();
            MessageBox.Show("Order Sent....");


            
            
            
        }
     
        private void btnPrepaid_Click(object sender, EventArgs e)
        {
            //=========================== need to rewrite logics between prepaid and order method =============================
            //=========================== need to render table if table has been taken ========================================

            con.Open();

            SqlCommand cmd2 = new SqlCommand(@"insert into cafeIncome (date,dailyIncome) values('" + dateTimePicker1.Value + "','" + total.ToString() + "')", con);

            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Date Sent....");

            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from cafeSale where TName = '" + lbTableID.Text + "' and TId = '"+lbID.Text+"'", con);
           
            SqlCommand cmdd = new SqlCommand("Delete from cafeBillings where TName = '" + lbTableID.Text + "' and TId = '"+lbID.Text+"'", con);
            cmd.ExecuteNonQuery();
            cmdd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thanks You....");


           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }

        private void panelEmHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbDailyTotal_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
