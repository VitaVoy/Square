using System;

namespace Square
{
    class Triangle : Figure
    {     

        public int a;
        public int b;
        public int c;

        public int p;

        public bool pythagoras = false;

        public override void Calculate()
        {
            PoluPerimetr();
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine(s);
        }

        private void PoluPerimetr()
        {
            p = (a + b + c) / 2;
        }

        public bool SquareCheck()
        {
            bool result = false;
            if (Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2)) || 
                Math.Pow(b, 2) == (Math.Pow(c, 2) + Math.Pow(a, 2)) ||
                Math.Pow(c, 2) == (Math.Pow(a, 2) + Math.Pow(b, 2)))
            {
                result = true;                
            }

            return result;
        }
    }
}
