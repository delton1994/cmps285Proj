using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StarterProject.Api.Data.Entites
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }


        public string Name { get; set; }
        public List<Question> Questions { get; set; }


    }
}