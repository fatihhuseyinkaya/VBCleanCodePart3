using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle rectangle = new Rectangle { Height = 20, Width = 5 };
            //Square square = new Square { Width = 20 };
            //Console.WriteLine(square.GetArea());
            //Console.WriteLine(rectangle.GetArea());

            var dortgen = GeometryFactory.GetGeometry(20,5);
                //dortgen.Height = 10;
            //dortgen.Width = 20;

            Console.WriteLine(dortgen.GetArea());

            Console.ReadLine();


        }

       
    }

    public class GeometryFactory
    {
        public static IAreaCalculatable GetGeometry(int width, int height=1)
        {
            //farz edin ki koşullar gereği kare dönecek:

            if (height != 1)
            {
                return new Rectangle { Width = width, Height = height };
            }
            return new Square { Length = width };
        }
    }

    public interface IAreaCalculatable
    {
        int GetArea();
    }
    public class Rectangle : IAreaCalculatable
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea()
        {
           return Width * Height;
        }
    }
    public class Square : IAreaCalculatable
    {
        public int Length { get; set; }

        public int GetArea()
        {
            return Length * Length;
        }
    }
}
