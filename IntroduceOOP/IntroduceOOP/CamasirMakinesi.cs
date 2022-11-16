namespace IntroduceOOP
{
    public enum CamasirTuru
    {
        Beyaz,
        Renkli,
        Pamuklu
    }
    public class CamasirMakinesi
    {
        public string Renk;

        public void Calistir(CamasirTuru camasirTuru)
        {

        }
        public void Yika()
        {
            Console.WriteLine("Çamaşırlar yıkanıyor");
        }

        public void Kurut()
        {
            Console.WriteLine("Çamaşırlar kurutuluyor");
        }
    }
}
