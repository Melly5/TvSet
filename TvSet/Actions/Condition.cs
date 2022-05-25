using System.Windows;
using System.Windows.Media;

namespace TvSet
{
    public partial class MainWindow : Window
    {
        int ind;
        int dead = 0;    
        public void Check_condition(double temp, double hum)
        {
            if (SelectedCanvasObject==null)
			{
                return;
			}
            ind = (int)SelectedCanvasObject.Tag +1;
            if (SelectedCanvasObject.Name=="Tree")
			{              
                switch(ind)
				{
                    case 1:
                        Fir tree = new Fir();
                        var result = tree.CheckCondition(temp, hum);
                        Condition_text.Text = result.Item1;
                        Condition.Fill = result.Item2;
                        if (result.Item1 == "Ваше дерево мертво")
						{
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                            dead = 1;
                        }
                        return;
                    case 2:
                        DragonTree dragon = new DragonTree();
                        result = dragon.CheckCondition(temp, hum);
                        Condition_text.Text = result.Item1;
                        Condition.Fill = result.Item2;
                        if (result.Item1 == "Ваше дерево мертво")
                        {
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                            dead = 1;
                        }
                        return;
                    case 3:
                        Beech beech = new Beech();
                        result = beech.CheckCondition(temp, hum);
                        Condition_text.Text = result.Item1;
                        Condition.Fill = result.Item2;
                        if (result.Item1 == "Ваше дерево мертво")
                        {
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                            dead = 1;
                        }
                        return;
                    case 4:
                        Linden linden = new Linden();
                        result = linden.CheckCondition(temp, hum);
                        Condition_text.Text = result.Item1;
                        Condition.Fill = result.Item2;
                        if (result.Item1 == "Ваше дерево мертво")
                        {
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                            dead = 1;
                        }
                        return;
                    case 5:
                        Oak oak = new Oak();
                        result = oak.CheckCondition(temp, hum);
                        Condition_text.Text = result.Item1;
                        Condition.Fill = result.Item2;
                        if (result.Item1 == "Ваше дерево мертво")
                        {
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                            dead = 1;
                        }
                        return;
                }              
			}
            else if (SelectedCanvasObject.Name == "Bird")
            {
                switch (ind)
                {
                    case 1:
                        Redpoll redpoll = new Redpoll();
                        var result = redpoll.CheckCondition(temp, hum);
                        Condition_text.Text = result.Item1;
                        Condition.Fill = result.Item2;
                        if (result.Item1 == "Птица мертва")
                        {
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                            dead = 1;
                        }
                        return;
                    case 2:
                        BlueTit bluetit = new BlueTit();
                        result = bluetit.CheckCondition(temp, hum);
                        Condition_text.Text = result.Item1;
                        Condition.Fill = result.Item2;
                        if (result.Item1 == "Птица мертва")
                        {
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                            dead = 1;
                        }
                        return;
                    case 3:
                        Pigeon pigeon = new Pigeon();
                        result = pigeon.CheckCondition(temp, hum);
                        Condition_text.Text = result.Item1;
                        Condition.Fill = result.Item2;
                        if (result.Item1 == "Птица мертва")
                        {
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                            dead = 1;
                        }
                        return;
                    case 4:
                        Hummingbird humm = new Hummingbird();
                        result = humm.CheckCondition(temp, hum);
                        Condition_text.Text = result.Item1;
                        Condition.Fill = result.Item2;
                        if (result.Item1 == "Птица мертва")
                        {
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                            dead = 1;
                        }
                        return;
                    case 5:
                        Finch finch = new Finch();
                        result = finch.CheckCondition(temp, hum);
                        Condition_text.Text = result.Item1;
                        Condition.Fill = result.Item2;
                        if (result.Item1 == "Птица мертва")
                        {
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                            dead = 1;
                        }
                        return;
                }
            }
            else if (SelectedCanvasObject.Name == "Animal")
            {
                switch (ind)
                {
                    case 1:
                        Wolf wolf = new Wolf();
                        var result = wolf.CheckCondition(temp, hum);
                        Condition_text.Text = result.Item1;
                        Condition.Fill = result.Item2;
                        if (result.Item1 == "Волк мертв")
                        {
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                            dead = 1;
                        }
                        return;
                    case 2:
                        Squirrel squirrel = new Squirrel();
                        result = squirrel.CheckCondition(temp, hum);
                        Condition_text.Text = result.Item1;
                        Condition.Fill = result.Item2;
                        if (result.Item1 == "Белка мертва")
                        {
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                            dead = 1;
                        }
                        return;
                    case 3:
                        Fox fox = new Fox();
                        result = fox.CheckCondition(temp, hum);
                        Condition_text.Text = result.Item1;
                        Condition.Fill = result.Item2;
                        if (result.Item1 == "Лиса мертва")
                        {
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                            dead = 1;
                        }
                        return;
                    case 4:
                        Bear bear = new Bear();
                        result = bear.CheckCondition(temp, hum);
                        Condition_text.Text = result.Item1;
                        Condition.Fill = result.Item2;
                        if (result.Item1 == "Медведь мертв")
                        {
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                            dead = 1;
                        }
                        return;
                    case 5:
                        Bunny bunny = new Bunny();
                        result = bunny.CheckCondition(temp, hum);
                        Condition_text.Text = result.Item1;
                        Condition.Fill = result.Item2;
                        if (result.Item1 == "Зайчик мертв")
                        {
                            information.Text = "Удалите объект";
                            Move.Visibility = Visibility.Hidden;
                            dead = 1;
                        }
                        return;
                }
            }
        }
    }
}
