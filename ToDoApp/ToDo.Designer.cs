﻿namespace ToDoApp
{
    partial class ToDo
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
            this.richTb = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTb
            // 
            this.richTb.Location = new System.Drawing.Point(61, 96);
            this.richTb.Name = "richTb";
            this.richTb.Size = new System.Drawing.Size(241, 299);
            this.richTb.TabIndex = 0;
            this.richTb.Text = "";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd:MM:yyyy  hh:mm:ss";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(61, 51);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(10);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(123, 432);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 516);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.richTb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTb;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnAdd;
    }
}

