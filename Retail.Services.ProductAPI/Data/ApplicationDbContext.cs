﻿using Microsoft.EntityFrameworkCore;
using Retail.Services.ProductAPI.Models;

namespace Retail.Services.ProductAPI.Data
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		
		public DbSet<Product> Products { get; set; }

		public DbSet<Category> Categories { get; set; }
		
	}
}
