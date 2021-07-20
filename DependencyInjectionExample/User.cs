using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
     internal class User
     {
       private INotificationService _notificationService; //(ConsoleNotification)  // the user class depends on the consolenotification class and we what not ths user class affected by change 
                                                         //to the consolenotification.So  make sure we depend on an abstraction 
       public string Username { get; set; }
       public User(string username, INotificationService notificationService) //using dependency ingection
       {
            Username = username;
            _notificationService = notificationService;//new ConsoleNotification();
       }
           
        public void ChangeUserName(string newUsername)
        {
            Username = newUsername;
            _notificationService.NotifyUserChanged(this);
        }



     }
}
