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
    public partial class addEmployee : Form
    {
        public addEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //using System.Data.SqlClient;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
            con.Open();
            String sql = "insert into employee(Name,FatherName,Address,PhoneNo,Role) Values(@Name,@Fname,@Addr,@PhNo,@Role)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Name", tbName.Text);
            cmd.Parameters.AddWithValue("@Fname", tbFname.Text);
            cmd.Parameters.AddWithValue("@Addr", tbAddr.Text);
            cmd.Parameters.AddWithValue("@PhNo", tbPhNo.Text);
            cmd.Parameters.AddWithValue("@Role", cbRole.Text);


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Employee Added Sucessfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
           // getEmployeeList();
            clearAll();
            //this.Close();
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
            SqlCommand cmd = new SqlCommand("Delete from employee where No = '" + id.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Sucessfully...");
            //clearAll();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update employee set Name='" + tbName.Text + "',FatherName='" + tbFname.Text + "',Address ='" + tbAddr.Text + "', PhoneNo ='" + tbPhNo.Text + "',Role = '"+ cbRole.Text+"' where No  = '" + id.Text + "'", con);
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
        private void clearAll()
        {
            tbName.Text = "";
            tbFname.Text = "";
            tbPhNo.Text = "";
            tbAddr.Text = "";
            cbRole.Text = "";
        }
    }
}
