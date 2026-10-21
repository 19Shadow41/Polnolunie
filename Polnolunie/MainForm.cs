using System;
using System.Windows.Forms;

namespace Polnolunie
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.buttonRooms.Click += new System.EventHandler(this.buttonRooms_Click);
            this.buttonBookings.Click += new System.EventHandler(this.buttonBookings_Click); // Новая строка
        }

        private void buttonRooms_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm();
            roomsForm.ShowDialog();
        }

        // Новый метод для кнопки броней
        private void buttonBookings_Click(object sender, EventArgs e)
        {
            BookingsForm bookingsForm = new BookingsForm();
            bookingsForm.ShowDialog();
        }
    }
}