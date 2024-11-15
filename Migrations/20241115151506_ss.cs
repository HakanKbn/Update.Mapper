using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Update.Mapper.Migrations
{
    /// <inheritdoc />
    public partial class ss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Referans",
                columns: table => new
                {
                    kod = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    tipId = table.Column<int>(type: "int", nullable: false),
                    tenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    deneme = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_Referans_tenantId_kod_tipId",
                table: "Referans",
                columns: new[] { "tenantId", "kod", "tipId" },
                unique: true,
                filter: "[tenantId] IS NOT NULL AND [kod] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Referans");
        }
    }
}
