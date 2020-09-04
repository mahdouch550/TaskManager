namespace MK_TaskManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedTaskUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "User", c => c.String());
            DropColumn("dbo.Tasks", "Users");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "Users", c => c.String());
            DropColumn("dbo.Tasks", "User");
        }
    }
}
