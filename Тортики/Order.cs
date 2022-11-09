namespace Тортики
{
    internal class Order
    {
        private int allprice;
        private string vahzakaz;
        private DateTime date;
        public void Zakaz()
        {
            Console.WriteLine("Заказ торта в кондитерской 'CofeSound', желание покупателя - закон!");
            Console.WriteLine("Выберете параметр торта");
            Console.WriteLine("-----------------------");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            Console.WriteLine(" ");
            Console.WriteLine("Цена: " + allprice);
            Console.WriteLine("Ваш заказ: " + vahzakaz);
        }

        public List<Points> Forma()
        {
            Points kryg = new Points();
            kryg.podmenu = "  Круг";
            kryg.price = 20;
            Points kvadrat = new Points();
            kvadrat.podmenu = "  Квадрат";
            kvadrat.price = 10;
            Points treygolnik = new Points();
            treygolnik.podmenu = "  Треугольник";
            treygolnik.price = 15;

            List<Points> forma = new List<Points>();
            forma.Add(kryg);
            forma.Add(kvadrat);
            forma.Add(treygolnik);

            return forma;
        }
        public List<Points> Razmer()
        {
            Points size = new Points();
            size.podmenu = "  20";
            size.price = 200;
            Points size1 = new Points();
            size1.podmenu = "  25";
            size1.price = 300;
            Points size2 = new Points();
            size2.podmenu = "  30";
            size2.price = 400;

            List<Points> razmer = new List<Points>();
            razmer.Add(size);
            razmer.Add(size1);
            razmer.Add(size2);

            return razmer;
        }
        public List<Points> Vkys()
        {
            Points klybnika = new Points();
            klybnika.podmenu = "  Клубника";
            klybnika.price = 400;
            Points slivki = new Points();
            slivki.podmenu = "  Сливки";
            slivki.price = 100;
            Points hokolad = new Points();
            hokolad.podmenu = "  Шоколад";
            hokolad.price = 200;

            List<Points> vkys = new List<Points>();
            vkys.Add(klybnika);
            vkys.Add(slivki);
            vkys.Add(hokolad);

            return vkys;
        }
        public List<Points> Korg()
        {
            Points kolvo = new Points();
            kolvo.podmenu = "  2";
            kolvo.price = 500;
            Points kolvo1 = new Points();
            kolvo1.podmenu = "  3";
            kolvo1.price = 1000;
            Points kolvo2 = new Points();
            kolvo2.podmenu = "  4";
            kolvo2.price = 1500;

            List<Points> korg = new List<Points>();
            korg.Add(kolvo);
            korg.Add(kolvo1);
            korg.Add(kolvo2);

            return korg;
        }
        public List<Points> Glazyr()
        {
            Points pink = new Points();
            pink.podmenu = "  Розовая";
            pink.price = 100;
            Points white = new Points();
            white.podmenu = "  Белая";
            white.price = 100;
            Points black = new Points();
            black.podmenu = "  Чёрная";
            black.price = 100;

            List<Points> glazyr = new List<Points>();
            glazyr.Add(pink);
            glazyr.Add(white);
            glazyr.Add(black);

            return glazyr;
        }
        public List<Points> Dekor()
        {
            Points orehi = new Points();
            orehi.podmenu = "  Орехи";
            orehi.price = 300;
            Points pospka = new Points();
            pospka.podmenu = "  Посыпка";
            pospka.price = 100;
            Points risynok = new Points();
            risynok.podmenu = "  Рисунок";
            risynok.price = 1000;

            List<Points> dekor = new List<Points>();
            dekor.Add(orehi);
            dekor.Add(pospka);
            dekor.Add(risynok);

            return dekor;
        }
        public void Money(List<Points> points)
        {
            int position = 1;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                foreach (Points a in points)
                {
                    Console.WriteLine(a.podmenu + " - " + a.price);
                }
                position = Strelka(key, position);
                if (key.Key == ConsoleKey.Enter)
                {

                    allprice = points[position].price + allprice;
                    vahzakaz = points[position].podmenu + vahzakaz;
                    /*break;*/
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Zakaz();

                }


            }
        }
        public void Clear()
        {
            allprice = 0;
            vahzakaz = "";
        }
        public void Date()
        {
            date = DateTime.Now;
        }
        public void Text()
        {


            File.AppendAllText("C:\\Users\\user\\Desktop\\История заказов.txt", date.ToString());
            File.AppendAllText("C:\\Users\\user\\Desktop\\История заказов.txt", allprice.ToString());
            File.AppendAllText("C:\\Users\\user\\Desktop\\История заказов.txt", vahzakaz.ToString());


        }
        public int Strelka(ConsoleKeyInfo key, int position)
        {
            if (key.Key == ConsoleKey.UpArrow)
            {
                position--;

            }

            if (key.Key == ConsoleKey.DownArrow)
            {
                position++;

            }
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            return position;
        }
    }
}
