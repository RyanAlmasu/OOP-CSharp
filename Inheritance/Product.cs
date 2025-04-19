using System.Security.Cryptography.X509Certificates;

public class Product
{
    public int _Id {get ; set; }
    public string _Name { get; set; }
    public double _Price { get; set; }  

    public int _Quantity { get; set; }

    public string _ProductName { get; set; }   

    public int _Day { get; set; }   

    public Product( int id, string name, double price, int quantity, string productName, int day)
    {
        _Id = id;
        _Name = name;
        _Price = price;
        _Quantity = quantity;
        _ProductName = productName;
        _Day = day;

    }

    public double CalculatePrice()
    {
        try
        {
            return _Price * _Quantity;
        }
        catch
        {
            if ( _Quantity <= 0)
            {
                return 1;
            }
            return _Quantity;

        }
    }

    public void ExpensiveOrCheap()
    {
        double Nominal = CalculatePrice();

        if ( Nominal >= 50 )
        {
            Console.WriteLine("This is expensive");
        }
        else 
        {
            Console.WriteLine("Cheap!");
        }
  
    }

    public void DayConvert()
    {
        int forDay = _Day;
        {
            switch ( forDay )
            {
                case 1 :
                Console.WriteLine("Monday");
                break;
                case 2 :
                Console.WriteLine("Tuesday");
                break;
                case 3 :
                Console.WriteLine("Wednesday");
                break;
                case 4 :
                Console.WriteLine("Thursday");
                break;
                case 5 :
                Console.WriteLine("Friday");
                break;
                case 6 :
                Console.WriteLine("Saturday");
                break;                
                case 7 :
                Console.WriteLine("Sunday");
                break;
            }
        }
    }
    public override string ToString()
    {
        return $"Details:\n{_Id} | {_Name} | {_ProductName} | price: {_Price} with the quantity of: {_Quantity} and buying for about: {CalculatePrice()} $ after total price";
    }
}