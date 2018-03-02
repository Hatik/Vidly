namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2d2a6ff9-c335-410e-9016-e7737ce9e75a', N'guest@vidly.com', 0, N'AH/k1HUU4qwhn5d7lRF4XKJYERUO4xxHwHyETyBHIq2i8RnOkdxRnrzHZcScJhbVcw==', N'54e30c31-2ee2-47d1-ab1a-8bd27332a08f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c7124a7f-9650-42ff-a37d-731aac81b07f', N'admin@vidly.com', 0, N'AMQzZfIjM/S7PGwPzP+uNieS7lPCoANc+DzLhlWWOnYLx4VIECIgrfnN9vOqCAF11Q==', N'b19aaa80-9aff-4cf5-a8e9-2f3bb1247f15', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7e00314b-e208-4230-b02a-757d38ae0a0d', N'CanManageMovies')
            
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c7124a7f-9650-42ff-a37d-731aac81b07f', N'7e00314b-e208-4230-b02a-757d38ae0a0d')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
