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
        private Rectangle _newTree;
        int random;
       
        public Rectangle addT(ImageBrush treeImage, Random rand)
        {
            random = rand.Next(1, 5);
            string[] unicName = new string[5];

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
            _newTree.MouseMove += Rectangle_OnMouseUp;
            Canvas.SetTop(_newTree, rand.Next(30, 300));
            Canvas.SetLeft(_newTree, rand.Next(30, 500));
            return _newTree;
        }


   
        }
}
