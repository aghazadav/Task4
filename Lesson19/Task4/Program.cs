namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length;
            bool validLength = false;

            do
            {
                Console.WriteLine("Massiv uzunlugunu daxil edin:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out length) && length > 0)
                {
                    validLength = true;
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz qiymət düzgün deyil. Massiv uzunluğu müsbət tam ədəd olmalıdır.");
                }
            } while (!validLength);

            int[] array = new int[length];

            Console.WriteLine("Massiv elementlerini daxil edin:");

            for (int i = 0; i < length; i++)
            {
                bool validNumber = false;

                do
                {
                    Console.Write($"Element {i + 1}: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out array[i]))
                    {
                        validNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Daxil etdiyiniz eded duzgun deyil. Yeniden cehd edin.");
                    }
                } while (!validNumber);
            }

            Dictionary<int, List<int>> duplicateElements = FindDuplicateElements(array);

            if (duplicateElements.Count == 0)
            {
                Console.WriteLine("Massivde tekrarlanan element yoxdur.");
            }
            else
            {
                Console.WriteLine("Tekrarlanan elementler:");

                foreach (var x in duplicateElements)
                {
                    Console.WriteLine($"Element: {x.Key}, Indexler: {string.Join(", ", x.Value)}");
                }
            }
        }

        static Dictionary<int, List<int>> FindDuplicateElements(int[] array)
        {
            Dictionary<int, List<int>> duplicateElements = new Dictionary<int, List<int>>();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        if (!duplicateElements.ContainsKey(array[i]))
                        {
                            duplicateElements.Add(array[i], new List<int>());
                        }

                        if (!duplicateElements[array[i]].Contains(i))
                        {
                            duplicateElements[array[i]].Add(i);
                        }

                        if (!duplicateElements[array[i]].Contains(j))
                        {
                            duplicateElements[array[i]].Add(j);
                        }
                    }
                }
            }

            return duplicateElements;
        }
    }
}
