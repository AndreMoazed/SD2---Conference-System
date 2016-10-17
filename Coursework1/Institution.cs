//Andre Moazed - 40216327
//This is a class that is associated with the atendee class, where the Name and address of an institution can be found
//10-10-16

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coursework1
{
    public class Institution
    {
        private string name;    //declaring private variables
        private string address;

        public string Name { get; set; }    //create public variable using get/set
        public string Address { get; set; }

        public Institution() 
        {
            Name = "";      //seting default values
            Address = "";   
        }
    }
}
