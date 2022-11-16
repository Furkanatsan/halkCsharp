using Inheritance;

Asci asci = new Asci();
Corba domatesCorbasi = new Corba();
domatesCorbasi.PismeSuresi = 5;
EtYemegi kofte = new EtYemegi();
kofte.PismeSuresi = 20;

Baklava baklava = new Baklava();
baklava.PismeSuresi = 60;


asci.Pisir(domatesCorbasi);
asci.Pisir(kofte);
asci.Pisir(baklava);

object o = "test";
