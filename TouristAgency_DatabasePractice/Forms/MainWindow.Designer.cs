namespace TouristAgency_DatabasePractice.Forms
{
    partial class MainWindow
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
            this.TabFrame = new System.Windows.Forms.TabControl();
            this.Shops = new System.Windows.Forms.TabPage();
            this.Museums = new System.Windows.Forms.TabPage();
            this.Restaraunts = new System.Windows.Forms.TabPage();
            this.Activities = new System.Windows.Forms.TabPage();
            this.ToTourButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TabFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabFrame
            // 
            this.TabFrame.Controls.Add(this.Shops);
            this.TabFrame.Controls.Add(this.Museums);
            this.TabFrame.Controls.Add(this.Restaraunts);
            this.TabFrame.Controls.Add(this.Activities);
            this.TabFrame.Location = new System.Drawing.Point(12, 12);
            this.TabFrame.Name = "TabFrame";
            this.TabFrame.SelectedIndex = 0;
            this.TabFrame.Size = new System.Drawing.Size(1316, 767);
            this.TabFrame.TabIndex = 0;
            // 
            // Shops
            // 
            this.Shops.Location = new System.Drawing.Point(4, 24);
            this.Shops.Name = "Shops";
            this.Shops.Padding = new System.Windows.Forms.Padding(3);
            this.Shops.Size = new System.Drawing.Size(1308, 739);
            this.Shops.TabIndex = 0;
            this.Shops.Text = "Shops";
            this.Shops.UseVisualStyleBackColor = true;
            // 
            // Museums
            // 
            this.Museums.Location = new System.Drawing.Point(4, 24);
            this.Museums.Name = "Museums";
            this.Museums.Padding = new System.Windows.Forms.Padding(3);
            this.Museums.Size = new System.Drawing.Size(1308, 739);
            this.Museums.TabIndex = 1;
            this.Museums.Text = "Museums";
            this.Museums.UseVisualStyleBackColor = true;
            // 
            // Restaraunts
            // 
            this.Restaraunts.Location = new System.Drawing.Point(4, 24);
            this.Restaraunts.Name = "Restaraunts";
            this.Restaraunts.Padding = new System.Windows.Forms.Padding(3);
            this.Restaraunts.Size = new System.Drawing.Size(1308, 739);
            this.Restaraunts.TabIndex = 2;
            this.Restaraunts.Text = "Restaraunts";
            this.Restaraunts.UseVisualStyleBackColor = true;
            // 
            // Activities
            // 
            this.Activities.Location = new System.Drawing.Point(4, 24);
            this.Activities.Name = "Activities";
            this.Activities.Padding = new System.Windows.Forms.Padding(3);
            this.Activities.Size = new System.Drawing.Size(1308, 739);
            this.Activities.TabIndex = 3;
            this.Activities.Text = "Activities";
            this.Activities.UseVisualStyleBackColor = true;
            // 
            // ToTourButton
            // 
            this.ToTourButton.Location = new System.Drawing.Point(16, 785);
            this.ToTourButton.Name = "ToTourButton";
            this.ToTourButton.Size = new System.Drawing.Size(162, 23);
            this.ToTourButton.TabIndex = 1;
            this.ToTourButton.Text = "To Tour";
            this.ToTourButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1249, 785);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.Location = new System.Drawing.Point(1143, 785);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(100, 23);
            this.AdminButton.TabIndex = 3;
            this.AdminButton.Text = "Admin control";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(184, 783);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(202, 25);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Today is DD/MM/YYYY";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 820);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ToTourButton);
            this.Controls.Add(this.TabFrame);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.TabFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl TabFrame;
        private TabPage Shops;
        private TabPage Museums;
        private TabPage Restaraunts;
        private TabPage Activities;
        private Button ToTourButton;
        private Button ExitButton;
        private Button AdminButton;
        private Label DateLabel;
    }
}