using StarterProject.Api.Features.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace StarterProject.Api.Data.Entites
{
    public class UserResult
    {
        [Key]
        public int UserId { get; set; }
        public int LanguageId { get; set; }
        public int Result { get; set; }
        public int CorrectAnswer { get; set; }
        public int IncorrectAnswer { get; set; }
    }

    public class UserResultDto
    {
        public int UserId { get; set; }
        public int LanguageId { get; set; }
        public int Result { get; set; }
        public int CorrectAnswer { get; set; }
        public int IncorrectAnswer { get; set; }
    }

    public class UserCreateResultDto
    {
        public int LanguageId { get; set; }
        public int Result { get; set; }
        public int CorrectAnswer { get; set; }
        public int IncorrectAnswer { get; set; }
    }

    //add LanguageId and factor in query for language id
}
