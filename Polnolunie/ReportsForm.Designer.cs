namespace Polnolunie
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRevenue;
        private System.Windows.Forms.TabPage tabPageRating;
        private System.Windows.Forms.DataGridView dataGridViewRevenue;
        private System.Windows.Forms.DataGridView dataGridViewRating;
        private System.Windows.Forms.Button buttonRevenue;
        private System.Windows.Forms.Button buttonRating;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRevenue = new System.Windows.Forms.TabPage();
            this.tabPageRating = new System.Windows.Forms.TabPage();
            this.dataGridViewRevenue = new System.Windows.Forms.DataGridView();
            this.dataGridViewRating = new System.Windows.Forms.DataGridView();
            this.buttonRevenue = new System.Windows.Forms.Button();
            this.buttonRating = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();

            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRating)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRevenue);
            this.tabControl1.Controls.Add(this.tabPageRating);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabControl1.Location = new System.Drawing.Point(50, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1800, 900);
            this.tabControl1.TabIndex = 0;

            // 
            // tabPageRevenue
            // 
            this.tabPageRevenue.Controls.Add(this.labelStart);
            this.tabPageRevenue.Controls.Add(this.labelEnd);
            this.tabPageRevenue.Controls.Add(this.dtpStart);
            this.tabPageRevenue.Controls.Add(this.dtpEnd);
            this.tabPageRevenue.Controls.Add(this.buttonRevenue);
            this.tabPageRevenue.Controls.Add(this.dataGridViewRevenue);
            this.tabPageRevenue.Location = new System.Drawing.Point(4, 30);
            this.tabPageRevenue.Name = "tabPageRevenue";
            this.tabPageRevenue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRevenue.Size = new System.Drawing.Size(1792, 866);
            this.tabPageRevenue.TabIndex = 0;
            this.tabPageRevenue.Text = "Выручка за период";
            this.tabPageRevenue.UseVisualStyleBackColor = true;

            // 
            // dataGridViewRevenue
            // 
            this.dataGridViewRevenue.AllowUserToAddRows = false;
            this.dataGridViewRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRevenue.Location = new System.Drawing.Point(20, 100);
            this.dataGridViewRevenue.Name = "dataGridViewRevenue";
            this.dataGridViewRevenue.ReadOnly = true;
            this.dataGridViewRevenue.Size = new System.Drawing.Size(1750, 700);

            // 
            // buttonRevenue
            // 
            this.buttonRevenue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonRevenue.Location = new System.Drawing.Point(600, 30);
            this.buttonRevenue.Name = "buttonRevenue";
            this.buttonRevenue.Size = new System.Drawing.Size(200, 40);
            this.buttonRevenue.Text = "Сформировать";
            this.buttonRevenue.UseVisualStyleBackColor = true;
            this.buttonRevenue.Click += new System.EventHandler(this.buttonRevenue_Click);

            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(150, 35);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(150, 29);

            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(400, 35);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(150, 29);

            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(20, 40);
            this.labelStart.Text = "С:";

            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(350, 40);
            this.labelEnd.Text = "По:";

            // 
            // tabPageRating
            // 
            this.tabPageRating.Controls.Add(this.buttonRating);
            this.tabPageRating.Controls.Add(this.dataGridViewRating);
            this.tabPageRating.Location = new System.Drawing.Point(4, 30);
            this.tabPageRating.Name = "tabPageRating";
            this.tabPageRating.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRating.Size = new System.Drawing.Size(1792, 866);
            this.tabPageRating.TabIndex = 1;
            this.tabPageRating.Text = "Рейтинг номеров";
            this.tabPageRating.UseVisualStyleBackColor = true;

            // 
            // dataGridViewRating
            // 
            this.dataGridViewRating.AllowUserToAddRows = false;
            this.dataGridViewRating.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRating.Location = new System.Drawing.Point(20, 100);
            this.dataGridViewRating.Name = "dataGridViewRating";
            this.dataGridViewRating.ReadOnly = true;
            this.dataGridViewRating.Size = new System.Drawing.Size(1750, 700);

            // 
            // buttonRating
            // 
            this.buttonRating.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonRating.Location = new System.Drawing.Point(20, 30);
            this.buttonRating.Name = "buttonRating";
            this.buttonRating.Size = new System.Drawing.Size(200, 40);
            this.buttonRating.Text = "Загрузить рейтинг";
            this.buttonRating.UseVisualStyleBackColor = true;
            this.buttonRating.Click += new System.EventHandler(this.buttonRating_Click);

            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчеты";

            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRating)).EndInit();
            this.ResumeLayout(false);
        }
    }
}