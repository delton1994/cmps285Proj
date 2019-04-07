using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StarterProject.Api.Data;
using StarterProject.Api.Data.Entites;

namespace StarterProject.Api.Features.Questions
{
    public interface IQuestionRepository
    {
       List<QuestionGetDto> GetAllQuestions();
       List<QuestionGetDto> GetAllQuestions(int languageId);
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
            return _context
                .Set<Question>()
                 .Select(x => new QuestionGetDto()
                {
                    Name = x.Name,
                    LanguageId = x.LanguageId,
                    Choices = x.Choices.Select(r => new ChoiceGetDto()
                        {
                            Name = r.Name,
                            QuestionId = x.Id,
                            IsAnswer = r.IsAnswer

                        })
                        .ToList()
                  })
                  .ToList();
                  
        public List<QuestionGetDto> GetAllQuestions(int languageId)
        {
            var questionQuery = _context.Set<Question>().AsQueryable();

            if (languageId > 0)
            {
                questionQuery = questionQuery.Where(x => x.LanguageId == languageId);
            }

            var result = questionQuery
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
            return result;
        }
    }
}
