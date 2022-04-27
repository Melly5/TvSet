﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TvSet
{
    internal class AddAnimal
    {
        int countA = 0;
        public Rectangle addA(ImageBrush animalImage, Random rand)
        {
            int random = rand.Next(1, 5);
            countA++;

            switch (random)
            {
                case 1:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal1.png", UriKind.Relative));
                    break;
                case 2:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal2.png", UriKind.Relative));
                    break;
                case 3:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal3.png", UriKind.Relative));
                    break;
                case 4:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal4.png", UriKind.Relative));
                    break;
                case 5:
                    animalImage.ImageSource = new BitmapImage(new Uri("C:/Users/Melly/source/repos/TvSet/TvSet/Images/Animals/animal5.png", UriKind.Relative));
                    break;
            }
            Rectangle newAnimal = new Rectangle
            {
                Tag = countA.ToString(CultureInfo.InvariantCulture),
                Height = rand.Next(70, 100),
                Width = rand.Next(40, 50),
                Fill = animalImage
            };
            Canvas.SetTop(newAnimal, rand.Next(40, 150));
            Canvas.SetLeft(newAnimal, rand.Next(30, 300));
            return newAnimal;
           
            
           
        }
    }
}
