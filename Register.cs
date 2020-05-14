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
    public partial class Register : Form
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

        public Register()
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
        private void crbMale_Click(object sender, EventArgs e)
        {
            Genderr = "Male";
        }

        private void crbFemale_Click(object sender, EventArgs e)
        {
            Genderr = "Female";
        }

        private void cUpdate_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();


            //ConnectionString:
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
            //Generating SQL Query
            string sql = "UPDATE clientinfo SET name = " + " ' " + name.Text + " '" + "where cid=" + cid.Text;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();


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

        private void cDelete_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();


            //ConnectionString:
            con.ConnectionString = "data source = AIRONY-LAPTOP;" +
                                   "database = GymManagementSystem;" +
                                   "integrated security = SSPI";

            //Generating SQL Query
            string sql = "Delete from clientinfo  where cid=" + cid.Text;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();


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
        //********************************************************** T R A I N E R******************************************
        private void tInsert_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();
            //ConnectionString:
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
            //Generating SQL Query
            string sql = "INSERT INTO trainerinfo(name,email,phone,address,dob,heightft,heightinch,weight,gender,username,password) VALUES(@dname,@demail,@dphone,@dadd,@ddob,@dheightft,@dheightinch,@dweight,@dgender,@dusername,@dpassword)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
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
                //Generating SQL Query
                SqlCommand command = new SqlCommand("select * from trainerinfo", con);
                //Execute SQL Query:
                SqlDataReader DR = command.ExecuteReader();
                //Binding reader to binding source
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                //Binding gridview or control datacsource to binding source:
                trainerinfotable.DataSource = source;
                //Disconnect
                con.Close();
            }
        }
        String tGender;
        private void trbMale_Click(object sender, EventArgs e)
        {
            tGender = "Male";
        }

        private void trbFemale_CheckedChanged(object sender, EventArgs e)
        {
            tGender = "Female";
        }

        private void tUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
            string sql = "UPDATE trainerinfo SET name = " + " ' " + tname.Text + " '" + "where tid=" + tid.Text;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                //Generating SQL Query
                SqlCommand command = new SqlCommand("select * from trainerinfo", con);

                //Execute SQL Query:
                SqlDataReader DR = command.ExecuteReader();

                //Binding reader to binding source
                BindingSource source = new BindingSource();
                source.DataSource = DR;

                //Binding gridview or control datacsource to binding source:
                trainerinfotable.DataSource = source;

                //Disconnect
                con.Close();
            }
        }

        private void tDelete_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();


            //ConnectionString:
            con.ConnectionString = "data source = AIRONY-LAPTOP;" +
                                   "database = GymManagementSystem;" +
                                   "integrated security = SSPI";

            //Generating SQL Query
            string sql = "Delete from trainerinfo  where tid=" + tid.Text;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                //Generating SQL Query
                SqlCommand command = new SqlCommand("select * from trainerinfo", con);

                //Execute SQL Query:
                SqlDataReader DR = command.ExecuteReader();

                //Binding reader to binding source
                BindingSource source = new BindingSource();
                source.DataSource = DR;

                //Binding gridview or control datacsource to binding source:
                trainerinfotable.DataSource = source;

                //Disconnect
                con.Close();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }

        //*********************************************************M A N A G E R *****************************************
        String mGender;
        private void mInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
            string sql = "INSERT INTO manageinfo(name,email,phone,address,dob,nid,gender,username,password) VALUES(@dname,@demail,@dphone,@dadd,@ddob,@nid,@dgender,@dusername,@dpassword)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.Parameters.Add("@dname", SqlDbType.NVarChar, 50).Value = mname.Text;
                cmd.Parameters.Add("@demail", SqlDbType.NVarChar, 50).Value = memail.Text;
                cmd.Parameters.Add("@dphone", SqlDbType.NVarChar, 50).Value = mphone.Text;
                cmd.Parameters.Add("@dadd", SqlDbType.NVarChar, 50).Value = maddress.Text;
                cmd.Parameters.Add("@ddob", SqlDbType.Date).Value = mdob.Value.Date;
                cmd.Parameters.Add("@nid", SqlDbType.NVarChar, 50).Value = mnid.Text;
                cmd.Parameters.Add("@dgender", SqlDbType.NVarChar, 50).Value = mGender;
                cmd.Parameters.Add("@dusername", SqlDbType.NVarChar, 50).Value = muname.Text;
                cmd.Parameters.Add("@dpassword", SqlDbType.NVarChar, 50).Value = mpass.Text;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("select * from manageinfo", con);
                SqlDataReader DR = command.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                managerinfotable.DataSource = source;
                con.Close();
            }
        }

        private void mmale_CheckedChanged(object sender, EventArgs e)
        {
            mGender = "Male";
        }

        private void mfemale_CheckedChanged(object sender, EventArgs e)
        {
            mGender = "Female";
        }

        private void mUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
            string sql = "UPDATE manageinfo SET name = " + " ' " + mname.Text + " '" + "where mid=" + mid.Text;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("select * from manageinfo", con);
                SqlDataReader DR = command.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                managerinfotable.DataSource = source;
                con.Close();
            }
        }

        private void mDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;" +
                                   "database = GymManagementSystem;" +
                                   "integrated security = SSPI";
            string sql = "Delete from manageinfo  where mid=" + mid.Text;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("select * from manageinfo", con);
                SqlDataReader DR = command.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                managerinfotable.DataSource = source;
                con.Close();
            }
        }

        private void mBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDB ae = new AdminDB();
            ae.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDB ll = new AdminDB();
            ll.Show();
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
            address.Text = "";
            tweight.Text = "";
            tuname.Text = "";
           tpassword.Text = "";
        }

        private void mClearAll_Click(object sender, EventArgs e)
        {
            mname.Text = "";
            memail.Text = "";
            mphone.Text = "";
            maddress.Text = "";
            muname.Text = "";
            mpass.Text = "";
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";

            SqlCommand command = new SqlCommand("select * from manageinfo", con);
            con.Open();
            SqlDataReader DR = command.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = DR;
            managerinfotable.DataSource = source;
            con.Close();
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

        private void tshow_Click(object sender, EventArgs e)
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
