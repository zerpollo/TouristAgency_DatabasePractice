﻿namespace TouristAgency_DatabasePractice.UserControls
{
    partial class RestaurantControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.CloseTimeLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.OpenTimeLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.DescriptionTextBox);
            this.panel2.Controls.Add(this.CloseTimeLabel);
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Controls.Add(this.OpenTimeLabel);
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.PhoneNumberLabel);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.LocationLabel);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Location = new System.Drawing.Point(5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 296);
            this.panel2.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(193, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 30);
            this.label13.TabIndex = 43;
            this.label13.Text = "-";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.Tan;
            this.DescriptionTextBox.Location = new System.Drawing.Point(11, 138);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(484, 80);
            this.DescriptionTextBox.TabIndex = 40;
            // 
            // CloseTimeLabel
            // 
            this.CloseTimeLabel.AutoSize = true;
            this.CloseTimeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseTimeLabel.Location = new System.Drawing.Point(218, 91);
            this.CloseTimeLabel.Name = "CloseTimeLabel";
            this.CloseTimeLabel.Size = new System.Drawing.Size(27, 15);
            this.CloseTimeLabel.TabIndex = 42;
            this.CloseTimeLabel.Text = "null";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(387, 17);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(108, 108);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 25;
            this.pictureBox.TabStop = false;
            // 
            // OpenTimeLabel
            // 
            this.OpenTimeLabel.AutoSize = true;
            this.OpenTimeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OpenTimeLabel.Location = new System.Drawing.Point(141, 91);
            this.OpenTimeLabel.Name = "OpenTimeLabel";
            this.OpenTimeLabel.Size = new System.Drawing.Size(27, 15);
            this.OpenTimeLabel.TabIndex = 41;
            this.OpenTimeLabel.Text = "null";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddButton.Location = new System.Drawing.Point(209, 224);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 39);
            this.AddButton.TabIndex = 33;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(26, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 15);
            this.label17.TabIndex = 40;
            this.label17.Text = "Open - Close time:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(118, 65);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(27, 15);
            this.PhoneNumberLabel.TabIndex = 32;
            this.PhoneNumberLabel.Text = "null";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(26, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 15);
            this.label20.TabIndex = 31;
            this.label20.Text = "Phone number:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LocationLabel.Location = new System.Drawing.Point(118, 41);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(27, 15);
            this.LocationLabel.TabIndex = 30;
            this.LocationLabel.Text = "null";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(59, 41);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 15);
            this.label22.TabIndex = 29;
            this.label22.Text = "Location:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameLabel.Location = new System.Drawing.Point(118, 17);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(27, 15);
            this.NameLabel.TabIndex = 28;
            this.NameLabel.Text = "null";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Location = new System.Drawing.Point(73, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 15);
            this.label24.TabIndex = 27;
            this.label24.Text = "Name:";
            // 
            // RestaurantControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(240)))), ((int)(((byte)(196)))));
            this.Controls.Add(this.panel2);
            this.Name = "RestaurantControl";
            this.Size = new System.Drawing.Size(516, 308);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox;
        private Button AddButton;
        private Label PhoneNumberLabel;
        private Label label20;
        private Label LocationLabel;
        private Label label22;
        private Label NameLabel;
        private Label label24;
        private TextBox DescriptionTextBox;
        private Label label13;
        private Label CloseTimeLabel;
        private Label OpenTimeLabel;
        private Label label17;
    }
}
