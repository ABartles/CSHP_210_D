/* Andrew Bartles
 CSHP 210 D
 1/15/17
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


// Principles:
// - Do the simplest thing that could actually work 
// - YAGNI - You Aren't Going To Need It -- dont add functionality until deemed necessary


namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("start of main.");

            int cost = 55;  // Is it best to inililize the cost her or in line 22? // Cost of the soda
            int pay; // Amount paid by user

            // Object creation 
            PurchasePrice MyPurchasePrice = new PurchasePrice(cost);
            CanRack MyCanRack = new CanRack();


            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");   // welcome window
            
            // payment 
            Console.Write("Please insert {0} cents: ", MyPurchasePrice.Price);  // prompt for user input
            string Strpay = Console.ReadLine(); // read user input
            pay = int.Parse(Strpay);    // Change user input from a string to a int 
            Console.WriteLine("You have inserted {0} cents.", pay); // prompt confirming payment 

            // Display inventory status
            MyCanRack.InventoryStatus();

            // despense an Orange soda 
            Console.WriteLine("\n--Despense an Orange soda.--");
            MyCanRack.RemoveACanOf("Orange");

            // Check that Orange has dispensed a can
            MyCanRack.InventoryStatus();

            // Add one can of orange soda
            Console.WriteLine("\n--Add one can of orange soda.--");
            MyCanRack.AddACanOf("Orange");

            // Check that a can of Orange soda was added
            // Check that the bin of regular is full before attempt to overfill bin
            // Check eception handling of capitilization errors
            Console.WriteLine("Bin of Orange is full: {0}", MyCanRack.IsFull("OrAnGe"));    // Check eception handling of capitilization errors
            MyCanRack.InventoryStatus();

            // Try and over fill the bin of regular
            Console.WriteLine("\n--Try and over fill the bin of regular.--");
            MyCanRack.AddACanOf("Regular");

            // Empty the bin of Lemon
            Console.WriteLine("\n--Empty the bin of Lemon.--");
            MyCanRack.EmptyCanRackOf("Lemon");
            Console.WriteLine("\nBin of Lemon is Empty: {0}", MyCanRack.IsEmpty("Lemon")); // Check the bin of lemon inventory
            MyCanRack.InventoryStatus();

            // Try to remove a can from an empty bin
            Console.WriteLine("\n--Try to remove a can from an empty bin.--");
            MyCanRack.RemoveACanOf("Lemon");

            // Restock bins
            // Check that bin was restocked
            Console.WriteLine("\n--Restock bins.--");
            MyCanRack.FillTheCanRack();
            MyCanRack.InventoryStatus();
            Console.WriteLine("");
        }
    }
}
