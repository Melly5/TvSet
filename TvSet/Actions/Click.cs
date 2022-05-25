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
        private ComboBoxItem _selectedItem;
        private string boxName;
        DropShadowEffect effect = new DropShadowEffect();        
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            _selectedItem = selectedItem;
            boxName = comboBox.Name;
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
                Check_condition(temp,hum);
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

        //Удаление одного выбранного объекта
        private void DeleteObject(object sender, RoutedEventArgs e)
        {
            DeleteOne();
            if (count == 0)
                Hint.Visibility = Visibility.Hidden;
        }

        private void DeleteOne()
		{
            if (SelectedCanvasObject == null)
            {
                return;
            }
            if (dead == 1)
            {
                Move.Visibility = Visibility.Visible;
                dead = 0;
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
            DeleteEveryone();
            if (count == 0)
                Hint.Visibility = Visibility.Hidden;

        }

        private void DeleteEveryone()
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
