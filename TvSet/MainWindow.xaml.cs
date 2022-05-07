using System;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace TvSet
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	/// 
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		static Random rand = new Random();
		int temp, hum;
		int count = 0;
		private static FrameworkElement SelectedCanvasObject;
		public MainWindow()
		{
			InitializeComponent();
			InfoGrid.Visibility = Visibility.Hidden;
		
		}


		private string count_obj;
		public string CountObjects
		{
			get => count_obj; set
			{
				count_obj = value;

				OnPropertyChanged("CountObjects");
			}
		}
		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}

	}
}
