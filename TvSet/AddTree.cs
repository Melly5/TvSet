using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
    public partial class MainWindow : Window
    {
        private Rectangle _newTree;
        private ComboBoxItem _selectedItem;

        public Rectangle AddTree(int ind)
        {
            ImageBrush treeImage = new ImageBrush();
            _newTree = new Rectangle();
            switch (ind)
            {
                case 1:
                    treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree1.png", UriKind.Absolute));
                    _newTree.Height = _newTree.ActualHeight + 120;
                    _newTree.Width = _newTree.ActualWidth + 120;
                    break;
                case 2:
                    treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree2.png", UriKind.Relative));

                    _newTree.Height = _newTree.ActualHeight + 120;
                    _newTree.Width = _newTree.ActualWidth + 140;
                    break;
                case 3:
                    treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree3.png", UriKind.Relative));

                    _newTree.Height = _newTree.ActualHeight + 150;
                    _newTree.Width = _newTree.ActualWidth + 120;
                    break;
                case 4:
                    treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree4.png", UriKind.Relative));
                    _newTree.Height = _newTree.ActualHeight + 150;
                    _newTree.Width = _newTree.ActualWidth + 120;
                    break;
                case 5:
                    treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree5.png", UriKind.Relative));
                    _newTree.Height = _newTree.ActualHeight + 130;
                    _newTree.Width = _newTree.ActualWidth + 140;
                    break;
            }
     
            _newTree.Fill = treeImage;
            _newTree.Tag = ind-1;
            _newTree.MouseDown += Rectangle_OnMouseDown;
 
            Canvas.SetTop(_newTree, rand.Next(30, 300));
            Canvas.SetLeft(_newTree, rand.Next(30, 500));
            return _newTree;
        }



		
    }
}
