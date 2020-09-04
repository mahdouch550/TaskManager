namespace MK_TaskManager
{
    partial class TaskEditUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TaskCommentTextBox = new System.Windows.Forms.TextBox();
            this.TaskValidateButton = new System.Windows.Forms.Button();
            this.TaskIDTextBox = new System.Windows.Forms.TextBox();
            this.TaskTitleTextBox = new System.Windows.Forms.TextBox();
            this.TaskPriorityComboBox = new System.Windows.Forms.ComboBox();
            this.TaskStateComboBox = new System.Windows.Forms.ComboBox();
            this.TaskDeleteButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.TaskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Priority:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Comment:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Assign to: ";
            // 
            // TaskCommentTextBox
            // 
            this.TaskCommentTextBox.Location = new System.Drawing.Point(20, 276);
            this.TaskCommentTextBox.Multiline = true;
            this.TaskCommentTextBox.Name = "TaskCommentTextBox";
            this.TaskCommentTextBox.Size = new System.Drawing.Size(480, 63);
            this.TaskCommentTextBox.TabIndex = 8;
            // 
            // TaskValidateButton
            // 
            this.TaskValidateButton.Location = new System.Drawing.Point(304, 345);
            this.TaskValidateButton.Name = "TaskValidateButton";
            this.TaskValidateButton.Size = new System.Drawing.Size(116, 23);
            this.TaskValidateButton.TabIndex = 9;
            this.TaskValidateButton.Text = "Validate";
            this.TaskValidateButton.UseVisualStyleBackColor = true;
            this.TaskValidateButton.Click += new System.EventHandler(this.TaskValidateButton_Click);
            // 
            // TaskIDTextBox
            // 
            this.TaskIDTextBox.Enabled = false;
            this.TaskIDTextBox.Location = new System.Drawing.Point(82, 13);
            this.TaskIDTextBox.Name = "TaskIDTextBox";
            this.TaskIDTextBox.Size = new System.Drawing.Size(418, 20);
            this.TaskIDTextBox.TabIndex = 0;
            // 
            // TaskTitleTextBox
            // 
            this.TaskTitleTextBox.Location = new System.Drawing.Point(82, 50);
            this.TaskTitleTextBox.Name = "TaskTitleTextBox";
            this.TaskTitleTextBox.Size = new System.Drawing.Size(418, 20);
            this.TaskTitleTextBox.TabIndex = 1;
            // 
            // TaskPriorityComboBox
            // 
            this.TaskPriorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaskPriorityComboBox.FormattingEnabled = true;
            this.TaskPriorityComboBox.Items.AddRange(new object[] {
            "NotImportant",
            "Medium",
            "Important",
            "VeryImportant",
            "Urgent"});
            this.TaskPriorityComboBox.Location = new System.Drawing.Point(82, 88);
            this.TaskPriorityComboBox.Name = "TaskPriorityComboBox";
            this.TaskPriorityComboBox.Size = new System.Drawing.Size(200, 21);
            this.TaskPriorityComboBox.TabIndex = 2;
            // 
            // TaskStateComboBox
            // 
            this.TaskStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaskStateComboBox.FormattingEnabled = true;
            this.TaskStateComboBox.Items.AddRange(new object[] {
            "NotStarted",
            "Started",
            "Blocked",
            "Finished"});
            this.TaskStateComboBox.Location = new System.Drawing.Point(82, 127);
            this.TaskStateComboBox.Name = "TaskStateComboBox";
            this.TaskStateComboBox.Size = new System.Drawing.Size(200, 21);
            this.TaskStateComboBox.TabIndex = 3;
            // 
            // TaskDeleteButton
            // 
            this.TaskDeleteButton.Location = new System.Drawing.Point(426, 345);
            this.TaskDeleteButton.Name = "TaskDeleteButton";
            this.TaskDeleteButton.Size = new System.Drawing.Size(76, 23);
            this.TaskDeleteButton.TabIndex = 10;
            this.TaskDeleteButton.Text = "Delete";
            this.TaskDeleteButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Start Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Due Date:";
            // 
            // StartDateDateTimePicker
            // 
            this.StartDateDateTimePicker.Location = new System.Drawing.Point(82, 154);
            this.StartDateDateTimePicker.Name = "StartDateDateTimePicker";
            this.StartDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDateDateTimePicker.TabIndex = 4;
            // 
            // DueDateDateTimePicker
            // 
            this.DueDateDateTimePicker.Location = new System.Drawing.Point(82, 185);
            this.DueDateDateTimePicker.Name = "DueDateDateTimePicker";
            this.DueDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DueDateDateTimePicker.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Description:";
            // 
            // TaskDescriptionTextBox
            // 
            this.TaskDescriptionTextBox.Location = new System.Drawing.Point(288, 107);
            this.TaskDescriptionTextBox.Multiline = true;
            this.TaskDescriptionTextBox.Name = "TaskDescriptionTextBox";
            this.TaskDescriptionTextBox.Size = new System.Drawing.Size(212, 98);
            this.TaskDescriptionTextBox.TabIndex = 7;
            // 
            // UserComboBox
            // 
            this.UserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(82, 229);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(200, 21);
            this.UserComboBox.TabIndex = 6;
            // 
            // TaskEditUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserComboBox);
            this.Controls.Add(this.DueDateDateTimePicker);
            this.Controls.Add(this.StartDateDateTimePicker);
            this.Controls.Add(this.TaskStateComboBox);
            this.Controls.Add(this.TaskPriorityComboBox);
            this.Controls.Add(this.TaskTitleTextBox);
            this.Controls.Add(this.TaskIDTextBox);
            this.Controls.Add(this.TaskDeleteButton);
            this.Controls.Add(this.TaskValidateButton);
            this.Controls.Add(this.TaskDescriptionTextBox);
            this.Controls.Add(this.TaskCommentTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaskEditUserControl";
            this.Size = new System.Drawing.Size(510, 376);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TaskCommentTextBox;
        private System.Windows.Forms.Button TaskValidateButton;
        private System.Windows.Forms.TextBox TaskIDTextBox;
        private System.Windows.Forms.TextBox TaskTitleTextBox;
        private System.Windows.Forms.ComboBox TaskPriorityComboBox;
        private System.Windows.Forms.ComboBox TaskStateComboBox;
        private System.Windows.Forms.Button TaskDeleteButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker StartDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker DueDateDateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TaskDescriptionTextBox;
        private System.Windows.Forms.ComboBox UserComboBox;
    }
}
