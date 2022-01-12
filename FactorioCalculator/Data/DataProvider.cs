using FactorioCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioCalculator.Data
{
	internal class DataProvider
	{
		public IEnumerable<Recipe> GetAllRecipes()
		{
			string folderPath = "\\data\\base\\prototypes";
			string recipes = "recipe.lua";
			string items = "item.lua";
			throw new NotImplementedException();
		}
	}
}
