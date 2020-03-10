using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tp_concetpion_d_une_classe
{
    class Program{
        static void Main(string[] args) { }
    }
    class Bidon
    {
        //données membres de lobjet 
        private int contenance;
        private int contenanceMax;
        private string couleur;

        //constructeur 
        public Bidon(string laCouleur, int laContenance)
        {
            contenance = 0;
            couleur = laCouleur;
            contenanceMax = laContenance;
        }

        //methodes : foncions ou prcedure 
        public void Remplir(int quantite)
        {
            if (contenance + quantite > contenanceMax)
            {
                int surplus = contenance + quantite - contenanceMax;
                Console.WriteLine("ça déborde de {0} litre(s)", surplus);
                contenance = contenanceMax;
            }
            else
            {
                contenance = contenance + quantite;
            }
        }

        public void Vider(int quantite)
        {
            contenance = contenance - quantite;
        }
        //methode retournant un bidon sous la forme du chaine de caractere 
        public string Tostring()
        {
            return string.Format("un bidon de {0} litre(s) contenant {1} litre(s) de couleur {2}", contenanceMax, contenance, couleur);

        }
    }
}

