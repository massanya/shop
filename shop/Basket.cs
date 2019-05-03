using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
	public class Basket
	{
		public int OrderPrice=0;
		public void Order(List<Goods> goods)
		{
			
			for (int i = 0; i < goods.Count; i++)
			{
				OrderPrice += goods[i].Price;
			}
			Console.WriteLine($"{OrderPrice}");
		}
		public int OrderNumber { get; set; }
		
	}
}
