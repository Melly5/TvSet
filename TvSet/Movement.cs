using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;


namespace TvSet
{
     
    public partial class MainWindow : Window
    {
        private int movement = 0;
        private int move_object = 0;

        private void Move_Object(object sender, RoutedEventArgs e)
        {
            move_object = 1;
        }
		private void Window_MouseMove(object sender, MouseEventArgs e)
		{
			var p = e.GetPosition(World);
			if (SelectedCanvasObject != null&&move_object==1)
			{
				var clampP = new Point(
				Clamp(p.X - SelectedCanvasObject.Width / 2, 50, World.Width - 100),
				Clamp(p.Y - SelectedCanvasObject.Height / 2, 50, World.Height - 100)
				);

				Canvas.SetLeft(SelectedCanvasObject, clampP.X);
				Canvas.SetTop(SelectedCanvasObject, clampP.Y);
				movement = 1;
               
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
            if (SelectedCanvasObject != null && movement == 1)
            {
                SelectedCanvasObject.Effect = null;
                SelectedCanvasObject = null;
                movement = 0;
                move_object = 0;
            }
        }
        private void KeyisDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (SelectedCanvasObject == null)
                return;
            else if (e.Key == Key.OemMinus)
            {

                SelectedCanvasObject.Height -= 5;
                SelectedCanvasObject.Width -= 5;
            }
            else if (e.Key == Key.OemPlus)
            {
                SelectedCanvasObject.Height += 5;
                SelectedCanvasObject.Width += 5;
            }
            else if (e.Key == Key.Delete)
			{
                World.Children.Remove(SelectedCanvasObject as UIElement);
                count--;
            }
            else if (e.Key == Key.Back)
			{
                World.Children.Clear();
                count = 0;
            }
        }          
    }
}
