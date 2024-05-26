namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                Console.WriteLine("Heyvanin tipini daxin edin (it/pisik), cixmaq ucun 'cixis' yazin:");
                string input = Console.ReadLine().ToLower();

                if (input == "cixis")
                {
                    break;
                }

                if (input != "it" && input != "pisik")
                {
                    Console.WriteLine("Sehv daxil etdiniz.'it' veya 'pisik' olaraq yazin.");
                    continue;
                }

                while (true)
                {
                    Console.WriteLine("Heyvanin adini daxil edin:");
                    string name = Console.ReadLine();
                    try
                    {
                        if (!name.Any(char.IsDigit))
                        {
                            Console.WriteLine("Heyvanin yasini daxil edin:");
                            int age;
                            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
                            {
                                Console.WriteLine("Duzgun yas daxil edin.:");
                            }

                            string hasOwnerInput;
                            bool hasOwner;
                            do
                            {
                                Console.WriteLine("Heyvanin sahibi var yoxsa yox? (b/x):");
                                hasOwnerInput = Console.ReadLine().ToLower();
                            } while (hasOwnerInput != "b" && hasOwnerInput != "x");

                            hasOwner = hasOwnerInput == "b";

                            Animal animal;
                            if (input == "it")
                            {
                                animal = new Dog(name, age, hasOwner);
                            }
                            else if (input == "pisik")
                            {
                                animal = new Cat(name, age, hasOwner);
                            }
                            else
                            {
                                Console.WriteLine("Heyvanin tipini daxil edin.");
                                continue;
                            }

                            animals.Add(animal);
                            Console.WriteLine($"{input} elave edildi: {name}.");

                            Console.WriteLine("Heyvanlarin siyahisini gormek isteyirsiniz mi? (b/x):");
                            string showList = Console.ReadLine().ToLower();
                            if (showList == "b")
                            {
                                Console.WriteLine("\nHeyvanlarin siyahisi:");
                                foreach (var a in animals)
                                {
                                    Console.WriteLine($"{animal.Name} ({animal.GetType().Name}), Yas: {animal.Age}, Sahibi: {animal.HasOwner}");
                                }
                            }

                            break;
                        }
                        else
                        {
                            throw new ArgumentException("Ad elave ederken reqem daxil etmeyin.");
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Xeta: " + ex.Message);
                    }
                }
            }

            Console.WriteLine("\nHeyvanlarin siyahisi:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name}, Yas: {animal.Age}, Sahibi: {animal.HasOwner}");
                animal.Eat();
                animal.Sleep();
                Console.WriteLine();
            }
        }
    }
}
