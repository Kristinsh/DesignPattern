using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.Singleton
{
    class TestLogger
    {
        
        static void Main()
        {
            var object1 = Logger.Instance;
            var object2 = Logger.Instance;

            Console.WriteLine(object1.GetHashCode());
            Console.WriteLine(object2.GetHashCode());

        }
    }
}

/* 
 When using the singleton pattern, you want the class to only have one object. And you want that
object to be reused again and again.
You also don't want the program to be able to create different instances of that object.
 As you can see here, the GetHashCode methods show that the same LoggerInstance is used,
because we dont want it to be able to create multiple Logger instances.  
 
 */