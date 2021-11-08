using System;

namespace Square
{
    class ChoiceController
    {
        public Triangle triangle;

        public Triangle TriangleData()
        {
            triangle = new Triangle();
            

            Console.WriteLine("Введите сторону а");
            triangle.a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону b");
            triangle.b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону c");
            triangle.c = Convert.ToInt32(Console.ReadLine());

            return triangle;
        }
        
        public void CircleData()
        {
            Console.WriteLine("Введите радиус");
            Circle.r = Convert.ToInt32(Console.ReadLine());
        }        
    }
}
