namespace Topshiriq;

public class Butun_sonlar
{
    public int a;
    public int b;

    public Butun_sonlar(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public int Ekuk()
    {
        int x = a, y = b;
        while (x != y)
        {
            if (x > y)
            {
                y += b;
            }
            else
            {
                x += a;
            }
        }

        return x;
    }
    
}