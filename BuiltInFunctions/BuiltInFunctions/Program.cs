namespace BuiltInFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kelime = "halkbank";
            Console.WriteLine("Aranacak harf");
            var aranacakKelime = Console.ReadLine();
            bool harfVarMi = kelime.Contains(aranacakKelime);
            if (harfVarMi)
            {
                Console.WriteLine($"{kelime.ToUpper()} içinde {aranacakKelime.ToUpper()} ifadesi bulunuyor...");
            }

            char aranacakHarf = Convert.ToChar(Console.ReadLine());
            int index = kelime.IndexOf(aranacakHarf);

            //Console.WriteLine($"{kelime} kelimesinde {aranacakHarf} harfinin indexi {index}...");
            int baslangicNoktasi = 0;
            int bulunanIndex = 0;
            while (kelime.IndexOf(aranacakHarf, baslangicNoktasi) != -1)
            {
                bulunanIndex = kelime.IndexOf(aranacakHarf, baslangicNoktasi);
                baslangicNoktasi = bulunanIndex + 1;
                Console.WriteLine($"{aranacakHarf}, {kelime} kelimesinin {bulunanIndex}. indexinde");
            }

            int sayi = 5;
            Console.WriteLine(Convert.ToString(sayi--));
            Console.WriteLine(sayi);

        }
    }
}