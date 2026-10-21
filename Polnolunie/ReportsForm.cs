using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Polnolunie
{
    public partial class ReportsForm : Form
    {
        string connStr = "Server=141.8.192.217;Database=upl02_hostel;Uid=upl02_hostel;Pwd=Vhod1941;";

        public ReportsForm()
        {
            InitializeComponent();
        }

        // Отчет о выручке
        private void buttonRevenue_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            r.number AS 'Номер', 
                            COUNT(b.id) AS 'Кол-во броней', 
                            SUM(DATEDIFF(b.check_out, b.check_in) * r.price_per_day) AS 'Выручка (руб.)'
                        FROM bookings b
                        JOIN rooms r ON b.room_id = r.id
                        WHERE b.status != 'cancelled' AND b.check_in >= @start AND b.check_out <= @end
                        GROUP BY r.number
                        ORDER BY 'Выручка (руб.)' DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@start", dtpStart.Value.Date);
                        cmd.Parameters.AddWithValue("@end", dtpEnd.Value.Date);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridViewRevenue.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Отчет о рейтинге
        private void buttonRating_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            r.number AS 'Номер', 
                            IFNULL(ROUND(AVG(rev.rating), 1), 0) AS 'Средний балл', 
                            COUNT(rev.id) AS 'Кол-во отзывов',
                            COUNT(b.id) AS 'Популярность (брони)'
                        FROM rooms r
                        LEFT JOIN reviews rev ON r.id = rev.room_id
                        LEFT JOIN bookings b ON r.id = b.room_id
                        GROUP BY r.number
                        ORDER BY 'Средний балл' DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewRating.DataSource = dt;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}