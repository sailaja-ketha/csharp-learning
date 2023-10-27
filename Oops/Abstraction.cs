

namespace Oops
{

    //abstraction is nothing but hiding unnecessary details showing only necessary details
    //we can acheive by using classes and interfaces
    // abstraction is showing relevent information encapsulation is data protection
    public class Abstraction
    {
        public abstract class Shape
        {
           public abstract void Area();
        }

        public class Triangle : Shape
        {
            private int breadth;
            private int height;
            public Triangle(int breadth, int height)
            {
                this.breadth = breadth;
                this.height = height;
            }
            public override void Area()
            {
                Console.WriteLine("Area of the triangle is : " + (0.5* breadth * height));
            }
        }
        public  class Square : Shape
        {
            private double side;
            
            public Square(double side)
            {
                this.side = side;
                
            }
            public override void Area()
            {
                Console.WriteLine("Area of the Square is : " + ( side * side));
            }
        }
        public class Circle : Shape
        {
            private double radius;
            public Circle(double radius)
            {
                this.radius = radius;
            }
            public override void Area()
            {
                Console.WriteLine("Area of the Circle is : " + (3.14*radius*radius));
            }
        }
    }
}
