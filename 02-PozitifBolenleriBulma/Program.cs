class Program
{
    static void Main(string[] args)
    {
        int sayi;
        string bolenler = "";
        Console.Write("Bir sayi giriniz: ");
        sayi = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= sayi; i++)
        {
            if (sayi % i == 0)
            {
                bolenler += i + " ";
            }
        }

        Console.WriteLine(bolenler);
    }
}