#region snippet
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TodoApi.Models
{
    [Table("Products")]
    public class TodoItem
    {
        [Key]
        public long Id { get; set; }
        
        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName ="bigint")]
        public long CategoryId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(1000)]
        public string ManufacturerUrl { get; set; }

        [StringLength(1000)]
        public string ImageUrl { get; set; }

        [Required]
        [Column(TypeName = "Money")]
        public decimal Price { get; set; }
    }
}
#endregion