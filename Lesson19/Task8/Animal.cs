class Animal
{
    private string name;
    private int age;
    private bool hasOwner;

    public Animal(string name, int age, bool hasOwnerString)
    {
        Name = name;
        Age = age;
        HasOwner = hasOwnerString;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (!value.Any(char.IsDigit))
            {
                name = value;
            }
            else
            {
                throw new ArgumentException("Ad da reqem olabilmez.");
            }
        }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public bool HasOwner
    {
        get { return hasOwner; }
        set { hasOwner = value; }
    }

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} yemek yeyir.");
    }

    public virtual void Sleep()
    {
        Console.WriteLine($"{Name} yatir.");
    }
}

