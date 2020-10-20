using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace abpWorkerServiceDemo.Migrations
{
    public partial class Add_DemoEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "demo");

            migrationBuilder.CreateTable(
                name: "DemoEntities",
                schema: "demo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemoEntities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DemoEntities",
                schema: "demo");
        }
    }
}
