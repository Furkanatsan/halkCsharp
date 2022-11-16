namespace Constructor
{
    public class ExcelRaporOlusturucu
    {

        public ExcelRaporOlusturucu(string dosyaAdresi)
        {
            DosyaAdresi = dosyaAdresi;
        }

        public string DosyaAdresi { get; set; }
        public void DosyayiAc()
        {
            //verilen excel adresinden dosyayı oku!
        }

        public void VeriyiOku() { }


    }
}
