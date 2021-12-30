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
    public partial class addMenu : Form
    {
        public addMenu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
        string imageUrl = "-";
        private void button1_Click(object sender, EventArgs e)
        {

            pBFoodPic.Image = null; 
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    pBFoodPic.Image = Image.FromFile(ofd.FileName);
                    // .Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
             Image img = pBFoodPic.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
             arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            con.Open();
            
            SqlCommand cmd = new SqlCommand("insert into cafeMenuItem(FoodPic,Name,Price,Size,Type,PicURL) values (@FoodPic,@Name,@Price,@Size,@Type,@PicURL)", con);
            cmd.Parameters.AddWithValue("@Name", tbFname.Text);
            cmd.Parameters.AddWithValue("@Size", cbSize.Text);
            cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(tbPrice.Text));
            cmd.Parameters.AddWithValue("@Type", cbType.Text);
            cmd.Parameters.AddWithValue("@PicURL", imageUrl);
            cmd.Parameters.AddWithValue("@FoodPic", arr);
            
            cmd.ExecuteNonQuery();
            clear();
            MessageBox.Show("Menu Item is added");
            con.Close();
           // this.Close();
        }
        private void clear()
        {
            tbFname.Text = "";
            tbPrice.Text = "";
            cbSize.Text = "";
            cbType.Text = "";
        }
            

        private void addMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //CafeEmployee em = new CafeEmployee();
            //k.tbName.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
            //id = Convert.ToInt32(em.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            // id = em.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //id.Text = em.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from cafeMenuItem where No = '" + id.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Menu Sucessfully...");
            //clearAll();
            this.Close();
        }
        byte[] convertImageToBinary(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // ============= need to do image update. right now image cannot be updated ====================
           
            con.Open();
            
            /*Image img = pBFoodPic.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));*/

            SqlCommand cmd = new SqlCommand("update cafeMenuItem set Name ='" + tbFname.Text + "',Size ='" + cbSize.Text + "', Price ='" + Convert.ToInt64(tbPrice.Text) + "',Type = '" + cbType.Text + "' where No  = '" + id.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Sucessfully...");
            //clearAll();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbFname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
