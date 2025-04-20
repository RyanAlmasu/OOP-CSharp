public class Program
{
    public static void Main(string[] args)

    {
        List<Animal> animals= new List<Animal>
        {
            new Dog("Parg"),
            new Cat("Puff"),
            new Cow("Jui"),
        };


        foreach( Animal animal in animals)
        {
            animal.MakeSound();
            animal.Walk();
        }


    }
}