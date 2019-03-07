using System.Collections.Generic;
using System.Linq;
using StarterProject.Api.Data;
using StarterProject.Api.Data.Entites;

namespace StarterProject.Api.Features.Questions
{
    public interface IQuestionRepository
    {
      
        List<QuestionGetDto> GetAllQuestions();

    }

    public class QuestionRepository : IQuestionRepository
    {
        private readonly DataContext _question;

        public QuestionRepository(DataContext context)
        {
            _question = context;
        }



        public List<QuestionGetDto> GetAllQuestions()
        {
            return _question
                .Set<Question>()
                .Select(x => new QuestionGetDto()
                {
                    Name = x.Name,
                    LanguageId = x.LanguageId
                })
                .ToList();
        }


    }
}
