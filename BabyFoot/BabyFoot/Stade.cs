using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabyFoot
{
    internal class Stade : Panel
    {
        public Terrain terrain;
        public Piste pi;
        public Affichage affiche;
        public Stade(Terrain ter)
        {
            this.terrain = ter;
            this.SuspendLayout();
            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackColor = Color.Brown;
            this.Location = new Point(0, 0);
            this.Name = "Stade 1";
            this.Size = new System.Drawing.Size(this.terrain.Width, this.terrain.Height);
            this.pi = new Piste(this);
            this.Controls.Add(pi);
            this.terrain.KeyDown += new KeyEventHandler(this.pi.keyIsDown);
            this.terrain.KeyUp += new KeyEventHandler(this.pi.KeyIsUp);
            //
            this.affiche = new Affichage(this.terrain,this.pi);
            this.Controls.Add(affiche);

        }
    }
}
