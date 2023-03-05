using Microsoft.Build.Framework;

namespace FineBlog.ViewModels
{
    public class PageVM
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        public string? Description { get; set; }
        public string? ThumbnailUrl { get; set; }
        public IFormFile? Thumbnail { get; set; }
    }
}
