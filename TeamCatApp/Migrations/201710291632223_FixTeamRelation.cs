namespace TeamCatApp.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class FixTeamRelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "Team_Id", "dbo.Teams");
            DropIndex("dbo.AspNetUsers", new[] { "Team_Id" });
            RenameColumn(table: "dbo.AspNetUsers", name: "Team_Id", newName: "TeamId");
            AlterColumn("dbo.AspNetUsers", "TeamId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "TeamId");
            AddForeignKey("dbo.AspNetUsers", "TeamId", "dbo.Teams", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "TeamId", "dbo.Teams");
            DropIndex("dbo.AspNetUsers", new[] { "TeamId" });
            AlterColumn("dbo.AspNetUsers", "TeamId", c => c.Int());
            RenameColumn(table: "dbo.AspNetUsers", name: "TeamId", newName: "Team_Id");
            CreateIndex("dbo.AspNetUsers", "Team_Id");
            AddForeignKey("dbo.AspNetUsers", "Team_Id", "dbo.Teams", "Id");
        }
    }
}
