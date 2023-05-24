using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyFoot
{
    internal class Jetonaire
    {
        public int joueur1 { get; set; }
        public int joueur2 { get; set; }
        public double mise1 { get; set; }
        public double mise2 { get; set; }
        public double tarif { get; set; }
        public DateTime daty { get; set; }

        public Jetonaire(int joueur1, int joueur2, double mise1, double mise2, double tarif, DateTime daty)
        {
            this.joueur1 = joueur1;
            this.joueur2 = joueur2;
            this.mise1 = mise1;
            this.mise2 = mise2;
            this.tarif = tarif;
            this.daty = daty;
        }
    }
}
