using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.Singleton
{
    class Logger
    {
        //private static Logger logger;
        //public Logger()
        //{

        //}

        //public static Logger GetLoggerInstance()
        //{
        //    if(logger == null )
        //    {
        //        logger = new Logger();
        //    }
        //    return logger;
        //}

        private static Logger instance;

        private Logger()
        {

        }


        public static Logger Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Logger();

                }
                return instance;
            }

           
        }
    }
}

/*
Note that the get methods returns a value, while the set method let us set a value.
This has to be done in the get, because we are trying to get the Logger instance, 
and we need to create the instance here if its null, or else the value would never be set. 
 */