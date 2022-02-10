using System;

namespace NUnitRectangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Global variables
            int length = 0; int width = 0;

            Console.Write("---------------------------------------------------------\n");
            Console.Write("This program only takes in positive integers greater than 0\n");
            Console.Write("---------------------------------------------------------\n");

            Console.Write("Enter Length of Rectangle : ");
            //int length = Convert.ToInt32(Console.ReadLine());
            //input validation
            while (!int.TryParse(Console.ReadLine(), out length))
            {
                Console.Write("Please Enter a valid integer value!\n" + "Enter the Length of Rectangle : ");
            }

            Console.Write("Enter Width Of Rectangle: ");
            // int width= Convert.ToInt32(Console.ReadLine());
            //input validation
            while (!int.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Please Enter a valid integer value! \n" + "Enter the Width of Rectangle : ");
            }

            // Menu
            Console.WriteLine("------------------------------------------------");
            Console.Write("Select any one option from the menu given below\n");
            Console.Write("1.Get Rectangle Length\n" +
                            "2.Change Rectangle Length\n" +
                            "3.Get Rectangle Width\n" +
                            "4.Change Rectangle Width\n" +
                            "5.Get Rectangle Perimeter\n" +
                            "6.Get Rectangle Area\n" +
                            "7.Exit\n");
            Console.WriteLine("------------------------------------------------");
            Console.Write("Enter the option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------");

            if (option == 1)
            {
                Rectangle rectangle = new Rectangle();
                Console.WriteLine("Length of the Rectangle: " + rectangle.GetLength());
            }
            else if (option == 2)
            {
                Console.Write("Enter new Length of Rectangle: ");
                int length1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------------------------------");
                Rectangle rectangle = new Rectangle(length, width);
                Console.WriteLine("New Length of Rectangle: " + rectangle.SetLength(length1));
            }
            else if (option == 3)
            {
                Rectangle rectangle = new Rectangle();
                Console.WriteLine("Width of the Rectangle: " + rectangle.GetWidth());
            }
            else if (option == 4)
            {
                Console.Write("Enter new Width of Rectangle: ");
                int width1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------------------------------");
                Rectangle rectangle = new Rectangle(length, width);
                Console.WriteLine("New Length of Rectangle: " + rectangle.SetWidth(width1));
            }
            else if (option == 5)
            {
                Rectangle rectangle = new Rectangle(length, width);
                Console.WriteLine("Perimeter of Rectangle: " + rectangle.GetPerimeter());
            }
            else if (option == 6)
            {
                Rectangle rectangle = new Rectangle(length, width);
                Console.WriteLine("Area of Rectangle: " + rectangle.GetArea());
            }
            else if (option == 7)
            {
                Environment.Exit(0); // Exit the program
            }
        }
    }
}
