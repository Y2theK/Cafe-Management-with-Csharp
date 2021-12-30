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
    public partial class CafeMenu : Form
    {
        public CafeMenu()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
        private void CafeMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coeCafeDataSet4.cafeMenuItem' table. You can move, or remove it, as needed.
            this.cafeMenuItemTableAdapter.Fill(this.coeCafeDataSet4.cafeMenuItem);
            lbMenus.Text = dataGridView1.Rows.Count.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
        private void getMenuList(string valueToFind)
        {
            
            
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from cafeMenuItem where Name like '"  + valueToFind + "%'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.DataSource = dt;
            lbMenus.Text = dataGridView1.Rows.Count.ToString();
        }

        private void btnAddNewEmployee_Click_1(object sender, EventArgs e)
        {
            addMenu menu = new addMenu();
            menu.btnDelete.Visible = false;
            menu.btnUpdate.Visible = false;
            menu.id.Visible = false;
            menu.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           
           addMenu me = new addMenu();
           me.btnSave.Visible = false;
           /*Image img = me.pBFoodPic.Image;
           byte[] arr;
           ImageConverter converter = new ImageConverter();
           arr = (byte[])converter.ConvertTo(img, typeof(byte[]));*/
           Byte[] img = (byte[])dataGridView1.CurrentRow.Cells[1].Value;
           MemoryStream ms = new MemoryStream(img);
           me.pBFoodPic.Image = Image.FromStream(ms);
           me.id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
           me.tbFname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
           me.tbPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
           me.cbSize.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
           me.cbType.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
           // Image i = (Image)dataGridView1.CurrentRow.Cells[1].Value;
           //MemoryStream ms = new MemoryStream();
           //Bitmap img = (Bitmap)this.dataGridView1.CurrentRow.Cells[1].Value;
           // me.pBFoodPic.Image = i;
           //me.pBFoodPic.Image = this.dataGridView1.CurrentRow.Cells[5];
          // arr = Convert.ToByte(this.dataGridView1.CurrentRow.Cells[1].Value);
          me.id.Visible = false;
          me.ShowDialog();
           

           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDBrefresh_Click(object sender, EventArgs e)
        {
            getMenuList("");
        }

        private void tbMenuSearch_TextChanged(object sender, EventArgs e)
        {
            getMenuList(tbMenuSearch.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbFname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //cbSize.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //cbType.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();

            Byte[] img = (byte[])dataGridView1.CurrentRow.Cells[1].Value;
            MemoryStream ms = new MemoryStream(img);
            pBFoodPic.Image = Image.FromStream(ms);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pBFoodPic_Click(object sender, EventArgs e)
        {

        }
    }
}
