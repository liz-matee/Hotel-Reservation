using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMRConnector;



namespace Hotel_Reservation_system.User_Control
{
    public partial class UserControlClient : UserControl
    {

        DbConnector db;
        private string ID = "";


        public class DbConnector
        {
            private string connectionString = "Server=DUSH\\SQLEXPRESS01;Database=Hotel_Reservation_System;Integrated Security=True;";

            //ADD CLIENT METHOD

            public bool AddClient(string Firstname, string Lastname, String PhoneNo)
            {
                bool isAdded = false;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO Client_Table (Client_Firstname, Client_Lastname, Client_PhoneNo) VALUES (@Firstname, @Lastname, @PhoneNo)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Firstname", Firstname);
                            cmd.Parameters.AddWithValue("@Lastname", Lastname);
                            cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);


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

            // Method to display and search data
            public void DisplayAndSearchClient(string query, DataGridView dgv)
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

            //EDIT CLIENT METHOD

            public bool EditClient(String id, string Firstname, string Lastname, String PhoneNo)
            {
                bool isUpdated = false;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE Client_Table SET Client_Firstname = @Firstname, Client_Lastname = @Lastname,  Client_PhoneNo = @PhoneNo WHERE Client_ID = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Firstname", Firstname);
                            cmd.Parameters.AddWithValue("@Lastname", Lastname);
                            cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
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

            //DELETE CLIENT METHOD


            public bool DeleteClient(string id)
            {
                bool isDeleted = false;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Client_Table WHERE Client_ID = @ID";
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



    

        

        public UserControlClient()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()

        {

            textBoxFirstnameClient.Clear();
            textBoxLastnameClient.Clear();
            textBoxPhoneClient.Clear();
            tabControlClient.SelectedTab = tabPageAddClient;
        }

        public void Clear1()

        {

            textBoxFirstnameClient1.Clear();
            textBoxLastnameClient1.Clear();
            textBoxPhoneClient1.Clear();
            ID = "";
        }


     
        private void tabPageAddClient_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearchClient("SELECT * FROM Client_Table", dataGridViewSearchClient);
        }

        private void tabPageSearchClient_Leave(object sender, EventArgs e)
        {
            textBoxSearchClient.Clear();
        }

        private void textBoxSearchClient_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearchClient("SELECT * FROM Client_Table WHERE Client_PhoneNo LIKE '%" + textBoxSearchClient.Text + "%'", dataGridViewSearchClient);

        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (textBoxFirstnameClient1.Text.Trim() == String.Empty || textBoxLastnameClient1.Text.Trim() == String.Empty || textBoxPhoneClient1.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Kindly fill out all fields.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    check = db.EditClient(ID, textBoxFirstnameClient1.Text.Trim(), textBoxLastnameClient1.Text.Trim(), textBoxPhoneClient1.Text.Trim());

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

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
                if (textBoxFirstnameClient1.Text.Trim() == String.Empty || textBoxLastnameClient1.Text.Trim() == String.Empty || textBoxPhoneClient1.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Kindly fill out all fields.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this Client?", "Delete Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    check = db.DeleteClient(ID);
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

        private void tabPageDeleteClient_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            bool check;
            if (textBoxFirstnameClient.Text.Trim() == String.Empty || textBoxLastnameClient.Text.Trim() == String.Empty || textBoxPhoneClient.Text.Trim() == String.Empty)
                MessageBox.Show("Kindly fill out all fields.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.AddClient(textBoxFirstnameClient.Text.Trim(), textBoxLastnameClient.Text.Trim(), textBoxPhoneClient.Text.Trim());
                if (check)
                    Clear();

            }
        }

        private void dataGridViewSearchClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 0)
            {
                DataGridViewRow row = dataGridViewSearchClient.Rows[e.RowIndex];
                ID = row.Cells[1].Value.ToString();
                textBoxFirstnameClient1.Text = row.Cells[2].Value.ToString();
                textBoxLastnameClient1.Text = row.Cells[3].Value.ToString();
                textBoxPhoneClient1.Text = row.Cells[4].Value.ToString();


            }
        }

        private void tabPageAddClient_Click(object sender, EventArgs e)
        {

        }

        private void tabPageSearchClient_Click(object sender, EventArgs e)
        {

        }
    }
}

