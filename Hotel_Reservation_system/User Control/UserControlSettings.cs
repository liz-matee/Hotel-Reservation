using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMRConnector;
using System.Diagnostics.Eventing.Reader;


namespace Hotel_Reservation_system
{
    public partial class UserControlSettings : UserControl
    {


        DbConnector db;
        private string ID = "";

        public class DbConnector
        {
            private string connectionString = "Server=DUSH\\SQLEXPRESS01;Database=Hotel_Reservation_System;Integrated Security=True;";

            // Method to display and search data
            public void DisplayAndSearch(string query, DataGridView dgv)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgv.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Method to add user

            public bool AddUser(string username, string password)
            {
                bool isAdded = false;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO User_Table (User_Name, User_Password) VALUES (@Username, @Password)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@Password", password);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            isAdded = rowsAffected > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                return isAdded;
            }


            // Method to edit user

            public bool EditUser(string id, string username, string password)
            {
                bool isUpdated = false;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE User_Table SET User_Name = @Username, User_Password = @Password WHERE User_ID = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@Password", password);
                            cmd.Parameters.AddWithValue("@ID", id);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            isUpdated = rowsAffected > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                return isUpdated;
            }

            // Method to delete user

            public bool DeleteUser(string id)
            {
                bool isDeleted = false;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM User_Table WHERE User_ID = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", id);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            isDeleted = rowsAffected > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                return isDeleted;
            }

        }




        public UserControlSettings()
        {
            InitializeComponent();
            db = new DbConnector();
        }


        public void Clear()

        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            tabControlSettings.SelectedTab = tabPageAddUser;

        }


        public void Clear1()

        {
            textBoxUsername1.Clear();
            textBoxPassword1.Clear();
            ID = "";


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void tabPageAddUser_Click(object sender, EventArgs e)
        {

        }

        private void tabControlSettings_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageSearch_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM User_Table", dataGridViewSearch);
        }

        private void tabPageSearch_Leave(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void tabPageEdituser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            bool check;
            if (textBoxUsername.Text.Trim() == String.Empty || textBoxPassword.Text.Trim() == String.Empty)
                MessageBox.Show("Kindly fill out all fields.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.AddUser(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());
                if (check)
                    Clear();

            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM User_Table WHERE User_Name LIKE '%" + textBoxSearch.Text + "%'", dataGridViewSearch);
        }

        private void tabControlSettings_Enter(object sender, EventArgs e)
        {
            dataGridViewSearch.Invoke(new Action(() =>
            {
                dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                db.DisplayAndSearch("SELECT * FROM User_Table", dataGridViewSearch);
                dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }));
        }





        private void dataGridViewSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewSearch.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxUsername1.Text = row.Cells[1].Value.ToString();
                textBoxPassword1.Text = row.Cells[2].Value.ToString();

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (textBoxUsername1.Text.Trim() == string.Empty || textBoxPassword1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Kindly fill out all fields.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    check = db.EditUser(ID, textBoxUsername1.Text.Trim(), textBoxPassword1.Text.Trim());

                    if (check)
                        Clear1();
                    else
                        MessageBox.Show("Edit failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kindly select a row from the table.", "Selection of a row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
                if (textBoxUsername1.Text.Trim() == string.Empty || textBoxPassword1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Kindly fill out all fields.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    check = db.DeleteUser(ID);
                        if (check)
                            Clear1();
                        else
                            MessageBox.Show("Deletion failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            else
            {
                MessageBox.Show("Kindly select a row from the table.", "Selection of a row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}