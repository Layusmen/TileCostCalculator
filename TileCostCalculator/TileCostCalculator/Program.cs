using System;
using System.Drawing;

namespace TileCostCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Supply the shape of the room
            Console.WriteLine("Please select whether the shape of the room. For rectangular, enter r. For Triangle enter t.");
            string shapeOfRoom = Console.ReadLine();

            // Convert ShapeofRoom to Uppercase
            shapeOfRoom = shapeOfRoom.ToUpper();

            // Supply the Cost/unit of Tile
            Console.WriteLine("Please Supply the Cost of Tile/Square Feet in $ : ");
            double costOfTile = Convert.ToDouble(Console.ReadLine());

            // Supply the size of each unit of tiles in square feet
            Console.WriteLine("Size of each unit of tiles in square feet : ");
            double sizeOfTile = Convert.ToDouble(Console.ReadLine());
            double squareFeet = 20;
            double perHour = 86;
                // since work done on 20 square feet is
            //#86/hr. Then:
            double workDone = squareFeet / perHour;

            double area = 0;

            // Calculating the Area to floor 
            if (shapeOfRoom == "R")

            {
                //Supply the lenght
                Console.WriteLine("Good day. Please Supply the flooring Length in feet");
                double lengthOfRoom = Convert.ToDouble(Console.ReadLine());

                // Supply the Width
                Console.WriteLine("Please Supply the flooring width in feet");
                double widthOfRoom = Convert.ToDouble(Console.ReadLine());

                // Calculating the Area to floor 
                area = lengthOfRoom * widthOfRoom;
                Console.WriteLine("Area of Rectangle is: " + area);

            }
            else if (shapeOfRoom == "T")
            {
                //Supply the bas
                Console.WriteLine("Enter the base of triangle:");
                double triangleBase = Convert.ToDouble(Console.ReadLine());

                //Supply the height
                Console.WriteLine("Enter the height of triangle:");
                double triangleHeight = Convert.ToDouble(Console.ReadLine());

                // Calculate the are of the Triangle
                area = (triangleBase * triangleHeight) / 2;
                Console.WriteLine("Area of triangle is: " + area);
            }
            else
            {
                Console.WriteLine("Shape is invalid");
            }

            // Tiles needed 
            double tilesNeeded;
            tilesNeeded = (int)Math.Ceiling(area / sizeOfTile); // Rounded up
            Console.WriteLine("The total tiles needed is: " + tilesNeeded + ".");

            // Calculating the Total Cost
            double total;
            total = tilesNeeded * costOfTile;
            Console.WriteLine("The Total Cost is: $" + total + ".");

            //since work done on 20 square feet is 
            //#86/hr. Then:
            double labourCost;
            labourCost = area * workDone;
            Console.WriteLine("The labor cost is: $" + labourCost);
        }

    }
}

