namespace TeamCatApp.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class TeamsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamCode = c.String(),
                        TeamName = c.String(),
                        TeamEmail = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Teams", new[] { "User_Id" });
            DropTable("dbo.Teams");
        }
    }
}
