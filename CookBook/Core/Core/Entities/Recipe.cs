using SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities
{
    public class Recipe : BaseEntity
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public List<IngridientRecipe> IngidientRecipe { get; set; } = new List<IngridientRecipe>(); //I'd like to have List<Ingridient> here
        public List<Step> Steps { get; set; } = new List<Step>();
    }
}
