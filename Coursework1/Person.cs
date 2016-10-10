using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1
{

    public class Person
    {
        private string firstName;
        private string secondName;

        public string FirstName
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
