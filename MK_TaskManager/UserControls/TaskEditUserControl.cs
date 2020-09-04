using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using MK_TaskManager.DTSs;
using MK_TaskManager.Enumerations;

namespace MK_TaskManager
{
    public partial class TaskEditUserControl : UserControl
    {
        private TaskManagerDbContext context;

        public event EventHandler TaskAdded;

        private Models.Task CurrentTask;

        public TaskEditUserControl()
        {
            InitializeComponent();
            context = new TaskManagerDbContext();
            UserComboBox.Items.Clear();
            UserComboBox.Items.AddRange(context.Users.Select(user => user.FullName).ToArray());
            UserComboBox.Text = UserComboBox.Items[0].ToString();
            TaskPriorityComboBox.Text = TaskPriorityComboBox.Items[0].ToString();
            TaskStateComboBox.Text = TaskStateComboBox.Items[0].ToString();
        }

        public void SetTaskEditUserControlContent(Models.Task task)
        {
            CurrentTask = task;
            Invoke(new MethodInvoker(() =>
            {
                TaskIDTextBox.Text = task.ID.ToString();
                TaskTitleTextBox.Text = task.Title;
                TaskCommentTextBox.Text = task.Comments.First().ToString();
                TaskDescriptionTextBox.Text = task.Description;
                TaskStateComboBox.Text = task.TaskState.ToString();
                TaskPriorityComboBox.Text = task.TaskPriority.ToString();
                DueDateDateTimePicker.Text = task.DueDate.ToString();
                StartDateDateTimePicker.Text = task.StartDate.ToString();
            }));
        }

        private void TaskValidateButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var ID = Guid.Empty;
                if (String.IsNullOrEmpty(TaskIDTextBox.Text))
                {
                    ID = Guid.NewGuid();
                }
                else
                    ID = Guid.Parse(TaskIDTextBox.Text);

                var newTask = new Models.Task
                {
                    ID = ID,
                    Description = TaskDescriptionTextBox.Text,
                    DueDate = DueDateDateTimePicker.Value,
                    StartDate = StartDateDateTimePicker.Value,
                    TaskPriority = (TaskPriority)Enum.Parse(typeof(TaskPriority), TaskPriorityComboBox.Text),
                    TaskState = (TaskState)Enum.Parse(typeof(TaskState), TaskStateComboBox.Text),
                    Title = TaskTitleTextBox.Text,
                    Comments = TaskCommentTextBox.Text,
                    User = UserComboBox.Text
                };
                context.Tasks.AddOrUpdate(newTask);
                TaskAdded.Invoke(this, null);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Please verify your inputs!");
            }
        }

        private bool ValidateInput()
        {
            if (DueDateDateTimePicker.Value.Date < StartDateDateTimePicker.Value.Date)
                return false;
            return !String.IsNullOrEmpty(TaskTitleTextBox.Text) ||
                   !String.IsNullOrEmpty(TaskDescriptionTextBox.Text);
        }

        public void OnTaskAdded()
        {
            TaskAdded.Invoke(this, EventArgs.Empty);
        }
    }
}