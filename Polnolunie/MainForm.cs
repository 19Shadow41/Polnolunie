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
            this.buttonBookings.Click += new System.EventHandler(this.buttonBookings_Click);
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click); // Новая строка
        }

        private void buttonRooms_Click(object sender, EventArgs e) { new RoomsForm().ShowDialog(); }
        private void buttonBookings_Click(object sender, EventArgs e) { new BookingsForm().ShowDialog(); }

        // Новый метод
        private void buttonReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }
    }
}