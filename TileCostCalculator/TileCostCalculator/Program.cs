using System;
namespace TileCostCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double GIVENFEET = 20;
            const double RATEPERHOUR = 86;
            string shapeOfRoom;

            while (true)
            {
                //Supply the shape of the room
                Console.WriteLine("Please select whether the shape of the room. For rectangular, enter r. For Triangle enter t.");
                shapeOfRoom = Console.ReadLine().ToUpper();

                if (shapeOfRoom == "R" || shapeOfRoom == "T")
                {
                    break; // Loop exited once code input is valid.
                }
                else
                {
                    Console.WriteLine("Invalid shape input. Enter 'r' for rectangular or 't' for triangle.");
                }
            }

            //Supply the Cost/unit of Tile
            Console.WriteLine("Please Supply the Cost of Tile/Square Feet in $ : ");
            double costOfTile = Convert.ToDouble(Console.ReadLine());

            //Supply the size of each unit of tiles in square feet
            Console.WriteLine("Size of each unit of tiles in square feet : ");
            double sizeOfTile = Convert.ToDouble(Console.ReadLine());
            double area = 0;

            {
                //Calculate the Area to floor 
                if (shapeOfRoom == "R")
                {
                    //Supply the lenght
                    Console.WriteLine("Good day. Please Supply the flooring Length in feet");
                    double lengthOfRoom = Convert.ToDouble(Console.ReadLine());

                    //Supply the Width
                    Console.WriteLine("Please Supply the flooring width in feet");
                    double widthOfRoom = Convert.ToDouble(Console.ReadLine());

                    //Calculate the Area to floor 
                    area = lengthOfRoom * widthOfRoom;
                    Console.WriteLine("Area of Rectangle is: " + area);
                }
                else if (shapeOfRoom == "T")
                {
                    //Supply the base
                    Console.WriteLine("Enter the base of triangle:");
                    double triangleBase = Convert.ToDouble(Console.ReadLine());

                    //Supply the height
                    Console.WriteLine("Enter the height of triangle:");
                    double triangleHeight = Convert.ToDouble(Console.ReadLine());

                    //Calculate the are of the Triangle
                    area = (triangleBase * triangleHeight) / 2;
                    Console.WriteLine("Area of triangle is: " + area);
                }
            }
            string dollar = "$";

            //Tiles needed 
            double tilesNeeded = (int)Math.Ceiling(area / sizeOfTile); // Rounded up
            Console.WriteLine($"The total tiles needed is: {tilesNeeded}.");

            //Calculate the Total Cost
            double total = tilesNeeded * costOfTile;
            Console.WriteLine($"The total cost is: {dollar}{total}.");

            /* since 20 Square Feet is done every hour at the rate of $86/hr. 
             Then: 1 Sqaure Feet is done at 86/hr divide 20.*/
            double squareFeetPerHour = RATEPERHOUR / GIVENFEET;
            double labourCost = area * squareFeetPerHour;
            Console.WriteLine($"The labor cost is: {dollar}{labourCost}");
        }
    }
}