using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public class Greeter
    {
        

        public void Hello()
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"What's Up {name}?");
    

        }

        public void Goodbye(string name)
        {

            Console.WriteLine($"See ya later {name}");
            Console.ReadLine();
        }

        public void Greeting(string name)
        {
            DateTime time = new DateTime();
            time = DateTime.Now;
            if (time.Hour < 12)
            {
                Console.WriteLine("Good Morning" + name);
            }
            else if (time.Hour < 16 && time.Hour >= 12)
            {
                Console.WriteLine("Good Afternoon" + name);
            }
            else if (time.Hour >= 16 && time.Hour < 20)
            {
                Console.WriteLine("Good Evening" + name);
            }
            else if (time.Hour >= 20)
            {
                Console.WriteLine("Good Night" + name);
            }
        }

        Hello hello = new Hello();
        Goodbye goodbye = new Goodbuy();
        Greeting greeting = new Greeting();

        


       






            

    }
}
