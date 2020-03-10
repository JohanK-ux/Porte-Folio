using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace banque
{
    class Program
    {
        static void Main(string[] args)
        {
            Banque b1 = new Banque("credit lyonnais");
            Banque b2 = new Banque("Societe Generale");

            compte c1 = new compte(1, "harrytuttle", 0, -200);
            compte c2 = new compte(2,"jill layton",100,-100);

            b1.AjouterCompte(c1);
            b2.AjouterCompte(c2);
            b1.AjouterCompte(3, "sam lowry", 1000, -500);
            b1.AjouterCompte(4, "jack lint", 200, 0);

            for (int i = 0; i < Count; i = i + 1)
            {
            }
        }
    }
}
