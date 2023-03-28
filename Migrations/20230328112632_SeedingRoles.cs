using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Movies.Migrations
{
    public partial class SeedingRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                    table:"Roles",
                    schema:"Movies",
                    columns: new[] {"Id","Name", "NormalizedName", "ConcurrencyStamp" } ,
                    values: new object[] {Guid.NewGuid().ToString(),"User","User".ToUpper().ToString(),Guid.NewGuid().ToString() }
                );

            migrationBuilder.InsertData(
                    table:"Roles",
                    schema:"Movies",
                    columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                    values: new object[] {Guid.NewGuid().ToString(),"Admin","Admin".ToUpper().ToString(),Guid.NewGuid().ToString() }
                    );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Movies].[Roles]");
        }
    }
}
