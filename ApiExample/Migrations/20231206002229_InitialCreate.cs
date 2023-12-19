using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiExample.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    HeightInInches = table.Column<int>(type: "INTEGER", nullable: false),
                    SecretIdentity = table.Column<string>(type: "TEXT", nullable: false),
                    IsGood = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEvil = table.Column<bool>(type: "INTEGER", nullable: false),
                    CanFly = table.Column<bool>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
