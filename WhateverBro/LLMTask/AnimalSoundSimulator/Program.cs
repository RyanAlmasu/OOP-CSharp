public class Program
{
    public static void Main(string[] args)  
    {
        RunSimulator();
    }
    // So this is a function to Instantiate the 3 animal categories 
    static void RunSimulator()
    {
        Animal dog = new Dog("Fellow");
        Animal cat = new Cat("Boker");
        Animal cow =  new Cow("Jerapah");
        // Then i use list to store it
        List<Animal> animals = new List<Animal>()
        {
            dog,
            cat,
            cow
        };
        // Then i use foreach to print the ISound and Describe methods cuz i already override that on the list 
        foreach (Animal animal in animals) 
        {
            Console.WriteLine(animal.Describe());

            if (animal is ISound sound)

            {
                sound.MakeSound();
            }

            Console.WriteLine();
        } 
    }
}