using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioCalculator.Models
{
	internal class Recipe
	{
		public ItemStack OutputItem { get; set; }
		public IEnumerable<ItemStack> InputItems { get; set; }
		public IEnumerable<Assembler> Assemblers { get; set; }
	}
}
