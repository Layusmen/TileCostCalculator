using System;

namespace TileCostCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Supply the shape of the room
            Console.WriteLine("Please select whether the shape of the room. For rectangular, enter r. For Triangle enter t.");
            string shapeofRoom = Console.ReadLine();

            // Convert ShapeofRoom to Uppercase
            string newShape = shapeofRoom.ToUpper();

            // Supply the Cost/unit of Tile
            Console.WriteLine("Please Supply the Cost of Tile/Square Feet in $ : ");
            double costofTile = Convert.ToDouble(Console.ReadLine());

            // Supply the size of each unit of tiles in square feet
            Console.WriteLine("Size of each unit of tiles in square feet : ");
            double sizeofTile = Convert.ToDouble(Console.ReadLine());

            double tilesNeeded;
            double area = 0;
            double total;
            double labourCost;

            // Calculating the Area to floor 
            if (newShape == "R")

            {
                //Supply the lenght
                Console.WriteLine("Good day. Please Supply the flooring Length in feet");
                double lengthofRoom = Convert.ToDouble(Console.ReadLine());

                // Supply the Width
                Console.WriteLine("Please Supply the flooring width in feet");
                double widthofRoom = Convert.ToDouble(Console.ReadLine());

                // Calculating the Area to floor 
                area = lengthofRoom * widthofRoom;
                Console.WriteLine("Area of Rectangle is: " + area);

            }
            else if (newShape == "T")
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
            tilesNeeded = (int)Math.Ceiling(area / sizeofTile); // Rounded up
            Console.WriteLine("The total tiles needed is: " + tilesNeeded + ".");

            // Calculating the Total Cost
            total = tilesNeeded * costofTile;
            Console.WriteLine("The Total Cost is: $" + total + ".");

            //since work done on 20 square feet is 
            //#86/hr. Then:
            double workdone = 86 / 20;
            labourCost = area * workdone;
            Console.WriteLine("The labor cost is: $" + labourCost);
        }

    }
}
