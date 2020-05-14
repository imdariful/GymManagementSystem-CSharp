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
    public partial class TrainerUpdate : Form
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
        public TrainerUpdate()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private void tUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AIRONY-LAPTOP;database = GymManagementSystem;integrated security = SSPI";
            string sql = "UPDATE trainerinfo SET name = " + " ' " + tname.Text + " '" + "where tid=" + id.Text;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!");
                con.Close();
            }
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainerBD ll = new TrainerBD();
            ll.Show();
        }
    }
}
