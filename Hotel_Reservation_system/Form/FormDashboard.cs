using Hotel_Reservation_system.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hotel_Reservation_system
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }



        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
                this.Close();
            {
                
            }

        }

       

        private void buttonClient_Click(object sender, EventArgs e)
        {
            buttonSettings.BackColor = SystemColors.Control;
            buttonReservation.BackColor = SystemColors.Control;
            buttonClient.BackColor = Color.Gold;


            userControlSettings.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();

            userControlClient1.Clear();
            userControlClient1.Show();





        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            buttonClient.BackColor = SystemColors.Control;
            buttonReservation.BackColor = SystemColors.Control;
            buttonSettings.BackColor = SystemColors.Control;


            userControlSettings.Hide();
            userControlClient1.Hide();
            userControlReservation1.Hide();

            userControlRoom1.Show();



        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            
            

            buttonClient.BackColor = SystemColors.Control;
            buttonReservation.BackColor = SystemColors.Control;
            buttonSettings.BackColor = Color.Gold;

            userControlSettings.Clear();
            userControlSettings.Show();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();




        }



        private void buttonReservation_Click(object sender, EventArgs e)
        {
            buttonClient.BackColor = SystemColors.Control;
            buttonSettings.BackColor = SystemColors.Control;
            buttonReservation.BackColor = Color.Gold;

            userControlSettings.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Show();


        }

        private void userControlSettings_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            buttonClient.BackColor = SystemColors.Control;
            buttonReservation.BackColor = SystemColors.Control;
            buttonSettings.BackColor = SystemColors.Control;



            userControlSettings.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();





        }

        private void userControlClient1_Load(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

        }
    }
    }

