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
    public partial class cafeMenuView : Form
    {
        public cafeMenuView()
        {
            InitializeComponent();
        }
         
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
        PictureBox pic;
        Label price;
        Label FName;
        //NumericUpDown count;
        //Label Fcount;
        //Button takeOrder;
        Panel oneItem;
        MemoryStream ms;
        private void getMenuItem(string valueToFind)
        {

            flowLayoutPanel1.Controls.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select FoodPic,PicURL,Name,Price,Type,Size,No from cafeMenuItem where Name like '" + valueToFind + "%'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                /*long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));*/

                oneItem = new Panel();
                oneItem.Width = 150;
                oneItem.Height = 200;
                oneItem.BackgroundImageLayout = ImageLayout.Stretch;
                oneItem.BorderStyle = BorderStyle.FixedSingle;
                oneItem.Margin = new Padding(10, 10, 10, 10);

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


                //ms = new MemoryStream(array);
                //pic.Image = Image.FromStream(ms);
                //System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(ms);
                // pic.BackgroundImage = bitmap;

                // pic.Click += new EventHandler(picHover_mouseHover(count.Value.ToString()));
                //pic.MouseHover += new System.EventHandler(picHover_mouseHover);
                //pic.MouseHover += new System.EventHandler();
                // pic.Margin = new Padding(0,10,0,10);

                FName = new Label();
                FName.Text = dr["Name"].ToString();
                FName.BackColor = Color.FromArgb(46, 134, 222);
                FName.Dock = DockStyle.Top;
                FName.TextAlign = ContentAlignment.MiddleCenter;
                FName.Width = 50;
                //flowLayoutPanel1.Controls.Add(Name);

                price = new Label();
                price.Text = dr["Price"].ToString();
                price.BackColor = Color.FromArgb(192, 255, 255);
                price.Dock = DockStyle.Bottom;
                price.Width = 50;
                price.TextAlign = ContentAlignment.MiddleCenter;

                



                flowLayoutPanel1.Controls.Add(oneItem);
                oneItem.Controls.Add(pic);
                oneItem.Controls.Add(price);
                oneItem.Controls.Add(FName);
                //oneItem.Controls.Add(Fcount);
                //oneItem.Controls.Add(count);
                //oneItem.Controls.Add(takeOrder);

                //flowLayoutPanel1.Controls.Add(tbName);

                //flowLayoutPanel1.Controls.Add(count);
               
            }
            dr.Close();
            con.Close();
        }
        private void cafeMenuView_Load(object sender, EventArgs e)
        {
            getMenuItem("");
        }

        private void tbNameSearch_TextChanged(object sender, EventArgs e)
        {
            getMenuItem(tbNameSearch.Text);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
    }
}
