using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var notificationService = new ConsoleNotification();
            var user = new User("Cruise", notificationService);
            user.ChangeUserName("kos");


            Console.ReadKey();



        }
    }
}
