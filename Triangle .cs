using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    class Triangle : Shape {
        public Triangle(int width, int height) : base( width, height) { 
            
        }

        public void CircumferanceAndArea() {
            int circumferance = width + height * 2;
            int area = width * height * 2 % 2;

            Console.WriteLine("The area of this triangle is: " + area + "\nThe circumferance of the triangle is: " + circumferance);
        }
    }
