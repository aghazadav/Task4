namespace Task1
{
    public class Person
    {
        private string fullName;

        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
            SetFullName();
        }

        private void SetFullName()
        {
            fullName = Name + " " + Surname;
        }

        public string GetFullName()
        {
            return fullName;
        }
    }
}
