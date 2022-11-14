//bmi = kilo / (metre *metre)
Console.WriteLine("lütfen kilonuzu giriniz:");

try
{
	var kilo = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Boyunuzu metre cinsinden giriniz");
	var boy = Convert.ToDouble(Console.ReadLine());

	//var sadece metot scope'u içinde kullanılır.
	var bmi = kilo / (boy * boy);
	Console.WriteLine($"BMI sonucunuz:{bmi}");
}
catch (FormatException exception)
{

	Console.WriteLine("Girdiğiniz değerler, sadece sayısal olmalı");
}

try
{
	Console.WriteLine("Bölünecek sayı:");
	var bolunecek = Convert.ToInt32(args[0]);
	Console.WriteLine("Bölen Sayı");
	var bolen = Convert.ToInt32(Console.ReadLine());
	var sonuc = bolunecek / bolen;

	Console.WriteLine($"{bolunecek} sayısını {bolen} sayısına böldüğümüzde sonuç: {sonuc}, kalan ise {bolunecek % bolen}");
}
catch (FormatException)
{
	Console.WriteLine("Lütfen sayısal değer girin...");

}
catch (DivideByZeroException)
{
	Console.WriteLine("Tam sayılar, 0'a bölünemez");
}
catch (Exception exception)
{
	Console.WriteLine($"Bir hata meydana geldi... İşleme devam edemiyorum....Hata detayı:{exception.Message}");
}

