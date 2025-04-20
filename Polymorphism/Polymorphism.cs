public class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public virtual void MakeSound()
    {}
    public virtual void Walk()
    {}
    public virtual void Eat()
    {}
}
public class Dog : Animal 
{
    public Dog(string name ) : base(name) {}
    public override void MakeSound()
    {
        Console.WriteLine($" {Name} says Woof!");
    }
    public override void Walk()
    {
        Console.WriteLine("Dog might running around");
    }
}
public class Cat : Animal
{
    public Cat(string name ) : base(name) {}
    public override void MakeSound()
    {
        Console.WriteLine($" {Name} says Meow!");
    }
    public override void Walk()
    {
        Console.WriteLine("Cat might jumping around");
    }
}
public class Cow : Animal 
{
    public Cow(string name ) : base(name) {}
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says Moo!");
    }
    public override void Walk()
    {
        Console.WriteLine("Cow might running slowly");
    }
}