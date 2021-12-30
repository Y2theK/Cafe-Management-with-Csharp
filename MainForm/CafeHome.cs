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
using System.IO;
namespace MainForm
{
    public partial class CafeHome : Form
    {
        public CafeHome()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void CafeHome_Load(object sender, EventArgs e)
        {
            //label8.Text = numericUpDown1.Value.ToString();
            fillComboBox();
            fillSeatCount();
            fillSale4Today();
            fillActiveVoucher();
            
        }
        private void fillActiveVoucher()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select TId,TName from cafeBillings", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            // DataRow dr = new DataRow();
            string[] uniqueIDArray = new string[dt.Rows.Count];
            int k = 0;
            foreach (DataRow drow in dt.Rows)
            {



                // cbTableLists.Items.Add(drow["TId"].ToString());
                uniqueIDArray[k] = drow["TId"].ToString() + drow["TName"].ToString();
                // uniqueIDArray[k][1] = drow["TName"].ToString();
                k++;




            }
            uniqueIDArray = uniqueIDArray.Distinct().ToArray();
            

                lbActiveVoucher.Text = uniqueIDArray.Length.ToString();

            
            con.Close();



        }
        private void fillSale4Today()
        {
            con.Open();
            SqlDataAdapter ada = new SqlDataAdapter("select Sum(dailyIncome) OVER (PARTITION BY date ORDER BY id) from cafeIncome  ", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            lbSale4Today.Text = dt.Rows[(dt.Rows.Count)-1][0].ToString();
            con.Close();
        }
        private void fillSeatCount()
        {
            con.Open();
            SqlDataAdapter ada = new SqlDataAdapter("select Count(*) from cafeTables", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            lbSeatCount.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void fillComboBox()
        {

            cbFoodLists.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Name from cafeMenuItem", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cbFoodLists.Items.Add(dr["Name"].ToString());
            }
            con.Close();
            //cbFoodLists.SelectedIndex = cbFoodLists.Items.Count - 1;
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //label8.Text = numericUpDown1.Value.ToString();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Name,PicURL,Price from cafeMenuItem where Name like '" + cbFoodLists.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            Panel todaySpecial = new Panel();
            todaySpecial.Height = 280;
            todaySpecial.Width = 300;
            todaySpecial.Margin = new Padding(50, 30, 50, 0);
            
            PictureBox picTodaySpecial = new PictureBox();
            picTodaySpecial.Dock = DockStyle.Bottom;
            picTodaySpecial.Height = 250;
            picTodaySpecial.Width = 300;


            Label fName = new Label();
           // fName.Dock = DockStyle.Bottom;
            fName.BackColor = Color.FromArgb(146, 134, 222);
            fName.Dock = DockStyle.Top;
            fName.TextAlign = ContentAlignment.MiddleCenter;
            fName.Width = 50;
            fName.Height = 30;
            fName.Font = new Font("Segoe Marker", 20, FontStyle.Regular);

            Label fPrice = new Label();
            fPrice.BackColor = Color.FromArgb(146, 134, 222);
            fPrice.Font = new Font("Arial", 15, FontStyle.Regular);
            fPrice.Dock = DockStyle.Bottom;
            fPrice.Width = 30;

            while(dr.Read())
            {
                fName.Text = dr["Name"].ToString() + " AVALIABLE ";
                fPrice.Text = dr["Price"].ToString();
                string url = dr["PicURL"].ToString();
                picTodaySpecial.BackgroundImageLayout = ImageLayout.Stretch;
                //pic.Image = Image.FromFile(url);
                picTodaySpecial.BackgroundImage = Image.FromFile(url);
                
            }

            dr.Close();
            con.Close();
            //picTodaySpecial.Controls.Add(fPrice);
            todaySpecial.Controls.Add(picTodaySpecial);
            todaySpecial.Controls.Add(fName);
            
            if (cbFoodLists.Text == "")
                MessageBox.Show("Choose Your Today Speical");
            else
                flowLayoutPanel1.Controls.Add(todaySpecial); 
           
           

            //cbFoodLists.Text = "";
        }

        private void cbFoodLists_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbSeatCount_Click(object sender, EventArgs e)
        {

        }
    }
}
