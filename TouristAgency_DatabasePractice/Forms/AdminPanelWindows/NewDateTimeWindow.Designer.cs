namespace TouristAgency_DatabasePractice.Forms.AdminPanelWindows
{
    partial class NewDateTimeWindow
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
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(12, 12);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(214, 23);
            this.DatePicker.TabIndex = 0;
            // 
            // TimeComboBox
            // 
            this.TimeComboBox.FormattingEnabled = true;
            this.TimeComboBox.Location = new System.Drawing.Point(241, 15);
            this.TimeComboBox.Name = "TimeComboBox";
            this.TimeComboBox.Size = new System.Drawing.Size(121, 23);
            this.TimeComboBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(21, 226);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(341, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NewDateTimeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 265);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TimeComboBox);
            this.Controls.Add(this.DatePicker);
            this.Name = "NewDateTimeWindow";
            this.Text = "NewDateTimeWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker DatePicker;
        private ComboBox TimeComboBox;
        private Button AddButton;
    }
}