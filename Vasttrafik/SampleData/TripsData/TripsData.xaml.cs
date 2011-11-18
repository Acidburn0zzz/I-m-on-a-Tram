﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.TripsData
{
	using System; 

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class TripsData { }
#else

	public class TripsData : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		public TripsData()
		{
			try
			{
				System.Uri resourceUri = new System.Uri("/Vasttrafik;component/SampleData/TripsData/TripsData.xaml", System.UriKind.Relative);
				if (System.Windows.Application.GetResourceStream(resourceUri) != null)
				{
					System.Windows.Application.LoadComponent(this, resourceUri);
				}
			}
			catch (System.Exception)
			{
			}
		}

		private ItemCollection _Collection = new ItemCollection();

		public ItemCollection Collection
		{
			get
			{
				return this._Collection;
			}
		}
	}

	public class ItemCollection : System.Collections.ObjectModel.ObservableCollection<Item>
	{ 
	}

	public class Item : System.ComponentModel.INotifyPropertyChanged
	{
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		private double _DisplayNextTrip = 0;

		public double DisplayNextTrip
		{
			get
			{
				return this._DisplayNextTrip;
			}

			set
			{
				if (this._DisplayNextTrip != value)
				{
					this._DisplayNextTrip = value;
					this.OnPropertyChanged("DisplayNextTrip");
				}
			}
		}

		private string _Destination = string.Empty;

		public string Destination
		{
			get
			{
				return this._Destination;
			}

			set
			{
				if (this._Destination != value)
				{
					this._Destination = value;
					this.OnPropertyChanged("Destination");
				}
			}
		}

		private string _LineBackgroundColor = string.Empty;

		public string LineBackgroundColor
		{
			get
			{
				return this._LineBackgroundColor;
			}

			set
			{
				if (this._LineBackgroundColor != value)
				{
					this._LineBackgroundColor = value;
					this.OnPropertyChanged("LineBackgroundColor");
				}
			}
		}

		private string _LineForegroundColor = string.Empty;

		public string LineForegroundColor
		{
			get
			{
				return this._LineForegroundColor;
			}

			set
			{
				if (this._LineForegroundColor != value)
				{
					this._LineForegroundColor = value;
					this.OnPropertyChanged("LineForegroundColor");
				}
			}
		}

		private double _Line = 0;

		public double Line
		{
			get
			{
				return this._Line;
			}

			set
			{
				if (this._Line != value)
				{
					this._Line = value;
					this.OnPropertyChanged("Line");
				}
			}
		}
	}
#endif
}