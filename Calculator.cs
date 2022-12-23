using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Methods
{
    public class Calculator
    {
        //this is not a efficient way to overload the add method
        //if a want to add 10 numbers together we have to overload add method 10 times
        /*public int Add(int n1, int n2)
        {
            int a = n1 + n2;
            return a;
        }
        public int Add(int n1, int n2, int n3)
        {
            int b = n1 + n2 + n3;
            return b;
        }
        public int Add(int n1, int n2, int n3, int n4)
        {
            int c = n1 + n2 + n3 + n4;
            return c;
        }*/

        //the first step to make it better is to use an array
        /*public int Add(int[] numbers)
          {
          }*/

        //with this declaration we can use add method like here, but everytime
        // we want to pass a number o argument to this add method we have to create and initialize an array
        //we have to use the new operator and the int[] operation
        /*var result = Calculator.Add(new int[] {1,2,3,4});*/

        //to solve this we use the params modifier
        //we change the declaration of the add method including params keyword
        //with that we can call this method in couple of ways  
         /*public int Add(params int[] numbers)
            {
            }*/
        /*var result = Calculator.Add(new int[] {1,2,3,4,5,});*/
        /*var result = Calculator.Add(1,2,3,4);*/ //simpler, dont need to create and initialize an array

        ////////////Pratic exemple////////////
        public int Add(params int[] numbers)
        {
           var sum = 0;
           foreach (var number in numbers)
           {
            sum += number;
           }
           return sum;
        }
    }
}