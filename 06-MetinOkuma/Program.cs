using System.IO;


class Program
{
    static void Main(string[] args)
    {
        FileStream fs = new FileStream("C:\\Users\\AEK\\Desktop\\Metin Belgesi.txt", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        string metin = sr.ReadLine();
        while(metin != null)
        {
            Console.WriteLine(metin);
            metin = sr.ReadLine();
        }
        sr.Close();
        fs.Close();
    }
}