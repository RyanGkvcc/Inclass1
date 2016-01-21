using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Employee
    {
        // Backing Fields
        private String firstName;
        private String lastName;
        private Decimal weeklySalary;

        // properties for the backing fields
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public  Decimal WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }

        //One Method that is public. Can be accessed from other classes.
        public String GetFullName()
        {
            return this.firstName + " " + this.lastName;
        }


        //Override method that will print all of the fields
        //It overrides the the default To String that every objest ets for free!
        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " " + this.weeklySalary.ToString("c");
        }

        //One Method that is private. Can only be called from inside this class.
        private String FOO()
        {
            return "FOO";
        }

        //3 Parameter constructor.
        public Employee (String firstName, String lastName, Decimal weeklySalary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            //Can do weeklySalary the same way,
            //or,
            //Assign the passed in value by the property.
            this.WeeklySalary = weeklySalary;
        }

        //Default constructor
        public Employee()
        {
            //Lets just leave this blank.
        }
    }
}
