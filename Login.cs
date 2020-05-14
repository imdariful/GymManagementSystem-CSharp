using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace GymManagementSystem
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
            );
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            
            Close();

        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register re = new Register();
            re.Show();

        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "User Name")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "User Name";
                username.ForeColor = Color.DarkGray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";
                password.ForeColor = Color.DarkGray;
            }
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                password.UseSystemPasswordChar = true;

            }
            else
            {
                password.UseSystemPasswordChar = false;
            }
        }

        private void musername_Enter(object sender, EventArgs e)
        {
            if (musername.Text == "User Name")
            {
                musername.Text = "";
                musername.ForeColor = Color.Black;
            }
        }

        private void mpasswod_Leave(object sender, EventArgs e)
        {
            if (mpassword.Text == "")
            {
                mpassword.Text = "Password";
                mpassword.ForeColor = Color.DarkGray;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mpassword.UseSystemPasswordChar = true;

            }
            else
            {
                mpassword.UseSystemPasswordChar = false;
            }
        }

        private void mpassword_Enter(object sender, EventArgs e)
        {
            if (mpassword.Text == "Password")
            {
                mpassword.Text = "";
                mpassword.ForeColor = Color.Black;
            }
        }

        private void musername_Leave(object sender, EventArgs e)
        {
            if (musername.Text == "")
            {
                musername.Text = "User Name";
                musername.ForeColor = Color.DarkGray;
            }
        }

        private void tusername_Enter(object sender, EventArgs e)
        {
            if (tusername.Text == "User Name")
            {
                tusername.Text = "";
                tusername.ForeColor = Color.Black;
            }

        }

        private void tusername_Leave(object sender, EventArgs e)
        {
            if (tusername.Text == "")
            {
                tusername.Text = "User Name";
                tusername.ForeColor = Color.DarkGray;
            }
        }

        private void tpassword_Enter(object sender, EventArgs e)
        {
            if (tpassword.Text == "Password")
            {
                tpassword.Text = "";
                tpassword.ForeColor = Color.Black;
            }
        }

        private void tpassword_Leave(object sender, EventArgs e)
        {

            if (tpassword.Text == "")
            {
                tpassword.Text = "Password";
                tpassword.ForeColor = Color.DarkGray;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                tpassword.UseSystemPasswordChar = true;

            }
            else
            {
                tpassword.UseSystemPasswordChar = false;
            }
        }

        private void cusername_Enter(object sender, EventArgs e)
        {

            if (cusername.Text == "User Name")
            {
               cusername.Text = "";
                cusername.ForeColor = Color.Black;
            }
        }

        private void cusername_Leave(object sender, EventArgs e)
        {
            if (cusername.Text == "")
            {
                cusername.Text = "User Name";
                cusername.ForeColor = Color.DarkGray;
            }
        }

        private void cpassword_Enter(object sender, EventArgs e)
        {
            if (cpassword.Text == "Password")
            {
                cpassword.Text = "";
                cpassword.ForeColor = Color.Black;
            }
        }

        private void cpassword_Leave(object sender, EventArgs e)
        {
            if (cpassword.Text == "")
            {
                cpassword.Text = "Password";
                cpassword.ForeColor = Color.DarkGray;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                cpassword.UseSystemPasswordChar = true;

            }
            else
            {
                cpassword.UseSystemPasswordChar = false;
            }
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
                SqlCommand cmd = new SqlCommand(
                    cmdText: "Select * from admininfo where username='" + username.Text + " 'and password='" + password.Text + "'", connection: con);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    AdminDB fm = new AdminDB();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
                SqlCommand cmd = new SqlCommand(
                    cmdText: "Select * from manageinfo where username='" + musername.Text + " 'and password='" + mpassword.Text + "'", connection: con);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    ManagerDB em = new ManagerDB();
                    em.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
                SqlCommand cmd = new SqlCommand(
                    cmdText: "Select * from trainerinfo where username='" + tusername.Text + " 'and password='" + tpassword.Text + "'", connection: con);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                   TrainerBD fq = new TrainerBD();
                    fq.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
                SqlCommand cmd = new SqlCommand(
                    cmdText: "Select * from clientinfo where username='" + cusername.Text + " 'and password='" + cpassword.Text + "'", connection: con);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    ClientDB cd = new ClientDB();
                    cd.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
