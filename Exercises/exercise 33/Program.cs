using System;

namespace exercise_33
{
    public class Shape
    {
        public int height;
        public int width;
    }
    public class Circle : Shape
    {
        public void Show()
        {
            Console.WriteLine("Circle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //UpCasting
            //Circle circle = new Circle();
            Shape shape = new Shape();
            //circle.Show();
            //DownCasting
            Circle anotherCircle = (Circle)shape;
            anotherCircle.Show();
        }
    }
}
