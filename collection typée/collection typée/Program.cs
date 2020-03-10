


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace collection_typée
{
    class Program
    {
        static void Main(string[] args)
        {              
                    animal chien = new animal("chocolat", 43, 12, "chien", "wouf", "viande");
                    animal chat = new animal("samsung", 15, 2, "chat", "miaou", "poisson");
                    animal loup = new animal("chocolat", 50, 10, "loup", "aouuu", "jambon");
                    animal tortue = new animal("linux", 8, 20, "tortue", "grr", "salade");
                    animal poissonrouge = new animal("samsung", 1, 7, "poisson", "glouglou", "graine");

                    animal chien = new animal("chocolat", 43, 12, "chien", "wouf", "viande");
                    animal chat = new animal("samsung", 15, 2, "chat", "miaou", "poisson");
                    animal loup = new animal("chocolat", 50, 10, "loup", "aouuu", "jambon");
                    animal tortue = new animal("linux", 8, 20, "tortue", "grr", "salade");
                    animal poissonrouge = new animal("samsung", 1, 7, "poisson", "glouglou", "graine");

                    List<string> db = new List<string>();
                     db.Add("chien");
                     db.Add("chat");
                     db.Add("loup");
                     db.Add("tortue");
                     db.Add("poissonrouge");
                     Console.ReadLine();   



                    chien.afficher;

            int caseSwitch = 1;
            switch (caseSwitch)
            {
                case 1:
                    chien.Ajouter(db, animal);
                    break;
                   
            }
                            
        } 
      
       
    }
  }


