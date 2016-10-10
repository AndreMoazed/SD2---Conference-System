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

        public Attendeee Attendeee
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Institution() 
        {
            Name = "";      //seting default values
            Address = "";   
        }
    }
}
