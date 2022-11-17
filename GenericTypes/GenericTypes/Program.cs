// See https://aka.ms/new-console-template for more information
using GenericTypes;
using System.Collections;

object value = "Test";
object sayi = 5;
object random = new Random();

//object'den orjinal tipe yapılan casting'e unboxing diyoruz.
int x = (int)sayi;

GeneralPoint generalPoint = new GeneralPoint();
generalPoint.X = 8;
generalPoint.PositionPoint(13, 8);

//string xPosition = (string)generalPoint.X;

ArrayList simple = new ArrayList();
simple.Add(3);
simple.Add("üç");
simple.Add(false);

List<string> words = new List<string>()
{
    "Kale",
    "Coğrafya",
    "Topoloji"
};

words.Add("Hadi ara verelim :)");

int number = (int)simple[0];


GenericPoint<decimal> genericPoint = new GenericPoint<decimal>();
genericPoint.X = 1.14M;
genericPoint.Y = 2.48M;
genericPoint.Reset();

GenericPoint<Point> anotherGeneric = new GenericPoint<Point>();

sampleMethod("deneme");
if (isEqual(3, 5))
{
    Console.WriteLine("3 ve 5 eşittir");
}

if (isEqual(3.5, 3.5))
{
    Console.WriteLine("iki değer (3.5) eşittir");
}


void sampleMethod<T>(T type)
{
    Console.WriteLine(type);
}

bool isEqual<T, W>(T value1, W value2) where T : struct, IComparable
                                       where W : struct, IComparable
{
    return value1.CompareTo(value2) == 0;
}