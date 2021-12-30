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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-881DQV8;Initial Catalog=CoeCafe;Integrated Security=True");
        private void btnShowSideMenu_Click(object sender, EventArgs e)
        {
            if (panelSideMenu.Visible == false)
                panelSideMenu.Visible = true;
            else if (panelSideMenu.Visible == true)
                panelSideMenu.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
            /*btnSale.BackColor = Color.FromArgb(192, 255, 255);
            btnHome.BackColor = Color.FromArgb(192, 255, 255);
            btnMenu.BackColor = Color.FromArgb(192, 255, 255);
            btnOrder.BackColor = Color.FromArgb(192, 255, 255); 
            btnSaleHistory.BackColor = Color.FromArgb(192, 255, 255);
            btnEmployees.BackColor = Color.FromArgb(192, 255, 255);
            btnTables.BackColor = Color.FromArgb(192, 255, 255);
            btnCategory.BackColor = Color.FromArgb(192, 255, 255);*/
        }

       
        private Form actvieForm = null;
        private void openChildForm(Form childForm)
        {
            if (actvieForm != null)
                actvieForm.Close();
            actvieForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
              //childForm.Height =  panelContainer.Height;
              //childForm.Width = panelContainer.Width;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
        
       
        private void pBSaleHistory_Click(object sender, EventArgs e)
        {

        }
       

        

        private void btnTable2_Click_1(object sender, EventArgs e)
        {
            /*openChildForm(new CafeTables());
            Form1 f = new Form1();
            btnTables.BackColor = f.panelContainer.BackColor;
            btnTable2.BackColor = f.panelContainer.BackColor;*/
        }

        private void pBEmployee_Move(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            btnEmployees.BackColor = Color.Red;
        }

        private void pBOrder_Click(object sender, EventArgs e)
        {

        }

      

      

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


       
       




        //minimized
        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //maximized normal
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
            this.WindowState = FormWindowState.Normal;
        }

        private void panelSideMenuIcon_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            cafeMenuView view = new cafeMenuView();
            view.StartPosition = FormStartPosition.CenterScreen;
            view.ShowDialog();
        }
        //table click
        private void btnTables_Click(object sender, EventArgs e)
        {
            openChildForm(new CafeTables());
            Form1 f = new Form1();
            btnTables.BackColor = f.panelContainer.BackColor;
        }

        private void btnTables_Leave(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            btnTables.BackColor = f.panelSideMenu.BackColor;
        }
        //employee click
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            openChildForm(new CafeEmployee());
            Form1 f = new Form1();
            btnEmployees.BackColor = f.panelContainer.BackColor;
        }

        private void btnEmployees_Leave(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            btnEmployees.BackColor = f.panelSideMenu.BackColor;
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            openChildForm(new CafeEmployee());
            
            //Form1 f = new Form1();
            //btnEmployees.BackColor = f.panelContainer.BackColor;

        }
        //menu click
        private void pBMenu_Click(object sender, EventArgs e)
        {
            openChildForm(new CafeMenu());
            pBMenu.BorderStyle = BorderStyle.Fixed3D;
            //Form1 f = new Form1();
           // btnMenu.BackColor = f.panelContainer.BackColor;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            openChildForm(new CafeMenu());
            Form1 f = new Form1();
            btnMenu.BackColor = f.panelContainer.BackColor;
        }
        private void btnMenu_Leave(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            btnMenu.BackColor = f.panelSideMenu.BackColor;
        }

        
        //sale click
        private void pBSale_Click(object sender, EventArgs e)
        {
            openChildForm(new cafeSale());
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            openChildForm(new cafeSale());
            Form1 f = new Form1();
            btnSale.BackColor = f.panelContainer.BackColor;
        }
        private void btnSale_Leave(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            btnSale.BackColor = f.panelSideMenu.BackColor;
        }
        //home click
        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new CafeHome());
            Form1 f = new Form1();
            btnHome.BackColor = f.panelContainer.BackColor;
        }
        private void btnHome_Leave(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            btnHome.BackColor = f.panelSideMenu.BackColor;
        }
        //order click
        private void btnOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new cafeOrder());
            Form1 f = new Form1();
            btnOrder.BackColor = f.panelContainer.BackColor;
        }
       
        private void btnOrder_Leave(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            btnOrder.BackColor = f.panelSideMenu.BackColor;
        }
        //sale history
        private void btnSaleHistory_Click(object sender, EventArgs e)
        {
            openChildForm(new ComingSoonForm());
            Form1 f = new Form1();
           // btnOrder.BackColor = f.panelContainer.BackColor;
        }
        private void btnSaleHistory_Leave(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            btnOrder.BackColor = f.panelSideMenu.BackColor;
        }
        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Lee Hey");
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginIn l = new LoginIn();
            this.Hide();
            l.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            con.Open();
            
                SqlCommand cmd = new SqlCommand("select * from cafeAccounts where Username = '" + lbName.Text + "' and Passward = '"+lbPassward.Text+"' and Type='"+btnRole.Text+"'", con);
                SqlDataReader dr = cmd.ExecuteReader();



                cafeUserAccount acc = new cafeUserAccount();
               
                    while (dr.Read())
                    {
                        
                        acc.lbRole.Text = "ROLE - " + btnRole.Text.ToUpper();
                        acc.tbName.Text = lbName.Text;
                        acc.lbID.Text = dr["No"].ToString();
                        acc.tbFname.Text = dr["FatherName"].ToString();
                        acc.tbAddress.Text = dr["Address"].ToString();
                        acc.tbPhoneNo.Text = dr["PhonoNo"].ToString();
                        acc.tbDOB.Text = dr["bd"].ToString();

                        //================== need to show profile and update ========================
                        
                        /*string url = dr["Photo"].ToString();
                        acc.pbImage.BackgroundImage = Image.FromFile(url);*/
                       
                        acc.ShowDialog();
                       
                    }

                    dr.Close();
                    
                con.Close();

            
            
        }

       
    }
}
