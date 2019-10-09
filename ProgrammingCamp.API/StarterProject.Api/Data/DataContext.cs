using System;
using Microsoft.EntityFrameworkCore;
using StarterProject.Api.Common;
using StarterProject.Api.Features.Users;
using StarterProject.Api.Security;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StarterProject.Api.Data.Entites;

namespace StarterProject.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Choice> Choices { get; set; }
        public DbSet<UserResult> UserResults { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var passwordHasher = new PasswordHash("admin");
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Role = Constants.Users.Roles.Admin,
                    Username = "admin",
                    Email = "admin@admin.com",
                    FirstName = "Seeded-Admin-FirstName",
                    LastName = "Seeded-Admin-LastName",
                    PasswordHash = passwordHasher.Hash,
                    PasswordSalt = passwordHasher.Salt,

                }
            );
            var passwordHasher1 = new PasswordHash(password: "Kimber1994@");
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 2,
                    Role = Constants.Users.Roles.Admin,
                    Username = "Delton94",
                    Email = "delton_w@yahoo.com",
                    FirstName = "Delton",
                    LastName = "Watkins",
                    PasswordHash = passwordHasher1.Hash,
                    PasswordSalt = passwordHasher1.Salt,

                }
            );

            modelBuilder.Entity<Language>().HasData(
                new List<Language>()
                {
                    new Language {Name = " JavaScript", Id = 1},
                    new Language {Name = "Html", Id = 2},
                    new Language {Name = "Java", Id = 3},
                    new Language {Name = "C#", Id = 4}
                }
            );
            modelBuilder.Entity<Question>().HasData(
                new List<Question>
                {
                    new Question {Name = "What is JavaScript?", Id = 1, LanguageId = 1},
                    new Question {Name = "Is JavaScript used for web development?", Id = 2, LanguageId = 1},
                    new Question {Name = "Are Java and JavaScript the same?", Id = 9, LanguageId = 1},
                    new Question {Name = "How long did it take to make JavaScript?", Id = 10, LanguageId = 1},
                    new Question {Name = "What company made JavaScript?", Id = 11, LanguageId = 1},
                    new Question {Name = "Is javascript frontend, backend or full stack?", Id = 12, LanguageId = 1},
                    new Question {Name = "How do you make a comment in JavaScript?", Id = 13, LanguageId = 1},
                    new Question {Name = "What does Html mean?", Id = 3, LanguageId = 2},
                    new Question {Name = "What is one use for Html?", Id = 4, LanguageId = 2},
                    new Question {Name = "When was HTML first developed?", Id = 14, LanguageId = 2},
                    new Question {Name = "Who developed HTML?", Id = 15, LanguageId = 2},
                    new Question {Name = "When was HTML5 released?", Id = 16, LanguageId = 2},
                    new Question {Name = "What companies maintain HTML?", Id = 17, LanguageId = 2},
                    new Question {Name = "Do all HTML tags need to come in pairs?", Id = 18, LanguageId = 2},
                    new Question {Name = "How do you insert a comment in HTML?", Id = 19, LanguageId = 2},
                    new Question {Name = "What is Java?", Id = 5, LanguageId = 3},
                    new Question {Name = "How do you receive input from a user in Java?", Id = 6, LanguageId = 3},
                    new Question {Name = "What was the original purpose for Java?", Id = 20, LanguageId = 3},
                    new Question {Name = "What was Java originally called?", Id = 21, LanguageId = 3},
                    new Question {Name = "When was the first version released?", Id = 22, LanguageId = 3},
                    new Question {Name = "How many platforms does Java have?", Id = 23, LanguageId = 3},
                    new Question {Name = "Who invented Java?", Id = 24, LanguageId = 3},
                    new Question {Name = "How do you comment in Java?", Id = 25, LanguageId = 3},
                    new Question {Name = "What is C#?", Id = 7, LanguageId = 4},
                    new Question {Name = "How do you declare a variable in C#?", Id = 8, LanguageId = 4},
                    new Question {Name = "What company made C# and when?", Id = 26, LanguageId = 4},
                    new Question {Name = "What was the purpose of creating C#?", Id =27, LanguageId = 4},
                    new Question {Name = "What was the initial name for C#?", Id = 28, LanguageId = 4},
                    new Question {Name = "What was C# named after?", Id = 29, LanguageId = 4},
                    new Question {Name = "Can you have a try without a catch statement in C#?", Id = 30, LanguageId = 4},
                    new Question {Name = "How do you comment in C#?", Id = 31, LanguageId = 4},
                }
            );

            modelBuilder.Entity<Choice>().HasData(
                new List<Choice>
                {
                    new Choice
                    {
                        Name = "JavaScript is the programming language of Html and the Web.", Id = 1, QuestionId = 1,
                        IsAnswer = true
                    },
                    new Choice
                    {
                        Name = "JavaScript is an excerpt from The Raven.", Id = 2, QuestionId = 1, IsAnswer = false
                    },
                    new Choice {Name = "JavaScript is a musical play.", Id = 3, QuestionId = 1, IsAnswer = false},
                    new Choice
                    {
                        Name = "JavaScript is  the name of a pharmacy ", Id = 4, QuestionId = 1, IsAnswer = false
                    },
                    new Choice {Name = "Yes", Id = 5, QuestionId = 2, IsAnswer = true},
                    new Choice {Name = "No", Id = 6, QuestionId = 2, IsAnswer = false},
                    new Choice {Name = "Maybe", Id = 7, QuestionId = 2, IsAnswer = false},
                    new Choice {Name = "I dont know", Id = 8, QuestionId = 2, IsAnswer = false},
                    new Choice {Name = "Hypertext Markup Language", Id = 9, QuestionId = 3, IsAnswer = true},
                    new Choice {Name = "Hyper Time-Machine Lasso", Id = 10, QuestionId = 3, IsAnswer = false},
                    new Choice {Name = "Huge Text-Maker Language", Id = 11, QuestionId = 3, IsAnswer = false},
                    new Choice {Name = "Hungry Taffy-Maker Laughing", Id = 12, QuestionId = 3, IsAnswer = false},
                    new Choice {Name = "To create a web page", Id = 13, QuestionId = 4, IsAnswer = true},
                    new Choice {Name = "To do some homework", Id = 14, QuestionId = 4, IsAnswer = false},
                    new Choice {Name = "To clean the house ", Id = 15, QuestionId = 4, IsAnswer = false},
                    new Choice {Name = "To be or not to be", Id = 16, QuestionId = 4, IsAnswer = false},
                    new Choice
                    {
                        Name = "A general purpose computer programing language", Id = 17, QuestionId = 5,
                        IsAnswer = true
                    },
                    new Choice {Name = "A mutlimedia outlet", Id = 18, QuestionId = 5, IsAnswer = false},
                    new Choice {Name = "A race car", Id = 19, QuestionId = 5, IsAnswer = false},
                    new Choice {Name = "A type of drink", Id = 20, QuestionId = 5, IsAnswer = false},
                    new Choice
                    {
                        Name = "Scanner input = new Scanner(System.in);", Id = 21, QuestionId = 6, IsAnswer = true
                    },
                    new Choice {Name = "Scanner = int Scanner;", Id = 22, QuestionId = 6, IsAnswer = false},
                    new Choice {Name = "Scan user input data", Id = 23, QuestionId = 6, IsAnswer = false},
                    new Choice {Name = "System.out.println(input);", Id = 24, QuestionId = 6, IsAnswer = false},
                    new Choice
                    {
                        Name =
                            "A mutliparadigm powerful programming language which uses features such as strong typing",
                        Id = 25, QuestionId = 7, IsAnswer = true
                    },
                    new Choice
                    {
                        Name = "A noise you make when you stub your toe", Id = 26, QuestionId = 7, IsAnswer = false
                    },
                    new Choice {Name = "The sound of Screeching", Id = 27, QuestionId = 7, IsAnswer = false},
                    new Choice {Name = "A musical note", Id = 28, QuestionId = 7, IsAnswer = false},
                    new Choice {Name = "variable", Id = 29, QuestionId = 8, IsAnswer = false},
                    new Choice {Name = "int variable", Id = 30, QuestionId = 8, IsAnswer = false},
                    new Choice {Name = "var", Id = 31, QuestionId = 8, IsAnswer = true},
                    new Choice {Name = "int var", Id = 32, QuestionId = 8, IsAnswer = false},

                    new Choice {Name = "No", Id = 33, QuestionId = 9, IsAnswer = true},
                    new Choice {Name = "Ten days for version 1", Id = 34, QuestionId = 10, IsAnswer =true},
                    new Choice {Name = "Netscape", Id = 35, QuestionId = 11, IsAnswer = true},
                    new Choice {Name = "FullStack", Id = 36, QuestionId = 12, IsAnswer = true},
                    new Choice {Name = "//comment", Id = 37, QuestionId = 13, IsAnswer = true},
                    new Choice {Name = "1990", Id = 38, QuestionId = 14, IsAnswer = true},
                    new Choice {Name = "Tim Berbers-Lee", Id = 39, QuestionId = 15, IsAnswer = true},
                    new Choice {Name = "Released in 2008", Id = 40, QuestionId = 16, IsAnswer = true},
                    new Choice {Name = "w3c and WHATWG", Id = 41, QuestionId = 17, IsAnswer = true},
                    new Choice {Name = "NO", Id = 42, QuestionId = 18, IsAnswer = true},
                    new Choice {Name = "<!--Comment-->", Id = 43, QuestionId = 19, IsAnswer = true},
                    new Choice {Name = "Originally designed for interactive television, but was too advanced", Id = 44, QuestionId = 20, IsAnswer = true},
                    new Choice {Name = "Originally called Oak, after the tree", Id = 45, QuestionId = 21, IsAnswer = true},
                    new Choice {Name = "First version released in 1996 ", Id = 46, QuestionId = 22, IsAnswer =true},
                    new Choice {Name = "4 platforms", Id = 47, QuestionId = 23, IsAnswer = true},
                    new Choice {Name = "James Gosling invented Java", Id = 48, QuestionId = 24, IsAnswer = true},
                    new Choice {Name = "//comment", Id = 49, QuestionId = 25, IsAnswer = true},
                    new Choice {Name = "Made by Microsoft in 2000", Id = 50, QuestionId = 26, IsAnswer = true},
                    new Choice {Name = "intended to be a modern simple, general purpose language", Id = 51, QuestionId = 27, IsAnswer = true},
                    new Choice {Name = "Originally named COOL (C-like Object Oriented Language)", Id = 52, QuestionId = 28, IsAnswer = true},
                    new Choice {Name = "Named after the musical notation", Id = 53, QuestionId = 29, IsAnswer = true},
                    new Choice {Name = "Yes", Id = 54, QuestionId = 30, IsAnswer = true},
                    new Choice {Name = "//comment", Id = 55, QuestionId = 31, IsAnswer = true},
                }
            );  
        }
        public DbSet<UserResult> UserResult { get; set; }
            

        
    }
}

