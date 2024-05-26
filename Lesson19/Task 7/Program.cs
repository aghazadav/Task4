namespace Task7
{
    /*
     Bir eded daxil edin ve hemin ededin sade olub olmadigini yoxlayin
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir eded daxil edin:");
            int number;

            while (!int.TryParse(Console.ReadLine(), out number) || number <= 1)
            {
                Console.WriteLine("Düzgün bir musbet tam eded daxil edin:");
            }

            bool isPrime = IsPrime(number);

            if (isPrime)
            {
                Console.WriteLine($"{number} sade bir ededdir.");
            }
            else
            {
                Console.WriteLine($"{number} sade bir eded deyil.");
            }
        }

        static bool IsPrime(int number)
        {
            if (number == 2)
            {
                return true;
            }

            if (number < 2 || number % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
