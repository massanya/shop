using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
	public class Goods
	{
		public string Name { get; set; }
		public char Sex { get; set; }
		public string Color { get; set; }
		public int Price { get; set; }
		public string Rating { get; set; }
	
		public static bool operator >(Goods a, Goods b)                
			{
			return a.Price > b.Price;
			}

		public static bool operator <(Goods a, Goods b)                
			{
			return a.Price < b.Price;
			}
		public static bool operator ==(Goods a, Goods b)                
			{
			return a.Price == b.Price;
			}

		public static bool operator !=(Goods a, Goods b)                
			{
			return a.Price != b.Price;
			}
	}
	
}
