using System.Collections.Generic;
using System.Linq;
using StarterProject.Api.Data;
using StarterProject.Api.Data.Entites;

namespace StarterProject.Api.Features.Choices
{
    public interface IChoiceRepository
    {
        List<ChoiceGetDto> GetAllChoices();
    }

    public class ChoiceRepository : IChoiceRepository
    {
        private readonly DataContext _context;

        public ChoiceRepository(DataContext context)
        {
            _context = context;
        }

        public List<ChoiceGetDto> GetAllChoices()
        {
            return _context
                .Set<Choice>()
                .Select(x => new ChoiceGetDto()
                {
                    QuestionId = x.QuestionId,
                    Name = x.Name
                })
                .ToList();
        }


    }
}