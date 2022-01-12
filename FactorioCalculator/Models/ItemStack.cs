using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioCalculator.Models
{
	internal struct ItemStack
	{
		public Item Item { get; set; }
		public short Quantity { get; set; }
	}
}
