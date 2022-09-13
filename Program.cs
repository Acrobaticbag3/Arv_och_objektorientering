// See https://aka.ms/new-console-template for more information
using System;

namespace Arv_och_objektorientering {
    internal class Program {
        static void Main(string[] args) {
            string line = "====================";

            int loop = 0;
            int width;
            int height;
        
            while (loop < 1){
                Console.Write("Input which shape you'd like to edit: ");
                string answer = Console.ReadLine();

                if(answer == "triangle"){
                    int i = 0;
                    while (i < 1){
                        Console.WriteLine("What do you wish to calculate? \nArea or Circumferance");
                        string answerTwo = Console.ReadLine();

                        if(answerTwo == "area") {
                            Console.WriteLine("Input width and height, in that order");
                            width = int.Parse(Console.ReadLine());
                            height = int.Parse(Console.ReadLine());
                            Triangle triangle = new Triangle(width, height);
                            
                            Console.WriteLine(line);
                            triangle.Area();
                            Console.WriteLine(line);

                        } else if(answerTwo == "circumferance") {
                            Console.WriteLine("Input width and height, in that order");
                            width = int.Parse(Console.ReadLine());
                            height = int.Parse(Console.ReadLine());
                            Triangle triangle = new Triangle(width, height);

                            Console.WriteLine(line);
                            triangle.Circumferance();
                            Console.WriteLine(line);
                        } else {
                            Console.WriteLine("No such calculation exists, input again.");
                        }
                    }
                    loop++;

                } else if(answer == "rectangle") {
                    int i = 0;
                    while (i < 1){
                        Console.WriteLine("What do you wish to calculate? \nArea or Circumferance");
                        string answerTwo = Console.ReadLine();

                        if(answerTwo == "area") {
                            Console.WriteLine("Input width and height, in that order");
                            width = int.Parse(Console.ReadLine());
                            height = int.Parse(Console.ReadLine());
                            Rectangle Rectangle = new Rectangle(width, height);
                            
                            Console.WriteLine(line);
                            Rectangle.Area();
                            Console.WriteLine(line);

                        } else if(answerTwo == "circumferance") {
                            Console.WriteLine("Input width and height, in that order");
                            width = int.Parse(Console.ReadLine());
                            height = int.Parse(Console.ReadLine());
                            Rectangle Rectangle = new Rectangle(width, height);

                            Console.WriteLine(line);
                            Rectangle.Circumferance();
                            Console.WriteLine(line);
                        } else {
                            Console.WriteLine("No such calculation exists, input again.");
                        }
                    }
                    loop++;

                } else {
                    Console.WriteLine("No such sape exists, input again.");
                }   
            }
        }
    }
}