namespace TouristAgency_DatabasePractice
{
    partial class UserInfoWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.FNTextBox = new System.Windows.Forms.TextBox();
            this.LNTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // FNTextBox
            // 
            this.FNTextBox.Location = new System.Drawing.Point(113, 122);
            this.FNTextBox.Name = "FNTextBox";
            this.FNTextBox.Size = new System.Drawing.Size(188, 23);
            this.FNTextBox.TabIndex = 1;
            // 
            // LNTextBox
            // 
            this.LNTextBox.Location = new System.Drawing.Point(113, 151);
            this.LNTextBox.Name = "LNTextBox";
            this.LNTextBox.Size = new System.Drawing.Size(188, 23);
            this.LNTextBox.TabIndex = 2;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(113, 180);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(188, 23);
            this.AddressTextBox.TabIndex = 3;
            // 
            // PhoneNTextBox
            // 
            this.PhoneNTextBox.Location = new System.Drawing.Point(113, 238);
            this.PhoneNTextBox.Name = "PhoneNTextBox";
            this.PhoneNTextBox.Size = new System.Drawing.Size(188, 23);
            this.PhoneNTextBox.TabIndex = 4;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(113, 209);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(188, 23);
            this.CountryTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Country:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Please enter your info";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(113, 291);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(150, 49);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // UserInfoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 354);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.PhoneNTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.LNTextBox);
            this.Controls.Add(this.FNTextBox);
            this.Controls.Add(this.label1);
            this.Name = "UserInfoWindow";
            this.Text = "UserInfoWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox FNTextBox;
        private TextBox LNTextBox;
        private TextBox AddressTextBox;
        private TextBox PhoneNTextBox;
        private TextBox CountryTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button SubmitButton;
    }
}