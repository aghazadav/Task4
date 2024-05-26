namespace Task9
{
    /*
     Istifadəçidən 10 ilə 20 arasında bir rəqəm alın . 
    Bir array yaradın və daxil edilən rəqəm sayı qədər arraya random rəqəm daxil edin.
    Daha sonra həmin arrayin içərisindən tək ədədləri ayrı, cüt ədələri ayrı şəkildə,ardıcıllıqla konsola yazdırın.

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 ile 20 arasında bir reqem daxil edin:");
            int number;
            while (true)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 10 && number <= 20)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz reqem 10 ile 20 arasinda deyil. Yeniden cehd edin:");
                }
            }

            Random random = new Random();
            int[] array = new int[number];

            for (int i = 0; i < number; i++)
            {
                array[i] = random.Next(10, 21);
            }

            static void PrintOddEvenNumbers(int[] array)
            {
                Console.WriteLine("Tek ededler:");
                foreach (int num in array)
                {
                    if (num % 2 != 0)
                    {
                        Console.Write(num + " ");
                    }
                }
                Console.WriteLine("\nCut ededler:");
                foreach (int num in array)
                {
                    if (num % 2 == 0)
                    {
                        Console.Write(num + " ");
                    }
                }
                Console.WriteLine();
            }
            PrintOddEvenNumbers(array);

        }
    }
}
