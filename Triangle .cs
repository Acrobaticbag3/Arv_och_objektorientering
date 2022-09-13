using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    class Triangle : Shape {
        public Triangle(int width, int height) : base( width, height) { 
            
        }

         public void Circumferance() {
            int circumferance = width * 2 + height * 2;
            Console.WriteLine("the circumferance of this rectangle is: " + circumferance);
        }

        public void Area() {
            int area = width * height / 2;
            Console.WriteLine("The area of this rectangle is: " + area);
        }
    }
