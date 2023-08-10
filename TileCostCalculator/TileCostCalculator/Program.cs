using System;

namespace TileCostCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Supply the shape of the room
            Console.WriteLine("Please state whether the shape of the room is triangular or rectangular");
            string ShapeofRoom = Console.ReadLine();

            // Convert ShapeofRoom to Uppercase
            string NewShape = ShapeofRoom.ToUpper();

            // Supply the Cost/unit of Tile
            Console.WriteLine("Please Supply the Cost of Tile/Square Feet in $ : ");
            double CostofTile = Convert.ToDouble(Console.ReadLine());

            // Supply the size of each unit of tiles in square feet
            Console.WriteLine("Size of each unit of tiles in square feet : ");
            double SizeofTile = Convert.ToDouble(Console.ReadLine());

            // Calculating the Area to floor 
            if (NewShape == "RECTANGLE")
            {
                Console.WriteLine("Good day. Please Supply the flooring Length in feet");
                double LengthofRoom = Convert.ToDouble(Console.ReadLine());

                // Supply the Width
                Console.WriteLine("Please Supply the flooring width in feet");
                double WidthofRoom = Convert.ToDouble(Console.ReadLine());

                // Calculating the Area to floor 
                double Area = LengthofRoom * WidthofRoom;

                // Tiles needed 
                double TilesNeeded = Area / SizeofTile;
                Console.WriteLine("The total tiles needed is: " + TilesNeeded + ".");

                // Calculating the Total Cost
                double total = TilesNeeded * CostofTile;
                Console.WriteLine("The Total Cost is: $ " + total + ".");
                //since work done on 20 square feet is 
                //#86/hr. Then, I square feet costs 86/20 = $4.3
                double labourCost = Area * (86 / 20);
                Console.WriteLine("The labor cost is: $" + labourCost);


            }
            else if (NewShape == "TRIANGLE")
            {
                Console.WriteLine("Enter the base of triangle:");
                double TriangleBase = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height of triangle:");
                double TriangleHeight = Convert.ToDouble(Console.ReadLine());
                double AreaOfTriangle = (TriangleBase * TriangleHeight) / 2;
                Console.WriteLine("Area of triangle is: " + AreaOfTriangle);

                // Tiles needed 
                int TilesNeeded = (int)Math.Ceiling(AreaOfTriangle / SizeofTile); // Rounded up
                Console.WriteLine("The total tiles needed is: " + TilesNeeded + ".");

                // Calculating the Total Cost
                double total = TilesNeeded * CostofTile;
                Console.WriteLine("The Total Cost is: $" + total + ".");

                //since work done on 20 square feet is 
                //#86/hr. Then, I square feet costs 86/20 = $4.3
                double labourCost = AreaOfTriangle * (86 / 20);
                Console.WriteLine("The labor cost is: $" + labourCost);
            }
            else
            {
                Console.WriteLine("Shape is invalid");
            }
            
        }

    }
}


