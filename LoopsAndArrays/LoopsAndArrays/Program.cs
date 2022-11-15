namespace LoopsAndArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 42, 60, 90, 0, -6, 150, 4 };


            //Minimum değeri bul:

            var minimum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (minimum > numbers[i])
                {
                    minimum = numbers[i];
                }
            }

            Console.WriteLine(minimum);

            //Ortalama al:
            var total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine($"Toplam: {total}");
            var avg = total / numbers.Length;
            Console.WriteLine($"Ortalama: {avg}");
        }


    }
}