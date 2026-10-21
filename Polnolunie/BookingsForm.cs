using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Polnolunie
{
    public partial class BookingsForm : Form
    {
        public BookingsForm()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(41, 53, 65);

            Button btnBack = new Button();
            btnBack.Text = "← Назад";
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.Size = new Size(150, 40);
            btnBack.Location = new Point(50, 30);
            btnBack.BackColor = Color.FromArgb(220, 53, 69);
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Click += (s, e) => { this.Close(); };
            this.Controls.Add(btnBack);

            buttonRefresh.Location = new Point(220, 30);
            buttonRefresh.BackColor = Color.White;
            buttonRefresh.FlatStyle = FlatStyle.Flat;

            dataGridViewBookings.Location = new Point(50, 100);
            dataGridViewBookings.Size = new Size(1800, 900);

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
                    string query = @"
                        SELECT 
                            b.id AS 'ID',
                            r.number AS 'Номер',
                            g.full_name AS 'Гость',
                            b.check_in AS 'Заезд',
                            b.check_out AS 'Выезд',
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
                        UiStyle.ApplyModernStyle(dataGridViewBookings);
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