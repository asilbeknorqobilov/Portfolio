using System;

namespace Topshiriq;

class Program
{
    public static void task5_a()
    {
        Ratsional kasr1 = new Ratsional(4, 10);
        Ratsional kasr2 = new Ratsional(2, 3);
        Console.WriteLine(kasr1.Equals(kasr2));
        Console.WriteLine("-------------------");
    }

    public static void task5_b()
    {
        Ratsional a = new Ratsional(4, 8);
        Ratsional b = new Ratsional(2, 4);
        a = a.Qisqartir();
        b = b.Qisqartir();
        a = (a + b);
        Console.WriteLine(a.Qisqartir()); 
        Console.WriteLine("-------------------");

    }

    public static void task5_d()
    {
        Ratsional a = new Ratsional(60, 120);
        a = a.Qisqartir(); //RAtsional qaytaradi
        Console.WriteLine(a);
        Console.WriteLine("-------------------");

    }

    public static void task5_e()
    {
        Console.WriteLine("Massiv elementlar sonini kiriting");
        int n = Convert.ToInt32(Console.ReadLine());
        Ratsional[] r = new Ratsional[n];
        Console.WriteLine("Massiv elementlarini kiriting");
        for (int i = 0; i < n; i++)
        {
            r[i] = new Ratsional(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"{i} - ratsional son ={r[i]}");
            Console.WriteLine("-------------------");

        }


        Ratsional max = ratsional_max(r);
        Console.WriteLine($"Eng kattasi {max}");
    }

    public static Ratsional ratsional_max(Ratsional[] r)
    {
        Ratsional max = r[0];
        for (int i = 1; i < r.Length; i++)
        {
            if (max.kichik(r[i]))
            {
                max = r[i];
            }
        }
        return max;
    }

    static void Main(string[] args)
    {
        task5_a();
        task5_b();
        task5_d();
        task5_e();
    }

    // public static void mantiqiy_ifoda_task()
    // {
    //     string ifoda = "!(&&(||(false,!(false)),true,!(true)))";
    //     MantiqiyIfoda mi = new MantiqiyIfoda();
    //     bool x = mi.oprand_and(mi.oprand_or(false, mi.operand_not(false)), true, mi.operand_not(true));
    //     Console.WriteLine(x);
    // }
    //
    // static void Main(string[] args)
    // {
    //     mantiqiy_ifoda_task();
    // }
}