namespace APILecture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VoterStuff : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Voters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Party = c.String(),
                        Token = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Voters");
        }
    }
}
