using System;
using System.Windows.Forms;
using System.Drawing;

namespace Polnolunie
{
    public partial class MainForm : Form
    {
        private string userRole;

        public MainForm(string role)
        {
            InitializeComponent();
            userRole = role;

            ConfigureMenuForRole();

            // Кнопка выхода (слева внизу)
            Button btnLogout = new Button();
            btnLogout.Text = "Выйти";
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogout.Size = new Size(150, 40);
            btnLogout.Location = new Point(50, 980); // В самом низу
            btnLogout.BackColor = Color.FromArgb(220, 53, 69); // Красный
            btnLogout.ForeColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Click += BtnLogout_Click;
            this.Controls.Add(btnLogout);

            this.buttonRooms.Click += new System.EventHandler(this.buttonRooms_Click);
            this.buttonBookings.Click += new System.EventHandler(this.buttonBookings_Click);
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void ConfigureMenuForRole()
        {
            labelWelcome.Text = $"Главное меню ({userRole})";

            if (userRole == "guest")
            {
                buttonRooms.Visible = false;
                buttonReports.Visible = false;
                buttonBookings.Text = "Мои бронирования";
                buttonBookings.Location = new Point(760, 430);
            }
            else if (userRole == "manager")
            {
                buttonReports.Visible = false;
                buttonBookings.Location = new Point(760, 350);
                buttonRooms.Location = new Point(760, 430);
            }
            else
            {
                buttonBookings.Location = new Point(760, 350);
                buttonRooms.Location = new Point(760, 430);
                buttonReports.Location = new Point(760, 510);
            }
        }

        private void buttonRooms_Click(object sender, EventArgs e) { new RoomsForm().ShowDialog(); }
        private void buttonBookings_Click(object sender, EventArgs e) { new BookingsForm().ShowDialog(); }
        private void buttonReports_Click(object sender, EventArgs e) { new ReportsForm().ShowDialog(); }
    }
}