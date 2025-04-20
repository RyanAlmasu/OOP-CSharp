using System.Security.Cryptography.X509Certificates;

public class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public virtual void MakeSound()
    {
    
    }
}
public class Dog : Animal 
{
    public Dog(string name ) : base(name) {}
    public override void MakeSound()
    {
        Console.WriteLine($" {Name} says Woof!");
    }
}
public class Cat : Animal
{
    public Cat(string name ) : base(name) {}
    public override void MakeSound()
    {
        Console.WriteLine($" {Name} says Meow!");
    }
}
public class Cow : Animal 
{
    public Cow(string name ) : base(name) {}
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says Moo!");
    }
}