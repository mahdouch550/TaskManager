using System;
using System.ComponentModel.DataAnnotations;

namespace MK_TaskManager.Models
{
    public class TaskComment
    {
        [Key]
        public Guid ID { get; set; }

        public Guid TaskID { get; set; }
        public Guid UserID { get; set; }
        public String CommentContent { get; set; }
        public DateTime Timestamp { get; private set; }

        public void SetCommentContent(String commentContent)
        {
            CommentContent = commentContent;
            Timestamp = DateTime.Now;
        }
    }
}