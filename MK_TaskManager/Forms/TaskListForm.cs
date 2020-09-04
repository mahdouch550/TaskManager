using MK_TaskManager.DTSs;
using MK_TaskManager.Models;
using System.Linq;
using System.Windows.Forms;

namespace MK_TaskManager.Forms
{
    public partial class TaskListForm : Form
    {
        private TaskManagerDbContext context;
        private User CurrentUser;

        public TaskListForm(User user)
        {
            InitializeComponent();
            if (user != null)
                CurrentUser = user;
            context = new TaskManagerDbContext();
            taskEditUserControl.TaskAdded += TaskEditUserControl_TaskAdded;
        }

        private void TaskEditUserControl_TaskAdded(object sender, System.EventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                TasksDataGridView.DataSource = context.Tasks.Select(task => task.Title).ToList();
            }));
        }

        private void TasksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            taskEditUserControl.SetTaskEditUserControlContent(context.Tasks.FirstOrDefault(task => task.Title.Equals(TasksDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString())));
        }

        private void TaskListForm_Load(object sender, System.EventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                TasksDataGridView.DataSource = context.Tasks.Select(task => task.Title).ToList();
            }));
        }
    }
}