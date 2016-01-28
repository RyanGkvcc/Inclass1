using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace cis237inclass1
{
    class CSVProcessor
    {
        public bool ImportCSV(String pathToCSVFile, Employee[] employees)
        {
            StreamReader streamReader = null;

            try
            {
                //determine a string to represent a line we read
                String line;

                //Create a new instance of the StreamReader class
                streamReader = new StreamReader(pathToCSVFile);

                //Create a counter to know what index to place the new object
                Int32 counter = 0;


                //This linne is doing a bunch of stuff. It is reading a line from 
                // the file. It is assigning that info to the 'line' variable, and
                //lastly it is making sure that what it just read was not null.
                //if it is null, we are done reading the file and we can exit the
                //loop.
                while((line = streamReader.ReadLine()) != null)
                {
                    processLine(line, employees, counter++);
                }
                return true;
            }
            catch (Exception e)
            {
                //Spit out the errors that occured
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                
                //If an instance of the streamreader was made, we want to ensure
                //that we close it. The finally block is a perfect spot to put it
                //since it will get called regardless of whether or not the try
                //succeeded.
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
            return false;
        }

        private void processLine(String line, Employee[] employees, Int32 index)
        {
            //Split the line into pars, and assign the parts to a string array
            String[] parts = line.Split(',');

            String firstName = parts[0];
            String lastName = parts[1];
            Decimal salary = decimal.Parse(parts[2]);

            //Now we just need to add a new wmployee to the aray and use the parts 
            //we parsed out. If you had a collection class, I would hope that it has 
            //a method that you made called 'add' that would then do the work of 
            //adding a new employee to the collection.
            employees[index] = new Employee(firstName, lastName, salary);
        }
    }
}
