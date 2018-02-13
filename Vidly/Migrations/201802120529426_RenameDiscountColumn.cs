namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameDiscountColumn : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.MembershipTypes", "DiscountType", "DiscountRate");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.MembershipTypes", "DiscountRate", "DiscountType");
        }
    }
}
