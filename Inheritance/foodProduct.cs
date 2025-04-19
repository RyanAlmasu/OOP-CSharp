public class Food : Product 
{
    public int _Expired {get; set;}

    public Food( int id, string name, double price, int quantity, string productName, int day, int expire )
    : base(id, name, price, quantity, productName, day)
    {
        _Expired = expire;
    }

    public override string ToString()
    {
        base.ToString();
        return base.ToString() + $"And the expired date is about: {_Expired} days";
    }
}