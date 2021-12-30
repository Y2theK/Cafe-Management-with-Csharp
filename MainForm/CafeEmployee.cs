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
    public partial class CafeEmployee : Form
    {
        public CafeEmployee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
        private void CafeEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coeCafeDataSet2.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.coeCafeDataSet2.employee);
            getEmployeeList("");
            int em = dataGridView1.Rows.Count - 1;
            lbEmployee.Text = '"' + em.ToString() + '"';

        }
        private void getEmployeeList(string valueToFind)
        {
            con.Open();
            // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=dbBBMS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from employee where Name like '"+valueToFind+"%'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            addEmployee em = new addEmployee();
            em.btnUpdate.Visible = false;
            em.btnDelete.Visible = false;
            em.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            getEmployeeList("");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            addEmployee add = new addEmployee();
            add.id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            add.tbName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            add.tbFname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            add.tbPhNo.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            add.tbAddr.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            add.cbRole.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString(); 
            // this.Hide();

            add.btnSave.Visible = false;
            //k.btnRegister.Visible = false;
            add.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDBrefresh_Click(object sender, EventArgs e)
        {
            getEmployeeList("");
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            /*con.Open();
            // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=dbBBMS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from employee where Name like '"+tbSearch.Text+"%'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;*/
            getEmployeeList(tbSearch.Text);

        }

        private void lbEmployee_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
