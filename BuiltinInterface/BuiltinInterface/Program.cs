//List<string> countries = new List<string>();
//countries.Add("Türkiye");
//countries.Add("Almanya");
//var country = countries.g

using BuiltinInterface;

Announce announce = new Announce { CreatedDate = new DateTime(2022, 4, 1), Title = "Rent a House", Description = "Good place :)" };
Announce carAnnounce = new Announce { CreatedDate = new DateTime(2021, 1, 1), Title = "My car is open for order", Description = "Low KM" };

AnnounceList announceList = new AnnounceList();
announceList.AddAnnounce(announce);
announceList.AddAnnounce(carAnnounce);

//var list = announceList.OrderAnnounce();
foreach (var ann in announceList)
{
    Console.WriteLine(ann.Title);
}

