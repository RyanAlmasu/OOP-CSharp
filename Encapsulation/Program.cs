public class Program
{
    public static void Main(string[] args)
    {   
        Speed download= new Speed(150);
        
        Console.WriteLine($"The download speed is about to: {download.getSpeed} MBps");

    }
}