﻿namespace TouristAgency_DatabasePractice.Forms
{
    partial class ToTourWindow
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FinalPriceLabel = new System.Windows.Forms.Label();
            this.NumberOfPeopleComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectedItemsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ReturnButton.Location = new System.Drawing.Point(1017, 413);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(94, 51);
            this.ReturnButton.TabIndex = 0;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected items:";
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PayButton.Location = new System.Drawing.Point(917, 413);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(94, 51);
            this.PayButton.TabIndex = 3;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(517, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Final price:";
            // 
            // FinalPriceLabel
            // 
            this.FinalPriceLabel.AutoSize = true;
            this.FinalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FinalPriceLabel.Location = new System.Drawing.Point(639, 426);
            this.FinalPriceLabel.Name = "FinalPriceLabel";
            this.FinalPriceLabel.Size = new System.Drawing.Size(46, 25);
            this.FinalPriceLabel.TabIndex = 5;
            this.FinalPriceLabel.Text = "null";
            // 
            // NumberOfPeopleComboBox
            // 
            this.NumberOfPeopleComboBox.FormattingEnabled = true;
            this.NumberOfPeopleComboBox.Location = new System.Drawing.Point(216, 428);
            this.NumberOfPeopleComboBox.Name = "NumberOfPeopleComboBox";
            this.NumberOfPeopleComboBox.Size = new System.Drawing.Size(110, 23);
            this.NumberOfPeopleComboBox.TabIndex = 6;
            this.NumberOfPeopleComboBox.SelectedValueChanged += new System.EventHandler(this.NumberOfPeopleComboBox_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of people:";
            // 
            // SelectedItemsFlowLayoutPanel
            // 
            this.SelectedItemsFlowLayoutPanel.AutoScroll = true;
            this.SelectedItemsFlowLayoutPanel.Location = new System.Drawing.Point(12, 42);
            this.SelectedItemsFlowLayoutPanel.Name = "SelectedItemsFlowLayoutPanel";
            this.SelectedItemsFlowLayoutPanel.Size = new System.Drawing.Size(1099, 365);
            this.SelectedItemsFlowLayoutPanel.TabIndex = 8;
            // 
            // ToTourWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1123, 469);
            this.Controls.Add(this.SelectedItemsFlowLayoutPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberOfPeopleComboBox);
            this.Controls.Add(this.FinalPriceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnButton);
            this.Name = "ToTourWindow";
            this.Text = "ToTourWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ReturnButton;
        private Label label1;
        private Button PayButton;
        private Label label2;
        private Label FinalPriceLabel;
        private ComboBox NumberOfPeopleComboBox;
        private Label label4;
        private FlowLayoutPanel SelectedItemsFlowLayoutPanel;
    }
}