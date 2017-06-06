namespace ScrumPoker.Models
{
    public class ScrumPokerResult<T> where T : class, new()
    {
        public bool Success { get; set; }
        public T Result { get; set; }
        public string Error { get; set; }
    }
}