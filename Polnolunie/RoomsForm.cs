using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Polnolunie
{
    public partial class RoomsForm : Form
    {
        public RoomsForm()
        {
            InitializeComponent();
            LoadRooms(); // Загружаем данные при открытии
        }

        private void LoadRooms()
        {
            string connStr = "Server=141.8.192.217;Database=upl02_hostel;Uid=upl02_hostel;Pwd=Vhod1941;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    // Берем данные из таблицы rooms
                    string query = "SELECT number AS 'Номер', capacity AS 'Вместимость', price_per_day AS 'Цена за сутки', status AS 'Статус' FROM rooms";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Привязываем данные к таблице
                        dataGridViewRooms.DataSource = dt;
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
            LoadRooms(); // Обновляем таблицу по кнопке
        }
    }
}