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
using System.Runtime.InteropServices;

namespace GymManagementSystem
{
    public partial class ManagerEmp : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,    
               int nTopRect,     
               int nRightRect,  
               int nBottomRect,  
               int nWidthEllipse, 
               int nHeightEllipse 
               );
        public ManagerEmp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void cInsert_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();
            //ConnectionString:
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
            //Generating SQL Query
            string sql = "INSERT INTO clientinfo(name,email,phone,address,dob,heightft,heightinch,weight,gender,username,password) VALUES(@dname,@demail,@dphone,@dadd,@ddob,@dheightft,@dheightinch,@dweight,@dgender,@dusername,@dpassword)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();
                cmd.Parameters.Add("@dname", SqlDbType.NVarChar, 50).Value = name.Text;
                cmd.Parameters.Add("@demail", SqlDbType.NVarChar, 50).Value = email.Text;
                cmd.Parameters.Add("@dphone", SqlDbType.NVarChar, 50).Value = phone.Text;
                cmd.Parameters.Add("@dadd", SqlDbType.NVarChar, 50).Value = address.Text;
                cmd.Parameters.Add("@ddob", SqlDbType.Date).Value = dob.Value.Date;
                cmd.Parameters.Add("@dheightft", SqlDbType.NVarChar, 50).Value = heightft.Text.ToString();
                cmd.Parameters.Add("@dheightinch", SqlDbType.NVarChar, 50).Value = heightinch.Text.ToString();
                cmd.Parameters.Add("@dweight", SqlDbType.NVarChar, 50).Value = weight.Text;
                cmd.Parameters.Add("@dgender", SqlDbType.NVarChar, 50).Value = Genderr;
                cmd.Parameters.Add("@dusername", SqlDbType.NVarChar, 50).Value = username.Text;
                cmd.Parameters.Add("@dpassword", SqlDbType.NVarChar, 50).Value = password.Text;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                //Generating SQL Query
                SqlCommand command = new SqlCommand("select * from clientinfo", con);
                //Execute SQL Query:
                SqlDataReader DR = command.ExecuteReader();
                //Binding reader to binding source
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                //Binding gridview or control datacsource to binding source:
                clientinfotable.DataSource = source;
                //Disconnect
                con.Close();
            }
        }
        string Genderr;
        

        private void cUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
            string sql = "UPDATE clientinfo SET name = " + " ' " + name.Text + " '" + "where cid=" + cid.Text;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("select * from clientinfo", con);
                SqlDataReader DR = command.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                clientinfotable.DataSource = source;
                con.Close();
            }
        }

        private void cDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;" +
                                   "database = GymManagementSystem;" +
                                   "integrated security = SSPI";
            string sql = "Delete from clientinfo  where cid=" + cid.Text;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("select * from clientinfo", con);
                SqlDataReader DR = command.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                clientinfotable.DataSource = source;
                con.Close();
            }
        }

        private void cClearAll_Click(object sender, EventArgs e)
        {
            name.Text = "";
            email.Text = "";
            phone.Text = "";
            address.Text = "";
            weight.Text = "";
            username.Text = "";
            password.Text = "";       
        }

        private void tClearAll_Click(object sender, EventArgs e)
        {
            tname.Text = "";
            temail.Text = "";
            tphone.Text = "";
            taddress.Text = "";
            tweight.Text = "";
            tuname.Text = "";
            tpassword.Text = "";
        }

        private void tInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
            string sql = "INSERT INTO trainerinfo(name,email,phone,address,dob,heightft,heightinch,weight,gender,username,password) VALUES(@dname,@demail,@dphone,@dadd,@ddob,@dheightft,@dheightinch,@dweight,@dgender,@dusername,@dpassword)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.Parameters.Add("@dname", SqlDbType.NVarChar, 50).Value = tname.Text;
                cmd.Parameters.Add("@demail", SqlDbType.NVarChar, 50).Value = temail.Text;
                cmd.Parameters.Add("@dphone", SqlDbType.NVarChar, 50).Value = tphone.Text;
                cmd.Parameters.Add("@dadd", SqlDbType.NVarChar, 50).Value = taddress.Text;
                cmd.Parameters.Add("@ddob", SqlDbType.Date).Value = tdob.Value.Date;
                cmd.Parameters.Add("@dheightft", SqlDbType.NVarChar, 50).Value = thft.Text.ToString();
                cmd.Parameters.Add("@dheightinch", SqlDbType.NVarChar, 50).Value = thinch.Text.ToString();
                cmd.Parameters.Add("@dweight", SqlDbType.NVarChar, 50).Value = tweight.Text;
                cmd.Parameters.Add("@dgender", SqlDbType.NVarChar, 50).Value = tGender;
                cmd.Parameters.Add("@dusername", SqlDbType.NVarChar, 50).Value = tuname.Text;
                cmd.Parameters.Add("@dpassword", SqlDbType.NVarChar, 50).Value = tpassword.Text;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("select * from trainerinfo", con);
                SqlDataReader DR = command.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                trainerinfotable.DataSource = source;
                con.Close();
            }
        }

        private void tUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
            string sql = "UPDATE trainerinfo SET name = " + " ' " + tname.Text + " '" + "where tid=" + tid.Text;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("select * from trainerinfo", con);
                SqlDataReader DR = command.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                trainerinfotable.DataSource = source;
                con.Close();
            }
        }

        private void tDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;" +
                                   "database = GymManagementSystem;" +
                                   "integrated security = SSPI";
            string sql = "Delete from trainerinfo  where tid=" + tid.Text;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("select * from trainerinfo", con);
                SqlDataReader DR = command.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                trainerinfotable.DataSource = source;
                con.Close();
            }
        }
        String tGender;
        private void trbMale_CheckedChanged(object sender, EventArgs e)
        {
            tGender = "Male";
        }

        private void trbFemale_CheckedChanged(object sender, EventArgs e)
        {
            tGender = "Female";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerDB db = new ManagerDB();
            db.Show();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void crbFemale_CheckedChanged(object sender, EventArgs e)
        {
            Genderr = "Female";
        }

        private void crbMale_CheckedChanged(object sender, EventArgs e)
        {
            Genderr = "Male";
        }

        private void cshow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";

            SqlCommand command = new SqlCommand("select * from clientinfo", con);
            con.Open();
            SqlDataReader DR = command.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = DR;
            clientinfotable.DataSource = source;
            con.Close();
        }

        private void tShowAll_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";

            SqlCommand command = new SqlCommand("select * from trainerinfo", con);
            con.Open();
            SqlDataReader DR = command.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = DR;
            trainerinfotable.DataSource = source;
            con.Close();
        }
    }
}
