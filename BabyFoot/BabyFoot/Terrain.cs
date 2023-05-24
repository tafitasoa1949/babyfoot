using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabyFoot
{
    public partial class Terrain : Form
    {
        String nom_joueur1;
        double argent1;
        String nom_joueur2;
        double argent2;
        double mise;
        public String getNomJ1()
        {
            return this.nom_joueur1;
        }
        public void setNomJ1(String nom)
        {
            this.nom_joueur1 = nom;
        }
        public double getArgent1()
        {
            return this.argent1;
        }
        public void setArgent1(double ar)
        {
            this.argent1 = ar;
        }
        public String getNomJ2()
        {
            return this.nom_joueur2;
        }
        public void setNomJ2(String nom)
        {
            this.nom_joueur2 = nom;
        }
        public double getArgent2()
        {
            return this.argent2;
        }
        public void setArgent2(double ar)
        {
            this.argent2 = ar;
        }
        public double getMise()
        {
            return this.mise;
        }
        public void setMise(double mi)
        {
            this.mise = mi;
        }
        public Terrain(String J1,double ar1,String J2,double ar2,double mis)
        {
            InitializeComponent();
            //
            this.setNomJ1(J1);
            this.setArgent1(ar1);
            this.setNomJ2(J2);
            this.setArgent2(ar2);
            this.setMise(mis);
            //
            Stade stade = new Stade(this);
            this.Controls.Add(stade);

        }

        private void Terrain_Load(object sender, EventArgs e)
        {
        }

    }
}
