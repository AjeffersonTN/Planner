using System;
using System.Collections.Generic;
/*Private Fields
_designer of type string. It will hold your name.
_dateConstructed of type DateTime. This will hold the exact time the building was created.
_address of type string.
_owner of type string. This will store the same of the person who owns the building.
Public Properties
Stories typed as an integer.
Width typed as a double.
Depth typed as a double.
Volume should be read-only and should return width * depth * (3 * # of stories). Each story is 3 meters high. */

namespace Planner
{
    public class Building{
        //private properties
        private string designer = "Antonio";
        private DateTime dateConstructed;
        private string address;
        private string owner;

        // //public properties
        public int Stories{get; set;}

        public double Width {get; set;}

        public double Depth{get; set;}
        public double Volume
         {
            get{
                return Width * Depth * (3 * Stories);
            }
        }
        //constructor
        public Building (string addressInput)
        {
            address = addressInput;
        }
        //public methods
        public void Construct()
        {
            dateConstructed = DateTime.Now;
        }
        public void Purchase(string purchaser)
        {
            owner = purchaser;
        }

        public void Print(){
            Console.WriteLine(
                $@"
     {address}
 -------------------------
Designed by {designer}
Constructed on {dateConstructed}
Owned by {owner}
{Volume} cubic meters of space.");

        }

        //can use the method below and it will change the default console.writeline to what is given below

 /*             public override string ToString () {
            return $@"
{address}
-------------------------
Designed by {designer}
Constructed on {dateConstructed}
Owned by {owner}
{Volume} cubic meters of space.";
        }
        */

    }

}