using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvocateWebApp.Models
{
    [Table("InsightArticles")]
    public class InsightArticle
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Slug is required")]
        [StringLength(150)]
        public string Slug { get; set; } = string.Empty;

        [Required(ErrorMessage = "Title is required")]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category Name is required")]
        [StringLength(100)]
        public string CategoryName { get; set; } = string.Empty; // e.g., "Law Students Corner", "Knowledge Centre"

        [StringLength(100)]
        public string SubCategory { get; set; } = string.Empty; // e.g., "Article Publication", "Bail Guides"

        [StringLength(150)]
        public string AuthorName { get; set; } = "Advocate Editorial Team";

        public int DisplayOrder { get; set; } = 0;

        [StringLength(500)]
        public string? ShortDescription { get; set; }

        [Required(ErrorMessage = "Full Content is required")]
        public string FullContent { get; set; } = string.Empty;

        // Marked as string? so saving paths/URLs to wwwroot is optional and nullable
        [StringLength(300)]
        public string? BannerImageUrl { get; set; }

        [StringLength(300)]
        public string? ThumbnailImageUrl { get; set; }

        [StringLength(300)]
        public string? PDFDocumentUrl { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsFeatured { get; set; } = false; // For pinning important articles

        public int ViewCount { get; set; } = 0; // Tracks article readership popularity

        [StringLength(150)]
        public string? MetaTitle { get; set; }

        [StringLength(300)]
        public string? MetaDescription { get; set; }

        [StringLength(250)]
        public string? MetaKeywords { get; set; }

        public DateTime PublishedDate { get; set; } = DateTime.Now;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? UpdatedDate { get; set; }
    }
}