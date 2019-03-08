using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class addingLangauagequestionsChoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Choices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IsAnswer = table.Column<bool>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Choices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Choices_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, " JavaScript" },
                    { 2, "Html" },
                    { 3, "Java" },
                    { 4, "C#" }
                });

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

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "LanguageId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "What is JavaScript?" },
                    { 2, 1, "Is JavaScript used for web development?" },
                    { 3, 2, "What does Html mean?" },
                    { 4, 2, "What is one use for Html?" },
                    { 5, 3, "What is Java?" },
                    { 6, 3, "How do you receive input from a user in Java?" },
                    { 7, 4, "What is C#?" },
                    { 8, 4, "How do you declare a variable in C#?" }
                });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "IsAnswer", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 1, true, "JavaScript is the programming language of Html and the Web.", 1 },
                    { 30, false, "int variable", 8 },
                    { 29, false, "variable", 8 },
                    { 28, false, "A musical note", 7 },
                    { 27, false, "The sound of Screeching", 7 },
                    { 26, false, "A noise you make when you stub your toe", 7 },
                    { 25, true, "A mutliparadigm powerful programming language which uses features such as strong typing", 7 },
                    { 24, false, "System.out.println(input);", 6 },
                    { 23, false, "Scan user input data", 6 },
                    { 22, false, "Scanner = int Scanner;", 6 },
                    { 21, true, "Scanner input = new Scanner(System.in);", 6 },
                    { 20, false, "A type of drink", 5 },
                    { 19, false, "A race car", 5 },
                    { 18, false, "A mutlimedia outlet", 5 },
                    { 17, true, "A general purpose computer programing language", 5 },
                    { 16, false, "To be or not to be", 4 },
                    { 15, false, "To clean the house ", 4 },
                    { 14, false, "To do some homework", 4 },
                    { 13, true, "To create a web page", 4 },
                    { 12, false, "Hungry Taffy-Maker Laughing", 3 },
                    { 11, false, "Huge Text-Maker Language", 3 },
                    { 10, false, "Hyper Time-Machine Lasso", 3 },
                    { 9, true, "Hypertext Markup Language", 3 },
                    { 8, false, "I dont know", 2 },
                    { 7, false, "Maybe", 2 },
                    { 6, false, "No", 2 },
                    { 5, true, "Yes", 2 },
                    { 4, false, "JavaScript is  the name of a pharmacy ", 1 },
                    { 3, false, "JavaScript is a musical play.", 1 },
                    { 2, false, "JavaScript is an excerpt from The Raven.", 1 },
                    { 31, true, "var", 8 },
                    { 32, false, "int var", 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Choices_QuestionId",
                table: "Choices",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_LanguageId",
                table: "Questions",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Choices");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 200, 4, 247, 197, 7, 4, 213, 133, 199, 228, 100, 211, 148, 8, 186, 157, 36, 166, 40 }, new byte[] { 229, 173, 211, 167, 209, 178, 125, 29, 42, 75, 36, 28, 60, 191, 205, 35 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 112, 142, 194, 124, 44, 203, 219, 67, 22, 207, 136, 107, 90, 243, 184, 213, 61, 115, 167, 170 }, new byte[] { 94, 109, 228, 224, 25, 29, 178, 179, 105, 161, 153, 224, 13, 99, 161, 27 } });
        }
    }
}
