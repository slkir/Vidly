namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'87b19b58-ec55-4019-8b38-0cd2309de31d', N'admin@vidly.com', 0, N'ALYB621sCzm5dAuvIGP2WUzOQb7nLz7eKP0w/2IeaXlZNeKFwJBP8w7sxcIYwoA7qg==', N'b4d4cdab-d6e6-42be-aa1d-8e345e7176ad', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c9d3ed97-c23b-477c-a4bd-8a544f17f7dc', N'guest@vidly.com', 0, N'AMzd3PDqK6UYNFfgcZ0MjPJPsAjA79zBhtMpIY/rPPVMupIHG0B9vtcCMpsOlKZPBw==', N'caf2b5a4-7f1e-40c0-8934-ed39955d55db', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')



INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c547c857-01b8-4557-98d7-59b86f340e66', N'CanManageMovies')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'87b19b58-ec55-4019-8b38-0cd2309de31d', N'c547c857-01b8-4557-98d7-59b86f340e66')");
        }

        public override void Down()
        {
        }
    }
}
