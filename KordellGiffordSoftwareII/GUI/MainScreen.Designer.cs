﻿namespace KordellGiffordCapstone
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.appointmentsTable = new System.Windows.Forms.DataGridView();
            this.appointmentsLabel = new System.Windows.Forms.Label();
            this.addAppBtn = new System.Windows.Forms.Button();
            this.updateAptBtn = new System.Windows.Forms.Button();
            this.deleteAptBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.weekCal = new System.Windows.Forms.DataGridView();
            this.weekLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.customerRecords = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.searchCustomer = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekCal)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentsTable
            // 
            this.appointmentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsTable.Location = new System.Drawing.Point(831, 92);
            this.appointmentsTable.Name = "appointmentsTable";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.appointmentsTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.appointmentsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentsTable.Size = new System.Drawing.Size(454, 476);
            this.appointmentsTable.TabIndex = 0;
            this.appointmentsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentsTable_CellContentClick);
            this.appointmentsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentsTable_CellContentClick);
            // 
            // appointmentsLabel
            // 
            this.appointmentsLabel.AutoSize = true;
            this.appointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsLabel.Location = new System.Drawing.Point(828, 63);
            this.appointmentsLabel.Name = "appointmentsLabel";
            this.appointmentsLabel.Size = new System.Drawing.Size(94, 15);
            this.appointmentsLabel.TabIndex = 1;
            this.appointmentsLabel.Text = "Appointments";
            // 
            // addAppBtn
            // 
            this.addAppBtn.Location = new System.Drawing.Point(1044, 63);
            this.addAppBtn.Name = "addAppBtn";
            this.addAppBtn.Size = new System.Drawing.Size(77, 23);
            this.addAppBtn.TabIndex = 2;
            this.addAppBtn.Text = "Add Apt.";
            this.addAppBtn.UseVisualStyleBackColor = true;
            this.addAppBtn.Click += new System.EventHandler(this.addAppBtn_Click);
            // 
            // updateAptBtn
            // 
            this.updateAptBtn.Location = new System.Drawing.Point(1127, 63);
            this.updateAptBtn.Name = "updateAptBtn";
            this.updateAptBtn.Size = new System.Drawing.Size(75, 23);
            this.updateAptBtn.TabIndex = 3;
            this.updateAptBtn.Text = "Update Apt.";
            this.updateAptBtn.UseVisualStyleBackColor = true;
            this.updateAptBtn.Click += new System.EventHandler(this.updateAptBtn_Click);
            // 
            // deleteAptBtn
            // 
            this.deleteAptBtn.Location = new System.Drawing.Point(1208, 63);
            this.deleteAptBtn.Name = "deleteAptBtn";
            this.deleteAptBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteAptBtn.TabIndex = 4;
            this.deleteAptBtn.Text = "Delete Apt.";
            this.deleteAptBtn.UseVisualStyleBackColor = true;
            this.deleteAptBtn.Click += new System.EventHandler(this.deleteAptBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1220, 959);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // calendar
            // 
            this.calendar.AllowUserToAddRows = false;
            this.calendar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.calendar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.calendar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calendar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.calendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendar.GridColor = System.Drawing.SystemColors.Highlight;
            this.calendar.Location = new System.Drawing.Point(13, 92);
            this.calendar.MultiSelect = false;
            this.calendar.Name = "calendar";
            this.calendar.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.calendar.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.calendar.RowTemplate.Height = 85;
            this.calendar.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.calendar.Size = new System.Drawing.Size(771, 476);
            this.calendar.TabIndex = 6;
            this.calendar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calendar_CellContentClick);
            this.calendar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calendar_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(219, 66);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(66, 24);
            this.monthLabel.TabIndex = 8;
            this.monthLabel.Text = "label1";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(273, 66);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(66, 24);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "label1";
            // 
            // weekCal
            // 
            this.weekCal.AllowUserToAddRows = false;
            this.weekCal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.weekCal.BackgroundColor = System.Drawing.Color.White;
            this.weekCal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.weekCal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weekCal.Location = new System.Drawing.Point(13, 614);
            this.weekCal.MultiSelect = false;
            this.weekCal.Name = "weekCal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.weekCal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.weekCal.RowTemplate.Height = 300;
            this.weekCal.Size = new System.Drawing.Size(1272, 328);
            this.weekCal.TabIndex = 11;
            this.weekCal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.weekCal_CellContentClick);
            this.weekCal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.weekCal_CellContentClick);
            // 
            // weekLabel
            // 
            this.weekLabel.AutoSize = true;
            this.weekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekLabel.Location = new System.Drawing.Point(12, 587);
            this.weekLabel.Name = "weekLabel";
            this.weekLabel.Size = new System.Drawing.Size(106, 24);
            this.weekLabel.TabIndex = 12;
            this.weekLabel.Text = "Week View";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.customerRecords);
            this.flowLayoutPanel1.Controls.Add(this.reportsBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(772, 48);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // customerRecords
            // 
            this.customerRecords.Location = new System.Drawing.Point(3, 3);
            this.customerRecords.Name = "customerRecords";
            this.customerRecords.Size = new System.Drawing.Size(75, 23);
            this.customerRecords.TabIndex = 0;
            this.customerRecords.Text = "Customers";
            this.customerRecords.UseVisualStyleBackColor = true;
            this.customerRecords.Click += new System.EventHandler(this.customerRecords_Click);
            // 
            // reportsBtn
            // 
            this.reportsBtn.Location = new System.Drawing.Point(84, 3);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(75, 23);
            this.reportsBtn.TabIndex = 1;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.UseVisualStyleBackColor = true;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // searchCustomer
            // 
            this.searchCustomer.FormattingEnabled = true;
            this.searchCustomer.Location = new System.Drawing.Point(1044, 36);
            this.searchCustomer.Name = "searchCustomer";
            this.searchCustomer.Size = new System.Drawing.Size(158, 21);
            this.searchCustomer.TabIndex = 14;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(1208, 34);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 15;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1296, 994);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchCustomer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.weekLabel);
            this.Controls.Add(this.weekCal);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteAptBtn);
            this.Controls.Add(this.updateAptBtn);
            this.Controls.Add(this.addAppBtn);
            this.Controls.Add(this.appointmentsLabel);
            this.Controls.Add(this.appointmentsTable);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekCal)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView appointmentsTable;
        private System.Windows.Forms.Label appointmentsLabel;
        private System.Windows.Forms.Button addAppBtn;
        private System.Windows.Forms.Button updateAptBtn;
        private System.Windows.Forms.Button deleteAptBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridView calendar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.DataGridView weekCal;
        private System.Windows.Forms.Label weekLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button customerRecords;
        private System.Windows.Forms.Button reportsBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox searchCustomer;
        private System.Windows.Forms.Button searchBtn;
    }
}