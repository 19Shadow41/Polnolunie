namespace Polnolunie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
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
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(760, 350);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(400, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Вход в систему \"Полнолуние\"";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.Location = new Point(760, 450);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(69, 25);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Логин:";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(760, 480);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(400, 32);
            txtLogin.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(760, 530);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(80, 25);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Пароль:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(760, 560);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 32);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true; // Скрывает пароль точками
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.Location = new Point(860, 630);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(200, 50);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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

        #endregion

        private Label labelTitle;
        private Label labelLogin;
        private TextBox txtLogin;
        private Label labelPassword;
        private TextBox txtPassword;
        private Button buttonLogin;
    }
}