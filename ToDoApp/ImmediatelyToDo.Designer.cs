namespace ToDoApp
{
    partial class ImmediatelyToDo
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDone = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy  hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // checkBoxDone
            // 
            this.checkBoxDone.AutoSize = true;
            this.checkBoxDone.Location = new System.Drawing.Point(60, 437);
            this.checkBoxDone.Name = "checkBoxDone";
            this.checkBoxDone.Size = new System.Drawing.Size(78, 21);
            this.checkBoxDone.TabIndex = 2;
            this.checkBoxDone.Text = "Erledigt";
            this.checkBoxDone.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(127, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 48);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(61, 96);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(276, 308);
            this.listBox.TabIndex = 4;
            this.listBox.Click += new System.EventHandler(this.listBox_Click);
            // 
            // ImmediatelyToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 554);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.checkBoxDone);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ImmediatelyToDo";
            this.Text = "ImmediatelyToDo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxDone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBox;
    }
}