using FactorioCalculator.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioCalculator.ViewModels
{
	internal class MainViewModel : PropertyChangedModel
	{

		private ObservableCollection<string> _Factories = new ObservableCollection<string>(new string[] { "name1", "Factory2" });
		public ObservableCollection<string> Factories
		{
			get => _Factories;
			set { _Factories = value; OnPropertyChanged(); }
		}
	}
}
