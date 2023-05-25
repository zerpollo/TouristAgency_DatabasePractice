namespace TouristAgency_DatabasePractice.Forms.AdminPanelWindows
{
    partial class NewLanguageWindow
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.pricvelabe = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(126, 24);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(183, 23);
            this.NameTextBox.TabIndex = 63;
            // 
            // pricvelabe
            // 
            this.pricvelabe.AutoSize = true;
            this.pricvelabe.Location = new System.Drawing.Point(18, 27);
            this.pricvelabe.Name = "pricvelabe";
            this.pricvelabe.Size = new System.Drawing.Size(92, 15);
            this.pricvelabe.TabIndex = 62;
            this.pricvelabe.Text = "Language name";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(126, 80);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(183, 23);
            this.AddButton.TabIndex = 61;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NewLanguageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 136);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.pricvelabe);
            this.Controls.Add(this.AddButton);
            this.Name = "NewLanguageWindow";
            this.Text = "NewLanguageWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NameTextBox;
        private Label pricvelabe;
        private Button AddButton;
    }
}