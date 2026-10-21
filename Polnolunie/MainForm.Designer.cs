namespace Polnolunie
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelWelcome.Location = new Point(700, 200);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(500, 45);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Главное меню";
            // 
            // buttonBookings
            // 
            buttonBookings.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBookings.Location = new Point(760, 350);
            buttonBookings.Name = "buttonBookings";
            buttonBookings.Size = new Size(400, 60);
            buttonBookings.TabIndex = 1;
            buttonBookings.Text = "Управление бронями";
            buttonBookings.UseVisualStyleBackColor = true;
            // 
            // buttonRooms
            // 
            buttonRooms.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRooms.Location = new Point(760, 430);
            buttonRooms.Name = "buttonRooms";
            buttonRooms.Size = new Size(400, 60);
            buttonRooms.TabIndex = 2;
            buttonRooms.Text = "Управление номерами";
            buttonRooms.UseVisualStyleBackColor = true;
            // 
            // buttonReports
            // 
            buttonReports.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReports.Location = new Point(760, 510);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new Size(400, 60);
            buttonReports.TabIndex = 3;
            buttonReports.Text = "Отчеты (Выручка и Рейтинг)";
            buttonReports.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(buttonReports);
            Controls.Add(buttonRooms);
            Controls.Add(buttonBookings);
            Controls.Add(labelWelcome);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Полнолуние - Главное меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Button buttonBookings;
        private Button buttonRooms;
        private Button buttonReports;
    }
}