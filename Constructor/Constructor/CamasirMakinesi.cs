namespace Constructor
{
    public class CamasirMakinesi
    {
        public string Renk { get; set; }
        public int Rpm { get; set; }
        public string EnerjiSinifi { get; set; }
        public string Marka { get; set; }
        public CamasirMakinesi()
        {
            Renk = "Beyaz";
        }

        public CamasirMakinesi(string marka)
        {
            Marka = marka;
        }


    }
}
