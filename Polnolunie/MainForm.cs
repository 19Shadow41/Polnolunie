using System;
using System.Windows.Forms;

namespace Polnolunie
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Добавляем событие клика к кнопке номера
            this.buttonRooms.Click += new System.EventHandler(this.buttonRooms_Click);
        }

        private void buttonRooms_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm();
            roomsForm.ShowDialog(); // Показываем форму номеров поверх главного меню
        }
    }
}