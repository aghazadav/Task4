namespace Task11
{   /*
     3 rəqəmli ədədin rəqəmləri cəmini tapın
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 reqemli bir ededi daxil edin:");
            int number;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number >= 100 && number <= 999)
                    {
                        int birinciReqem = number / 100;
                        int ikinciReqem = (number % 100) / 10;
                        int ucuncuReqem = number % 10;

                        int cem = birinciReqem + ikinciReqem + ucuncuReqem;

                        Console.WriteLine($"Reqemlerin cemi: {cem}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Xeta: Daxil edilen eded 3 reqemli deyil.");
                    }
                }
                else
                {
                    Console.WriteLine("Xəta: Daxil edilen deyer eded deyil.");
                }
            }
        }
    }
}
