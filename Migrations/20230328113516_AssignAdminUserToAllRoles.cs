using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Migrations
{
    public partial class AssignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [Movies].[UserRoles] (UserId,RoleId) SELECT '8ebb0efc-b8c8-4e59-8008-5090873be757',Id FROM [Movies].[Roles] ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Movies].[Roles] WHERE  UserId='8ebb0efc-b8c8-4e59-8008-5090873be757' ");

        }
    }
}
