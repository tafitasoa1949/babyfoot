using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyFoot
{
    internal class Joueur
    {
        public int id { get; set; }
        public string nom { get; set; }
        public double mise { get; set; }
        public int score { get; set; }

        public Joueur(int id, string nom, double mise, int score)
        {
            this.id = id;
            this.nom = nom;
            this.mise = mise;
            this.score = score;
        }
    }
    
}
