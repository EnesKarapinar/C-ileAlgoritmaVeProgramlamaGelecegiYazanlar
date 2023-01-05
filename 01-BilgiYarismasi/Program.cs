class Program
{
    static void Main(string[] args)
    {
        int dogru = 0;
        int soru = 1;
        string cevap;

        do
        {
            if (soru == 1)
            {
                Console.WriteLine("Turkiyenin baskenti neredir?\nA) Ankara\nB) Istanbul\nC) Kirikkale");
                cevap = Console.ReadLine();
                if (cevap == "A")
                {
                    dogru++;
                    Console.WriteLine("Dogru cevap");
                    soru++;
                }
                else
                {
                    Console.WriteLine("Yanlis cevap");
                    break;
                }
            }

            if (soru == 2)
            {
                Console.WriteLine("Atatürk tarafından 4 Eylül 1919 tarihinde Sivas Kongresi'nde kurulmuş olan gazetenin adı?\nA) Irade-i Vatan\nB) Irade-i Turkiye\nC) Irade-i Milliye");
                cevap = Console.ReadLine();
                if (cevap == "C")
                {
                    dogru++;
                    Console.WriteLine("Dogru cevap");
                    soru++;
                }
                else
                {
                    Console.WriteLine("Yanlis cevap");
                    break;
                }
            }

            if (soru == 3)
            {
                Console.WriteLine("‘Türk Devleti bir Cumhuriyettir.’ ifadesi anayasamızın kaçıncı maddesidir?\nA) 2\nB) 1\nC) 3");
                cevap = Console.ReadLine();
                if (cevap == "B")
                {
                    dogru++;
                    Console.WriteLine("Dogru cevap");
                    soru++;
                }
                else
                {
                    Console.WriteLine("Yanlis cevap");
                    break;
                }
            }

            if (soru == 4)
            {
                Console.WriteLine("Cumhurbaşkanı kim tarafından seçilir?\nA) Halk tarafından seçimle\nB) Meclis tarafından seçimle\nC) Babadan Ogula");
                cevap = Console.ReadLine();
                if (cevap == "A")
                {
                    dogru++;
                    Console.WriteLine("Dogru cevap");
                    soru++;
                }
                else
                {
                    Console.WriteLine("Yanlis cevap");
                    break;
                }
            }
        }
        while (dogru == 3 || soru == 4);
    }
}