using System.Collections.Generic;
using System.Linq;
using StarterProject.Api.Data;
using StarterProject.Api.Data.Entites;

namespace StarterProject.Api.Features.Questions
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetAllQuestions();
        List<Question> GetQuestionsByName(string name);

    }

    public class QuestionRepository : IQuestionRepository
    {
        private readonly DataContext _question;

        public QuestionRepository(DataContext context)
        {
            _question = context;
        }

        public IEnumerable<Question> GetAllQuestions()
        {
            return _question.Questions
                .OrderBy(p => p.LanguageId)
                .ToList();
        }

        public List<Question> GetQuestionsByName(string name)
        {
            return _question.Questions
                .Where(p => p.Name == name)
                .ToList();
        }


    }
}
