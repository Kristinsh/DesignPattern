using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.Basics
{
   
    class Person1
    {
        public string FirstName;                                                          //Store bokstaver for properties
        public string LastName;

        public Person1(string firstName, string lastName)              //Kan ha parameter, trenger ikke
        {                                                                                                 //Små bokstaver for argument/parameter
            FirstName = firstName;
            LastName = lastName;
        }

        public Person1()                                                                      //Empty constructor
        {
        }

    }

    class MultipleConstructors
    {
        static void Main()
        {
            Person1 person = new Person1("Prins", "Milo");          //Constructor med content
            Person1 person1 = new Person1();                                  //Empty constructor
            person1.FirstName = "Willy";                                    //Legger til innhold I empty constructor
            person1.LastName = "Wonka";
            System.Console.WriteLine(person.FirstName + "" +person.LastName);
            System.Console.WriteLine(person1.FirstName + "" +person1.LastName); //Viser Willy Wonka

        }
    }

}
