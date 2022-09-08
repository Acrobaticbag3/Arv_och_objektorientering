using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    class Rectangle : Shape {
        public Rectangle(int width, int height) : base( width, height) {

        }

        public void CircumferanceAndArea() {
            int circumferance = width * 2 + height * 2;
            int area = width * height;

            Console.WriteLine("The area of this rectangle is: " + area + "\nthe circumferance of this rectangle is: " + circumferance);
        }
    }