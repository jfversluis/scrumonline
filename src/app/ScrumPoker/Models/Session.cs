namespace ScrumPoker.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPrivate { get; set; }
        public int MemberCount { get; set; }
    }
}