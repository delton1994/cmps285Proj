namespace StarterProject.Api.Data.Entites
{
    public class Choice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAnswer { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }

    public class ChoiceGetDto
    {
        public int QuestionId { get; set; }
        public string Name { get; set; }
        public bool IsAnswer { get; set; }
    }
}
