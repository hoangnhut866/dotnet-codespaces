public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Speak()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }
}


public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} barks.");
    }

    public override void Speak()
    {
        Bark();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Buddy", 2);
        dog.Speak();
    }
}
