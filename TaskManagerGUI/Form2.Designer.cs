namespace TaskManagerGUI
{
    partial class Form2
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleDesc = new System.Windows.Forms.Label();
            this.Priotiry = new System.Windows.Forms.Label();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.DescTextBox = new System.Windows.Forms.TextBox();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CompletedButton = new System.Windows.Forms.RadioButton();
            this.NYButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.NullButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registration";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.Location = new System.Drawing.Point(51, 123);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(53, 21);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            // 
            // titleDesc
            // 
            this.titleDesc.AutoSize = true;
            this.titleDesc.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleDesc.Location = new System.Drawing.Point(51, 170);
            this.titleDesc.Name = "titleDesc";
            this.titleDesc.Size = new System.Drawing.Size(121, 21);
            this.titleDesc.TabIndex = 3;
            this.titleDesc.Text = "Description";
            // 
            // Priotiry
            // 
            this.Priotiry.AutoSize = true;
            this.Priotiry.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Priotiry.Location = new System.Drawing.Point(51, 224);
            this.Priotiry.Name = "Priotiry";
            this.Priotiry.Size = new System.Drawing.Size(81, 21);
            this.Priotiry.TabIndex = 4;
            this.Priotiry.Text = "Priority";
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.priorityComboBox.Location = new System.Drawing.Point(198, 229);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(121, 20);
            this.priorityComboBox.TabIndex = 5;
            // 
            // DescTextBox
            // 
            this.DescTextBox.Location = new System.Drawing.Point(198, 172);
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(275, 19);
            this.DescTextBox.TabIndex = 6;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Location = new System.Drawing.Point(97, 404);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(75, 23);
            this.AddTaskButton.TabIndex = 8;
            this.AddTaskButton.Text = "Add Task";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(51, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Deadline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(51, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Completed";
            // 
            // CompletedButton
            // 
            this.CompletedButton.AutoSize = true;
            this.CompletedButton.Location = new System.Drawing.Point(210, 333);
            this.CompletedButton.Name = "CompletedButton";
            this.CompletedButton.Size = new System.Drawing.Size(77, 16);
            this.CompletedButton.TabIndex = 11;
            this.CompletedButton.TabStop = true;
            this.CompletedButton.Text = "Completed";
            this.CompletedButton.UseVisualStyleBackColor = true;
            // 
            // NYButton
            // 
            this.NYButton.AutoSize = true;
            this.NYButton.Location = new System.Drawing.Point(321, 333);
            this.NYButton.Name = "NYButton";
            this.NYButton.Size = new System.Drawing.Size(62, 16);
            this.NYButton.TabIndex = 12;
            this.NYButton.TabStop = true;
            this.NYButton.Text = "Not Yet";
            this.NYButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 284);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(198, 128);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(275, 19);
            this.titleTextBox.TabIndex = 14;
            // 
            // NullButton
            // 
            this.NullButton.AutoSize = true;
            this.NullButton.Location = new System.Drawing.Point(411, 333);
            this.NullButton.Name = "NullButton";
            this.NullButton.Size = new System.Drawing.Size(43, 16);
            this.NullButton.TabIndex = 15;
            this.NullButton.TabStop = true;
            this.NullButton.Text = "Null";
            this.NullButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 486);
            this.Controls.Add(this.NullButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.NYButton);
            this.Controls.Add(this.CompletedButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.priorityComboBox);
            this.Controls.Add(this.Priotiry);
            this.Controls.Add(this.titleDesc);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label titleDesc;
        private System.Windows.Forms.Label Priotiry;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.TextBox DescTextBox;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton CompletedButton;
        private System.Windows.Forms.RadioButton NYButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.RadioButton NullButton;
    }
}