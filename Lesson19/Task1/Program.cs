namespace Task1
{
    /*
        Bir class yaradın. Bu classın name və surname propeprtyləri və fullname adlı fieldi olsun. 
    Fullname fieldinə qıraqdan əl çatmaq olmasın.siz name və surname əlavə etdikdə fulname ad + soyad olaraq təyin edilsin.

     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Adınızı daxil edin: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.Write($"Soyadinizi daxil edin: ");
            string surname = Console.ReadLine();
            Console.WriteLine();

            Person person = new Person(name, surname);
            Console.WriteLine($"Tam adiniz: " + person.GetFullName());


        }
    }
}
