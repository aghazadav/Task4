namespace Task3
{
    /*
     User classı yaradın.Userin name, surname və age fieldləri olsun.
    İstifadəçidən ad soyad və yaş daxil etməyini istəyin.Userdə password fieldi yaradın və bu field bütün
    istifadəçilər üçün eyni olsun classı istifadə edərkən dəyişdirilə bilsin.Və bununla yeni obyekt yaradın.
    Bu fieldlərin biri olmasa obyekt yarada bilməsin.Sonra User classında bir method yaradın və məlumatları konsola yazdırın.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            User.Password = "Deyisilmelisifre123";

            Console.WriteLine("Adinizi daxil edin:");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name) || name.Length < 3 || name.Any(char.IsDigit))
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Ad bos buraxila bilmez. Adinizi daxil edin:");
                }
                else if (name.Length < 3)
                {
                    Console.WriteLine("Ad minimum 3 herifden ibaret olmalidir. Adinizi daxil edin:");
                }
                else if (name.Any(char.IsDigit))
                {
                    Console.WriteLine("Ad da reqem olmamalidir. Adinizi daxil edin:");
                }
                name = Console.ReadLine();
            }

            Console.WriteLine("Soyadinizi daxil edin:");
            string surname = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(surname) || surname.Length < 3 || surname.Any(char.IsDigit))
            {
                if (string.IsNullOrWhiteSpace(surname))
                {
                    Console.WriteLine("Soyad bos buraxila bilmez. Soyadinizi daxil edin:");
                }
                else if (surname.Length < 3)
                {
                    Console.WriteLine("Soyad minimum 3 herifden ibaret olmalidir. Soyadinizi daxil edin:");
                }
                else if (surname.Any(char.IsDigit))
                {
                    Console.WriteLine("Soyad da reqem olmamalıdır. Soyadinizi daxil edin:");
                }
                surname = Console.ReadLine();
            }

            Console.WriteLine("Yasinizi daxil edin:");
            int age;

            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.WriteLine("Yasinizi duzgun daxil edin:");
            }

            try
            {
                User user = new User(name, surname, age);
                user.PrintUserInfo();

                string newPassword = "";
                string confirmPassword = "";
                bool validPassword = false;

                while (!validPassword)
                {
                    Console.WriteLine($"Yeni sifreni daxil edin (minimum 7 herf ve reqemlerden olmali ve minimum 1 boyuk herf, 1 kicik herf ve reqemlerden ibaret olmalıdır):");
                    newPassword = Console.ReadLine();

                    if (newPassword.Length < 7 || !newPassword.Any(char.IsUpper) || !newPassword.Any(char.IsLower) || !newPassword.Any(char.IsDigit))
                    {
                        Console.WriteLine("Sifre uygun deyil. Yeniden cehd edin.");
                        continue;
                    }

                    Console.WriteLine("Sifreni tesdiq edin:");
                    confirmPassword = Console.ReadLine();

                    if (newPassword != confirmPassword)
                    {
                        Console.WriteLine("Tesdiq sifresi uygun gelmir. Yeniden cehd edin.");
                    }
                    else
                    {
                        validPassword = true;
                    }
                }

                User.Password = newPassword;
                Console.WriteLine("Sifre ugurla deyisdirildi.");
                Console.WriteLine();
                user.PrintUserInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine("İstifadəçi yaradıla bilmədi: " + ex.Message);
            }
        }
    }
}
