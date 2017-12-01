using System;


namespace First
{
    class Circle
    {
        private double _r;
        public double qwerty
        {
            get
            {
                return _r;
            }
            set
            {
                _r = value;
            }
        }
        public Circle(double r = 0)
        {
            _r = r;
        }
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(_r,2);
            }
        }
    }
    class Program
    {
        static double InputDouble(string s)
        {
            double numb;
            do
            {
                Console.WriteLine("Введите значение " + s);
            } while (!double.TryParse(Console.ReadLine(), out numb));
            return numb;
        }
        static void Main(string[] args)
        {
            double r1 = InputDouble("R1");
            double r2 = InputDouble("R2");
            double delta = InputDouble("Delta");
            Circle circ = new Circle();
            for(double i = r1; i <= r2; i += delta)
            {
                circ.Radius = i;
                Console.WriteLine(circ.Area);
                // Не хотелось прописывать повторяемость решения, потому что пришлось бы переписывать много кода и отдельно объявлять
                // и присваивать значение переменным r1,r2,delta

            }
        }
    }
}
