using System;
using System.Linq;
namespace DrawingCSharp
{
    public class Program
    {
        private static IShape[] drawing1 =
            new IShape[] { new Circle(3), new Circle(4), new Rectangle(2, 7), new Circle(10)};

        static void GrowAll(IShape[] shapes, int percent)
        {
            // iterate (loop) over array and delegate to equivalent method on each
            foreach (var shape in shapes)
            {
                shape.GrowBy(percent);
            }
        }

        static void SummariseAll(IShape[] shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Summary());
            }
        }

        // Main program here...
        public static void Main()
        {
            Console.WriteLine("Polymorphism in C#");
            SummariseAll(drawing1);
            GrowAll(drawing1, 50);
            Console.WriteLine();
            Console.WriteLine("After growing all by 50%:");
            SummariseAll(drawing1);
            Console.WriteLine("After rotating all by 90:");
            SummariseAll(drawing1);

            //To keep console open
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}