using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//Build a class called Greeter DONE
//Hello DONE
//Bye DONE
//Time Greeting
//Call Methods

namespace Week2Challenge
{
    [TestClass]
    public class Challenge
    {
        [TestMethod]
        public void HelloName()
        {
            Greeter name = new Greeter();
            name.YourName = Console.ReadLine();
            Console.WriteLine("Hello" + name.YourName);
            //hello method
        }

        public void ByeName()
        {
            Greeter name = new Greeter();
            name.YourName = Console.ReadLine();
            Console.WriteLine("Goodbye" + name.YourName);
            //goodbye method
        }

        public void TimeGreeting()
        {
            DateTime now = DateTime.Now;
            //now.TimeOfDay
            if (now.Hour >= 12 && now.Hour < 12)
            {
                Console.WriteLine($"{name.YourName}, it is too early.");
            }
        }

    }
}
