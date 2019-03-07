using System.Collections.Generic;
using System.Linq;
using StarterProject.Api.Data;
using StarterProject.Api.Data.Entites;

namespace StarterProject.Api.Features.Languages
{
    public interface ILanguageRepository
    {
        IEnumerable<Language> GetAllLanguages();
        List<Language> GetLanguagesByName(string name);

    }

    public class LanguageRepository : ILanguageRepository
    {
        private readonly DataContext _language;

        public LanguageRepository(DataContext context)
        {
            _language = context;
        }

        public IEnumerable<Language> GetAllLanguages()
        {
            return _language.Languages
                .ToList();
        }

        public List<Language> GetLanguagesByName(string name)
        {
            return _language.Languages
                .Where(p => p.Name == name)
                .ToList();
        }

     
    }
}