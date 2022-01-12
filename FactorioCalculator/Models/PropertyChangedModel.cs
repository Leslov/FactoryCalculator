using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FactorioCalculator
{
	[Serializable]
	public class PropertyChangedModel : INotifyPropertyChanged
	{
		[field: NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		public virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
