namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@" 
             INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2392f87c-4fd7-435c-9614-f7d7b43b40fe', N'myadmin@vidly.com.tr', 0, N'AAZY/kEFfSxFlnMoHO8mA0AgqnzlswG/Q9SK/h8euPyKFnU4H6uQiELJhg9+W3rxjQ==', N'8affb4a3-7a86-405e-b86e-3dc88fdb68c8', NULL, 0, 0, NULL, 1, 0, N'myadmin@vidly.com.tr')
             INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd798fba6-2394-446a-9ebb-f428ef0026a9', N'guest@vidly.com', 0, N'AIr/M9d0GsqBR/15VNcL/2Lmt/mSS2QZ1ePMuI6Qy4SN5inuzyj/5fkR6ajBH0hD3Q==', N'833b3e10-d946-4b17-9ec4-cc3d1e7d25e0', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
             INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5c0a650c-2778-4cf7-9be8-2ecc8e3ea244', N'CanManageMovie')
             INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2392f87c-4fd7-435c-9614-f7d7b43b40fe', N'5c0a650c-2778-4cf7-9be8-2ecc8e3ea244')
      ");
        }
        
        public override void Down()
        {
        }
    }
}
