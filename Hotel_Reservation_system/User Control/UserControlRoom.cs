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
    public partial class UserControlRoom : UserControl
    {

        DbConnector db;
        private string ID = "";


        public class DbConnector
        {
            private string connectionString = "Server=DUSH\\SQLEXPRESS01;Database=Hotel_Reservation_System;Integrated Security=True;";

            //ADD ROOM METHOD

            public bool AddRoom(string RoomType, String RoomPhone, String Free)
            {
                bool isAdded = false;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO Room_Table (Room_Type, Room_Phone, Room_Free) VALUES (@RoomType, @RoomPhone, @RoomFree)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@RoomType", RoomType);
                            cmd.Parameters.AddWithValue("@RoomPhone", RoomPhone);
                            cmd.Parameters.AddWithValue("@RoomFree", Free);



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

            // ROOM DISPLAY AND SEARCH METHOD
            public void DisplayAndSearchRoom(string query, DataGridView dgv)
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

            //EDIT ROOM METHOD

            public bool UpdateRoom(string RoomNo, string RoomType, String RoomPhone, String Free)
            {
                bool isUpdated = false;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE Room_Table SET Room_Free = @RoomFree, Room_Type = @RoomType,  Room_Phone = @RoomPhone WHERE Room_Number = @RoomNo";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@RoomFree", Free);
                            cmd.Parameters.AddWithValue("@RoomType", RoomType);
                            cmd.Parameters.AddWithValue("@RoomPhone", RoomPhone);
                            cmd.Parameters.AddWithValue("@RoomNo", RoomNo);




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

            //DELETE ROOM METHOD


            public bool DeleteRoom(string RoomNo)
            {
                bool isDeleted = false;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Room_Table WHERE ROOM_NUMBER = @RoomNo";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@RoomNo", RoomNo);

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







        public UserControlRoom()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()

        {
            textBoxRoomPhone.Clear();
            textBoxRoomFree.Clear();
            textBoxRoomType.Clear();
            tabControlRoom.SelectedTab = tabPageAddRoom;
        }

        public void Clear1()

        {
            textBoxRoomPhone1.Clear();
            textBoxRoomFree1.Clear();
            textBoxRoomType1.Clear();
            ID = "";

        }



        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchRoom_Leave(object sender, EventArgs e)
        {
            textBoxSearchRoom.Clear();
        }

        private void tabPageSearchRoom_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearchRoom("SELECT * FROM Room_Table", dataGridViewSearchRoom);
        }

        private void tabPageSearchClient_Leave(object sender, EventArgs e)
        {
            textBoxSearchRoom.Clear();
        }


        private void textBoxSearchRoom_TextChanged_1(object sender, EventArgs e)
        {
            db.DisplayAndSearchRoom("SELECT * FROM _Table WHERE Room_Number LIKE '%" + textBoxSearchRoom.Text + "%'", dataGridViewSearchRoom);

        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            bool check;
            if
                (textBoxRoomType.Text.Trim() == String.Empty || textBoxRoomPhone.Text.Trim() == String.Empty || textBoxRoomFree.Text.Trim() == String.Empty)
                MessageBox.Show("Kindly fill out all fields.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.AddRoom(textBoxRoomType.Text.Trim(), textBoxRoomPhone.Text.Trim(), textBoxRoomFree.Text.Trim()); 

                if (check)
                    Clear();

            }
        }


        private void dataGridViewSearchRoom_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 0)
            {
                DataGridViewRow row = dataGridViewSearchRoom.Rows[e.RowIndex];
                ID = row.Cells[2].Value.ToString();
                textBoxRoomType1.Text = row.Cells[3].Value.ToString();
                textBoxRoomPhone1.Text = row.Cells[4].Value.ToString();
                textBoxRoomFree1.Text = row.Cells[5].Value.ToString();


            }
        }



        private void buttonUpdateRoom_Click_1(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (textBoxRoomType.Text.Trim() == String.Empty || textBoxRoomPhone.Text.Trim() == String.Empty || textBoxRoomFree.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Kindly fill out all fields.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    check = db.UpdateRoom(ID, textBoxRoomType1.Text.Trim(), textBoxRoomPhone1.Text.Trim(), textBoxRoomFree1.Text.Trim());

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

        
        private void tabPageDeleteRoom_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonDeleteRoom_Click(object sender, EventArgs e)
        {
           
            bool check;
            if (ID != "")
                if (textBoxRoomType1.Text.Trim() == String.Empty || textBoxRoomPhone1.Text.Trim() == String.Empty || textBoxRoomFree1.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Kindly fill out all fields.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this Room?", "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    check = db.DeleteRoom(ID);
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

        private void tabPageDeleteRoom_Click(object sender, EventArgs e)
        {
            Clear1();
        }

        private void tabPageSearchRoom_Click(object sender, EventArgs e)
        {

        }
    }
}