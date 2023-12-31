using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookWorm.Models.ViewModels
{
    public class CategoryVM
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Length(3, 30)]
        [DisplayName("Name")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Display Order")]
        [Range(1, 100)]
        public int DisplayOrder { get; set; }
    }
}
