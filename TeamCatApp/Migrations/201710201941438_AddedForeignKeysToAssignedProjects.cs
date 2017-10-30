namespace TeamCatApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForeignKeysToAssignedProjects : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AssignedProjects", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.AssignedProjects", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.AssignedProjects", new[] { "Project_Id" });
            DropIndex("dbo.AssignedProjects", new[] { "User_Id" });
            RenameColumn(table: "dbo.AssignedProjects", name: "Project_Id", newName: "ProjectId");
            RenameColumn(table: "dbo.AssignedProjects", name: "User_Id", newName: "UserId");
            DropPrimaryKey("dbo.AssignedProjects");
            AlterColumn("dbo.AssignedProjects", "ProjectId", c => c.Int(nullable: false));
            AlterColumn("dbo.AssignedProjects", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.AssignedProjects", new[] { "UserId", "ProjectId" });
            CreateIndex("dbo.AssignedProjects", "UserId");
            CreateIndex("dbo.AssignedProjects", "ProjectId");
            AddForeignKey("dbo.AssignedProjects", "ProjectId", "dbo.Projects", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AssignedProjects", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            DropColumn("dbo.AssignedProjects", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AssignedProjects", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.AssignedProjects", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AssignedProjects", "ProjectId", "dbo.Projects");
            DropIndex("dbo.AssignedProjects", new[] { "ProjectId" });
            DropIndex("dbo.AssignedProjects", new[] { "UserId" });
            DropPrimaryKey("dbo.AssignedProjects");
            AlterColumn("dbo.AssignedProjects", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.AssignedProjects", "ProjectId", c => c.Int());
            AddPrimaryKey("dbo.AssignedProjects", "Id");
            RenameColumn(table: "dbo.AssignedProjects", name: "UserId", newName: "User_Id");
            RenameColumn(table: "dbo.AssignedProjects", name: "ProjectId", newName: "Project_Id");
            CreateIndex("dbo.AssignedProjects", "User_Id");
            CreateIndex("dbo.AssignedProjects", "Project_Id");
            AddForeignKey("dbo.AssignedProjects", "User_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AssignedProjects", "Project_Id", "dbo.Projects", "Id");
        }
    }
}
