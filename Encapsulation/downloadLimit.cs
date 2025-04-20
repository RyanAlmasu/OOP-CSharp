public class Speed
{
    private int speed;
    public Speed(int speed)
    {
        getSpeed = speed;
    }

    public int getSpeed
    {
        get { return speed; }
        set { 
            if (value > 100)
            {
                Console.WriteLine("Dont too fast your speed is now limited to: 100");
                speed = 100;
            }
            else 
            {
                speed = value;
            }

            }
    }
}