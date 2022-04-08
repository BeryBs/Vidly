namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "MembershipTypeID" });
            AlterColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Customers", "MembershipTypeId");
            DropColumn("dbo.Customers", "MemberShipType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MemberShipType", c => c.Int(nullable: false));
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            AlterColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "MembershipTypeID");
        }
    }
}
