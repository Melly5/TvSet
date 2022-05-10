using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Shapes;

namespace TvSet
{
    public partial class MainWindow : Window
    {
        /*MediaPlayer ClickSound = new MediaPlayer();

        private void click_cat(object sender, RoutedEventArgs e)
        {
            ClickSound.Open(new Uri("/Sounds/meow.mp3", UriKind.Relative));
            ClickSound.Play();
        }
        */
        private string boxName;
        DropShadowEffect effect = new DropShadowEffect();
        
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            _selectedItem = selectedItem;
            boxName = comboBox.Name;
        }

        //Добавление дерева
        private void Click_tree(object sender, RoutedEventArgs e)
        {
            if (_selectedItem == null)
                return;
            if (count >= 35)              
                return;
            int index = _selectedItem.TabIndex + 1;
            World.Children.Add(AddTree(index));            
        }

        //Добавление птицы
        private void Click_bird(object sender, RoutedEventArgs e)
        {
            if (_selectedItem == null)
                return;
            if (count >= 35)
                return;
            int index = _selectedItem.TabIndex + 1;
            World.Children.Add(AddBird(index));
        }

        //Добавление животного
        private void Click_animal(object sender, RoutedEventArgs e)
        {
            if (_selectedItem == null)
                return;
            if (count >= 35)
                return;
            int index = _selectedItem.TabIndex + 1;
            World.Children.Add(AddAnimal(index));
        }
        //При нажатии на объект
        private void Rectangle_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var mouseWasDownOn = e.Source as FrameworkElement;

            if (mouseWasDownOn != null)
            {
                //Вывод информации
                if(SelectedCanvasObject != null)
				{
                    SelectedCanvasObject.Effect = null;
                }
                SelectedCanvasObject = mouseWasDownOn;
                if (SelectedCanvasObject.Name =="Tree")
				{
                    kind.Text = Kind[0, (int)SelectedCanvasObject.Tag];
                    information.Text = Information[0, (int)SelectedCanvasObject.Tag];
                }
                else if (SelectedCanvasObject.Name == "Bird")
                {
                    kind.Text = Kind[1, (int)SelectedCanvasObject.Tag];
                    information.Text = Information[1, (int)SelectedCanvasObject.Tag];
                }
                else if (SelectedCanvasObject.Name == "Animal")
                {
                    kind.Text = Kind[2, (int)SelectedCanvasObject.Tag];
                    information.Text = Information[2, (int)SelectedCanvasObject.Tag];
                }
                //Эффекты объекта
                InfoGrid.Visibility = Visibility.Visible;
                effect.Color = Colors.Red;
                effect.Direction = -50;
                effect.BlurRadius = 5;
                effect.ShadowDepth = 6;
                SelectedCanvasObject.Effect = effect;
                Hint.Visibility = Visibility.Visible;
                Hint.Text = "Изменить размер - '+','-'.Удаление одного объекта - Delete, всех - Backspace.";

            }
        }
        //private void Unfocuse()
        //{
        //    if (SelectedCanvasObject != null)
        //    {
        //        SelectedCanvasObject.Effect = null;
        //        SelectedCanvasObject = null;

        //        Hint.Visibility = Visibility.Hidden;
        //    }
        //}

            //Удаление одного выбранного объекта
            private void DeleteObject(object sender, RoutedEventArgs e)
        {
            if (SelectedCanvasObject == null)
			{
                return;
			}
          
            World.Children.Remove(SelectedCanvasObject as UIElement);
            InfoGrid.Visibility = Visibility.Hidden;
            count--;
            CountObjects = count.ToString();
            SelectedCanvasObject = null;
        }
        //Удаление всех объектов
        private void DeleteAll(object sender, RoutedEventArgs e)
        {

            World.Children.Clear();
            InfoGrid.Visibility = Visibility.Hidden;
            count = 0;
            CountObjects = count.ToString();
        }
        //Завершение работы приложения
        private void Close(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
