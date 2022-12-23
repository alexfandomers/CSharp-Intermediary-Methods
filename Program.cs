using System.Drawing;
using System;

namespace Methods
{
     public class Program
    {
        //Agenda: Signature of methods, Method overloading, Params modifier(only modifier consider usefull), Ref and Out modifier
        static void Main(string[] args)
        {  
           /////////////////Point instance////////////////

           //creating a point object / an instance of point
           var point = new Point(10, 20);

           //call the move method
           point.Move(new Point(40, 60));
           Console.WriteLine("Point is at ({0}, {1}", point.x, point.y);

           //Using the second overload
           point.Move(100, 200);
           Console.WriteLine("Point is at ({0}, {1}", point.x, point.y);

           /////////////////Calculator instance////////////////

           //creating a calculator object
           var calculator = new Calculator();
           //call the add method passing 2 or more numbers and display the result on the console
           //thats the effect os params keyword
           Console.WriteLine(calculator.Add(1, 2));
           Console.WriteLine(calculator.Add(1, 2, 3));
           Console.WriteLine(calculator.Add(1, 2, 3, 4));
           //we can call this using array notation but is not the easier way
           //because we need to create a an integer array
           //and that's how we use the params keyword
           Console.WriteLine(calculator.Add(new int[] {1, 2, 3, 4, 5}));
        }
    }
}
