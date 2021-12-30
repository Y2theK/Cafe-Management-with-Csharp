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
    public partial class addTable : Form
    {
        public addTable()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addTable_Load(object sender, EventArgs e)
        {

        }
        private void getTableList()
        {

            CafeTables t = new CafeTables();
            SqlCommand cmd = new SqlCommand("Select * from CafeTables", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            t.dataGridView1.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
            con.Open();
            String sql = "insert into cafeTables(TableID,Seat) Values(@ID,@Seat)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ID", tbTableID.Text);
            cmd.Parameters.AddWithValue("@Seat", Convert.ToInt32(tbSeat.Text));


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Table Created Sucessfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getTableList();
            //clearAll();
            this.Close();
        }

        private void tbTableID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSeat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update cafeTables set TableID='" + tbTableID.Text + "',Seat='" + tbSeat.Text + "' where No  = '" + id.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Sucessfully...");
            //clearAll();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
            

            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from cafeTables where No = '" + id.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Sucessfully...");
            //clearAll();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
