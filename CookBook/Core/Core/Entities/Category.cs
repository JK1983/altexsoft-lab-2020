using SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities
{
	public class Category : BaseEntity
	{
		[Required]
		public Category ParentCategory { get; set; }
		[Required, MaxLength(128)]
		public string Title { get; set; }
		[MaxLength(512)]
		public string Description { get; set; }
	}
}
