using SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities
{
    public class Step : BaseEntity
    {
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } //I don't need it
        public int OrderNum { get; set; }
        public string Description { get; set; }
    }
}
