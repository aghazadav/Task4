namespace Task10
{   /*
    While ilə dövr yaradın. Hər dövrdə istifadəçidən 2 ədəd istəyin.
    Əgər bu 2 ədədin cəmi 6-ya qalıqsız bölünürsə bu zaman dövrü sonlandırın.Əks halda dövrü təkrarlayın.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Birinci ededi daxil edin:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ikinci ededi daxil edin:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if ((num1 + num2) % 6 == 0)
                {
                    Console.WriteLine("Daxil etdiyiniz iki ədədin cəmi 6-ya qaliqsiz bolunur.");
                    break;
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz iki ededin cemi 6-ya qaliqsiz bolunmur. Yeniden cehd edin.");
                }
            }
        }
    }
}
