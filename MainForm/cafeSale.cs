using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MainForm
{
    public partial class cafeSale : Form
    {

        public cafeSale()
        {
            InitializeComponent();
            
            
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
        
        int j,k;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelEmHeader_Paint(object sender, PaintEventArgs e)
        {

        }
        private void fillComboBox()
        {
            cbTableLists.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select TableID from cafeTables", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbTableLists.Items.Add(dr["TableID"].ToString());
            }
            con.Close();
        }
        private void cafeSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coeCafeDataSet5.cafeSale' table. You can move, or remove it, as needed.
            this.cafeSaleTableAdapter.Fill(this.coeCafeDataSet5.cafeSale);
            fillComboBox();
           fillActiveReceipt();
            
            
        }
        private void fillActiveReceipt()
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("select TId,TName from cafeBillings", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            da.Fill(dt);
           // DataRow dr = new DataRow();
           string[] uniqueIDArray = new string[dt.Rows.Count];
           k = 0;
            foreach (DataRow drow in dt.Rows)
            {



               // cbTableLists.Items.Add(drow["TId"].ToString());
                uniqueIDArray[k] = drow["TId"].ToString() + drow["TName"].ToString();
               // uniqueIDArray[k][1] = drow["TName"].ToString();
                k++;

              
               
                
            }
           uniqueIDArray = uniqueIDArray.Distinct().ToArray();
            for (j = 0; j < uniqueIDArray.Length;j++ )
            {
               
                cbTableLists.Items.Add(uniqueIDArray[j]);
                
            }
                con.Close();

           
            
        }
        static int i = 1;
        private void button1_Click(object sender, EventArgs e)
        {
             Panel table = new Panel();
            table.Width = 75;
            table.Height = 75;
            table.BackgroundImageLayout = ImageLayout.Stretch;
            table.BorderStyle = BorderStyle.FixedSingle;
            table.BackColor = Color.NavajoWhite;
            //table.Margin = new Padding(10, 10, 10, 10);
           // table.Margin = new Padding(10, 10, 10, 10);



            Button btn = new Button();
            btn.Text = cbTableLists.Text;
            btn.BackColor = Color.FromArgb(192, 192, 255);
            btn.Height = 75;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Width = 75;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Dock = DockStyle.Fill;
            //btn.Margin = new Padding(5, 5, 5, 5);
            btn.Tag = i; //to set current table id
            i++;
            btn.Name = "1";
            
           
           

            
           // table.Controls.Add(tablename);
            //table.Controls.Add(totalbill);
            table.Controls.Add(btn);
            if (cbTableLists.Text == "")
                MessageBox.Show("Add Table Name First");
            
         

            else
                //btn.Controls.Add(totalbill);
                flowLayoutPanel1.Controls.Add(table);
            
                //table.DoubleClick += new EventHandler(ToOrder_click);
                btn.Click += new EventHandler(ToOrder_click);
                //btn.DoubleClick += new EventHandler(ToPayBill_click);
                btn.MouseHover += new EventHandler(ToPayBill_click);
           // btn.Click += (senderr, ee) => ToOrder_click(this, e, btn.Text);
                
        }
        
        private void ToOrder_click(object sender, EventArgs e)
        {
            string tag = ((Button)sender).Tag.ToString();
            string name = ((Button)sender).Text.ToString();
            string bill = ((Button)sender).Name.ToString();
            
          
            cafeMenuList menu = new cafeMenuList();
            menu.lbTableID.Text = name;
            menu.lbID.Text = tag;
            menu.lbTotal.Text = bill;
            menu.ShowDialog();
        }
        private void ToPayBill_click(object sender, EventArgs e)
        {
            string tag = ((Button)sender).Tag.ToString();
            string name = ((Button)sender).Text.ToString();
            /*string bill = ((Button)sender).Name.ToString();
            if (dataGridView1.Rows.Count > 1) //dataGridView1.Rows.Count > 1
            {
                //int index = dataGridView1.Rows.Count - 2;
                //if(dataGridView1.Rows[i-1].Cells[5].Value.ToString() == "")
                bill = dataGridView1.Rows[i - 1].Cells[6].Value.ToString();

            }*/
            con.Open();

            // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=dbBBMS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from cafeSale where TName like '" + name + "%'  and TId like '" + tag + "%'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }
     //   double dailyTotalIncome = 0;
        private void btnDBrefresh_Click(object sender, EventArgs e)
        {
            

            con.Open();
            // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=dbBBMS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from cafeSale", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;

            //cafeMenuList sale = new cafeMenuList();
            //lbDailyTotal.Text = sale.lbTotal.Text;
            
            
           
            
            
        }

        private void btnAddNewMenu_Click(object sender, EventArgs e)
        {

        }

        private void cbTableLists_SelectedValueChanged(object sender, EventArgs e)
        {
            i = 1;
        }
    }
}
