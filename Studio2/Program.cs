using System;

namespace Studio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double r;
            double area;
            double circumference;
            double milesPerGallon;
            double gallonsOfGas;
           
//code with the circle class            
            Console.WriteLine("Enter a radius: ");
            input = Console.ReadLine();
            Console.WriteLine("Area of a circle with a radius of " + input + " is " + Circle.Area(input));
            Console.WriteLine("Circumference of a circle with a radius of " + input + " is " + Circle.Circumference(input));

            //Console.WriteLine("Enter miles per gallon of your vehicle:");
            //input = Console.ReadLine();
            //milesPerGallon = double.Parse(input);
            //gallonsOfGas = circumference / milesPerGallon;
            //Console.WriteLine(gallonsOfGas + " gallons of gas needed to go around circle with a radius of " + r + " miles.");


//code with no outside class
            //Console.WriteLine("Enter a radius: ");
            //input = Console.ReadLine();
            
            //r = double.Parse(input);
            
            //area = Math.PI * Math.Pow(r, 2);
            //Console.WriteLine("Area of a circle with a radius of " + r + " is " + area);

            //circumference = 2 * Math.PI * r;
            //Console.WriteLine("Circumference of a circle with a radius of " + r + " is " + circumference);
            

            //Console.WriteLine("Enter miles per gallon of your vehicle:");
            //input = Console.ReadLine();
            
            //milesPerGallon = double.Parse(input);
            //gallonsOfGas = circumference / milesPerGallon;
            //Console.WriteLine(gallonsOfGas + " gallons of gas needed to go around circle with a radius of " + r + " miles.");




        }
    }
}
