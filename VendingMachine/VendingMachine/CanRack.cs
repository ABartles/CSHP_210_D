/* Andrew Bartles
 CSHP 210 D
 1/15/17
*/

/* Class Discription:
    This class will represent a can storage rack (1) of the vending machine.
    1 can rack has 3 bins, each bin can hold 3 cans of a particular flavor.  
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace VendingMachine
{
    class CanRack
    {
        // Auto Impletement Properties
        private int _regular { get; set;}
        private int _orange { get; set; }
        private int _lemon { get; set; }

        // Constant fields
        // Avoids numerical literals "xy = 3" which would require a numer of areas to be updated when changes are made
        private const int FULL = 3; // by convention all caps 
        private const int EMPTY = 0; // by convention all caps

        // Constructor for a can rack. start with a full rack (3 cans of each flavor).
        public CanRack()
        {
            _regular = FULL;
            _orange = FULL;
            _lemon = FULL;
            // **Note: The lines in this constructor could be replaced by "FillTheCanRack()".
      
        }   // END of 'CanRack' Constructor

        // Method to add a can of specified flavor.
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            Debug.WriteLine("Class: CanRack, Method: AddACanOf");

            if (FlavorOfCanToBeAdded.ToLower() == "regular")
            {
                if (_regular == FULL)
                {
                    Console.WriteLine("Error: The bin of Regular is already full.");
                }
                else
                {
                    Debug.WriteLine("Adding a can of Regular"); // **Note: Debug.WriteLine cant handle multiple strings. 
                    ++_regular;
                }
            }
            else if (FlavorOfCanToBeAdded.ToLower() == "orange")
            {
                if (_orange == FULL)
                {
                    Console.WriteLine("Error: The bin of Orange is already full.");
                }
                else
                {
                    Debug.WriteLine("Adding a can of Orange");
                    ++_orange;
                }
            }
            else if (FlavorOfCanToBeAdded.ToLower() == "lemon")
            {
                if (_lemon == FULL)
                {
                    Console.WriteLine("Error: The bin of Lemon is already full.");
                }
                else
                {
                    Debug.WriteLine("Adding a can of Lemon");
                    ++_lemon;
                }
            }
            else
            {
                Debug.WriteLine("Object Not Found.");
                Console.WriteLine("Object Not Found.");
            }

        }   // END of 'AddACanOf' Method

        // Method to remove a can of specified flavor.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            Debug.WriteLine("Class: CanRack, Method: RemoveACanOf");

            if (FlavorOfCanToBeRemoved.ToLower() == "regular")
            {
                if (_regular == EMPTY)
                {
                    Console.WriteLine("Error: The bin of Regular is empty.");
                }
                else
                {
                    Debug.WriteLine("Removing a can of Regular");
                    --_regular;
                }     
            }
            else if (FlavorOfCanToBeRemoved.ToLower() == "orange")
            {
                if (_orange == EMPTY)
                {
                    Console.WriteLine("Error: The bin of Orange is empty.");
                }
                else
                {
                    Debug.WriteLine("Removing a can of Orange");
                    --_orange;
                }
            }
            else if (FlavorOfCanToBeRemoved.ToLower() == "lemon")
            {
                if (_lemon == EMPTY)
                {
                    Console.WriteLine("Error: The bin of Lemon is empty.");
                }
                else
                {
                    Debug.WriteLine("Removing a can of Lemon");
                    --_lemon;
                }
            }
            else
            {
                Debug.WriteLine("Object Not Found.");
                Console.WriteLine("Object Not Found.");
            }

        }   // END of 'RemoveACanOf' Method

        // Method to fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Class: CanRack, Method: FillTheCanRack");

            _regular = FULL;
            _orange = FULL;
            _lemon = FULL;
        }   // END of 'FillTheCanRack' Method

        // Method to remove all cans of a specified flavor. 
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            Debug.WriteLine("Class: CanRack, Method: EmptyCanRackOf");

            if (FlavorOfBinToBeEmptied.ToLower() == "regular")
            {
                Debug.WriteLine("Emptied Regular Bin");
                _regular = EMPTY;
            }
            else if (FlavorOfBinToBeEmptied.ToLower() == "orange")
            {
                Debug.WriteLine("Emptied Orange Bin");
                _orange = EMPTY;
            }
            else if (FlavorOfBinToBeEmptied.ToLower() == "lemon")
            {
                Debug.WriteLine("Emptied Lemon Bin");
                _lemon = EMPTY;
            }
            else
            {
                Debug.WriteLine("Object Not Found.");
                Console.WriteLine("Object Not Found.");
            }
        }   // END of 'EmptyCanRackOf' Method

        // Method (bool) to return full (true), empty (false) state of rack for specified flavor.
        public bool IsFull(string FlavorOfBinToCheck)
        {
            Debug.WriteLine("Class: CanRack, Method: IsFull");

            bool binstate;
            string flavor = FlavorOfBinToCheck.ToLower();

            switch (flavor)
            {
                case "regular":

                    Debug.WriteLine("Checking if bin of Regular is full.");

                    if (_regular == FULL)
                    {
                        binstate = true;
                        break;
                    }
                    else
                    {
                        binstate = false;
                        break;
                    }
                case "orange":

                    Debug.WriteLine("Checking if bin of Orange is full.");

                    if (_orange == FULL)
                    {
                        binstate = true;
                        break;
                    }
                    else
                    {
                        binstate = false;
                        break;
                    }
                case "lemon":

                    Debug.WriteLine("Checking if bin of Lemon is full.");

                    if (_lemon == FULL)
                    {
                        binstate = true;
                        break;
                    }
                    else
                    {
                        binstate = false;
                        break;
                    }
                default:
                    {
                        Debug.WriteLine("Object Not Found.");
                        binstate = false;
                        break;
                    }
            }   // END of switch

            return binstate;
        }   // END of 'IsFull' Method

        // Method (bool) to return full (false), empty (true) state of rack for specified flavor.
        public bool IsEmpty(string FlavorOfBinToCheck)
        {
            bool binstate;
            string flavor = FlavorOfBinToCheck.ToLower();

            switch(flavor)
            {
                case "regular":

                    Debug.WriteLine("Checking if bin of Regular is Empty.");

                    if (_regular == EMPTY)
                    {
                        binstate = true;
                        break;
                    }
                    else
                    {
                        binstate = false;
                        break;
                    }
                case "orange":

                    Debug.WriteLine("Checking if bin of Orange is Empty.");

                    if (_orange == EMPTY)
                    {
                        binstate = true;
                        break;
                    }
                    else
                    {
                        binstate = false;
                        break;
                    }
                case "lemon":

                    Debug.WriteLine("Checking if bin of Lemon is Empty.");
                   
                    if (_lemon == EMPTY)
                    {
                        binstate = true;
                        break;
                    }
                    else
                    {
                        binstate = false;
                        break;
                    }
                default: 
                    {
                        Debug.WriteLine("Object Not Found.");
                        binstate = false;
                        return binstate;
                    }
            }   // END of switch

            return binstate;
        }   // END of 'IsEmpty' Method

        // Inventory status
        public void InventoryStatus()
        {
            Console.WriteLine("\nInventory:");
            Console.WriteLine("\tRegular: {0} \n\tOrange: {1} \n\tLemon: {2}", _regular, _orange, _lemon);
        }

    }
}
