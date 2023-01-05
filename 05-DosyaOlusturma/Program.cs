using System.IO;

class Program
{
    static void Main(string[] args)
    {
        StreamWriter sw = new StreamWriter("C:\\Users\\AEK\\Desktop\\Metin Belgesi.txt");

        Console.Write("Mesajinizi giriniz: ");
        string mesaj = Console.ReadLine();

        sw.Write(mesaj);
        sw.Close();
    }
}