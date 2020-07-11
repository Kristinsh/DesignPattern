using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.Basics
{
                
    class Properties
    {

            static void Main(string[] args)        //hovedprogrammet
            {
                Person2 person = new Person2("Prins", "Milo");   //legger til innhold I argumentet
                person.Age = 10;                    //legge til alder da det ikke var et argument
                Person2 person2 = new Person2();    //nytt objekt
                person2.FirstName = "Kristin";      //legger til innhold  i firstName, lastName og age
                person2.LastName = "Hagen";
                person2.Age = 24;

                //Skriver ut i console (terminalen). 
                Console.WriteLine("Name: " +person.FirstName + person.LastName + "Age: " +person.Age);
                Console.WriteLine("Name: " +person2.FirstName + person2.LastName +"Age:"+person2.Age);
            }
        

    }

    class Person2                                  //klassen vår
    {
        private string firstName;           //field declaration for firstName
        private string lastName;           //field lastName
        private int age;                          //int age

        public string FirstName             //Lager property for firstName (prop)
        {
            get { return firstName; }            //returnerer firstName
            set { firstName = value; }           //sets verdien av property lik field firstName
        }

        public string LastName             //Lager property for lastName (prop)
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age             //Lager property for age (prop)
        {
            get { return age; }
            set { age = value; }
        }

        public Person2(string firstName, string lastName)   //takes two arguments
        {
            this.firstName = firstName;         //sets the arguments to our fields
            this.lastName = lastName;
        }

        public Person2()                         //empty constructor
        { }


        //Just to demonstrate property
        private int password;
        public int Password
        {
            get { return password; }            //Read
            set                                 //Write
            {
                if (value > 4 && value < 10)
                {
                    password = value;

                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }

        private string username;
        public string Username
        {
            get { return "The username is " + username; }  //Read
            set                                             //write
            {
                if (value.Length > 4 && value.Length < 10)
                {
                    username = value;

                }
                else
                {
                    Console.WriteLine("Error!");
                }

            }
        }




    }




}

//Fields are private and the props are public. You can also change the get and set inside the prop, if you want 
//for example the set to be private or internal.

