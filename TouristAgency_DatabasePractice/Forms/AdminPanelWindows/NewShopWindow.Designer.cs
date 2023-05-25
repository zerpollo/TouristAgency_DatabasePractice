namespace TouristAgency_DatabasePractice.Forms.AdminPanelWindows
{
    partial class NewShopWindow
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
            this.Namelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.OpenTimeComboBox = new System.Windows.Forms.ComboBox();
            this.CloseTimeComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(42, 36);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(39, 15);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Open time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Close time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Description";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(87, 33);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(183, 23);
            this.NameTextBox.TabIndex = 11;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(87, 83);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(183, 23);
            this.LocationTextBox.TabIndex = 12;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(87, 257);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(183, 103);
            this.DescriptionTextBox.TabIndex = 14;
            // 
            // OpenTimeComboBox
            // 
            this.OpenTimeComboBox.FormattingEnabled = true;
            this.OpenTimeComboBox.Location = new System.Drawing.Point(87, 134);
            this.OpenTimeComboBox.Name = "OpenTimeComboBox";
            this.OpenTimeComboBox.Size = new System.Drawing.Size(183, 23);
            this.OpenTimeComboBox.TabIndex = 15;
            // 
            // CloseTimeComboBox
            // 
            this.CloseTimeComboBox.FormattingEnabled = true;
            this.CloseTimeComboBox.Location = new System.Drawing.Point(87, 195);
            this.CloseTimeComboBox.Name = "CloseTimeComboBox";
            this.CloseTimeComboBox.Size = new System.Drawing.Size(183, 23);
            this.CloseTimeComboBox.TabIndex = 16;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(87, 375);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(183, 23);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NewShopWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 420);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CloseTimeComboBox);
            this.Controls.Add(this.OpenTimeComboBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Namelabel);
            this.Name = "NewShopWindow";
            this.Text = "NewShopWindow";
            this.Load += new System.EventHandler(this.NewShopWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Namelabel;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox NameTextBox;
        private TextBox LocationTextBox;
        private TextBox DescriptionTextBox;
        private ComboBox OpenTimeComboBox;
        private ComboBox CloseTimeComboBox;
        private Button AddButton;
    }
}