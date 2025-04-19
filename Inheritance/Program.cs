public class Program
{
    public static void Main()
    {
        Product person = new Product(1, "Sarah", 20, 3, "Laptop", 2);
        Food personFood = new Food(2, "Alex", 5, 6, "Seblak", 1, 1);

        Console.WriteLine(person); 
        person.ExpensiveOrCheap();
        person.DayConvert();
        Console.WriteLine();
        Console.WriteLine(personFood); 
        personFood.ExpensiveOrCheap();
        personFood.DayConvert();


    }
}