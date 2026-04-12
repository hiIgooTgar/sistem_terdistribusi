class ProgramSecond{
    public class NonThread
    {
        public void cuci_baju()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Cuci baju ke {0}", i);
            }
        }

        public void setrika()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Setrika ke {0}", i);
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("===============================");
        Console.WriteLine("== Mulai Melakukan Praktikum ==");
        Console.WriteLine("===============================");

        NonThread trNon1 = new NonThread();
        trNon1.cuci_baju();
        trNon1.setrika();

        Console.WriteLine("===============================");
        Console.WriteLine("====== Program Selesai!  ======");
        Console.WriteLine("===============================");
        Console.ReadLine();
    }
}
