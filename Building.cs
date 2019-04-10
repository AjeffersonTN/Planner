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
        private string designer{get; set;}
        private DateTime dateConstructed{get; set;}
        private string address{get; set;}
        private string owner{get; set;}

        // //public properties
        public int Stories
        {
            get{
                return Stories;
            }
            set{
                Stories = value;
            }
        }
        public double Width
         {
            get{
                return Width;
            }
            set{
                Width = value;
            }
        }
        public double Depth
         {
            get{
                return Depth;
            }
            set{
                Depth = value;
            }
        }
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
        DateTime currentTime()
        {
            dateConstructed = DateTime.Now;
        }
        string nameOfOwner(string ownerInput)
        {
            owner = ownerInput;
        }

    }
}