using StarterProject.Api.Features.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarterProject.Api.Data.Entites
{
    public class UserResult
    {
        [Key]
        public int ResultId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int Result { get; set; }
        public int CorrectAnswer { get; set; }
        public int IncorrectAnswer { get; set; }
    }

    public class UserResultDto
    {
        public int UserId { get; set; }
        public int Result { get; set; }
        public int CorrectAnswer { get; set; }
        public int IncorrectAnswer { get; set; }
    }

    public class UserCreateResultDto
    {
        public int Result { get; set; }
        public int CorrectAnswer { get; set; }
        public int IncorrectAnswer { get; set; }
    }
}
