public class Food : Product 
{
    public int _Expired {get; set;}
    public double _totalFat {get; set;}   

    public double _totalProtein {get; set ;}
    public Food( int id, string name, double price, int quantity, string productName, int day, int expire , double totalFat, double totalProtein )
    : base(id, name, price, quantity, productName, day)
    {
        _Expired = expire;
        _totalFat = totalFat;
        _totalProtein = totalProtein;  
    }

    public void Healthy()
    {
            if (_totalFat <= 20 && _totalFat >= 0)
            {
                Console.WriteLine("Healthy");
            }
            else if (_totalFat > 100)
            {
                Console.WriteLine("Not healthy, your calory is too high");
            }
            else 
            {
                Console.WriteLine("ERROR");
            }
    }

    public override string ToString()
    {
        base.ToString();
        return base.ToString() + $"And the expired date is about: {_Expired} days";
    }
}