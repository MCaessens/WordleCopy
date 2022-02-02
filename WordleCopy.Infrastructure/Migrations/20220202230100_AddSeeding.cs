using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordleCopy.Infrastructure.Migrations
{
    public partial class AddSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SelectedWords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SelectionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedWords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectedWords_Words_WordId",
                        column: x => x.WordId,
                        principalTable: "Words",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5809b45c-8ff6-436d-b701-8df473ea80e1"), "Torso" },
                    { new Guid("6565b6b5-4f3f-4cb7-b0a9-45c5572ed0a2"), "Muzzy" },
                    { new Guid("6c33fc4c-3b37-4d69-ba29-ebfb1b73d567"), "Jumps" },
                    { new Guid("8258f1dd-ad3a-44c4-abd3-a223aac2ca3c"), "Whizz" },
                    { new Guid("8a289b35-01eb-47a2-bdc2-52f633fdf016"), "Bizzy" },
                    { new Guid("a029a207-aba5-4bc2-8acd-8947445d4a90"), "Jumbo" },
                    { new Guid("ec4794d2-1365-45b7-8481-e46f679c1e9a"), "Frizz" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SelectedWords_WordId",
                table: "SelectedWords",
                column: "WordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SelectedWords");

            migrationBuilder.DropTable(
                name: "Words");
        }
    }
}
