using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Restaurantt
{
    class Client:Personne

    {
        public Client(string nom):base(nom)
        {

        }

        public void Servwine()
        {

        }
        public void ServFood(Cashier leCaissier)
        {
            leCaissier.Pay();
        }
        public void ServAtTable(Waiter unServeur)
        {
            unServeur.OrderFood(this);
        }

    }
}
