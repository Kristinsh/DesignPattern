using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.Basics
{
    class Constructors
    {
        static void Main()
        {
            Person person = new Person(“Prins”, “Milo”);
            System.Console.WriteLine(person.FirstName + “” +person.LastName);

        }
    }

    class Person
    {
        public string FirstName;                                                          //Store bokstaver for properties
        public string LastName;

        public Person(string firstName, string lastName)              //Kan ha parameter, trenger ikke
        {                                                                                                 //Små bokstaver for argument/parameter
            FirstName = firstName;
            LastName = lastName;
        }

    }

    //Alle klasser har en constructor, selv dersom man ikke declarerer en, så lager VS en constructor selv. 
    //Den har det samme navnet som klassen.

    //Vi tar verdien i argumentet/parameteret(string firstName, string lastName) og lagrer det i «FirstName» og «LastName», 
    //    som igjen blir lagret i våre «properties» (public string FirstName og public string LastName). 

}
