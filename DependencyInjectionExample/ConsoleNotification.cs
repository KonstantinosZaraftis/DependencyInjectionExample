using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
     internal class ConsoleNotification:INotificationService //consoleNotification class implement interface
     {
        public void NotifyUserChanged(User user) // implement the method
        {
            Console.WriteLine($"Username has been changed to:{user.Username}");
        }


     }
}
