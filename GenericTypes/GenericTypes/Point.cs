namespace GenericTypes
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void PositionPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Reset()
        {
            X = 0;
            Y = 0;
        }


    }

    public class DoublePoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public void PositionPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Reset()
        {
            X = 0;
            Y = 0;
        }
    }

    public class GeneralPoint
    {
        public object X { get; set; }
        public object Y { get; set; }

        public void PositionPoint(object x, object y)
        {
            X = x;
            Y = y;
        }


    }

    public class GenericPoint<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public void PositionPoint(T x, T y)
        {
            X = x;
            Y = y;
        }

        public void Reset()
        {
            X = default(T);
            Y = default(T);
        }

    }


}
