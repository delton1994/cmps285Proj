using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarterProject.Api.Data.Entites
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }
      //  public Language Language { get; set;}
        public List<Choice> Choices { get; set; }
        
    }
    // get the 
    public class QuestionGetDto
    {
        public string Name { get; set; }
        public int LanguageId { get; set; }
      //  public List<> Choices { get; set; }
    }
}
