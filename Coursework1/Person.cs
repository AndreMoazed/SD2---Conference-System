//Andre Moazed - 40216327
//This class is used as a parent class to attendee, as all people have a first name and a surname
//24-10-16

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1
{

    public class Person     //Parent calss "Person"
    {
        private string firstName;
        private string secondName;

        public string FirstName                 //First name being declared public
        {
            get
            {
                return firstName;
            }
            set
            {
                if(firstName != "")
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("You must enter your first name.");
                }
            }
        }
        public string SecondName
        {
            get
            {
                return secondName;
            }
            set
            {
                if(secondName != "")
                {
                    secondName = value;
                }
                else
                {
                    throw new ArgumentException("You must enter your second name.");
                }
            }
        }
    }
}
