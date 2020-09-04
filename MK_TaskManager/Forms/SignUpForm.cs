using MK_TaskManager.DTSs;
using MK_TaskManager.Enumerations;
using MK_TaskManager.Models;
using System;
using System.Windows.Forms;

namespace MK_TaskManager.Forms
{
    public partial class SignUpForm : Form
    {
        private TaskManagerDbContext context;

        public SignUpForm()
        {
            InitializeComponent();
            context = new TaskManagerDbContext();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                ID = Guid.NewGuid(),
                BirthDate = BirthDateDateTimePicker.Value,
                Email = EmailTextBox.Text,
                FullName = FullNameTextBox.Text,
                IsLoggedIn = false,
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                UserType = (UserType)Enum.Parse(typeof(UserType), UserTypeComboBox.Text)
            };
            context.Users.Add(user);
            context.SaveChanges();
            Close();
        }
    }
}