namespace KordellGiffordCapstone
{
    partial class ModifyAppointment
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.descriptionIn = new System.Windows.Forms.TextBox();
            this.urlIn = new System.Windows.Forms.TextBox();
            this.locationIn = new System.Windows.Forms.TextBox();
            this.titleIn = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.typeIn = new System.Windows.Forms.ComboBox();
            this.customerIn = new System.Windows.Forms.ComboBox();
            this.contactIn = new System.Windows.Forms.TextBox();
            this.contactLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(622, 357);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 39;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(703, 357);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 38;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(471, 101);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 35;
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(129, 101);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 34;
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // descriptionIn
            // 
            this.descriptionIn.BackColor = System.Drawing.Color.White;
            this.descriptionIn.Location = new System.Drawing.Point(129, 226);
            this.descriptionIn.Name = "descriptionIn";
            this.descriptionIn.Size = new System.Drawing.Size(231, 20);
            this.descriptionIn.TabIndex = 32;
            this.descriptionIn.TextChanged += new System.EventHandler(this.descriptionIn_TextChanged);
            // 
            // urlIn
            // 
            this.urlIn.BackColor = System.Drawing.Color.White;
            this.urlIn.Location = new System.Drawing.Point(129, 339);
            this.urlIn.Name = "urlIn";
            this.urlIn.Size = new System.Drawing.Size(231, 20);
            this.urlIn.TabIndex = 31;
            this.urlIn.TextChanged += new System.EventHandler(this.urlIn_TextChanged);
            // 
            // locationIn
            // 
            this.locationIn.BackColor = System.Drawing.Color.White;
            this.locationIn.Location = new System.Drawing.Point(129, 146);
            this.locationIn.Name = "locationIn";
            this.locationIn.Size = new System.Drawing.Size(130, 20);
            this.locationIn.TabIndex = 29;
            this.locationIn.TextChanged += new System.EventHandler(this.locationIn_TextChanged);
            // 
            // titleIn
            // 
            this.titleIn.BackColor = System.Drawing.Color.White;
            this.titleIn.Location = new System.Drawing.Point(129, 43);
            this.titleIn.Name = "titleIn";
            this.titleIn.Size = new System.Drawing.Size(137, 20);
            this.titleIn.TabIndex = 28;
            this.titleIn.TextChanged += new System.EventHandler(this.titleIn_TextChanged);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(39, 339);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(30, 17);
            this.urlLabel.TabIndex = 27;
            this.urlLabel.Text = "Url:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(39, 186);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(44, 17);
            this.typeLabel.TabIndex = 26;
            this.typeLabel.Text = "Type:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(39, 146);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(66, 17);
            this.locationLabel.TabIndex = 25;
            this.locationLabel.Text = "Location:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(39, 226);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 24;
            this.descriptionLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(39, 43);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 17);
            this.titleLabel.TabIndex = 23;
            this.titleLabel.Text = "Title:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(39, 267);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(72, 17);
            this.customerLabel.TabIndex = 22;
            this.customerLabel.Text = "Customer:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(428, 104);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(37, 17);
            this.endLabel.TabIndex = 21;
            this.endLabel.Text = "End:";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(39, 104);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(42, 17);
            this.startLabel.TabIndex = 20;
            this.startLabel.Text = "Start:";
            // 
            // startTime
            // 
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.Location = new System.Drawing.Point(335, 101);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(86, 20);
            this.startTime.TabIndex = 40;
            this.startTime.ValueChanged += new System.EventHandler(this.startTime_ValueChanged);
            // 
            // endTime
            // 
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTime.Location = new System.Drawing.Point(677, 101);
            this.endTime.Name = "endTime";
            this.endTime.ShowUpDown = true;
            this.endTime.Size = new System.Drawing.Size(86, 20);
            this.endTime.TabIndex = 41;
            this.endTime.ValueChanged += new System.EventHandler(this.endTime_ValueChanged);
            // 
            // typeIn
            // 
            this.typeIn.BackColor = System.Drawing.Color.White;
            this.typeIn.FormattingEnabled = true;
            this.typeIn.Location = new System.Drawing.Point(129, 186);
            this.typeIn.Name = "typeIn";
            this.typeIn.Size = new System.Drawing.Size(117, 21);
            this.typeIn.TabIndex = 42;
            this.typeIn.SelectedIndexChanged += new System.EventHandler(this.typeIn_SelectedIndexChanged);
            // 
            // customerIn
            // 
            this.customerIn.BackColor = System.Drawing.Color.White;
            this.customerIn.FormattingEnabled = true;
            this.customerIn.Location = new System.Drawing.Point(129, 267);
            this.customerIn.Name = "customerIn";
            this.customerIn.Size = new System.Drawing.Size(161, 21);
            this.customerIn.TabIndex = 43;
            this.customerIn.SelectedIndexChanged += new System.EventHandler(this.customerIn_SelectedIndexChanged);
            // 
            // contactIn
            // 
            this.contactIn.BackColor = System.Drawing.Color.White;
            this.contactIn.Location = new System.Drawing.Point(129, 304);
            this.contactIn.Name = "contactIn";
            this.contactIn.Size = new System.Drawing.Size(161, 20);
            this.contactIn.TabIndex = 45;
            this.contactIn.TextChanged += new System.EventHandler(this.contactIn_TextChanged);
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(39, 304);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(60, 17);
            this.contactLabel.TabIndex = 44;
            this.contactLabel.Text = "Contact:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ModifyAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 392);
            this.Controls.Add(this.contactIn);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.customerIn);
            this.Controls.Add(this.typeIn);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.descriptionIn);
            this.Controls.Add(this.urlIn);
            this.Controls.Add(this.locationIn);
            this.Controls.Add(this.titleIn);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Name = "ModifyAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Appointment";
            this.Load += new System.EventHandler(this.ModifyAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.TextBox descriptionIn;
        private System.Windows.Forms.TextBox urlIn;
        private System.Windows.Forms.TextBox locationIn;
        private System.Windows.Forms.TextBox titleIn;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.ComboBox typeIn;
        private System.Windows.Forms.ComboBox customerIn;
        private System.Windows.Forms.TextBox contactIn;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Timer timer1;
    }
}