namespace ExtensionMethods
{
    public static class AllExtensions
    {
        public static int GetSquare(this int number)
        {
            return number * number;
        }

        public static string ToTitleCase(this string value)
        {
            //türkay ürkmez
            //Türkay Ürkmez
            var wordArray = value.Split(' ');
            var titleFormat = new List<string>();
            wordArray.ToList().ForEach(word =>
            {
                titleFormat.Add(word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower());
            });

            return string.Join(' ', titleFormat.ToArray());
        }

        public static string NextLetter(this Random random)
        {
            int asciiCode = random.Next(65, 90);
            return Convert.ToString((char)asciiCode);

        }

        public static string NextWord(this Random random, int length)
        {
            string randomWord = string.Empty;
            for (int i = 0; i < length; i++)
            {
                randomWord += random.NextLetter();
            }

            return randomWord;
        }

    }
}
