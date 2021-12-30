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
    public partial class CafeTables : Form
    {
        public CafeTables()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
        private void CafeTables_Load(object sender, EventArgs e)
        {
            
            getTableList("");
            int tb = dataGridView1.Rows.Count-1;
             lbTables.Text = "\"" + tb.ToString() + "\"";
        }
        private void getTableList(string valueToFind)
        {
            con.Open();
            // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=dbBBMS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from cafeTables where Seat like '" + valueToFind + "%'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        private void panelFill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddNewTable_Click(object sender, EventArgs e)
        {
            addTable d = new addTable();
            d.btnDelete.Visible = false;
            d.btnUpdate.Visible = false;
            d.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addTable t = new addTable();
            //addEmployee add = new addEmployee();
            //add.id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            t.id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            t.tbTableID.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            t.tbSeat.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            // this.Hide();

            t.btnSave.Visible = false;
            //k.btnRegister.Visible = false;
            t.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void btnDBrefresh_Click(object sender, EventArgs e)
        {
            getTableList("");
        }

        private void tbSeatSearch_TextChanged(object sender, EventArgs e)
        {
            getTableList(tbSeatSearch.Text);
        }
    }
}
