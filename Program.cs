// See https://aka.ms/new-console-template for more information
using System;

namespace Arv_och_objektorientering {
    internal class Program {
        static void Main(string[] args) {
            Triangle triangle = new Triangle(15, 14);
            Rectangle rectangle = new Rectangle(10, 9);

            triangle.CircumferanceAndArea();
            rectangle.CircumferanceAndArea();
        }
    }
}