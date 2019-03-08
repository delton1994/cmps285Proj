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
        private readonly DataContext _choice;

        public ChoiceRepository(DataContext context)
        {
            _choice = context;
        }


        public List<ChoiceGetDto> GetAllChoices()
        {
            return _choice
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