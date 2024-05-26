namespace Task5
{
    /*
     Istifadeciden 1 eded alin ve bir array yaradin. Hemin ededin arrayin icinde olub olmadigini yoxlayin
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir eded daxil edin:");
            int number = int.Parse(Console.ReadLine());

            int[] array = { 1, 30, 48, 2523, 124 };

            bool isInArray = CheckIfInArray(number, array);

            if (isInArray)
            {
                Console.WriteLine($"{number} arrayin icindedir.");
            }
            else
            {
                Console.WriteLine($"{number} arrayin icinde deyil.");
            }
        }

        static bool CheckIfInArray(int number, int[] array)
        {
            foreach (int element in array)
            {
                if (element == number)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
