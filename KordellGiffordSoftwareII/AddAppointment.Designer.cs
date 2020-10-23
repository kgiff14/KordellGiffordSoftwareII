namespace KordellGiffordSoftwareII
{
    partial class AddAppointment
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
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.titleIn = new System.Windows.Forms.TextBox();
            this.locationIn = new System.Windows.Forms.TextBox();
            this.typeIn = new System.Windows.Forms.TextBox();
            this.urlIn = new System.Windows.Forms.TextBox();
            this.descriptionIn = new System.Windows.Forms.TextBox();
            this.customerIn = new System.Windows.Forms.ComboBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startHour = new System.Windows.Forms.TextBox();
            this.endHour = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(51, 105);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(42, 17);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "Start:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(440, 105);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(37, 17);
            this.endLabel.TabIndex = 1;
            this.endLabel.Text = "End:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(51, 268);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(72, 17);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "Customer:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(51, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 17);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(51, 227);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(51, 147);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(66, 17);
            this.locationLabel.TabIndex = 5;
            this.locationLabel.Text = "Location:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(51, 187);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(44, 17);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "Type:";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(51, 315);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(30, 17);
            this.urlLabel.TabIndex = 7;
            this.urlLabel.Text = "Url:";
            // 
            // titleIn
            // 
            this.titleIn.Location = new System.Drawing.Point(141, 44);
            this.titleIn.Name = "titleIn";
            this.titleIn.Size = new System.Drawing.Size(137, 20);
            this.titleIn.TabIndex = 8;
            // 
            // locationIn
            // 
            this.locationIn.Location = new System.Drawing.Point(141, 147);
            this.locationIn.Name = "locationIn";
            this.locationIn.Size = new System.Drawing.Size(130, 20);
            this.locationIn.TabIndex = 9;
            // 
            // typeIn
            // 
            this.typeIn.Location = new System.Drawing.Point(141, 187);
            this.typeIn.Name = "typeIn";
            this.typeIn.Size = new System.Drawing.Size(130, 20);
            this.typeIn.TabIndex = 10;
            // 
            // urlIn
            // 
            this.urlIn.Location = new System.Drawing.Point(141, 315);
            this.urlIn.Name = "urlIn";
            this.urlIn.Size = new System.Drawing.Size(231, 20);
            this.urlIn.TabIndex = 11;
            // 
            // descriptionIn
            // 
            this.descriptionIn.Location = new System.Drawing.Point(141, 227);
            this.descriptionIn.Name = "descriptionIn";
            this.descriptionIn.Size = new System.Drawing.Size(231, 20);
            this.descriptionIn.TabIndex = 12;
            // 
            // customerIn
            // 
            this.customerIn.FormattingEnabled = true;
            this.customerIn.Location = new System.Drawing.Point(141, 268);
            this.customerIn.Name = "customerIn";
            this.customerIn.Size = new System.Drawing.Size(161, 21);
            this.customerIn.TabIndex = 13;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(141, 102);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 14;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(483, 102);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 15;
            // 
            // startHour
            // 
            this.startHour.Location = new System.Drawing.Point(348, 102);
            this.startHour.Name = "startHour";
            this.startHour.Size = new System.Drawing.Size(86, 20);
            this.startHour.TabIndex = 16;
            // 
            // endHour
            // 
            this.endHour.Location = new System.Drawing.Point(689, 102);
            this.endHour.Name = "endHour";
            this.endHour.Size = new System.Drawing.Size(86, 20);
            this.endHour.TabIndex = 17;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(713, 361);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(632, 361);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.endHour);
            this.Controls.Add(this.startHour);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.customerIn);
            this.Controls.Add(this.descriptionIn);
            this.Controls.Add(this.urlIn);
            this.Controls.Add(this.typeIn);
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
            this.Name = "AddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox titleIn;
        private System.Windows.Forms.TextBox locationIn;
        private System.Windows.Forms.TextBox typeIn;
        private System.Windows.Forms.TextBox urlIn;
        private System.Windows.Forms.TextBox descriptionIn;
        private System.Windows.Forms.ComboBox customerIn;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.TextBox startHour;
        private System.Windows.Forms.TextBox endHour;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}