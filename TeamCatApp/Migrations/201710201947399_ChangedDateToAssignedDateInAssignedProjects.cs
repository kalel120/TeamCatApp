namespace TeamCatApp.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDateToAssignedDateInAssignedProjects : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AssignedProjects", "AssignedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.AssignedProjects", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AssignedProjects", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.AssignedProjects", "AssignedDate");
        }
    }
}
