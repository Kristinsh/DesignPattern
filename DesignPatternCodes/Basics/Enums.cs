using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.Basics
{
    class Enums
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            User user1 = new User("Milo", Race.Martian);
            Console.WriteLine(user1.id + user1.Username + user1.race + user1.HEIGHT);
            User user2 = new User("Kristin", Race.Earthling);
            Console.WriteLine(user2.id + user2.Username + Race.Earthling + user2.HEIGHT);

            Console.WriteLine("Amount of users is : " + User.currentId);
        }


        public enum Race
        {
            Earthling,
            Martian
        }

        public class User
        {
            private string username;
            private int password;
            public readonly int HEIGHT;
            public static int currentId;
            public readonly int id;
            public Race race; //create new field with datatype race with name race
            
            //public int id

            public string Username
            {
                get { return "The username is " + username; }
            }

            public int Password
            {
                set
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




            public User()
            {
                currentId++;
                id = currentId;

            }

            public User(string username)
            {

                this.username = username;

            }

            public User(string username, Race race)
            {

                this.username = username;
                this.race = race;

                currentId++;
                id = currentId;

                if (race == Race.Earthling) //if race is Earthling
                {
                    HEIGHT = 10;            //set height to 10

                }
                else if (race == Race.Martian)
                {
                    HEIGHT = 5;
                }
            }



        }


    }
}
