using System.Reflection.Metadata.Ecma335;
public class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public virtual string Describe()
    {
        return $"The name of the animal is: {Name}";
    }

}
public interface ISound 
{
    public void MakeSound();
}

// I call the interface ISound and inherit the base class to derrived class
public class Dog : Animal, ISound
{
    public Dog(string Name) : base (Name){}
    public void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
    // Then i override the virtual describe methods to this class
    public override string Describe()
    {
        // This is for return the value of the base class describe methods
        return base.Describe();
    }
}
// I call the interface ISound and inherit the base class to derrived class
public class Cat : Animal, ISound
{
    public Cat(string Name) : base (Name){}
    
    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
    public override string Describe()
    {
        return base.Describe();
    }

}
// I call the interface ISound and inherit the base class to derrived class
public class Cow : Animal, ISound
{
    public Cow(string Name) : base (Name){}
    
    public void MakeSound()
    {
        Console.WriteLine("Mooo!");
    }
        public override string Describe()
    {
        return base.Describe();
    }
}