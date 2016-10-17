﻿//Andre Moazed - 40216327
//declaring variables for an instance of attendee, also contains GetCost() method used for caluculating price that need to be paid by an attendee
//10-10-16

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coursework1
{
    public class Attendee : Person                      //inherits from parent class "Person"
    {
        private int attendeeRef;                        //declaring private variables and setting them equal empty
        private string institutionName;
        private string conferenceName;
        private string registrationType;
        private string paperTitle;
        private bool paid;
        private bool presenter;

        public Institution insitutionName = new Institution();      //creating an instance of institution

        public int AttedeeRef 
        {                                     //creating public variables with get and set methods
            get
            {
                return attendeeRef;
            }
            set
            {
                if(value >= 40000 && value <= 60000)
                {
                    attendeeRef = value;
                }
                else
                {
                    throw new ArgumentException("Attendee Reference must be between 40000 and 60000.");
                }
            }    
        }                          

        public string InstitutionName { get; set; }
        
        public string ConferenceName 
        {
            get 
            {
                return conferenceName;
            }
            set
            {
                if(conferenceName != "")
                {
                    conferenceName = value;
                }
                else
                {
                    throw new ArgumentException("Conference Name cannot be left blank.");
                }
            }
        }
        public string RegistrationType
        {
            get
            {
                return registrationType;
            }
            set
            {
                if(registrationType != "")
                {
                    registrationType = value;
                }
                else
                {
                    throw new ArgumentException("Registration Type cannot be left blank.");
                }
            }
        }
        public string PaperTitle
        {
            get
            {
                return paperTitle;
            }
            set
            {
                if(presenter == true && paperTitle == "")
                {
                    paperTitle = value;
                }
                else if(presenter == false && paperTitle != "")
                {
                    paperTitle = value;
                }
                else
                {
                    throw new ArgumentException("Presenters should have a Paper Title and if you have a Paper Title you must also be a presenter.");
                }
            }
        }
        public bool Paid { get; set; }
        public bool Presenter { get; set; }

        public double GetCost()
        {
            double cost = 0;                //creating vairable

            if(registrationType == "full") //checking if contents of the variable is "Full"
            {
                cost = 500;                 //Setting the value to 500
            }
            else if(registrationType == "student")
            {
                cost = 300;                 //Setting cost to 300
            }
            else
            {
                
            }
            
            if(Presenter == true)            //if the attendee is a presenter
            {
                cost = cost * 0.9;          //multiply cost by .9 (10% discount)
            }

            return cost;
        }
    }
}
