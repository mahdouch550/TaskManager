namespace MK_TaskManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskComments",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        TaskID = c.Guid(nullable: false),
                        UserID = c.Guid(nullable: false),
                        CommentContent = c.String(),
                        Timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Title = c.String(),
                        Users = c.String(),
                        Comments = c.String(),
                        Description = c.String(),
                        TaskState = c.Int(nullable: false),
                        TaskPriority = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        FullName = c.String(),
                        UserType = c.Int(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        IsLoggedIn = c.Boolean(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Tasks");
            DropTable("dbo.TaskComments");
        }
    }
}
