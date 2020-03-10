using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_lapin_2
{
    class lapin
    {
        private int Age;
        private int position;
        private string surnom;
        private static Random aleatoire = new Random();
        private int dossard;
        private static int comptage;

        public int Dossard
        {
            get
            {
                return this.dossard;
            }
            set => dossard = value;

        }

        public lapin(string surnom, int age)
        {
            this.position = 0;
            this.surnom = surnom;
            this.Age = age;
            lapin.comptage = lapin.comptage + 1;
            this.dossard = lapin.comptage + 1;


        }
        public void Avancer()
        {
            for (int i = 0; i <= 100; i = i + 1)
            {
                int pas = lapin.aleatoire.Next(0, 6);
                this.position += pas;

            }

        }

        internal int Surnom()
        {
            throw new NotImplementedException();
        }

        public int GetPosition
        {
            get
            {
                return this.position;
            }

        }

        public string GetSurnom
        {
            get
            {
                return this.GetSurnom;
            }
            set => surnom = value;
        }
        public int age
        {
            get
            {
                return this.Age;
            }
            set
            {
                Age = value;
            }
        }
        public string ToString()
        {
            return string.Format("la posistion des lapins {0} sont {1} dossard n:{2}", surnom, GetPosition, dossard);
        }
    }
}
