using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    interface INotificationService //make a interface 
    {
        void NotifyUserChanged(User user);
        

    }
}
