namespace Task3
{
    internal class User
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public static string Password { get; set; }

        public User(string name, string surname, int age)
        {

            Name = Capitalize(name);
            Surname = Capitalize(surname);
            Age = age;
        }

        public void PrintUserInfo()
        {
            Console.WriteLine($"Ad: {Name}");
            Console.WriteLine($"Soyad: {Surname}");
            Console.WriteLine($"Yaş: {Age}");
            Console.WriteLine($"Şifrə: {Password}");
        }
        private string Capitalize(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return "";
            }

            string[] parts = word.ToLower().Split(' ');
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = char.ToUpper(parts[i][0]) + parts[i][1..];
            }
            return string.Join(" ", parts);
        }
    }
}
