namespace Inheritance
{
    public class Yemek
    {
        public double Fiyat { get; set; }
        public int Porsiyon { get; set; }

        public string[] Malzemeler { get; set; }

        public int PismeSuresi { get; set; }

        public void Pisir()
        {
            Console.WriteLine($"{GetType().Name} yemeği, {PismeSuresi} dakikada pişirildi");
        }

        public virtual void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} yemeği, yanında pilav ile sunuldu");
        }


    }


    public class Corba : Yemek
    {
        public bool BaharatVarMi { get; set; }
    }

    public class SebzeYemegi : Yemek
    {
        public int ZeytinYagiOrani { get; set; }
    }

    public class Tatli : Yemek
    {

    }


    public class Baklava : Tatli
    {
        public override void SunumYap()
        {
            Console.WriteLine($"{GetType().Name} yemeği, yanında sade dondurma ile sunuldu");
        }
    }

    public class EtYemegi : Yemek
    {
        public string PismeBicimi { get; set; }
    }
}
