namespace LibraryAPI.Entities
{
    public class Book
    {
        public string BookId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int PageCount { get; set; }
        public int YearPublished { get; set; }
    }
}
