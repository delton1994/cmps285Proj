using System.Collections.Generic;
using System.Linq;
using StarterProject.Api.Data;
using StarterProject.Api.Data.Entites;
using StarterProject.Api.Features;

namespace StarterProject.Api.Features.Questions
{
    public interface IQuestionRepository
    {
       List<QuestionGetDto> GetAllQuestions();
    }

    public class QuestionRepository : IQuestionRepository
    {
        private readonly DataContext _context;

        public QuestionRepository(DataContext context)
        {
            _context = context;
        }

        public List<QuestionGetDto> GetAllQuestions()
        {
            return _context.Set<Question>()
                .Select(x => new QuestionGetDto()
                {
                    LanguageId = x.LanguageId,
                    Name = x.Name,
                    Choices = x.Choices.Select(r => new ChoiceGetDto()
                    { 
                         Name = r.Name,
                         QuestionId = x.Id,
                         IsAnswer = r.IsAnswer
                    })
                  .ToList()
                })
                .ToList();

        }


    }
}
