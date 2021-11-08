using System;

namespace Square
{
    class Menu
    {
        ChoiceController choiceController = new ChoiceController();
        Circle circle = new Circle();

        public void Choice()
        {
            Console.WriteLine("Выберите тип фигуры");
            Console.WriteLine("Если треугольник - нажмите 1");
            Console.WriteLine("Если круг - нажмите 2");
            Console.WriteLine("Если другая фигура - нажмите 3");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                var triangle = choiceController.TriangleData();
                triangle.Calculate();
                
                if (triangle.SquareCheck())
                {
                    Console.WriteLine("Треугольник - прямоугольный");
                }
            }
            else if (choice == 2)
            {
                choiceController.CircleData();
                circle.Calculate();
            }
            else
            {
                Console.WriteLine("Модуль рассчета площади будет установлен позже");
            }
        }
    }
}
