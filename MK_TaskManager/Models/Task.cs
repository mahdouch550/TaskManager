using MK_TaskManager.Enumerations;
using System;
using System.ComponentModel.DataAnnotations;

namespace MK_TaskManager.Models
{
    public class Task
    {
        [Key]
        public Guid ID { get; set; }

        public String Title { get; set; }
        public String User { get; set; } = "";
        public String Comments { get; set; }
        public String Description { get; set; }
        public TaskState TaskState { get; set; } = TaskState.NotStarted;
        public TaskPriority TaskPriority { get; set; } = TaskPriority.NotImportant;
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }

        public void UpdateTaskState(TaskState taskState) => TaskState = taskState;

        //public void AddComment(TaskComment taskComment) => Comments.Add(taskComment);

        //public void RemoveComment(TaskComment taskComment) => Comments.Remove(taskComment);

        //public void AddUser(User user) => Users.Add(user.ID);

        //public void RemoveUser(User user) => Users.Remove(user.ID);

        public void SetDescription(String description) => Description = description;

        public void SetTaskPriority(TaskPriority taskPriority) => TaskPriority = taskPriority;
    }
}