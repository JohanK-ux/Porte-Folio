using System;
using System.Collections.Generic;
using System.Text;

namespace tp_Gesper
{
    public class Employe
    {
        private byte cadre;
        private int id;
        private string nom;
        private string prenom;
        private decimal salaire;
        private char sexe;
        private List<Diplome> lesDiplomes;
        private service leService;

        public Employe(int id, string nom, string prenom, char sexe,byte cadre,decimal salaire,service service)
        {
            this.id = id;
            this.cadre = cadre;
            this.nom = nom;
            this.prenom = prenom;
            this.salaire = salaire;
            this.sexe = sexe;
            this.leService = null;
        }

        public int Id { get => id; set => id = value; }
        public byte Cadre { get => cadre; set => cadre = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public decimal Salaire { get => salaire; set => salaire = value; }
        public char Sexe { get => sexe; set => sexe = value; }
        public List<Diplome> LesDiplomes { get => lesDiplomes; set => lesDiplomes = value; }

        public string ToString()
        {
            return null;
        }
    }
}
