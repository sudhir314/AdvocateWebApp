using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvocateWebApp.Models
{
    [Table("PracticeAreaServices")]
    public class PracticeAreaService
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Slug is required")]
        [StringLength(150)]
        public string Slug { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(200)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Category Name is required")]
        [StringLength(100)]
        public string CategoryName { get; set; }

        public int DisplayOrder { get; set; } = 0;

        [StringLength(500)]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "Full Content is required")]
        public string FullContent { get; set; }

        [StringLength(300)]
        public string BannerImageUrl { get; set; }

        [StringLength(300)]
        public string ThumbnailImageUrl { get; set; }

        [StringLength(300)]
        public string PDFDocumentUrl { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsFeatured { get; set; } = false;

        // SEO Metadata Fields
        [StringLength(150)]
        public string MetaTitle { get; set; }

        [StringLength(300)]
        public string MetaDescription { get; set; }

        [StringLength(250)]
        public string MetaKeywords { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? UpdatedDate { get; set; }
    }
}