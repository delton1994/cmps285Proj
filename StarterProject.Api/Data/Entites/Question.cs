using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarterProject.Api.Data.Entites
{
    public class Question
    {
     
        public int LanguageId { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public Language Language { get; set;}
        public List<Choice> Choices { get; set; }
       
        
        
    }
}
