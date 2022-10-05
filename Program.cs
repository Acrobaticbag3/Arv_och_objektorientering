// See https://aka.ms/new-console-template for more information
using System;

namespace Arv_och_objektorientering {
    internal class Program {
        static void Main(string[] args) {
            string line = "====================";
            string inputNow = "Input width and height, in that order";
            string notFound = "No such calculation exists, input again \n==================";
            string whatToDo = "What do you wish to calculate? \nArea, Circumferance or Both?";

            int loop = 0;
            int width;
            int height;

            List<Shape> shapes = new List<Shape>();
        
            while (loop < 1){
                Console.Write("Input which shape you'd like to edit: ");
                string answer = Console.ReadLine();

                if(answer == "triangle"){
                    int i = 0;
                    while (i < 1){
                        Console.WriteLine(whatToDo);
                        string answerTwo = Console.ReadLine();

                        if(answerTwo == "Area") {
                            Console.WriteLine(inputNow);
                            width = int.Parse(Console.ReadLine());
                            height = int.Parse(Console.ReadLine());
                            Triangle triangle = new Triangle(width, height);
                            
                            Console.WriteLine(line);
                            triangle.Area();
                            Console.WriteLine(line);

                        } else if(answerTwo == "Circumferance") {
                            Console.WriteLine(inputNow);
                            width = int.Parse(Console.ReadLine());
                            height = int.Parse(Console.ReadLine());
                            Triangle triangle = new Triangle(width, height);

                            Console.WriteLine(line);
                            triangle.Circumferance();
                            Console.WriteLine(line);

                        } else if(answerTwo == "Both") {
                            Console.WriteLine(inputNow);
                            width = int.Parse(Console.ReadLine());
                            height = int.Parse(Console.ReadLine());
                            Triangle triangle = new Triangle(width, height);

                            Console.WriteLine(line);
                            triangle.Area();
                            triangle.Circumferance();
                            Console.WriteLine(line);

                        } else {
                            Console.WriteLine(notFound);
                        }
                        i++;
                    }
                    loop++;

                } else if(answer == "rectangle") {
                    int i = 0;
                    while (i < 1){
                        Console.WriteLine(whatToDo);
                        string answerTwo = Console.ReadLine();

                        if(answerTwo == "area") {
                            Console.WriteLine(inputNow);
                            width = int.Parse(Console.ReadLine());
                            height = int.Parse(Console.ReadLine());
                            Rectangle Rectangle = new Rectangle(width, height);
                            
                            Console.WriteLine(line);
                            Rectangle.Area();
                            Console.WriteLine(line);

                        } else if(answerTwo == "circumferance") {
                            Console.WriteLine(inputNow);
                            width = int.Parse(Console.ReadLine());
                            height = int.Parse(Console.ReadLine());
                            Rectangle Rectangle = new Rectangle(width, height);

                            Console.WriteLine(line);
                            Rectangle.Circumferance();
                            Console.WriteLine(line);

                        } else if(answerTwo == "Both") {
                            Console.WriteLine(inputNow);
                            width = int.Parse(Console.ReadLine());
                            height = int.Parse(Console.ReadLine());
                            Rectangle Rectangle = new Rectangle(width, height);

                            Console.WriteLine(line);
                            Rectangle.Area();
                            Rectangle.Circumferance();
                            Console.WriteLine(line);

                        }else {
                            Console.WriteLine(notFound);
                        }
                        i++;
                    }
                    loop++;

                } else {
                    Console.WriteLine("No such sape exists, input again.");
                }   
            }
        }
    }
}