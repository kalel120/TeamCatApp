namespace TeamCatApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changedassignedhourtypetodouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AssignedProjects", "AssignedHour", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AssignedProjects", "AssignedHour", c => c.Int(nullable: false));
        }
    }
}
