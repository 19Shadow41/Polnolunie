using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Polnolunie
{
    public partial class BookingsForm : Form
    {
        public BookingsForm()
        {
            InitializeComponent();
            LoadBookings();
        }

        private void LoadBookings()
        {
            string connStr = "Server=141.8.192.217;Database=upl02_hostel;Uid=upl02_hostel;Pwd=Vhod1941;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    // Берем данные из таблицы bookings, объединяя с rooms и guests
                    string query = @"
                        SELECT 
                            b.id AS 'ID брони',
                            r.number AS 'Номер комнаты',
                            g.full_name AS 'Гость',
                            b.check_in AS 'Дата заезда',
                            b.check_out AS 'Дата выезда',
                            b.status AS 'Статус'
                        FROM bookings b
                        LEFT JOIN rooms r ON b.room_id = r.id
                        LEFT JOIN guests g ON b.guest_id = g.id
                        ORDER BY b.id DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewBookings.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки броней: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadBookings();
        }
    }
}