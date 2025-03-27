using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMRConnector;

namespace Hotel_Reservation_system
{

    public partial class FormLogIn : Form
    {
        DbConnector db;
        public class DbConnector
        {
            private string connectionString = "Server=DUSH\\SQLEXPRESS01;Database=Hotel_Reservation_System;Integrated Security=True;";

            public bool IsValidNamePass(string username, string password)
            {
                bool isValid = false;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM User_Table WHERE User_Name = @username AND User_Password = @Password";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@Password", password);

                            int count = (int)cmd.ExecuteScalar();
                            isValid = count > 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Database Error: " + ex.Message);
                    }
                }

                return isValid;
            }
        }
        public FormLogIn()
        {
            InitializeComponent();
            db = new DbConnector();

        }

        private static readonly ToolTip toolTip1 = new ToolTip();
        private ToolTip toolTip = toolTip1;

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimise_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimise, "Minimise");

        }

        private void pictureBoxMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxHide.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            bool check = db.IsValidNamePass(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());
            if (textBoxUsername.Text.Trim() == String.Empty || textBoxPassword.Text.Trim() == String.Empty)
                MessageBox.Show("Kindly fill out all fields.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (check)
                {
                    FormDashboard fd = new FormDashboard();
                    fd.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.", "Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}