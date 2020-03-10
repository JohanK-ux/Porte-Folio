using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace banque
{
    class Banque
    {
        private compte[] possede;
        private string nom;
        private int nombreCompte;

        public Banque(string nomBanque)
        {
            this.nom = nomBanque;
            this.possede = new compte[1];
            this.nombreCompte = 0;
        }
        public void AjouterCompte(compte c)
        {
            if (this.nombreCompte < this.possede.Length)
            {
                this.possede[nombreCompte]= c;
                this.nombreCompte=this.nombreCompte+1;
            }
            else
            {
                throw new System.Exception("Attetion vous atteignez la taille maximum du tableau de votre compte");
            }
        }
        public void AjouteCompte(int numero, string titulaire, int solde,int decouvertMax){
            compte NouveauCompte = new compte(numero,titulaire,solde,decouvertMax);
            this.Add(NouveauCompte);
    }

        private void Add(compte NouveauCompte)
        {
            throw new NotImplementedException();
        }
        public int NombreCompte
        {
            get
            {
                 return this.nombreCompte; 
            }
        }
        public int GetNombreCompte(){
            return this.nombreCompte;
            }
        public compte GetCompte(int position){
            if (position>-1&& position<nombreCompte){
                return this.possede[position];
            }
            else {
                throw new System.Exception("En dehors de la plage de compte"); 
            }
        }
        public compte this[int position]{
            get{
                return this.GetCompte(position);
            }
        }


        internal void NouveauCompte(compte c1)
        {
            throw new NotImplementedException();
        }

        internal void AjouterCompte(int p, string p_2, int p_3, int p_4)
        {
            throw new NotImplementedException();
        }
    }
        }

    
    


