using System.Collections.Generic;

namespace StarterProject.Api.Data.Entites
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Choice> Choices { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set;}
    }

    public class QuestionGetDto 
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public List<ChoiceGetDto> Choices { get; set; }
    }
}
