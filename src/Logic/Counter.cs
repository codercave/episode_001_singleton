using System;
namespace src.Logic
{
    public class Counter
    {
        private int counter;

        private Counter()
        {
            counter = 0;
        }

        private static Counter theInstance;
        public static Counter Instance()
        {
            if(theInstance == null)
            {
                theInstance = new Counter();
            }

            return theInstance;
        }

        public int Increment()
        {
            return counter++;
        }
    }
}
