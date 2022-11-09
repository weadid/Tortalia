using Тортики;
internal class Program
{
    static void Main()
    { 
        int position = 3;

        while(true)
        {
            Order order = new Order();
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            order.Zakaz();
            position = order.Strelka(key, position);

            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                if(position == 3)
                {
                    order.Money(order.Forma());
                }
                else if(position == 4)
                {
                    order.Money(order.Razmer());
                }
                else if (position == 5)
                {
                    order.Money(order.Vkys());
                }
                else if (position == 6)
                {
                    order.Money(order.Korg());
                }
                else if (position == 7)
                {
                    order.Money(order.Glazyr());
                }
                else if (position == 8)
                {
                    order.Money(order.Dekor());
                }
                else if (position == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Спасибо за заказ! Если хотите сделать кщё один, нажмите на клавишу Escape");

                    ConsoleKey cey = Console.ReadKey().Key;
                    while (cey == ConsoleKey.Enter)
                    { 
                        order.Text();
                        if (cey == ConsoleKey.Escape)
                        {
                        Main();
                        }
                    }
                }
            }
        }
    }
 }