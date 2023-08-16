using System;
namespace TileCostCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double GIVENFEET = 20;
            const double RATEPERHOUR = 86;

            // Supply the shape of the room
            Console.WriteLine("Please select whether the shape of the room. For rectangular, enter r. For Triangle enter t.");
            string shapeOfRoom = Console.ReadLine().ToUpper();

            // Supply the Cost/unit of Tile
            Console.WriteLine("Please Supply the Cost of Tile/Square Feet in $ : ");
            double costOfTile = Convert.ToDouble(Console.ReadLine());

            // Supply the size of each unit of tiles in square feet
            Console.WriteLine("Size of each unit of tiles in square feet : ");
            double sizeOfTile = Convert.ToDouble(Console.ReadLine());
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
            double tilesNeeded = (int)Math.Ceiling(area / sizeOfTile); // Rounded up
            Console.WriteLine("The total tiles needed is: " + tilesNeeded + ".");

            // Calculating the Total Cost
            double total = tilesNeeded * costOfTile;
            Console.WriteLine("The Total Cost is: $" + total + ".");

            /* since 20 Square Feet is done every hour at the rate of $86/hr. Then:
            1 Sqaure Feet is done at 86/hr divide 20.*/
            double squareFeetPerHour = RATEPERHOUR / GIVENFEET;
            double labourCost = area * squareFeetPerHour;
            Console.WriteLine("The labor cost is: $" + labourCost);
        }
    }
}