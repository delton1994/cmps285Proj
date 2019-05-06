using StarterProject.Api.Features.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace StarterProject.Api.Data.Entites
{

    public class UserResult
    {
        public UserResult()
        {
            IsDeleted = false;
        }

        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LanguageId { get; set; }
        public int Result { get; set; }
        public bool IsDeleted { get; set; }
        public int CorrectAnswer { get; set; }
        public int IncorrectAnswer { get; set; }
    }

    public class UserResultDto
    {
        public UserResultDto()
        {
            IsDeleted = false;
        }
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int ResultId { get; set; }
        public int Result { get; set; }
        public bool IsDeleted { get; set; }
        public int CorrectAnswer { get; set; }
        public int IncorrectAnswer { get; set; }
        
    }

    public class UserCreateResultDto
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int Result { get; set; }
        public int CorrectAnswer { get; set; }
        public int IncorrectAnswer { get; set; }
    }
}
