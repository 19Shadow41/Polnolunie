namespace Polnolunie
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelLogin = new Label();
            txtLogin = new TextBox();
            labelPassword = new Label();
            txtPassword = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 300);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(1920, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Вход в систему \"Полнолуние\"";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter; // Центрируем текст внутри метки
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.ForeColor = Color.White;
            labelLogin.Location = new Point(710, 420);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(69, 25);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Логин:";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(710, 450);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(500, 32);
            txtLogin.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(710, 500);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(80, 25);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Пароль:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(710, 530);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(500, 32);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.Location = new Point(810, 600);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(300, 50);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 53, 65);
            ClientSize = new Size(1920, 1080);
            Controls.Add(buttonLogin);
            Controls.Add(txtPassword);
            Controls.Add(labelPassword);
            Controls.Add(txtLogin);
            Controls.Add(labelLogin);
            Controls.Add(labelTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelTitle;
        private Label labelLogin;
        private TextBox txtLogin;
        private Label labelPassword;
        private TextBox txtPassword;
        private Button buttonLogin;
    }
}