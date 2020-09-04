using MK_TaskManager.DTSs;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MK_TaskManager.Forms
{
    public partial class LoginForm : Form
    {
        private TaskManagerDbContext context;

        public LoginForm()
        {
            InitializeComponent();
            context = new TaskManagerDbContext();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var SignUpForm = new SignUpForm();
            SignUpForm.Show();
            SignUpForm.FormClosed += SignUpForm_FormClosed;
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitializeComponent();
            Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoginTextBox.Invoke(new MethodInvoker(() =>
            {
                LoginTextBox.AutoCompleteMode = AutoCompleteMode.Append;
                LoginTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                var loginAutoCompleteSource = new AutoCompleteStringCollection();
                loginAutoCompleteSource.AddRange(context.Users.Select(user => user.Login).ToArray());
                LoginTextBox.AutoCompleteCustomSource = loginAutoCompleteSource;
            }));
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var currentUser = context.Users.FirstOrDefault(user => user.Login.ToString().Equals(LoginTextBox.Text) && user.Password.Equals(PasswordTextBox.Text));
                if (currentUser == null)
                    MessageBox.Show("Login or password is incorrect!");
                else
                {
                    var taskListForm = new TaskListForm(currentUser);
                    Hide();
                    taskListForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Verify your Login/Password");
            }
        }

        private bool ValidateInput()
        {
            return !String.IsNullOrEmpty(LoginTextBox.Text) || (!String.IsNullOrEmpty(PasswordTextBox.Text) && PasswordTextBox.Text.Length < 8);
        }
    }
}