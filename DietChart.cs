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
   
    public partial class DietChart : Form
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
        public DietChart()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
            string sql = "INSERT INTO dietchart(title,breakfast,lunch,evening,dinner) VALUES(@dname,@demail,@dphone,@dadd,@dweight)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.Parameters.Add("@dname", SqlDbType.NVarChar, 50).Value = textBox1.Text;
                cmd.Parameters.Add("@demail", SqlDbType.NVarChar, 50).Value = textBox2.Text;
                cmd.Parameters.Add("@dphone", SqlDbType.NVarChar, 50).Value = textBox3.Text;
                cmd.Parameters.Add("@dadd", SqlDbType.NVarChar, 50).Value = textBox4.Text;
                cmd.Parameters.Add("@dweight", SqlDbType.NVarChar, 50).Value = textBox5.Text;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("select * from dietchart", con);
                SqlDataReader DR = command.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                dietcharttab.DataSource = source;
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
            string sql = "UPDATE dietchart SET title = " + " ' " + textBox1.Text + " '" + "where did=" + textBox6.Text;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("select * from  dietchart", con);
                SqlDataReader DR = command.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                dietcharttab.DataSource = source;
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
            string sql = "Delete from dietchart  where did=" + textBox6.Text;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("select * from dietchart", con);
                SqlDataReader DR = command.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = DR;
                dietcharttab.DataSource = source;
                con.Close();
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDB qq = new AdminDB();
            qq.Show();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";

            SqlCommand command = new SqlCommand("select * from dietchart", con);
            con.Open();
            SqlDataReader DR = command.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = DR;
            dietcharttab.DataSource = source;
            con.Close();
        }
    }
}
