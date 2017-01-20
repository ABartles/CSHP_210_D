/* Andrew Bartles
 CSHP 210 D
 1/15/17
*/

/* Class Discription:
    This Class represents the purchase price of an item.
    Initialy sets price to zero.
    Allows access and update through the property 'Price'. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class PurchasePrice
    {
        // Intilize instance variable
        private int _price; // **Note: "_" is used as a common convention on private varibles
        


        // Constructor: Set the price to 0
        public PurchasePrice()
        {
            int _price = 0;
        } // END of Constructor



        // Constructor: Allows a new purchase price to be set by the user
        public PurchasePrice(int initialPrice)
        {
            _price = initialPrice;
        } // END of Constructor



        // Property: Get/Set the value of the purchase price
        // could be simplified to auto implement property
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
               _price = value;
            }
        } // END of 'Price' Property 


    }  // END 'PurchasePrice' Class
}
