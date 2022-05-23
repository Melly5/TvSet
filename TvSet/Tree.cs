using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
    public class Tree
    {
        private Rectangle _newTree;
        static Random rand = new Random();
        public Rectangle AddTree(int ind, MainWindow main)
        {
            main.AddCount();

            ImageBrush treeImage = new ImageBrush();
            _newTree = new Rectangle();
            switch (ind)
            {
                case 1:
                    treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree1.png", UriKind.Absolute));
                    _newTree.Height = 120;
                    _newTree.Width = 120;
                    break;
                case 2:
                    treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree2.png", UriKind.Relative));

                    _newTree.Height = 120;
                    _newTree.Width = 140;
                    break;
                case 3:
                    treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree3.png", UriKind.Relative));

                    _newTree.Height = 150;
                    _newTree.Width = 120;
                    break;
                case 4:
                    treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree4.png", UriKind.Relative));
                    _newTree.Height = 150;
                    _newTree.Width = 120;
                    break;
                case 5:
                    treeImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Trees/tree5.png", UriKind.Relative));
                    _newTree.Height = 130;
                    _newTree.Width = 140;
                    break;
            }
            _newTree.Name = "Tree";
            _newTree.Fill = treeImage;
            _newTree.Tag = ind-1;
            main.AddAction(_newTree); 
            Canvas.SetTop(_newTree, rand.Next(170, 350));
            Canvas.SetLeft(_newTree, rand.Next(20, 520));
            return _newTree;
        }
    }
}
