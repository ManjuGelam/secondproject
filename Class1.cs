using System;
using System.Collections.Generic;
using System.Text;
using oopsproject;
namespace secondproject
{
    class Class1
    {
        static void Main()
        {
            Cone cone = new Cone(18.92, 34.12);
            Console.WriteLine($"Area of Cone is: {cone.GetArea()}\n");

            Circle circ = new Circle(45.36);
            Console.WriteLine($"Area of Circle is: {circ.GetArea()}\n");

            Triangle trin = new Triangle(34.98, 27.87);
            Console.WriteLine($"Area of Triangle is: {trin.GetArea()}\n");

            Rectangle rect = new Rectangle(45.29, 76.12);
            Console.WriteLine($"Area of Rectangle is: {rect.GetArea()}\n");
            Console.ReadLine();
        }

    }
}
