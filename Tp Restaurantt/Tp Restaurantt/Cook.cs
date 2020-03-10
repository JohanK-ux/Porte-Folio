using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Restaurantt
{
    class Cook:Personne
    {
        public Cook(string nom):base (nom){ }
        public void OrderFood(Waiter unServer)
       {
            unServer.Pickup();
            Console.WriteLine("^Preparation de la bouf");
            
        }
    }
}
