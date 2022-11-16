namespace Constructor
{
    public class Ekmek
    {
        public int Adet { get; set; }
        public string Tur { get; set; }

        public Ekmek() : this(1, "Beyaz Ekmek")
        {

        }
        public Ekmek(int adet) : this(adet, "Beyaz Ekmek")
        {

        }

        public Ekmek(string tur) : this(1, tur)
        {

        }

        public Ekmek(int adet, string tur)
        {
            Adet = adet;
            Tur = tur;
        }
    }
}
