class Program
{
    static void Main(string[] args)
    {
        int bakteri = 1;
        int saat;

        Console.Write("Kac saat sonra: ");
        saat = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= saat; i++)
        {
            bakteri *= 2;
        }

        Console.WriteLine($"{saat} saat sonra bakteri sayisi: {bakteri}");
    }
}