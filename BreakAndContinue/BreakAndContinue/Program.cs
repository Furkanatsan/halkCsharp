namespace BreakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "klavye", "gitar", "armut", "webex", "yazılım" };
            //amaç: kullanıcının girdiği kelime; words içerisinde var mı?
            Console.WriteLine("Aranacak kelimeyi girin");
            string searchingWord = Console.ReadLine();
            bool isWordFinded = false;

            for (int i = 0; i < words.Length; i++)
            {
                if (searchingWord == words[i])
                {
                    Console.WriteLine($"{searchingWord} array içinde var.");
                    isWordFinded = true;
                    break;
                }
            }


            if (isWordFinded)
            {
                Console.WriteLine($"{searchingWord} kelimesi bulunamadı...");
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length != 5)
                {
                    continue;
                }
                Console.WriteLine(words[i]);
            }



        }
    }
}