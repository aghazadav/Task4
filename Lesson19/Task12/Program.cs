using System.Reflection;

namespace Task12
{   /*
     Verilmiş 3 ədəddən ən böyük və ən kiçiyini tapın
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 eded daxil edin:");

            int number1, number2, number3;

            while (true)
            {
                Console.Write("1-ci ededi daxil edin: ");
                if (int.TryParse(Console.ReadLine(), out number1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Xeta: Daxil etdiyiniz deyer ədəd deyil.");
                }
            }

            while (true)
            {
                Console.Write("2-ci ededi daxil edin: ");
                if (int.TryParse(Console.ReadLine(), out number2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Xeta: Daxil etdiyiniz deyer eded deyil.");
                }
            }

            while (true)
            {
                Console.Write("3-cu ededi daxil edin: ");
                if (int.TryParse(Console.ReadLine(), out number3))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Xeta: Daxil etdiyiniz deyer ədəd deyil.");
                }
            }
            int minimum = Math.Min(number1, Math.Min(number2, number3));
            int maximum = Math.Max(number1, Math.Max(number2, number3));
            int middle = number1 + number2 + number3 - minimum - maximum;

            Console.WriteLine($"Birinci eded: {number1}, Ikinci eded: {number2}, Ucuncu eded: {number3} ");
            Console.WriteLine();
            Console.WriteLine($"En kicik eded: {minimum}");
            Console.WriteLine();
            Console.WriteLine($"Orta eded : {middle}");
            Console.WriteLine();
            Console.WriteLine($"En boyuk eded: {maximum}");

        }
    }
}
