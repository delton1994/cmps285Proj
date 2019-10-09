using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class NewQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "LanguageId", "Name" },
                values: new object[,]
                {
                    { 9, 1, "Are Java and JavaScript the same?" },
                    { 31, 4, "How do you comment in C#?" },
                    { 30, 4, "Can you have a try without a catch statement in C#?" },
                    { 29, 4, "What was C# named after?" },
                    { 28, 4, "What was the initial name for C#?" },
                    { 27, 4, "What was the purpose of creating C#?" },
                    { 26, 4, "What company made C# and when?" },
                    { 25, 3, "How do you comment in Java?" },
                    { 24, 3, "Who invented Java?" },
                    { 23, 3, "How many platforms does Java have?" },
                    { 22, 3, "When was the first version released?" },
                    { 21, 3, "What was Java originally called?" },
                    { 19, 2, "How do you insert a comment in HTML?" },
                    { 18, 2, "Do all HTML tags need to come in pairs?" },
                    { 17, 2, "What companies maintain HTML?" },
                    { 16, 2, "When was HTML5 released?" },
                    { 15, 2, "Who developed HTML?" },
                    { 14, 2, "When was HTML first developed?" },
                    { 13, 1, "How do you make a comment in JavaScript?" },
                    { 12, 1, "Is javascript frontend, backend or full stack?" },
                    { 11, 1, "What company made JavaScript?" },
                    { 10, 1, "How long did it take to make JavaScript?" },
                    { 20, 3, "What was the original purpose for Java?" }
                });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "IsAnswer", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 33, true, "No", 9 },
                    { 53, true, "Named after the musical notation", 29 },
                    { 52, true, "Originally named COOL (C-like Object Oriented Language)", 28 },
                    { 51, true, "intended to be a modern simple, general purpose language", 27 },
                    { 50, true, "Made by Microsoft in 2000", 26 },
                    { 49, true, "//comment", 25 },
                    { 48, true, "James Gosling invented Java", 24 },
                    { 47, true, "4 platforms", 23 },
                    { 46, true, "First version released in 1996 ", 22 },
                    { 45, true, "Originally called Oak, after the tree", 21 },
                    { 54, true, "Yes", 30 },
                    { 44, true, "Originally designed for interactive television, but was too advanced", 20 },
                    { 42, true, "NO", 18 },
                    { 41, true, "w3c and WHATWG", 17 },
                    { 40, true, "Released in 2008", 16 },
                    { 39, true, "Tim Berbers-Lee", 15 },
                    { 38, true, "1990", 14 },
                    { 37, true, "//comment", 13 },
                    { 36, true, "FullStack", 12 },
                    { 35, true, "Netscape", 11 },
                    { 34, true, "Ten days for version 1", 10 },
                    { 43, true, "<!--Comment-->", 19 },
                    { 55, true, "//comment", 31 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Choices");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
