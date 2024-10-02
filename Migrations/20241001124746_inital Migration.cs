using System;
using Microsoft.EntityFrameworkCore.Migrations;


namespace StudentPortalWeb.Migrations
{
    /// <inheritdoc />
    public partial class initalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "VARCHAR(36)", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Subscribed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
