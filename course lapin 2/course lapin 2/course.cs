using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_lapin_2
{
    class course
    {
        private int distance;
        private List<lapin> participer;
        internal IEnumerable<lapin> participer;

        public int Count => this.participer.Count;

        public lapin this[int position]
        {
            get
            {
                if (position > -1 && position < Count)
                {
                    return this.Participer[position];
                }
                else
                {
                    throw new SystemException("Il n'existe pas");
                }
            }
        }
        public void Add(lapin nouveauParticipant)
        {
            Participer.Add(nouveauParticipant);
        }

        public lapin Gagnant()
        {
            lapin gagnant = (lapin)Participer[0];
            foreach (lapin Lapin in Participer)
            {
                if (Lapin.GetPosition > gagnant.GetPosition)
                {
                    gagnant = Lapin;
                }
            }
            return gagnant;
        }



        public void Départ()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < Participer.Count; j++)
                {
                    Participer[j].Avancer();
                }
            }
        }

        public course(int distance)
        {
             this.distance = distance;
        }


        public List<lapin> GetParticiper()
        {
            return this.Participer;
        }
    }
}
