﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarterProject.Api.Data;

namespace StarterProject.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
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
                            Id = 7,
                            LanguageId = 4,
                            Name = "What is C#?"
                        },
                        new
                        {
                            Id = 8,
                            LanguageId = 4,
                            Name = "How do you declare a variable in C#?"
                        });
                });

            modelBuilder.Entity("StarterProject.Api.Data.Entites.UserResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CorrectAnswer");

                    b.Property<int>("IncorrectAnswer");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("LanguageId");

                    b.Property<int>("Result");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserResult");
                });

            modelBuilder.Entity("StarterProject.Api.Features.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Role");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@admin.com",
                            FirstName = "Seeded-Admin-FirstName",
                            LastName = "Seeded-Admin-LastName",

                            PasswordHash = new byte[] { 155, 72, 245, 72, 64, 109, 133, 79, 176, 154, 172, 168, 181, 30, 21, 75, 217, 70, 134, 112 },
                            PasswordSalt = new byte[] { 124, 237, 105, 103, 235, 63, 40, 219, 231, 235, 228, 18, 230, 196, 190, 93 },

                            Role = "Admin",
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "delton_w@yahoo.com",
                            FirstName = "Delton",
                            LastName = "Watkins",

                            PasswordHash = new byte[] { 162, 206, 178, 98, 220, 151, 127, 144, 197, 121, 192, 252, 104, 20, 73, 228, 217, 172, 99, 227 },
                            PasswordSalt = new byte[] { 127, 117, 10, 120, 116, 128, 82, 182, 212, 46, 175, 90, 43, 41, 217, 163 },

                            Role = "Admin",
                            Username = "Delton94"
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
