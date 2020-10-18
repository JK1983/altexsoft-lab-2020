using SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities
{
    public class Ingridient : BaseEntity
    {
        public int Name { get; set; }
        public string Description { get; set; }
        public List<IngridientRecipe> IngidientRecipe { get; set; } = new List<IngridientRecipe>(); //I don't need it 
    }
}

