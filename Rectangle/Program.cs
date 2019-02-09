using System;

namespace Rectangle
{
    public static class Program
    {
        public static void Main()
        {
            // Get input from the user and save it to a variable.
            Console.Write("Enter the length of the rectangle: ");
            int length = int.Parse(Console.ReadLine());
            
            // Get input from the user and save it to a second variable.
            Console.Write("Enter the width of the rectangle: ");
            int width = int.Parse(Console.ReadLine());
            
            int area = length * width;
            
            // Output - The area of the rectangle is (computed value)
            Console.WriteLine("The area of your rectangle is " + area);
            Console.ReadLine();
        }
    }
}
