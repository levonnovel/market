﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace onlineShop1.Models
{
	public class ShoppingStoreEntities: DbContext
	{
		public DbSet<Item> Items { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}