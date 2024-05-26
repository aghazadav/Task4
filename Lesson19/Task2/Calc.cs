namespace Task2
{
    public class Calc
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        public int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
