using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BabyFoot
{
    internal class Affichage : Panel
    {

        //
        Label nomJ1;
        Label argentJ1;
        Label scoreJ1;
        Label nomJ2;
        Label argentJ2;
        Label scoreJ2;
        Label mise;
        //
        public Terrain terrain;
        public Piste pi;
        public Affichage(Terrain tr,Piste p)
        {
            terrain = tr;
            pi = p;
            //Joueuer1
            this.nomJ1 = new Label();
            this.nomJ1.Location = new Point(10, 10);
            this.nomJ1.Size = new Size(300, 20);
            this.SetNameJ1(this.terrain.getNomJ1());
            Controls.Add(this.nomJ1);

            this.argentJ1 = new Label();
            this.argentJ1.Location = new Point(10, 50);
            this.argentJ1.Size = new Size(300, 20);
            this.SetArgent1(this.terrain.getArgent1());
            Controls.Add(this.argentJ1);

            this.scoreJ1 = new Label();
            this.scoreJ1.Location = new Point(10, 90);
            this.scoreJ1.Size = new Size(300, 20);
            this.SetScore1(this.pi.getScore1());
            Controls.Add(this.scoreJ1);

            //Joueur2
            this.nomJ2 = new Label();
            this.nomJ2.Location = new Point(10, 200);
            this.nomJ2.Size = new Size(300, 20);
            this.SetNameJ2(this.terrain.getNomJ2());
            Controls.Add(this.nomJ2);

            this.argentJ2 = new Label();
            this.argentJ2.Location = new Point(10, 250);
            this.argentJ2.Size = new Size(300, 20);
            this.SetArgent2(this.terrain.getArgent2());
            Controls.Add(this.argentJ2);

            this.scoreJ2 = new Label();
            this.scoreJ2.Location = new Point(10, 300);
            this.scoreJ2.Size = new Size(300, 20);
            this.SetScore2(this.pi.getScore2());
            Controls.Add(this.scoreJ2);
            //
            this.BackColor = Color.Pink;
            this.Location = new Point(700, 10);
            this.Name = "Affichage";
            this.Size = new System.Drawing.Size(550, 900);
        }
        public void SetNameJ1(String no)
        {
            nomJ1.Text = " Nom du Joueur 1: " + no;
        }


        public void SetArgent1(double money)
        {
            argentJ1.Text = "Argent : " + money + " ar";
        }

        public void SetScore1(int sc)
        {
            this.scoreJ1.Text = "Score  : " + sc;
        }
        //
        public void SetNameJ2(String no)
        {
            nomJ2.Text = " Nom du Joueur 2: " + no;
        }


        public void SetArgent2(double money)
        {
            argentJ2.Text = "Argent : " + money + " ar";
        }

        public void SetScore2(int sc)
        {
            this.scoreJ2.Text = "Score  : " + sc;
        }
    }
}
