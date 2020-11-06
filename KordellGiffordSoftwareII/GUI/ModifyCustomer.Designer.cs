namespace KordellGiffordCapstone
{
    partial class ModifyCustomer
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
            this.phoneIn = new System.Windows.Forms.TextBox();
            this.postalIn = new System.Windows.Forms.TextBox();
            this.address2In = new System.Windows.Forms.TextBox();
            this.addressIn = new System.Windows.Forms.TextBox();
            this.nameIn = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.canceBtn = new System.Windows.Forms.Button();
            this.cPhone = new System.Windows.Forms.Label();
            this.cPostal = new System.Windows.Forms.Label();
            this.cAddress2 = new System.Windows.Forms.Label();
            this.cCountry = new System.Windows.Forms.Label();
            this.cCity = new System.Windows.Forms.Label();
            this.cAddress = new System.Windows.Forms.Label();
            this.cName = new System.Windows.Forms.Label();
            this.cityIn = new System.Windows.Forms.ComboBox();
            this.countryIn = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.phoneFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phoneIn
            // 
            this.phoneIn.Location = new System.Drawing.Point(152, 278);
            this.phoneIn.Name = "phoneIn";
            this.phoneIn.Size = new System.Drawing.Size(123, 20);
            this.phoneIn.TabIndex = 41;
            this.phoneIn.TextChanged += new System.EventHandler(this.phoneIn_TextChanged);
            // 
            // postalIn
            // 
            this.postalIn.Location = new System.Drawing.Point(152, 211);
            this.postalIn.Name = "postalIn";
            this.postalIn.Size = new System.Drawing.Size(123, 20);
            this.postalIn.TabIndex = 39;
            this.postalIn.TextChanged += new System.EventHandler(this.postalIn_TextChanged);
            // 
            // address2In
            // 
            this.address2In.Location = new System.Drawing.Point(152, 145);
            this.address2In.Name = "address2In";
            this.address2In.Size = new System.Drawing.Size(123, 20);
            this.address2In.TabIndex = 37;
            this.address2In.TextChanged += new System.EventHandler(this.address2In_TextChanged);
            // 
            // addressIn
            // 
            this.addressIn.Location = new System.Drawing.Point(152, 111);
            this.addressIn.Name = "addressIn";
            this.addressIn.Size = new System.Drawing.Size(123, 20);
            this.addressIn.TabIndex = 36;
            this.addressIn.TextChanged += new System.EventHandler(this.addressIn_TextChanged);
            // 
            // nameIn
            // 
            this.nameIn.Location = new System.Drawing.Point(152, 78);
            this.nameIn.Name = "nameIn";
            this.nameIn.Size = new System.Drawing.Size(123, 20);
            this.nameIn.TabIndex = 35;
            this.nameIn.TextChanged += new System.EventHandler(this.nameIn_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(163, 365);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 34;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // canceBtn
            // 
            this.canceBtn.Location = new System.Drawing.Point(244, 365);
            this.canceBtn.Name = "canceBtn";
            this.canceBtn.Size = new System.Drawing.Size(75, 23);
            this.canceBtn.TabIndex = 33;
            this.canceBtn.Text = "Cancel";
            this.canceBtn.UseVisualStyleBackColor = true;
            this.canceBtn.Click += new System.EventHandler(this.canceBtn_Click);
            // 
            // cPhone
            // 
            this.cPhone.AutoSize = true;
            this.cPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPhone.Location = new System.Drawing.Point(50, 278);
            this.cPhone.Name = "cPhone";
            this.cPhone.Size = new System.Drawing.Size(53, 17);
            this.cPhone.TabIndex = 32;
            this.cPhone.Text = "Phone:";
            // 
            // cPostal
            // 
            this.cPostal.AutoSize = true;
            this.cPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPostal.Location = new System.Drawing.Point(50, 211);
            this.cPostal.Name = "cPostal";
            this.cPostal.Size = new System.Drawing.Size(51, 17);
            this.cPostal.TabIndex = 31;
            this.cPostal.Text = "Postal:";
            // 
            // cAddress2
            // 
            this.cAddress2.AutoSize = true;
            this.cAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAddress2.Location = new System.Drawing.Point(50, 145);
            this.cAddress2.Name = "cAddress2";
            this.cAddress2.Size = new System.Drawing.Size(76, 17);
            this.cAddress2.TabIndex = 30;
            this.cAddress2.Text = "Address 2:";
            // 
            // cCountry
            // 
            this.cCountry.AutoSize = true;
            this.cCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCountry.Location = new System.Drawing.Point(50, 243);
            this.cCountry.Name = "cCountry";
            this.cCountry.Size = new System.Drawing.Size(61, 17);
            this.cCountry.TabIndex = 29;
            this.cCountry.Text = "Country:";
            // 
            // cCity
            // 
            this.cCity.AutoSize = true;
            this.cCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCity.Location = new System.Drawing.Point(50, 177);
            this.cCity.Name = "cCity";
            this.cCity.Size = new System.Drawing.Size(35, 17);
            this.cCity.TabIndex = 28;
            this.cCity.Text = "City:";
            // 
            // cAddress
            // 
            this.cAddress.AutoSize = true;
            this.cAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAddress.Location = new System.Drawing.Point(50, 111);
            this.cAddress.Name = "cAddress";
            this.cAddress.Size = new System.Drawing.Size(64, 17);
            this.cAddress.TabIndex = 27;
            this.cAddress.Text = "Address:";
            // 
            // cName
            // 
            this.cName.AutoSize = true;
            this.cName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cName.Location = new System.Drawing.Point(50, 78);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(49, 17);
            this.cName.TabIndex = 26;
            this.cName.Text = "Name:";
            // 
            // cityIn
            // 
            this.cityIn.FormattingEnabled = true;
            this.cityIn.Location = new System.Drawing.Point(152, 177);
            this.cityIn.Name = "cityIn";
            this.cityIn.Size = new System.Drawing.Size(121, 21);
            this.cityIn.TabIndex = 42;
            this.cityIn.SelectedIndexChanged += new System.EventHandler(this.cityIn_SelectedIndexChanged);
            this.cityIn.TextChanged += new System.EventHandler(this.cityIn_SelectedIndexChanged);
            // 
            // countryIn
            // 
            this.countryIn.FormattingEnabled = true;
            this.countryIn.Location = new System.Drawing.Point(152, 243);
            this.countryIn.Name = "countryIn";
            this.countryIn.Size = new System.Drawing.Size(121, 21);
            this.countryIn.TabIndex = 43;
            this.countryIn.SelectedIndexChanged += new System.EventHandler(this.countryIn_SelectedIndexChanged);
            this.countryIn.TextChanged += new System.EventHandler(this.countryIn_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // phoneFormat
            // 
            this.phoneFormat.AutoSize = true;
            this.phoneFormat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.phoneFormat.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.phoneFormat.Location = new System.Drawing.Point(149, 301);
            this.phoneFormat.Name = "phoneFormat";
            this.phoneFormat.Size = new System.Drawing.Size(121, 13);
            this.phoneFormat.TabIndex = 44;
            this.phoneFormat.Text = "Format: ###-###-####";
            this.phoneFormat.Visible = false;
            // 
            // ModifyCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(332, 397);
            this.Controls.Add(this.phoneFormat);
            this.Controls.Add(this.countryIn);
            this.Controls.Add(this.cityIn);
            this.Controls.Add(this.phoneIn);
            this.Controls.Add(this.postalIn);
            this.Controls.Add(this.address2In);
            this.Controls.Add(this.addressIn);
            this.Controls.Add(this.nameIn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.canceBtn);
            this.Controls.Add(this.cPhone);
            this.Controls.Add(this.cPostal);
            this.Controls.Add(this.cAddress2);
            this.Controls.Add(this.cCountry);
            this.Controls.Add(this.cCity);
            this.Controls.Add(this.cAddress);
            this.Controls.Add(this.cName);
            this.Name = "ModifyCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Customer";
            this.Load += new System.EventHandler(this.ModifyCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox phoneIn;
        private System.Windows.Forms.TextBox postalIn;
        private System.Windows.Forms.TextBox address2In;
        private System.Windows.Forms.TextBox addressIn;
        private System.Windows.Forms.TextBox nameIn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button canceBtn;
        private System.Windows.Forms.Label cPhone;
        private System.Windows.Forms.Label cPostal;
        private System.Windows.Forms.Label cAddress2;
        private System.Windows.Forms.Label cCountry;
        private System.Windows.Forms.Label cCity;
        private System.Windows.Forms.Label cAddress;
        private System.Windows.Forms.Label cName;
        private System.Windows.Forms.ComboBox cityIn;
        private System.Windows.Forms.ComboBox countryIn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label phoneFormat;
    }
}