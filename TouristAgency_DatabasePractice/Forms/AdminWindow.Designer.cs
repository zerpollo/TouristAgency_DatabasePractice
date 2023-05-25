namespace TouristAgency_DatabasePractice.Forms
{
    partial class AdminWindow
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
            this.AddShopButton = new System.Windows.Forms.Button();
            this.AddRestarauntButton = new System.Windows.Forms.Button();
            this.AddMuseumButton = new System.Windows.Forms.Button();
            this.AddActivityButton = new System.Windows.Forms.Button();
            this.AddLanguageButton = new System.Windows.Forms.Button();
            this.AddLangToActButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddShopButton
            // 
            this.AddShopButton.Location = new System.Drawing.Point(12, 12);
            this.AddShopButton.Name = "AddShopButton";
            this.AddShopButton.Size = new System.Drawing.Size(166, 23);
            this.AddShopButton.TabIndex = 0;
            this.AddShopButton.Text = "Add Shop";
            this.AddShopButton.UseVisualStyleBackColor = true;
            this.AddShopButton.Click += new System.EventHandler(this.AddShopButton_Click);
            // 
            // AddRestarauntButton
            // 
            this.AddRestarauntButton.Location = new System.Drawing.Point(12, 53);
            this.AddRestarauntButton.Name = "AddRestarauntButton";
            this.AddRestarauntButton.Size = new System.Drawing.Size(166, 23);
            this.AddRestarauntButton.TabIndex = 1;
            this.AddRestarauntButton.Text = "Add Restaraunt";
            this.AddRestarauntButton.UseVisualStyleBackColor = true;
            this.AddRestarauntButton.Click += new System.EventHandler(this.AddRestarauntButton_Click);
            // 
            // AddMuseumButton
            // 
            this.AddMuseumButton.Location = new System.Drawing.Point(12, 96);
            this.AddMuseumButton.Name = "AddMuseumButton";
            this.AddMuseumButton.Size = new System.Drawing.Size(166, 23);
            this.AddMuseumButton.TabIndex = 2;
            this.AddMuseumButton.Text = "Add Museum";
            this.AddMuseumButton.UseVisualStyleBackColor = true;
            this.AddMuseumButton.Click += new System.EventHandler(this.AddMuseumButton_Click);
            // 
            // AddActivityButton
            // 
            this.AddActivityButton.Location = new System.Drawing.Point(12, 140);
            this.AddActivityButton.Name = "AddActivityButton";
            this.AddActivityButton.Size = new System.Drawing.Size(166, 23);
            this.AddActivityButton.TabIndex = 3;
            this.AddActivityButton.Text = "Add Activity";
            this.AddActivityButton.UseVisualStyleBackColor = true;
            this.AddActivityButton.Click += new System.EventHandler(this.AddActivityButton_Click);
            // 
            // AddLanguageButton
            // 
            this.AddLanguageButton.Location = new System.Drawing.Point(12, 183);
            this.AddLanguageButton.Name = "AddLanguageButton";
            this.AddLanguageButton.Size = new System.Drawing.Size(166, 23);
            this.AddLanguageButton.TabIndex = 4;
            this.AddLanguageButton.Text = "Add Language";
            this.AddLanguageButton.UseVisualStyleBackColor = true;
            this.AddLanguageButton.Click += new System.EventHandler(this.AddLanguageButton_Click);
            // 
            // AddLangToActButton
            // 
            this.AddLangToActButton.Location = new System.Drawing.Point(12, 232);
            this.AddLangToActButton.Name = "AddLangToActButton";
            this.AddLangToActButton.Size = new System.Drawing.Size(166, 23);
            this.AddLangToActButton.TabIndex = 5;
            this.AddLangToActButton.Text = "Add Language to Activity";
            this.AddLangToActButton.UseVisualStyleBackColor = true;
            this.AddLangToActButton.Click += new System.EventHandler(this.AddLangToActButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 440);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(166, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 475);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddLangToActButton);
            this.Controls.Add(this.AddLanguageButton);
            this.Controls.Add(this.AddActivityButton);
            this.Controls.Add(this.AddMuseumButton);
            this.Controls.Add(this.AddRestarauntButton);
            this.Controls.Add(this.AddShopButton);
            this.Name = "AdminWindow";
            this.Text = "AdminWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddShopButton;
        private Button AddRestarauntButton;
        private Button AddMuseumButton;
        private Button AddActivityButton;
        private Button AddLanguageButton;
        private Button AddLangToActButton;
        private Button ExitButton;
    }
}