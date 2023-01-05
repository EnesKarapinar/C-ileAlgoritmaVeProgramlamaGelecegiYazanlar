using System.Drawing;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Clear();

        int toplamFiyat = 0;
        string secim;

        Console.WriteLine("********************************************************************************");
        Console.WriteLine();
        Console.WriteLine("**  Turkce Kitaplar Kategorisi         **  Yabanci Kitaplar Kategorisi        **");
        Console.WriteLine();
        Console.WriteLine("**  1-Calikusu: Resat Nuri             **  7-Tuna Kilavuzu: Jules Verne       **");
        Console.WriteLine();
        Console.WriteLine("**  2-Yaban: Yakup Kadri               **  8-Bir Kuzey Macerasi: Jack London  **");
        Console.WriteLine();
        Console.WriteLine("**  3-Sinekli Bakkal: Halide Edip      **  9-Altinci Kogus: Anton Cehov       **");
        Console.WriteLine();
        Console.WriteLine("**  4-Tehlikeli Oyunlar: Oguz Atay     **  10-Kumarbaz: Dostoyevski           **");
        Console.WriteLine();
        Console.WriteLine("**  5-Gectigim Gunlerden: H.Yucel      **  11-Iki Sehrin Hikayesi: C.Dickens  **");
        Console.WriteLine();
        Console.WriteLine("**  6-Kuyucakli Yusuf: Sabahattin Ali  **  12-Visne Bahcesi: Anton Cehov      **");
        Console.WriteLine();
        Console.WriteLine("********************************************************************************");
        Console.WriteLine();
        Console.WriteLine("***** Islemler Menusu *****");
        Console.WriteLine();
        Console.WriteLine("1-Fiyat Sorgulama");
        Console.WriteLine("2-Yeni Okur Kayit");
        Console.WriteLine("3-Gunun Kitabi");
        Console.WriteLine("4-Kitap Arsivi");
        Console.WriteLine("5-Yeni Kitap Satin Al");
        Console.WriteLine("6-Oyun");
        Console.WriteLine();
        Console.Write("Yapmak istediginiz islemin numarasi: ");

        char islem;
        islem = Convert.ToChar(Console.ReadLine());
        switch (islem)
        {
            case '1':
                Console.WriteLine();
                Console.Write("Lutfen fiyatini ogrenmek istediginiz kitabin numarasini giriniz: ");
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1": Console.WriteLine("Calikusu: 12 TL"); break;
                    case "2": Console.WriteLine("Yaban: 14 TL"); break;
                    case "3": Console.WriteLine("Sinekli Bakkal: 16 TL"); break;
                    case "4": Console.WriteLine("Tehlikeli Oyular: 11 TL"); break;
                    case "5": Console.WriteLine("Gectigim Gunlerden: 8 TL"); break;
                    case "6": Console.WriteLine("Kuyucakli Yusuf: 13 TL"); break;
                    case "7": Console.WriteLine("Tuna Kilavuzu: 17 TL"); break;
                    case "8": Console.WriteLine("Bir Kuey Macerasi: 4 TL"); break;
                    case "9": Console.WriteLine("Altinci Kogus: 5 TL"); break;
                    case "10": Console.WriteLine("Kumarbaz: 10 TL"); break;
                    case "11": Console.WriteLine("Iki Sehrin Hikayesi: 13 TL"); break;
                    case "12": Console.WriteLine("Visne Bahcesi: 6 TL"); break;
                    default: Console.WriteLine("Boyle bir kitap mevcut degil, numarayi kontrol edin"); break;
                }
                break;
            case '2':
                Console.WriteLine("***** Yeni Okur Kaydi *****");
                string ad, soyad, universite, dosya = "D:\\software\\gelecegiYazanlarC#\\GelecegiYazanlar\\08-KitaplikProjesi\\Kullanicilar.txt";
                Console.Write("Adiniz: ");
                ad = Console.ReadLine();
                Console.Write("Soyadiniz: ");
                soyad = Console.ReadLine();
                Console.Write("Universiteniz: ");
                universite = Console.ReadLine();

                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adiniz: " + ad);
                sw.WriteLine("Soyadiniz: " + soyad);
                sw.WriteLine("Universite: " + universite);
                sw.WriteLine("");
                sw.Close();

                break;
            case '3':
                Console.WriteLine();
                Console.WriteLine("*****************************************");
                Console.WriteLine("*                                       *");
                Console.WriteLine("*   *********************************   *");
                Console.WriteLine("***** Gunun Kitabi : Sinekli Bakkal *****");
                Console.WriteLine("*   *********************************   *");
                Console.WriteLine("*                                       *");
                Console.WriteLine("*****************************************");
                Console.WriteLine();
                break;
            case '4':
                Console.WriteLine();
                Console.WriteLine("*****************************************");
                Console.WriteLine();
                FileStream fs = new FileStream("D:\\software\\gelecegiYazanlarC#\\GelecegiYazanlar\\08-KitaplikProjesi\\Kitaplar.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                Console.WriteLine();
                Console.WriteLine("*****************************************");
                break;
            case '5':
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacaginiz Kitabin Numarasi: ");
                    Console.WriteLine();
                    secim = Console.ReadLine();
                    switch (secim)
                    {
                        case "1": toplamFiyat += 12; break;
                        case "2": toplamFiyat += 14; break;
                        case "3": toplamFiyat += 16; break;
                        case "4": toplamFiyat += 11; break;
                        case "5": toplamFiyat += 8; break;
                        case "6": toplamFiyat += 13; break;
                        case "7": toplamFiyat += 17; break;
                        case "8": toplamFiyat += 4; break;
                        case "9": toplamFiyat += 5; break;
                        case "10": toplamFiyat += 10; break;
                        case "11": toplamFiyat += 13; break;
                        case "12": toplamFiyat += 6; break;
                        default:
                            Console.WriteLine("Boyle bir kitap numarasi yok");
                            Console.WriteLine();
                            break;
                    }
                    Console.Write("Baska bir kitap almak ister misiniz: ");
                    string cevap = Console.ReadLine();
                    if (cevap == "h" || cevap == "H" || cevap == "hayir" || cevap == "HAYIR")
                    {
                        break;
                    }
                }
                Console.WriteLine("Toplam tutar: " + toplamFiyat);
                break;
            case '6':
                Console.WriteLine();
                int tahmin = 0;
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);
                while(sayi != tahmin)
                {
                    Console.Write("Sayi Giriniz: ");
                    tahmin = Convert.ToInt16(Console.ReadLine());
                    if (tahmin > sayi)
                    {
                        Console.Write("Daha Kucuk Bir ");
                    }
                    if (tahmin < sayi)
                    {
                        Console.Write("Daha Buyuk Bir ");
                    }
                    if (tahmin == sayi)
                    {
                        Console.WriteLine("Bildiniz");
                        break;
                    }
                }
                break;
            default:
                Console.WriteLine();
                Console.WriteLine("Hatali Secim");
                break;
        }
    }
}