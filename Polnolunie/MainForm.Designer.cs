namespace Polnolunie
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelWelcome = new Label();
            buttonBookings = new Button();
            buttonRooms = new Button();
            buttonReports = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            labelWelcome.ForeColor = Color.White;
            labelWelcome.Location = new Point(0, 200);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(1920, 50);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Главное меню";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter; // Центрируем текст!
            // 
            // buttonBookings
            // 
            buttonBookings.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBookings.Location = new Point(760, 350);
            buttonBookings.Name = "buttonBookings";
            buttonBookings.Size = new Size(400, 60);
            buttonBookings.TabIndex = 1;
            buttonBookings.Text = "Управление бронями";
            buttonBookings.UseVisualStyleBackColor = false;
            buttonBookings.BackColor = Color.White;
            // 
            // buttonRooms
            // 
            buttonRooms.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRooms.Location = new Point(760, 430);
            buttonRooms.Name = "buttonRooms";
            buttonRooms.Size = new Size(400, 60);
            buttonRooms.TabIndex = 2;
            buttonRooms.Text = "Управление номерами";
            buttonRooms.UseVisualStyleBackColor = false;
            buttonRooms.BackColor = Color.White;
            // 
            // buttonReports
            // 
            buttonReports.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReports.Location = new Point(760, 510);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new Size(400, 60);
            buttonReports.TabIndex = 3;
            buttonReports.Text = "Отчеты (Выручка и Рейтинг)";
            buttonReports.UseVisualStyleBackColor = false;
            buttonReports.BackColor = Color.White;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 53, 65);
            ClientSize = new Size(1920, 1080);
            Controls.Add(buttonReports);
            Controls.Add(buttonRooms);
            Controls.Add(buttonBookings);
            Controls.Add(labelWelcome);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Полнолуние - Главное меню";
            ResumeLayout(false);
        }

        private Label labelWelcome;
        private Button buttonBookings;
        private Button buttonRooms;
        private Button buttonReports;
    }
}