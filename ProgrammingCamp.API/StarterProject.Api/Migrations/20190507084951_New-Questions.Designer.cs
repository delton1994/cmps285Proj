﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarterProject.Api.Data;

namespace StarterProject.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190507084951_New-Questions")]
    partial class NewQuestions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StarterProject.Api.Data.Entites.Choice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsAnswer");

                    b.Property<string>("Name");

                    b.Property<int>("QuestionId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Choices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsAnswer = true,
                            Name = "JavaScript is the programming language of Html and the Web.",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            IsAnswer = false,
                            Name = "JavaScript is an excerpt from The Raven.",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 3,
                            IsAnswer = false,
                            Name = "JavaScript is a musical play.",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 4,
                            IsAnswer = false,
                            Name = "JavaScript is  the name of a pharmacy ",
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 5,
                            IsAnswer = true,
                            Name = "Yes",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 6,
                            IsAnswer = false,
                            Name = "No",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 7,
                            IsAnswer = false,
                            Name = "Maybe",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 8,
                            IsAnswer = false,
                            Name = "I dont know",
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 9,
                            IsAnswer = true,
                            Name = "Hypertext Markup Language",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 10,
                            IsAnswer = false,
                            Name = "Hyper Time-Machine Lasso",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 11,
                            IsAnswer = false,
                            Name = "Huge Text-Maker Language",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 12,
                            IsAnswer = false,
                            Name = "Hungry Taffy-Maker Laughing",
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 13,
                            IsAnswer = true,
                            Name = "To create a web page",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 14,
                            IsAnswer = false,
                            Name = "To do some homework",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 15,
                            IsAnswer = false,
                            Name = "To clean the house ",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 16,
                            IsAnswer = false,
                            Name = "To be or not to be",
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 17,
                            IsAnswer = true,
                            Name = "A general purpose computer programing language",
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 18,
                            IsAnswer = false,
                            Name = "A mutlimedia outlet",
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 19,
                            IsAnswer = false,
                            Name = "A race car",
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 20,
                            IsAnswer = false,
                            Name = "A type of drink",
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 21,
                            IsAnswer = true,
                            Name = "Scanner input = new Scanner(System.in);",
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 22,
                            IsAnswer = false,
                            Name = "Scanner = int Scanner;",
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 23,
                            IsAnswer = false,
                            Name = "Scan user input data",
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 24,
                            IsAnswer = false,
                            Name = "System.out.println(input);",
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 25,
                            IsAnswer = true,
                            Name = "A mutliparadigm powerful programming language which uses features such as strong typing",
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 26,
                            IsAnswer = false,
                            Name = "A noise you make when you stub your toe",
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 27,
                            IsAnswer = false,
                            Name = "The sound of Screeching",
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 28,
                            IsAnswer = false,
                            Name = "A musical note",
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 29,
                            IsAnswer = false,
                            Name = "variable",
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 30,
                            IsAnswer = false,
                            Name = "int variable",
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 31,
                            IsAnswer = true,
                            Name = "var",
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 32,
                            IsAnswer = false,
                            Name = "int var",
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 33,
                            IsAnswer = true,
                            Name = "No",
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 34,
                            IsAnswer = true,
                            Name = "Ten days for version 1",
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 35,
                            IsAnswer = true,
                            Name = "Netscape",
                            QuestionId = 11
                        },
                        new
                        {
                            Id = 36,
                            IsAnswer = true,
                            Name = "FullStack",
                            QuestionId = 12
                        },
                        new
                        {
                            Id = 37,
                            IsAnswer = true,
                            Name = "//comment",
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 38,
                            IsAnswer = true,
                            Name = "1990",
                            QuestionId = 14
                        },
                        new
                        {
                            Id = 39,
                            IsAnswer = true,
                            Name = "Tim Berbers-Lee",
                            QuestionId = 15
                        },
                        new
                        {
                            Id = 40,
                            IsAnswer = true,
                            Name = "Released in 2008",
                            QuestionId = 16
                        },
                        new
                        {
                            Id = 41,
                            IsAnswer = true,
                            Name = "w3c and WHATWG",
                            QuestionId = 17
                        },
                        new
                        {
                            Id = 42,
                            IsAnswer = true,
                            Name = "NO",
                            QuestionId = 18
                        },
                        new
                        {
                            Id = 43,
                            IsAnswer = true,
                            Name = "<!--Comment-->",
                            QuestionId = 19
                        },
                        new
                        {
                            Id = 44,
                            IsAnswer = true,
                            Name = "Originally designed for interactive television, but was too advanced",
                            QuestionId = 20
                        },
                        new
                        {
                            Id = 45,
                            IsAnswer = true,
                            Name = "Originally called Oak, after the tree",
                            QuestionId = 21
                        },
                        new
                        {
                            Id = 46,
                            IsAnswer = true,
                            Name = "First version released in 1996 ",
                            QuestionId = 22
                        },
                        new
                        {
                            Id = 47,
                            IsAnswer = true,
                            Name = "4 platforms",
                            QuestionId = 23
                        },
                        new
                        {
                            Id = 48,
                            IsAnswer = true,
                            Name = "James Gosling invented Java",
                            QuestionId = 24
                        },
                        new
                        {
                            Id = 49,
                            IsAnswer = true,
                            Name = "//comment",
                            QuestionId = 25
                        },
                        new
                        {
                            Id = 50,
                            IsAnswer = true,
                            Name = "Made by Microsoft in 2000",
                            QuestionId = 26
                        },
                        new
                        {
                            Id = 51,
                            IsAnswer = true,
                            Name = "intended to be a modern simple, general purpose language",
                            QuestionId = 27
                        },
                        new
                        {
                            Id = 52,
                            IsAnswer = true,
                            Name = "Originally named COOL (C-like Object Oriented Language)",
                            QuestionId = 28
                        },
                        new
                        {
                            Id = 53,
                            IsAnswer = true,
                            Name = "Named after the musical notation",
                            QuestionId = 29
                        },
                        new
                        {
                            Id = 54,
                            IsAnswer = true,
                            Name = "Yes",
                            QuestionId = 30
                        },
                        new
                        {
                            Id = 55,
                            IsAnswer = true,
                            Name = "//comment",
                            QuestionId = 31
                        });
                });

            modelBuilder.Entity("StarterProject.Api.Data.Entites.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = " JavaScript"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Html"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Java"
                        },
                        new
                        {
                            Id = 4,
                            Name = "C#"
                        });
                });

            modelBuilder.Entity("StarterProject.Api.Data.Entites.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LanguageId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LanguageId = 1,
                            Name = "What is JavaScript?"
                        },
                        new
                        {
                            Id = 2,
                            LanguageId = 1,
                            Name = "Is JavaScript used for web development?"
                        },
                        new
                        {
                            Id = 9,
                            LanguageId = 1,
                            Name = "Are Java and JavaScript the same?"
                        },
                        new
                        {
                            Id = 10,
                            LanguageId = 1,
                            Name = "How long did it take to make JavaScript?"
                        },
                        new
                        {
                            Id = 11,
                            LanguageId = 1,
                            Name = "What company made JavaScript?"
                        },
                        new
                        {
                            Id = 12,
                            LanguageId = 1,
                            Name = "Is javascript frontend, backend or full stack?"
                        },
                        new
                        {
                            Id = 13,
                            LanguageId = 1,
                            Name = "How do you make a comment in JavaScript?"
                        },
                        new
                        {
                            Id = 3,
                            LanguageId = 2,
                            Name = "What does Html mean?"
                        },
                        new
                        {
                            Id = 4,
                            LanguageId = 2,
                            Name = "What is one use for Html?"
                        },
                        new
                        {
                            Id = 14,
                            LanguageId = 2,
                            Name = "When was HTML first developed?"
                        },
                        new
                        {
                            Id = 15,
                            LanguageId = 2,
                            Name = "Who developed HTML?"
                        },
                        new
                        {
                            Id = 16,
                            LanguageId = 2,
                            Name = "When was HTML5 released?"
                        },
                        new
                        {
                            Id = 17,
                            LanguageId = 2,
                            Name = "What companies maintain HTML?"
                        },
                        new
                        {
                            Id = 18,
                            LanguageId = 2,
                            Name = "Do all HTML tags need to come in pairs?"
                        },
                        new
                        {
                            Id = 19,
                            LanguageId = 2,
                            Name = "How do you insert a comment in HTML?"
                        },
                        new
                        {
                            Id = 5,
                            LanguageId = 3,
                            Name = "What is Java?"
                        },
                        new
                        {
                            Id = 6,
                            LanguageId = 3,
                            Name = "How do you receive input from a user in Java?"
                        },
                        new
                        {
                            Id = 20,
                            LanguageId = 3,
                            Name = "What was the original purpose for Java?"
                        },
                        new
                        {
                            Id = 21,
                            LanguageId = 3,
                            Name = "What was Java originally called?"
                        },
                        new
                        {
                            Id = 22,
                            LanguageId = 3,
                            Name = "When was the first version released?"
                        },
                        new
                        {
                            Id = 23,
                            LanguageId = 3,
                            Name = "How many platforms does Java have?"
                        },
                        new
                        {
                            Id = 24,
                            LanguageId = 3,
                            Name = "Who invented Java?"
                        },
                        new
                        {
                            Id = 25,
                            LanguageId = 3,
                            Name = "How do you comment in Java?"
                        },
                        new
                        {
                            Id = 7,
                            LanguageId = 4,
                            Name = "What is C#?"
                        },
                        new
                        {
                            Id = 8,
                            LanguageId = 4,
                            Name = "How do you declare a variable in C#?"
                        },
                        new
                        {
                            Id = 26,
                            LanguageId = 4,
                            Name = "What company made C# and when?"
                        },
                        new
                        {
                            Id = 27,
                            LanguageId = 4,
                            Name = "What was the purpose of creating C#?"
                        },
                        new
                        {
                            Id = 28,
                            LanguageId = 4,
                            Name = "What was the initial name for C#?"
                        },
                        new
                        {
                            Id = 29,
                            LanguageId = 4,
                            Name = "What was C# named after?"
                        },
                        new
                        {
                            Id = 30,
                            LanguageId = 4,
                            Name = "Can you have a try without a catch statement in C#?"
                        },
                        new
                        {
                            Id = 31,
                            LanguageId = 4,
                            Name = "How do you comment in C#?"
                        });
                });


            modelBuilder.Entity("StarterProject.Api.Data.Entites.Choice", b =>
                {
                    b.HasOne("StarterProject.Api.Data.Entites.Question", "Question")
                        .WithMany("Choices")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StarterProject.Api.Data.Entites.Question", b =>
                {
                    b.HasOne("StarterProject.Api.Data.Entites.Language", "Language")
                        .WithMany("Questions")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
