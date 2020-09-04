using MK_TaskManager.Enumerations;
using System;
using System.ComponentModel.DataAnnotations;

namespace MK_TaskManager.Models
{
    public class User
    {
        [Key]
        public Guid ID { get; set; }

        public String FullName { get; set; }
        public UserType UserType { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsLoggedIn { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }

        public void SetLoggedIn(bool isLoggedIn) => IsLoggedIn = isLoggedIn;
    }
}