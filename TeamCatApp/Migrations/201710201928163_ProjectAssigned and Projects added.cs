namespace TeamCatApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjectAssignedandProjectsadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssignedProjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        AssignedHour = c.Int(nullable: false),
                        Project_Id = c.Int(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.Project_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectCode = c.String(),
                        ProjectName = c.String(),
                        Frequency = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AssignedProjects", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AssignedProjects", "Project_Id", "dbo.Projects");
            DropIndex("dbo.AssignedProjects", new[] { "User_Id" });
            DropIndex("dbo.AssignedProjects", new[] { "Project_Id" });
            DropTable("dbo.Projects");
            DropTable("dbo.AssignedProjects");
        }
    }
}
