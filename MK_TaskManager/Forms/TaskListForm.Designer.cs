namespace MK_TaskManager.Forms
{
    partial class TaskListForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PriorityGroupByRadioButton = new System.Windows.Forms.RadioButton();
            this.UserGroupByRadioButton = new System.Windows.Forms.RadioButton();
            this.DateGroupByRadioButton = new System.Windows.Forms.RadioButton();
            this.TasksDataGridView = new System.Windows.Forms.DataGridView();
            this.taskEditUserControl = new MK_TaskManager.TaskEditUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.TasksDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.taskEditUserControl);
            this.splitContainer1.Size = new System.Drawing.Size(899, 386);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PriorityGroupByRadioButton);
            this.groupBox1.Controls.Add(this.UserGroupByRadioButton);
            this.groupBox1.Controls.Add(this.DateGroupByRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 61);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group By:";
            // 
            // PriorityGroupByRadioButton
            // 
            this.PriorityGroupByRadioButton.AutoSize = true;
            this.PriorityGroupByRadioButton.Location = new System.Drawing.Point(272, 28);
            this.PriorityGroupByRadioButton.Name = "PriorityGroupByRadioButton";
            this.PriorityGroupByRadioButton.Size = new System.Drawing.Size(56, 17);
            this.PriorityGroupByRadioButton.TabIndex = 0;
            this.PriorityGroupByRadioButton.TabStop = true;
            this.PriorityGroupByRadioButton.Text = "Priority";
            this.PriorityGroupByRadioButton.UseVisualStyleBackColor = true;
            // 
            // UserGroupByRadioButton
            // 
            this.UserGroupByRadioButton.AutoSize = true;
            this.UserGroupByRadioButton.Location = new System.Drawing.Point(142, 28);
            this.UserGroupByRadioButton.Name = "UserGroupByRadioButton";
            this.UserGroupByRadioButton.Size = new System.Drawing.Size(47, 17);
            this.UserGroupByRadioButton.TabIndex = 0;
            this.UserGroupByRadioButton.TabStop = true;
            this.UserGroupByRadioButton.Text = "User";
            this.UserGroupByRadioButton.UseVisualStyleBackColor = true;
            // 
            // DateGroupByRadioButton
            // 
            this.DateGroupByRadioButton.AutoSize = true;
            this.DateGroupByRadioButton.Location = new System.Drawing.Point(22, 28);
            this.DateGroupByRadioButton.Name = "DateGroupByRadioButton";
            this.DateGroupByRadioButton.Size = new System.Drawing.Size(48, 17);
            this.DateGroupByRadioButton.TabIndex = 0;
            this.DateGroupByRadioButton.TabStop = true;
            this.DateGroupByRadioButton.Text = "Date";
            this.DateGroupByRadioButton.UseVisualStyleBackColor = true;
            // 
            // TasksDataGridView
            // 
            this.TasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksDataGridView.ColumnHeadersVisible = false;
            this.TasksDataGridView.Location = new System.Drawing.Point(3, 70);
            this.TasksDataGridView.Name = "TasksDataGridView";
            this.TasksDataGridView.RowHeadersVisible = false;
            this.TasksDataGridView.Size = new System.Drawing.Size(349, 313);
            this.TasksDataGridView.TabIndex = 0;
            this.TasksDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TasksDataGridView_CellClick);
            // 
            // taskEditUserControl
            // 
            this.taskEditUserControl.CausesValidation = false;
            this.taskEditUserControl.Location = new System.Drawing.Point(3, 3);
            this.taskEditUserControl.Name = "taskEditUserControl";
            this.taskEditUserControl.Size = new System.Drawing.Size(532, 372);
            this.taskEditUserControl.TabIndex = 0;
            // 
            // TaskListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 393);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TaskListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.TaskListForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PriorityGroupByRadioButton;
        private System.Windows.Forms.RadioButton UserGroupByRadioButton;
        private System.Windows.Forms.RadioButton DateGroupByRadioButton;
        private System.Windows.Forms.DataGridView TasksDataGridView;
        private TaskEditUserControl taskEditUserControl;
    }
}