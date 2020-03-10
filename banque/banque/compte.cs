using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace banque
{
    class compte
    {
        private int decouvertMax;
        private int numero;
        private int solde;
        private string titulaire;

        public compte(int numero, string titulaire, int solde, int découvertMax)
        {
            this.numero = numero;
            this.titulaire = titulaire;
            this.solde = solde;
            this.decouvertMax = decouvertMax;
        }
        public string ToString()
        {
            return string.Format("Votre numéro de compte est {0}, sous le nom de :{1} vous avez {2} euros avec un decouvert de {3}", numero, titulaire, solde, decouvertMax);
        }
    }
}
