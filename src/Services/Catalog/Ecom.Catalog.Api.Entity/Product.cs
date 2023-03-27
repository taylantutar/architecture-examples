﻿using System;
namespace Ecom.CatalogService.Entity
{
	public class Product
	{
		public Guid Id  { get; set; }
		public string Name { get; set; }
		public string Category { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
	}
}

