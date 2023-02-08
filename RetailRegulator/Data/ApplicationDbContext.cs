using Microsoft.EntityFrameworkCore;
using RetailRegulator.Models;

namespace RetailRegulator.Data
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
			
		}
		
		public DbSet<Category> Categories { get; set; }
		
	}
}
