using System.Threading;

public class MyThread {
    public static void Thread1()
    {
        for (int i = 0; i < 10; i++) {
            Console.WriteLine("Cuci baju ke {0}", i);
            Thread.Sleep(3000);
        }
    }

    public static void Thread2()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Setrika ke {0}", i);
            Thread.Sleep(3000);
        }
    }
}

class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("===============================");
        Console.WriteLine("== Mulai Melakukan Praktikum ==");
        Console.WriteLine("===============================");

        Thread tr1 = new Thread(new ThreadStart(MyThread.Thread1));
        Thread tr2 = new Thread(new ThreadStart(MyThread.Thread2));

        tr1.Start();
        tr2.Start();

        Console.ReadLine();
    }
}
