namespace TouristAgency_DatabasePractice.Forms.AdminPanelWindows
{
    partial class NewActivityWindow
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
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.pricvelabe = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(109, 173);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(183, 23);
            this.PriceTextBox.TabIndex = 60;
            // 
            // pricvelabe
            // 
            this.pricvelabe.AutoSize = true;
            this.pricvelabe.Location = new System.Drawing.Point(64, 176);
            this.pricvelabe.Name = "pricvelabe";
            this.pricvelabe.Size = new System.Drawing.Size(33, 15);
            this.pricvelabe.TabIndex = 59;
            this.pricvelabe.Text = "Price";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(109, 119);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(183, 23);
            this.DurationTextBox.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "Duration (hours)";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(109, 344);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(183, 23);
            this.AddButton.TabIndex = 56;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(109, 226);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(183, 103);
            this.DescriptionTextBox.TabIndex = 53;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(109, 64);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(183, 23);
            this.LocationTextBox.TabIndex = 52;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(109, 14);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(183, 23);
            this.NameTextBox.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 50;
            this.label6.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Location";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(64, 17);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(39, 15);
            this.Namelabel.TabIndex = 46;
            this.Namelabel.Text = "Name";
            // 
            // NewActivityWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 412);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.pricvelabe);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Namelabel);
            this.Name = "NewActivityWindow";
            this.Text = "NewActivityWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PriceTextBox;
        private Label pricvelabe;
        private TextBox DurationTextBox;
        private Label label1;
        private Button AddButton;
        private TextBox DescriptionTextBox;
        private TextBox LocationTextBox;
        private TextBox NameTextBox;
        private Label label6;
        private Label label2;
        private Label Namelabel;
    }
}