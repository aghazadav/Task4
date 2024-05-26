namespace Task6
{
    /*
     Daire  classi yaradin .
     Radiusu 5 olan dairenin uzunlugunu hesablayin.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            bool validInput = false;

            do
            {
                //double radius = 5;
                //Circle circle = new Circle(radius);


                Console.WriteLine("Dairenin radiusunu daxil edin:");
                string input = Console.ReadLine();

                if (double.TryParse(input, out radius))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz deyer duzgun deyil. Yeniden cehd edin.");
                }
            } while (!validInput);

            Circle circle = new Circle(radius);

            double circumference = circle.CalculateCircumference();

            Console.WriteLine($"Radiusu {radius} olan dairenin uzunglugu: {circumference}");
        }
    }
}
