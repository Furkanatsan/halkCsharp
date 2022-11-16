namespace OverloadingAndOptionalParams
{
    public enum Sekil
    {
        Kare,
        Ucgen,
        Daire,
        Dikdortgen
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var kareAlani = alanHesapla(5, Sekil.Kare);
            var ucgen = alanHesapla(12, 3, Sekil.Ucgen);

            Console.WriteLine($"Karenin alanı:{kareAlani}\nÜçgenin alanı:{ucgen}");

            var optKare = opsiyonelAlanHesapla(5);
            var optDaire = opsiyonelAlanHesapla(3, Sekil.Daire);
            var optUcgen = opsiyonelAlanHesapla(5, birim2: 4, sekil: Sekil.Ucgen);
            //named parameters
            var optDikdortgen = opsiyonelAlanHesapla(birim1: 5, sekil: Sekil.Dikdortgen, birim2: 8);

            Console.WriteLine($"Kare:{optKare}\nDaire:{optDaire}\nÜçgen:{optUcgen}\nDikdörtgen:{optDikdortgen}");



        }

        /// <summary>
        /// Tek birimle alanı hesaplanabilen basit geometrik şekillerin alanını hesaplar
        /// </summary>
        /// <param name="birim1">Şeklin birim uzunluğunu girin.</param>
        /// <param name="sekil">Alanı hesaplanacak şekli (daire ya da kare) girin</param>
        /// <returns></returns>
        static double alanHesapla(double birim1, Sekil sekil)
        {
            double sonuc = 0;
            switch (sekil)
            {
                case Sekil.Kare:
                    sonuc = Math.PI * Math.Pow(birim1, 2);
                    break;
                case Sekil.Daire:
                    sonuc = Math.Pow(birim1, 2);
                    break;
                default:
                    break;
            }
            return sonuc;
        }
        static double alanHesapla(double birim1, double birim2, Sekil sekil)
        {
            double sonuc = 0;
            //switch (sekil)
            //{
            //    case "üçgen":
            //        sonuc = (birim1 * birim2) / 2;
            //        break;
            //    case "dikdörtgen":
            //        sonuc = birim1 * birim2;
            //        break;
            //    default:
            //        break;
            //}
            switch (sekil)
            {

                case Sekil.Ucgen:
                    sonuc = (birim1 * birim2) / 2;
                    break;
                case Sekil.Dikdortgen:
                    sonuc = birim1 * birim2;
                    break;
                default:
                    break;
            }

            return sonuc;
        }

        static double opsiyonelAlanHesapla(double birim1, Sekil sekil = Sekil.Kare, double birim2 = 1)
        {

            switch (sekil)
            {
                case Sekil.Kare:
                    return Math.Pow(birim1, 2);
                case Sekil.Ucgen:
                    return (birim1 * birim2) / 2;

                case Sekil.Daire:
                    return Math.PI * Math.Pow(birim1, 2);
                case Sekil.Dikdortgen:
                    return birim1 * birim2;
                default:
                    return 0;

            }
        }



    }
}