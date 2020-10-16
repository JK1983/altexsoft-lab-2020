using SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities
{
    public class Step : BaseEntity
    {
        [Required]
        public int RecipeId { get; set; }
        [Required]
        public int OrderNum { get; set; }
        [MaxLength(512)]
        public string Description { get; set; }
    }
}
