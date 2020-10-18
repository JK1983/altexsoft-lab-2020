using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities
{
    public class IngridientRecipe
    {
        public int IngridientId { get; set; }
        public Ingridient Ingridient { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
