using StarterProject.Api.Features.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterProject.Api.Data.Entites
{
    public class UserResult
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LanguageId { get; set; }
        public int Result { get; set; }
        public int AnswerCorrect { get; set; }
        public int AnswersIncorrect { get; set; }
    }
}
