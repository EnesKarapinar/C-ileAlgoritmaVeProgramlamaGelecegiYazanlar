class Program
{
    static void Main(string[] args)
    {
        int sayi, sonuc = 1, sayac = 1;
        Console.Write("Faktoriyel Hesabi icin sayi giriniz: ");
        sayi = Convert.ToInt32(Console.ReadLine());

        while(sayac <= sayi)
        {
            sonuc *= sayac;
            sayac++;
        }

        Console.WriteLine($"{sayi}! sayisinin faktoriyeli: {sonuc}");
    }
}