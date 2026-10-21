using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Polnolunie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //Подключение к БД с внеш. источника (SprintHost)
        private void buttonTest_Click(object sender, EventArgs e)
        {
            string server = "141.8.192.217";
            string database = "upl02_hostel";
            string uid = "upl02_hostel";
            string password = "Elcapulco1941!";

            string connStr = $"Server={server};Database={database};Uid={uid};Pwd={password};";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    MessageBox.Show("Подключение успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}