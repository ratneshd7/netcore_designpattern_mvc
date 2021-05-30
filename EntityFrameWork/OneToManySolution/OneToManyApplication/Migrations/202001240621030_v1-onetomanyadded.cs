namespace OneToManyApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1onetomanyadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exhibitions",
                c => new
                    {
                        ExhibitionId = c.Guid(nullable: false),
                        ExhibitionName = c.String(),
                        Organizer_OrganizerId = c.Guid(),
                    })
                .PrimaryKey(t => t.ExhibitionId)
                .ForeignKey("dbo.Organizers", t => t.Organizer_OrganizerId)
                .Index(t => t.Organizer_OrganizerId);
            
            CreateTable(
                "dbo.Organizers",
                c => new
                    {
                        OrganizerId = c.Guid(nullable: false),
                        OrganizerName = c.String(),
                    })
                .PrimaryKey(t => t.OrganizerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exhibitions", "Organizer_OrganizerId", "dbo.Organizers");
            DropIndex("dbo.Exhibitions", new[] { "Organizer_OrganizerId" });
            DropTable("dbo.Organizers");
            DropTable("dbo.Exhibitions");
        }
    }
}
