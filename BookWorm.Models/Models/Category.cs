﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookWorm.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Length(3, 30)]
        [DisplayName("Name")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Display Order")]
        [Range(1, 100)]
        public int DisplayOrder { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime DeletedAt { get; set; } = DateTime.UtcNow;

    }
}
