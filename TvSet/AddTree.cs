using System;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Text;
namespace TvSet
{
    public partial class MainWindow : Window
    {
        private int _countT = 0;
        private Rectangle _newTree;
        public Rectangle addT(ImageBrush treeImage, Random rand)
        {
            int random = rand.Next(1, 5);
            _countT++;

            switch (random)
            {
                case 1:
                    treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree1.png", UriKind.Relative));
                    break;
                case 2:
                    treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree2.png", UriKind.Relative));
                    break;
                case 3:
                    treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree3.png", UriKind.Relative));
                    break;
                case 4:
                    treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree4.png", UriKind.Relative));
                    break;
                case 5:
                    treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree5.png", UriKind.Relative));
                    break;
            }

             _newTree = new Rectangle
            {
                Tag = new Guid().ToString(),
                Height = rand.Next(70, 100),
                Width = rand.Next(40, 50),
                Fill = treeImage
            };

            _newTree.MouseDown += Rectangle_OnMouseDown;

            Canvas.SetTop(_newTree, rand.Next(30, 300));
            Canvas.SetLeft(_newTree, rand.Next(30, 500));
            return _newTree;
        }

            private void Rectangle_OnMouseDown(object sender, MouseButtonEventArgs e)
            {
                var mouseWasDownOn = e.Source as FrameworkElement;

                if (mouseWasDownOn != null)
                {
                    SelectedCanvasObject = mouseWasDownOn;
                    
                }
            }
   
        }
}
