﻿namespace KordellGiffordCapstone
{
    partial class CustomerScreen
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.cName = new System.Windows.Forms.Label();
            this.cAddress = new System.Windows.Forms.Label();
            this.cCity = new System.Windows.Forms.Label();
            this.cCountry = new System.Windows.Forms.Label();
            this.cAddress2 = new System.Windows.Forms.Label();
            this.cPostal = new System.Windows.Forms.Label();
            this.cPhone = new System.Windows.Forms.Label();
            this.cNameResult = new System.Windows.Forms.Label();
            this.cAddressResult = new System.Windows.Forms.Label();
            this.cAddress2Result = new System.Windows.Forms.Label();
            this.cCityResult = new System.Windows.Forms.Label();
            this.cPostalResult = new System.Windows.Forms.Label();
            this.cCountryResult = new System.Windows.Forms.Label();
            this.cPhoneResult = new System.Windows.Forms.Label();
            this.customerList = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerList)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addBtn);
            this.flowLayoutPanel1.Controls.Add(this.modifyBtn);
            this.flowLayoutPanel1.Controls.Add(this.deleteBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(279, 53);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(77, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(86, 3);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(75, 23);
            this.modifyBtn.TabIndex = 1;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(167, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(531, 415);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // cName
            // 
            this.cName.AutoSize = true;
            this.cName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cName.Location = new System.Drawing.Point(361, 134);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(49, 17);
            this.cName.TabIndex = 3;
            this.cName.Text = "Name:";
            // 
            // cAddress
            // 
            this.cAddress.AutoSize = true;
            this.cAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAddress.Location = new System.Drawing.Point(361, 167);
            this.cAddress.Name = "cAddress";
            this.cAddress.Size = new System.Drawing.Size(64, 17);
            this.cAddress.TabIndex = 4;
            this.cAddress.Text = "Address:";
            // 
            // cCity
            // 
            this.cCity.AutoSize = true;
            this.cCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCity.Location = new System.Drawing.Point(361, 233);
            this.cCity.Name = "cCity";
            this.cCity.Size = new System.Drawing.Size(35, 17);
            this.cCity.TabIndex = 5;
            this.cCity.Text = "City:";
            // 
            // cCountry
            // 
            this.cCountry.AutoSize = true;
            this.cCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCountry.Location = new System.Drawing.Point(361, 299);
            this.cCountry.Name = "cCountry";
            this.cCountry.Size = new System.Drawing.Size(61, 17);
            this.cCountry.TabIndex = 6;
            this.cCountry.Text = "Country:";
            // 
            // cAddress2
            // 
            this.cAddress2.AutoSize = true;
            this.cAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAddress2.Location = new System.Drawing.Point(361, 201);
            this.cAddress2.Name = "cAddress2";
            this.cAddress2.Size = new System.Drawing.Size(76, 17);
            this.cAddress2.TabIndex = 7;
            this.cAddress2.Text = "Address 2:";
            // 
            // cPostal
            // 
            this.cPostal.AutoSize = true;
            this.cPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPostal.Location = new System.Drawing.Point(361, 267);
            this.cPostal.Name = "cPostal";
            this.cPostal.Size = new System.Drawing.Size(51, 17);
            this.cPostal.TabIndex = 8;
            this.cPostal.Text = "Postal:";
            // 
            // cPhone
            // 
            this.cPhone.AutoSize = true;
            this.cPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPhone.Location = new System.Drawing.Point(361, 334);
            this.cPhone.Name = "cPhone";
            this.cPhone.Size = new System.Drawing.Size(53, 17);
            this.cPhone.TabIndex = 9;
            this.cPhone.Text = "Phone:";
            // 
            // cNameResult
            // 
            this.cNameResult.AutoSize = true;
            this.cNameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNameResult.Location = new System.Drawing.Point(456, 134);
            this.cNameResult.Name = "cNameResult";
            this.cNameResult.Size = new System.Drawing.Size(0, 17);
            this.cNameResult.TabIndex = 10;
            // 
            // cAddressResult
            // 
            this.cAddressResult.AutoSize = true;
            this.cAddressResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAddressResult.Location = new System.Drawing.Point(456, 167);
            this.cAddressResult.Name = "cAddressResult";
            this.cAddressResult.Size = new System.Drawing.Size(0, 17);
            this.cAddressResult.TabIndex = 11;
            // 
            // cAddress2Result
            // 
            this.cAddress2Result.AutoSize = true;
            this.cAddress2Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAddress2Result.Location = new System.Drawing.Point(456, 201);
            this.cAddress2Result.Name = "cAddress2Result";
            this.cAddress2Result.Size = new System.Drawing.Size(0, 17);
            this.cAddress2Result.TabIndex = 12;
            // 
            // cCityResult
            // 
            this.cCityResult.AutoSize = true;
            this.cCityResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCityResult.Location = new System.Drawing.Point(456, 233);
            this.cCityResult.Name = "cCityResult";
            this.cCityResult.Size = new System.Drawing.Size(0, 17);
            this.cCityResult.TabIndex = 13;
            // 
            // cPostalResult
            // 
            this.cPostalResult.AutoSize = true;
            this.cPostalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPostalResult.Location = new System.Drawing.Point(456, 267);
            this.cPostalResult.Name = "cPostalResult";
            this.cPostalResult.Size = new System.Drawing.Size(0, 17);
            this.cPostalResult.TabIndex = 14;
            // 
            // cCountryResult
            // 
            this.cCountryResult.AutoSize = true;
            this.cCountryResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCountryResult.Location = new System.Drawing.Point(456, 299);
            this.cCountryResult.Name = "cCountryResult";
            this.cCountryResult.Size = new System.Drawing.Size(0, 17);
            this.cCountryResult.TabIndex = 15;
            // 
            // cPhoneResult
            // 
            this.cPhoneResult.AutoSize = true;
            this.cPhoneResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPhoneResult.Location = new System.Drawing.Point(456, 334);
            this.cPhoneResult.Name = "cPhoneResult";
            this.cPhoneResult.Size = new System.Drawing.Size(0, 17);
            this.cPhoneResult.TabIndex = 16;
            // 
            // customerList
            // 
            this.customerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerList.Location = new System.Drawing.Point(12, 73);
            this.customerList.Name = "customerList";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.customerList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.customerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerList.Size = new System.Drawing.Size(279, 354);
            this.customerList.TabIndex = 17;
            this.customerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerList_CellContentClick);
            this.customerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerList_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.customerList);
            this.Controls.Add(this.cPhoneResult);
            this.Controls.Add(this.cCountryResult);
            this.Controls.Add(this.cPostalResult);
            this.Controls.Add(this.cCityResult);
            this.Controls.Add(this.cAddress2Result);
            this.Controls.Add(this.cAddressResult);
            this.Controls.Add(this.cNameResult);
            this.Controls.Add(this.cPhone);
            this.Controls.Add(this.cPostal);
            this.Controls.Add(this.cAddress2);
            this.Controls.Add(this.cCountry);
            this.Controls.Add(this.cCity);
            this.Controls.Add(this.cAddress);
            this.Controls.Add(this.cName);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CustomerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerScreen_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label cName;
        private System.Windows.Forms.Label cAddress;
        private System.Windows.Forms.Label cCity;
        private System.Windows.Forms.Label cCountry;
        private System.Windows.Forms.Label cAddress2;
        private System.Windows.Forms.Label cPostal;
        private System.Windows.Forms.Label cPhone;
        private System.Windows.Forms.Label cNameResult;
        private System.Windows.Forms.Label cAddressResult;
        private System.Windows.Forms.Label cAddress2Result;
        private System.Windows.Forms.Label cCityResult;
        private System.Windows.Forms.Label cPostalResult;
        private System.Windows.Forms.Label cCountryResult;
        private System.Windows.Forms.Label cPhoneResult;
        private System.Windows.Forms.DataGridView customerList;
        private System.Windows.Forms.Timer timer1;
    }
}