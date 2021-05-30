namespace SimpleCustomerApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1designationAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Designation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Designation");
        }
    }
}
