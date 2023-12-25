using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookWorm.DataAccess.Data.DTOs
{
    public class UpdateRequestDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Value must be between 1 and 100")]
        public int DisplayOrder { get; set; }
    }
}
