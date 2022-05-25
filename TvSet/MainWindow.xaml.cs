using System;
using System.Windows;
using System.ComponentModel;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace TvSet
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	/// 
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		static Random rand = new Random();
		private int temp = 0, hum = 0;
		private int count = 0;
		private static FrameworkElement SelectedCanvasObject;

		public MainWindow()
		{
			InitializeComponent();
			
			InfoGrid.Visibility = Visibility.Hidden;
			Delete_All.Visibility = Visibility.Hidden;
			Hint.Visibility = Visibility.Hidden;
			CountObjects = count.ToString();
			CountHum = hum.ToString();
			CountTemp = temp.ToString();

		}
		public void AddCount()
		{
			count++;
			CountObjects = count.ToString();
		}
		public void AddAction(Rectangle obj)
		{
			obj.MouseDown += Rectangle_OnMouseDown;
		}
		public void Action(Rectangle new1)
		{
			count++;
			CountObjects = count.ToString();
			new1.MouseDown += Rectangle_OnMouseDown;						
		}
	}

}
