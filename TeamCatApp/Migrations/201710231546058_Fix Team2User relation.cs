namespace TeamCatApp.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class FixTeam2Userrelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teams", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Teams", new[] { "User_Id" });
            AddColumn("dbo.AspNetUsers", "Team_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Team_Id");
            AddForeignKey("dbo.AspNetUsers", "Team_Id", "dbo.Teams", "Id");
            DropColumn("dbo.Teams", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "User_Id", c => c.String(maxLength: 128));
            DropForeignKey("dbo.AspNetUsers", "Team_Id", "dbo.Teams");
            DropIndex("dbo.AspNetUsers", new[] { "Team_Id" });
            DropColumn("dbo.AspNetUsers", "Team_Id");
            CreateIndex("dbo.Teams", "User_Id");
            AddForeignKey("dbo.Teams", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
