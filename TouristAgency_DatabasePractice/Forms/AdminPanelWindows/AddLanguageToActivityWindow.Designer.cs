﻿namespace TouristAgency_DatabasePractice.Forms.AdminPanelWindows
{
    partial class AddLanguageToActivityWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.LangIDTextBox = new System.Windows.Forms.TextBox();
            this.ActivityIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Language ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Activity ID";
            // 
            // LangIDTextBox
            // 
            this.LangIDTextBox.Location = new System.Drawing.Point(122, 31);
            this.LangIDTextBox.Name = "LangIDTextBox";
            this.LangIDTextBox.Size = new System.Drawing.Size(71, 23);
            this.LangIDTextBox.TabIndex = 2;
            // 
            // ActivityIDTextBox
            // 
            this.ActivityIDTextBox.Location = new System.Drawing.Point(122, 129);
            this.ActivityIDTextBox.Name = "ActivityIDTextBox";
            this.ActivityIDTextBox.Size = new System.Drawing.Size(71, 23);
            this.ActivityIDTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add language to ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddLanguageToActivityWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 232);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ActivityIDTextBox);
            this.Controls.Add(this.LangIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddLanguageToActivityWindow";
            this.Text = "AddLanguageToActivityWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox LangIDTextBox;
        private TextBox ActivityIDTextBox;
        private Label label3;
        private Button button1;
    }
}