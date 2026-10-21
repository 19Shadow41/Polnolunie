using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Polnolunie
{
    public partial class RoomsForm : Form
    {
        public RoomsForm()
        {
            InitializeComponent();

            // Стилизация формы
            this.BackColor = Color.FromArgb(41, 53, 65);

            // Кнопка Назад
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

            // Сдвигаем кнопку обновления и красим
            buttonRefresh.Location = new Point(220, 30);
            buttonRefresh.BackColor = Color.White;
            buttonRefresh.FlatStyle = FlatStyle.Flat;

            // Таблица по центру (отступ сверху больше)
            dataGridViewRooms.Location = new Point(50, 100);
            dataGridViewRooms.Size = new Size(1800, 900);

            LoadRooms();
        }

        private void LoadRooms()
        {
            string connStr = "Server=141.8.192.217;Database=upl02_hostel;Uid=upl02_hostel;Pwd=Vhod1941;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    // Выводим данные, статусы уже переведены в БД
                    string query = "SELECT number AS 'Номер', capacity AS 'Вместимость', price_per_day AS 'Цена за сутки', status AS 'Статус' FROM rooms";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewRooms.DataSource = dt;
                        UiStyle.ApplyModernStyle(dataGridViewRooms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки номеров: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadRooms();
        }
    }
}