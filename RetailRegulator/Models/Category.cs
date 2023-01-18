using System.ComponentModel.DataAnnotations;

namespace RetailRegulator.Models
{
	public class Category
	{
		[Key]
		public int Id
		{
			get; set;

		}
		public string CategoryName { get; set; }

		public string Description { get; set; }

		public int DisplayOrder { get; set; }

		public byte[] Picture { get; set; }

		public DateTime CreatedDate { get; set; } = DateTime.Now;

		public DateTime ModifiedDate { get; set; }
	}
}
