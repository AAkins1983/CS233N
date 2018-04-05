using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductMaint
{
    // This application is described in chapter 14 of
    // "Murach's C# 2008" by Joel Murach
    // (c) 2008 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public class ProductList : List<Product>
	{
		// Modify the behavior of the Add method of the List<> class
		public new void Add(Product p)
		{
			base.Insert(0, p);
		}

		// Provide two additional methods
		public void Fill()
		{
			List<Product> products = ProductDB.GetProducts();
			foreach (Product product in products)
				base.Add(product);
		}

		public void Save()
		{
			ProductDB.SaveProducts(this);
		}
	}
}
