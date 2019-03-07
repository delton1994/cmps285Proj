using System.Collections.Generic;
using System.Linq;
using StarterProject.Api.Data;
using StarterProject.Api.Data.Entites;

namespace StarterProject.Api.Features.Choices
{
    public interface IChoiceRepository
    {
        IEnumerable<Choice> GetAllChoices();
        List<Choice> GetChoicesByName(string name);

    }

    public class ChoiceRepository : IChoiceRepository
    {
        private readonly DataContext _choice;

        public ChoiceRepository(DataContext context)
        {
            _choice = context;
        }

        public IEnumerable<Choice> GetAllChoices()
        {
            return _choice.Choices
                .OrderBy(p => p.QuestionId)
                .ToList();
        }

        public List<Choice> GetChoicesByName(string name)
        {
            return _choice.Choices
                .Where(p => p.Name == name)
                .ToList();
        }


    }
}