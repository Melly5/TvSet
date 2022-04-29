using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;


namespace TvSet
{
     
    public partial class MainWindow : Window
    {

        private void KeyisDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (SelectedCanvasObject == null)
                return;

            if (e.Key==Key.Down)
            {
                if (Canvas.GetTop(SelectedCanvasObject) > 5)
                {
                    Canvas.SetTop(SelectedCanvasObject, Canvas.GetTop(SelectedCanvasObject) + 10);
                }
            }
            else if (e.Key==Key.Up)
            {
                if (Canvas.GetTop(SelectedCanvasObject) > 5)
                {
                    Canvas.SetTop(SelectedCanvasObject, Canvas.GetTop(SelectedCanvasObject) - 10);
                }
            }
            else if (e.Key==Key.Left)
            {
                if (Canvas.GetLeft(SelectedCanvasObject) > 5)
                {
                    Canvas.SetLeft(SelectedCanvasObject, Canvas.GetLeft(SelectedCanvasObject) - 10);
                }
            }
            else if (e.Key==Key.Right)
            {
                if (Canvas.GetLeft(SelectedCanvasObject) > 5)
                {
                    Canvas.SetLeft(SelectedCanvasObject, Canvas.GetLeft(SelectedCanvasObject) + 10);
                }
            }
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
        }          
    }
}
