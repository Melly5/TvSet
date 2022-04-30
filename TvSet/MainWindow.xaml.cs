using System;
using System.Windows;
using System.Text;
using System.Globalization;
using System.Windows.Input;
using System.Windows.Controls;

namespace TvSet
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		static Random rand = new Random();
		string[] NameT = { "Sunny", "Buryy", "Curry", "Wedne", "Thir" };

		private static FrameworkElement SelectedCanvasObject;

		public MainWindow()
		{
			InitializeComponent();
			InfoGrid.Visibility = Visibility.Hidden;

		}
	}
}
