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
    public partial class LoginIn : Form
    {
        public LoginIn()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void LoginIn_Load(object sender, EventArgs e)
        {

        }
        private void searchData()
        {
            if (tbUsername.Text == "" || tbPassward.Text == "" || cbType.Text == "")
                MessageBox.Show("Make sure you enter all the form");
            else
            {
                con.Open();
                /*SqlCommand cmd = new SqlCommand("select * from cafeAccounts where Username = @user and Passward = @pwd and Type = @type", con);
                cmd.Parameters.AddWithValue("@user", tbUsername.Text);
                cmd.Parameters.AddWithValue("@pwd", tbPassward.Text);
                cmd.Parameters.AddWithValue("@type", cbType.Text);*/
                
                SqlCommand cmd = new SqlCommand("select * from cafeAccounts where Username = '" + tbUsername.Text + "' and Passward = '"+tbPassward.Text+"' and Type='"+cbType.Text+"'", con);
                SqlDataReader dr = cmd.ExecuteReader();

               
                if(dr.HasRows == true)
                {
                    Form1 f = new Form1();
                   
                    f.lbName.Text += tbUsername.Text;
                    
                    f.lbPassward.Text += tbPassward.Text;
                    f.btnRole.Text = cbType.Text;

                    if(cbType.Text == "admin")
                    {
                        this.Hide();

                        //Form1 f = new Form1();
                       
                        f.ShowDialog();

                        
                    }
                    else
                    {
                        //Form1 f = new Form1();
                        
                        f.btnCategory.Hide();
                        f.pBCategory.Hide();
                        f.btnMenu.Hide();
                        f.pBMenu.Hide();
                        f.btnTables.Hide();
                        f.pBTable.Hide();
                        f.btnEmployees.Hide();
                        f.pBEmployee.Hide();
                        
                        f.ShowDialog();

                        this.Hide();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid Try Again");
                }
                con.Close();


            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
