using System;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TvSet
{
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		// отслеживание подсчёта объектов
		private string count_obj;
		public string CountObjects
		{
			get => count_obj; set
			{
				count_obj = value;

				OnPropertyChanged("CountObjects");
				Check();
			}
		}
		public void Check()
		{
			if (count > 0)
				Delete_All.Visibility = Visibility.Visible;
			else
				Delete_All.Visibility = Visibility.Hidden;
			if (count == 35)
			{
				Hint.Visibility = Visibility.Visible;
				Hint.Text = "Количество объектов не может превышать 35";
			}	
		}
		private string count_temp;
		public string CountTemp
		{
			get => count_temp; set
			{
				count_temp = value;

				OnPropertyChanged("CountTemp");
			}
		}
		private string count_hum;
		public string CountHum
		{
			get => count_hum; set
			{
				count_hum = value;

				OnPropertyChanged("CountHum");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}

		// изменение значения в слайдере температуры
		StringBuilder str = new StringBuilder();

		private void Temperature_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			temp = (int)Temperature.Value;
			str.Append(temp + "°C");
			CountTemp = str.ToString();
			Check_condition(temp, hum);
			str.Clear();
		}
		// изменение значения в слайдере влажности
		private void Humidity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			hum = (int)Humidity.Value;
			str.Append(hum + "%");
			CountHum = str.ToString();
			Check_condition(temp, hum);
			str.Clear();
		}
	}
}
