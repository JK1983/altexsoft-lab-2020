using SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Entities
{
	public class Category : BaseEntity
	{
		public int ParentCategoryId { get; set; }		
		public Category ParentCategory { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public List<Category> ChildCategories { get; set; }
		public List<Recipe> Recipes { get; set; } //I don't need it
	}
}
