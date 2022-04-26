using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace TvSet
{
    internal class AddTree
    {
        public Rectangle add(ImageBrush treeImage, Random rand)
        {
            int random = rand.Next(1, 5);

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
            Rectangle newTree = new Rectangle
            {
                Tag = "tree",
                Height = rand.Next(70, 100),
                Width = rand.Next(40, 50),
                Fill = treeImage
            };

            Canvas.SetTop(newTree, rand.Next(40, 150));
            Canvas.SetLeft(newTree, rand.Next(30, 300));
            return newTree;
        }
    }
}
