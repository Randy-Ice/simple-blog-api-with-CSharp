namespace simple_blog_api_with_C_.Models.DTOs
{
    public class AllBlogsDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        //public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
