namespace Task2
{
    /* 
        Bir hesablama methodu yazın. Bu methoda int tipində dəyərlər əlavə edin və bu dəyərləri daxildə toplayın.
        Bunun üçün method overloadingdən istifadə edin.bir methodunuzda 2 parametr, birində 3 və s.
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();

            int count;

            while (true)
            {
                Console.WriteLine("Nece eded daxil etmek isteyirsiniz?");
                string input = Console.ReadLine();

                if (int.TryParse(input, out count) && count > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Reqem daxil edin.");
                }
            }

            switch (count)
            {
                case 2:
                    Console.WriteLine("2 eded daxil edin:");
                    int a = GetValidInteger();
                    int b = GetValidInteger();
                    Console.WriteLine($"{a} + {b} = " + calc.Sum(a, b));
                    break;

                case 3:
                    Console.WriteLine("3 eded daxil edin:");
                    int c = GetValidInteger();
                    int d = GetValidInteger();
                    int e = GetValidInteger();
                    Console.WriteLine($"{c} + {d} + {e} = " + calc.Sum(c, d, e));
                    break;

                case 4:
                    Console.WriteLine("4 eded daxil edin:");
                    int f = GetValidInteger();
                    int g = GetValidInteger();
                    int h = GetValidInteger();
                    int i = GetValidInteger();
                    Console.WriteLine($"{f} + {g} + {h} + {i} = " + calc.Sum(f, g, h, i));
                    break;

                default:
                    if (count > 4)
                    {
                        Console.WriteLine($"{count} eded daxil edin:");
                        int[] numbers = new int[count];
                        for (int j = 0; j < count; j++)
                        {
                            numbers[j] = GetValidInteger();
                        }
                        Console.WriteLine($"{string.Join(" + ", numbers)} = " + calc.Sum(numbers));
                    }
                    else
                    {
                        Console.WriteLine("Reqem daxil edin.");
                    }
                    break;
            }
            static int GetValidInteger()
            {
                int number;
                while (true)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out number))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Reqem daxil edin:");
                    }
                }
                return number;
            }
        }
    }
}
