using ExtensionMethods;

int number = 7;
Console.WriteLine(number.GetSquare());
Console.WriteLine(8.GetSquare());

List<string> participants = new List<string>()
{
    "çağAtAy öZCan",
    "berkAy cIlIz",

};
Console.WriteLine("türkay ürkmez".ToTitleCase());
participants.ForEach(p => Console.WriteLine(p.ToTitleCase()));

Console.WriteLine(new Random().NextLetter());
Console.WriteLine(new Random().NextWord(5));