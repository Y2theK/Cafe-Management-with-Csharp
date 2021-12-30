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
    public partial class cafeOrder : Form
    {
        public cafeOrder()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
        private void cafeOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coeCafeDataSet6.cafeSale' table. You can move, or remove it, as needed.
            this.cafeSaleTableAdapter.Fill(this.coeCafeDataSet6.cafeSale);

        }

        private void btnDBrefresh_Click(object sender, EventArgs e)
        {
            con.Open();
            // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=dbBBMS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from cafeSale ORDER by No asc", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelEmHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbMenuSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
