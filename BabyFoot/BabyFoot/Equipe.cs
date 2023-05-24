using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyFoot
{
    internal class Equipe
    {
        int id;
        public int getId()
        {
            return this.id;
        }
        public void setId(int ide)
        {
            this.id = ide;
        }
        public string nom { get; set; }
        public Personne[] olona { get; set; }
        public Equipe(int i)
        {
            this.setId(i);
        }
    }
}
