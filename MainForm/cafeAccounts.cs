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
    public partial class cafeAccounts : Form
    {
        public cafeAccounts()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
        private void cafeAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coeCafeDataSet7.cafeAccounts' table. You can move, or remove it, as needed.
           this.cafeAccountsTableAdapter.Fill(this.coeCafeDataSet7.cafeAccounts);
           lbMenus.Text = dataGridView1.Rows.Count.ToString();

        }
        private void getMenuList(string valueToFind)
        {
            

            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from cafeAccounts where Username like '" + valueToFind + "%'", con);
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

        private void tbAccSearch_TextChanged(object sender, EventArgs e)
        {
            getMenuList(tbAccSearch.Text);
        }
    }
}
