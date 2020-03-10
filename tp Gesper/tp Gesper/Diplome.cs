using System;
using System.Collections.Generic;
using System.Text;

namespace tp_Gesper
{
    public class Diplome
    {
        private int id;
        private List<Employe> lesEmployes;
        private string libelle;

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public  List<Employe> LesEmployes { get => lesEmployes; set => lesEmployes = value; }

        public Diplome(int num, string nom)
        {
            this.id = num;
            this.libelle = nom;
        }
        public string ToString()
        {
            return null;
        }
    }
}
