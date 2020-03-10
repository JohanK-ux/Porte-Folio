using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace collection_typée
{
    class animal
    {
        private string nom;
        private double poids;
        private int age;
        private string espèce;
        private string crie;
        private string nourriturePref;

        public animal(string nom, double poids, int age, string espèce, string crie, string nourriturePref)
        {
            this.nom = nom;
            this.poids = poids;
            this.age = age;
            this.espèce = espèce;
            this.crie = crie;
            this.nourriturePref = nourriturePref;
        }

        public string crier()
        {
            return this.crie;
        }
        public void boire(double quantité)
        {
        }
        public void seNourrire(int quantité)
        {
        }
        public string Nom
        {
            get
            {
                return this.nom;
            }
        }
        public double Poids
        {
            get
            {
                return this.poids;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
        }
        public string Espèce
        {
            get
            {
                return this.espèce;
            }
        }
        public string Crie
        {
            get
            {
                return this.crie;
            }
        }
        public string NourriturePref
        {
            get
            {
                return this.nourriturePref;
            }
        }
        public string collection
        {
            get
            {
                return this.collection;
            }
        }
        public void afficher()
        {
            Console.WriteLine("1. Ajouter");
            Console.WriteLine("2. Liste");
            Console.WriteLine("3. Vider");
            Console.WriteLine("4. Trouver");
            Console.WriteLine("5. Supprimer");
            Console.WriteLine("6. Insérer");
            Console.WriteLine("7. Modifier");
            Console.WriteLine("Votre choix:");
        }
        public void AfficherListFor(List<animal> animaux)
        {
            for (int i = 0; i <= animaux.Count; i++)
            {
                Console.WriteLine(animaux[i]);
            }
        }
        public void afficherListForeach(List<animal> animaux)
        {
            foreach (animal a in animaux)
            {
                Console.WriteLine(a.ToString);
            }

        }
        public string ToString { get; set; }

        public void Ajouter(List<animal> l, animal a)
        {
            Console.WriteLine("Entrer le nom de votre animal : ");
            string nom = Console.ReadLine();
            Console.WriteLine("Entrer le poids de votre animal : ");
            double poids = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Entrer l'age de votre animal : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer l'espece de votre animal : ");
            string espèce = Console.ReadLine();
            Console.WriteLine("Entrer le crie de votre animal : ");
            string crie = Console.ReadLine();
        }


    }
}
        
           
    




