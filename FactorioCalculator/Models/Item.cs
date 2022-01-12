using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioCalculator.Models
{
	internal class Item
	{
		public string Name { get; set; }
		public IEnumerable<Recipe> Recipes { get; set; }
	}
}
