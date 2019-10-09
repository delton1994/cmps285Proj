using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class AddedUserResults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Result = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserResults_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 79, 222, 177, 170, 138, 247, 109, 192, 115, 134, 146, 149, 117, 54, 185, 68, 139, 27, 157, 212 }, new byte[] { 229, 56, 244, 109, 28, 23, 144, 179, 118, 241, 95, 243, 124, 26, 96, 68 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 22, 98, 14, 24, 53, 192, 174, 166, 26, 49, 74, 247, 96, 198, 183, 94, 146, 4, 245, 51 }, new byte[] { 244, 66, 48, 219, 228, 56, 81, 57, 5, 255, 76, 222, 15, 0, 47, 50 } });

            migrationBuilder.CreateIndex(
                name: "IX_UserResults_UserId",
                table: "UserResults",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserResults");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 153, 21, 170, 54, 71, 111, 248, 17, 1, 147, 113, 179, 227, 139, 21, 113, 244, 5, 46, 201 }, new byte[] { 126, 176, 228, 27, 172, 213, 157, 92, 158, 35, 40, 194, 93, 246, 95, 78 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 230, 182, 78, 141, 82, 177, 86, 88, 200, 156, 238, 60, 5, 158, 78, 3, 95, 66, 108, 74 }, new byte[] { 165, 178, 219, 232, 222, 146, 78, 75, 27, 65, 141, 40, 212, 44, 10, 100 } });
        }
    }
}
