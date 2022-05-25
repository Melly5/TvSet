using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TvSet
{
    public partial class MainWindow : Window
    {
        private int movement = 0;
        private int move_object = 0;

        private void Move_Object(object sender, RoutedEventArgs e)
        {
            move_object = 1;
            Hint.Visibility = Visibility.Visible;
            Hint.Text = "Объект двигается вслед за курсором мыши. ЩЛКП для размещения.";
        }
		private void Window_MouseMove(object sender, MouseEventArgs e)
		{         
			var p = e.GetPosition(World);
			if (SelectedCanvasObject != null && move_object==1)
			{
                var clamp = new Clamp_Move();
				var clampP = new Point(
				clamp.Clamp(p.X - SelectedCanvasObject.Width / 2, 5, World.Width - 50),
				clamp.Clamp(p.Y - SelectedCanvasObject.Height / 2, 5, World.Height - 90)
				);

				Canvas.SetLeft(SelectedCanvasObject, clampP.X);
				Canvas.SetTop(SelectedCanvasObject, clampP.Y);
				movement = 1;              
			}
		}

		

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (SelectedCanvasObject != null && movement == 1)
            {
                SelectedCanvasObject.Effect = null;
                SelectedCanvasObject = null;
                movement = 0;
                move_object = 0;
                Hint.Visibility = Visibility.Hidden;
            }
        
        }
        private void KeyisDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (SelectedCanvasObject == null)
                return;
            else if (e.Key == Key.OemMinus)
            {
                if (SelectedCanvasObject.Height <= 5 | SelectedCanvasObject.Width <= 5)
                    return;
                SelectedCanvasObject.Height -= 5;
                SelectedCanvasObject.Width -= 5;
            }
            else if (e.Key == Key.OemPlus)
            {
                if (SelectedCanvasObject.Height >= 450 | SelectedCanvasObject.Width >= 450)
                    return;
                SelectedCanvasObject.Height += 5;
                SelectedCanvasObject.Width += 5;
            }
            else if (e.Key == Key.Delete)
			{
                DeleteOne();
            }
            else if (e.Key == Key.Back)
			{
               DeleteEveryone();
            }
        }          
    }
}
