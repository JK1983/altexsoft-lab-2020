using SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities
{
    public class Recipe : BaseEntity
    {
        [Required, MaxLength(128)]
        public string Title { get; set; }
        [Required]
        public Category Category { get; set; }
        [MaxLength(512)]
        public string Description { get; set; }
        public List<Ingidient> Ingidients { get; set; } = new List<Ingidient>();
        public List<Step> Steps { get; set; } = new List<Step>();
    }
}
