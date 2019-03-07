using System.Collections.Generic;
using System.Linq;
using StarterProject.Api.Data;
using StarterProject.Api.Data.Entites;

namespace StarterProject.Api.Features.Languages
{
    public interface ILanguageRepository
    {
       
        List<LanguageGetDto> GetAllLanguages();

    }

    public class LanguageRepository : ILanguageRepository
    {
        private readonly DataContext _language;

        public LanguageRepository(DataContext context)
        {
            _language = context;
        }

        public List<LanguageGetDto> GetAllLanguages()
        {
            return _language
                .Set<Language>()
                .Select(x => new LanguageGetDto()
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToList();

        }
    }

     
}

