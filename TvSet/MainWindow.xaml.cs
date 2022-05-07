using System;
using System.Windows;
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
		int temp, hum;

		private static FrameworkElement SelectedCanvasObject;
		int sliderValue;
		int move = 0;
		public MainWindow()
		{
			InitializeComponent();
			InfoGrid.Visibility = Visibility.Hidden;
			
		}

		private void Temperature_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			temp = (int)Temperature.Value;
			Check();
			//tbout.Text = sliderValue.ToString();
		}

		private void Humidity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			hum = (int)Humidity.Value;
			Check();
			//tbout.Text = ((int)Humidity.Value).ToString();
		}

		private void Window_MouseMove(object sender, MouseEventArgs e)
		{
			var p = e.GetPosition(World);
			if(SelectedCanvasObject != null)
			{
				var clampP = new Point(
				Clamp(p.X - SelectedCanvasObject.Width / 2, 50, World.Width - 100),
				Clamp(p.Y - SelectedCanvasObject.Height / 2, 50, World.Height - 100)
				);

				Canvas.SetLeft(SelectedCanvasObject, clampP.X);
				Canvas.SetTop(SelectedCanvasObject, clampP.Y);
				move = 1;
				 //if (MouseLeftButtonDown)

			}
		}

		private double Clamp(double val, double min, double max)
		{
			if (val < min) return min;
			if (val > max) return max;
			return val;
		}

		private void Window_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if(SelectedCanvasObject != null&&move==1)
			{
				SelectedCanvasObject.Effect = null;
				SelectedCanvasObject = null;
				move = 0;
			}
			
		}

		private void Check()
		{
			Check_condition(temp, hum);
		}
	}
}
