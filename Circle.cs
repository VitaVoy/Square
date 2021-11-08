using System;

namespace Square
{
    class Circle : Figure
    {
        public static int r { get; set; }      

        public override void Calculate()
        {
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(s);
        }
    }
}
