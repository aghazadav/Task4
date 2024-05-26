namespace Task13
{
    /*
     3 rəqəmli ədədlərdən 7 və 8-ə bölünən ədədlərin cəmini tapın
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("3 reqemli ededleri daxil edin:");

            for (int i = 0; i < 3; i++)
            {
                int number;
                while (true)
                {
                    Console.Write($"{i + 1}-ci ededi daxil edin: ");
                    Console.WriteLine();
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        if (number >= 100 && number <= 999)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Xeta: Daxil etdiyiniz eded 3 reqemli deyil.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Xeta: Daxil etdiyiniz deyer eded deyil.");
                    }
                }

                if (number % 7 == 0 || number % 8 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"7 ve 8-e bolunen ededlerin cəmi: {sum}");

        }
    }
}
