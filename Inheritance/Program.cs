public class Program
{
    public static void Main()
    {
        Product person = new Product(1, "Sarah", 20, 3, "Laptop", 2);
        Food personFood = new Food(2, "Alex", 5, 6, "Seblak", 1, 1, 40, 20);
        Food personFood1 = new Food(3, "Buzer", 7, 1, "Seblak", 2, 4, 150, 230);

        Console.WriteLine(person); 
        person.ExpensiveOrCheap();
        person.DayConvert();

        Console.WriteLine();

        Console.WriteLine(personFood); 
       

        personFood.ExpensiveOrCheap();
        personFood.DayConvert();
        personFood.Healthy();

        Console.WriteLine(personFood1); 
        personFood1.ExpensiveOrCheap();
        personFood1.DayConvert();
        personFood1.Healthy();



    }
}