using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Restaurantt
{
    class Cashier:Personne
        
    {
        public Cashier(string nom):base(nom) { }
        public void Pay()
        {
            Console.WriteLine("J'ai payé");
        }
    }
}
