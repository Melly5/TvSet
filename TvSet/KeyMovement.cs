
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;


namespace TvSet
{
    public partial class MainWindow : Window
    {
        bool goUp, goDown, goLeft, goRight;
        private void KeyisDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key==Key.Down)
            {
                goDown = true;
            }
            else if (e.Key==Key.Up)
            {
                goUp = true;
            }
            else if (e.Key==Key.Left)
            {
                goLeft = true;
            }
            else if (e.Key==Key.Right)
            {
                goRight = true;
            }
        }

        private void KeyisUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                goDown = false;
            }
            else if (e.Key == Key.Up)
            {
                goUp = false;
            }
            else if (e.Key == Key.Left)
            {
                goLeft = false;
            }
            else if (e.Key == Key.Right)
            {
                goRight = false;
            }
        }
 


           
}
}
