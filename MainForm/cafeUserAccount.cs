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
    public partial class cafeUserAccount : Form
    {
        public cafeUserAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imageUrl = "-";
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    pbImage.Image = Image.FromFile(ofd.FileName);
                    
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cafeUserAccount_Load(object sender, EventArgs e)
        {

        }

        private void tbFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbRole_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
            con.Open();

            Image img = pbImage.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            SqlCommand cmd = new SqlCommand("update cafeAccounts set Username ='" + tbName.Text + "',Photo = '" + arr + "',bd ='" + tbDOB.Text + "', FatherName ='" + tbFname.Text + "',PhonoNo = '" + tbPhoneNo.Text + "',Address = '" + tbAddress.Text + "' where No  = '" + lbID.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Sucessfully...");
            //clearAll();
            this.Close();
        }
    }
}
