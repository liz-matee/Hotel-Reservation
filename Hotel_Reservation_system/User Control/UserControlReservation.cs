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


namespace Hotel_Reservation_system.User_Control
{
    public partial class UserControlReservation : UserControl
    {


        DbConnector db;
        private string ID = "";

        public class DbConnector
        {
            private string connectionString = "Server=DUSH\\SQLEXPRESS01;Database=Hotel_Reservation_System;Integrated Security=True;";

            //ADD RESERVATION METHOD

            public bool AddReservation(string Clientname, string Roomnumber, String Roomtype, string Reserve)
            {
                bool isAdded = false;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO Reservation_Table (Client_name, Room_number, Room_Type, Room_Reservation) VALUES (@Clientname, @Roomnumber, @Roomtype, @Reserve)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Clientname", Clientname);
                            cmd.Parameters.AddWithValue("@Roomnumber", Roomnumber);
                            cmd.Parameters.AddWithValue("@Roomtype", Roomtype);
                            cmd.Parameters.AddWithValue("@Reserve", Reserve);



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

            // Method to display and search Reservation
            public void DisplayAndSearchReservation(string query, DataGridView dgv)
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


            //EDIT RESERVATION METHOD

            public bool UpdateReservation(String id, string Clientname, string Roomnumber, String Roomtype, string Reserve)
            {
                bool isUpdated = false;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE Reservation_Table SET Client_Name = @Clientname, Room_Number = @Roomnumber, Room_Type = @Roomtype, Room_Reservation = @Reserve WHERE Reservation_ID = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Clientname", Clientname);
                            cmd.Parameters.AddWithValue("@Roomnumber", Roomnumber);
                            cmd.Parameters.AddWithValue("@Roomtype", Roomtype);
                            cmd.Parameters.AddWithValue("@Reserve", Reserve);
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

            //DELETE RESERVATION METHOD

            public bool DeleteReservation(String id)
            {
                bool isDeleted = false;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Reservation_Table WHERE Reservation_ID = @ID";
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

        public UserControlReservation()
            {

                InitializeComponent();
                db = new DbConnector();

            }

        public void Clear()

        {

            textBoxClientName.Clear();
            textBoxRoomType.Clear();
            textBoxReserve.Clear();
            textBoxRoomNumber.Clear();
            tabControlReservation.SelectedTab = tabPageAddReservation;
        }



        public void Clear1()

        {

            textBoxClientName1.Clear();
            textBoxRoomType1.Clear();
            textBoxReserve1.Clear();
            textBoxRoomNumber1.Clear();
            ID = "";
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void UserControlReservation_Load(object sender, EventArgs e)
            {

            }

        private void tabControlReservation_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchReservation_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearchReservation("SELECT * FROM Reservation_Table", dataGridViewSearchReservation);

        }

        private void tabPageSearchReservation_Leave(object sender, EventArgs e)
        {
            textBoxSearchReservation.Clear();

        }

        private void textBoxSearchReservation_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearchReservation("SELECT * FROM Reservation_Table WHERE Client_Name LIKE '%" + textBoxSearchReservation.Text + "%'", dataGridViewSearchReservation);
        }

        private void buttonAddReservation_Click(object sender, EventArgs e)
        {
            bool check;
            if (textBoxClientName.Text.Trim() == String.Empty || textBoxRoomNumber.Text.Trim() == String.Empty || textBoxRoomType.Text.Trim() == String.Empty || textBoxReserve.Text.Trim() == String.Empty)
                MessageBox.Show("Kindly fill out all fields.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.AddReservation(textBoxClientName.Text.Trim(), textBoxRoomNumber.Text.Trim(), textBoxRoomType.Text.Trim(), textBoxReserve.Text.Trim());
                if (check)
                    Clear();

            }
        }

        private void dataGridViewSearchReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0 )
            {
                DataGridViewRow row = dataGridViewSearchReservation.Rows[e.RowIndex];
                ID = row.Cells[2].Value.ToString();
                textBoxClientName1.Text = row.Cells[3].Value.ToString();
                textBoxRoomNumber1.Text = row.Cells[4].Value.ToString();
                textBoxRoomType1.Text = row.Cells[5].Value.ToString();
                textBoxReserve1.Text = row.Cells[6].Value.ToString();
            }
        }

        private void buttonUpdateReservation_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (textBoxClientName1.Text.Trim() == String.Empty || textBoxRoomNumber1.Text.Trim() == String.Empty || textBoxRoomType1.Text.Trim() == String.Empty || textBoxReserve1.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Kindly fill out all fields.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    check = db.UpdateReservation( ID, textBoxClientName1.Text.Trim(),textBoxRoomNumber1.Text.Trim(), textBoxRoomType1.Text.Trim(), textBoxReserve1.Text.Trim());

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

        private void buttonDeleteReservation_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
                if (textBoxClientName1.Text.Trim() == String.Empty || textBoxRoomNumber1.Text.Trim() == String.Empty || textBoxRoomType1.Text.Trim() == String.Empty || textBoxReserve1.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Kindly fill out all fields.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this Reservation?", "Delete Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    check = db.DeleteReservation(ID);
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

        private void tabPageSearchReservation_Click(object sender, EventArgs e)
        {

        }
    }
    
}
