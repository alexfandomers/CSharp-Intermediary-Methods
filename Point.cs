using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Methods
{
    public class Point
    {
        public int x;
        public int y;

        //Build a constructor
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        //Signature of a method: Name, number and type of parameters.
        //A method to move this poit for a different location.
       public void Move(int x, int y)
       {
            this.x = x;
            this.y = y;
       }

       //overloading move method with same name and different signature
       public void Move(Point newLocation)
       {
            this.x = newLocation.x;
            this.y = newLocation.y;
       }

    }
}

        
      