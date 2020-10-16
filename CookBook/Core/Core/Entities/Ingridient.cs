using SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities
{
    public class Ingidient : BaseEntity
    {
        [MaxLength(128)]
        public int Name { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}
