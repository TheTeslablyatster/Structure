using System;

namespace Structure
{
    struct Vector
    {
        public double xcord;
        public double ycord;
        public double zcord;
        public Vector (double xcord, double ycord, double zcord)
        {
            this.xcord = xcord;
            this.ycord = ycord;
            this.zcord = zcord;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{xcord} {ycord} {zcord}");
        }
        public double FindLenght()
        {
            return Math.Sqrt(Math.Pow(xcord, 2) + Math.Pow(ycord, 2) + Math.Pow(zcord, 2));
        }
        public Vector Normalize()
        {
            double z = Math.Sqrt((Math.Pow(xcord, 2) + Math.Pow(ycord, 2) + Math.Pow(zcord, 2)));
            Vector c = new Vector(xcord /= z, ycord /= z, zcord /= z);
            return c;         
        }
        public Vector VectorsSumm(Vector a, Vector b)
        {
            Vector c = new Vector (a.xcord + b.xcord, a.ycord + b.ycord, a.zcord + b.zcord);
            return c;
        }
        public Vector VectorsDiff(Vector a, Vector b)
        {
            Vector c = new Vector(a.xcord - b.xcord, a.ycord - b.ycord, a.zcord - b.zcord);
            return c;
        }
        public Vector VectorsProd(Vector a, double b)
        {
            Vector c = new Vector(b * a.xcord, b * a.ycord, b * a.zcord);
            return c;
        }
        public Vector VectorsFrac(Vector a, double b)
        {
            Vector c = new Vector(b / a.xcord, b / a.ycord, b / a.zcord);
            return c;
        }
        public double VectorsScalarProd(Vector a, Vector b)
        {
            double scalar = a.xcord * b.xcord + a.ycord * b.ycord + a.zcord * b.zcord;
            return scalar;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
