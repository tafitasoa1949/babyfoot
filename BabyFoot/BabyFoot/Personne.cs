using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyFoot
{
    internal class Personne
    {
        int id;
        int idEquipe;
        int Xposition;
        int Yposition;
        Rectangle rectangle;
        public bool IsSelected { get; set; }
        public int getId()
        {
            return this.id;
        }
        public void setId(int ide)
        {
            this.id = ide;
        }
        public int getIdEquipe()
        {
            return this.idEquipe;
        }
        public void setIdEquipe(int ide)
        {
            this.idEquipe = ide;
        }
        public int GetxPosition()
        {
            return this.Xposition;
        }
        public void SetxPosition(int xPos)
        {
            this.Xposition = xPos;
        }
        public int GetyPosition()
        {
            return this.Yposition + 10;
        }
        public void SetyPosition(int yPos)
        {
            this.Yposition = yPos;
        }
        public Rectangle GetRectangle()
        {
            return this.rectangle;
        }

        public Personne(int i,int id,int x, int y)
        {
            this.setId(i);
            this.setIdEquipe(id);
            this.SetxPosition(x);
            this.SetyPosition(y);
            this.rectangle.Size = new Size(20, 20);
            this.rectangle.Location = new Point(this.GetxPosition(), this.GetyPosition());
        }
        public void Draw(Graphics g,Color c)
        {
            Brush br = new SolidBrush(c);
            g.FillRectangle(br, this.rectangle);
            this.rectangle.Location = new Point(this.Xposition,this.Yposition);
        }
        public void mouve_left()
        {
            this.Xposition -= 20;
        }
        public void mouve_rigth()
        {
            this.Xposition += 20;
        }
        public void mouve_avant()
        {
            if(this.getIdEquipe() == 1)
            {
                this.Yposition -= 20;
            }
            else if(this.getIdEquipe() == 2)
            {
                this.Yposition += 20;
            }
        }
        public void mouve_arriere()
        {
            if (this.getIdEquipe() == 1)
            {
                this.Yposition += 20;
            }
            else if (this.getIdEquipe() == 2)
            {
                this.Yposition -= 20;
            }
        }
        //Passe
        public double distance_joueur(Personne one, Personne two)
        {
            double delta_x = two.GetxPosition() - one.GetxPosition();
            double delta_y = two.GetyPosition() - one.GetyPosition();
            return Math.Sqrt(delta_x * delta_x + delta_y * delta_y);
        }
        public Personne coequipier_plus_proche(Personne[] namany,Personne izy)
        {
            Personne val = null;
            double min_distance = double.MaxValue;
            for (int i = 0; i < namany.Length; i++)
            {
                if (namany[i].getId() != izy.getId())
                {
                    double distance = distance_joueur(izy, namany[i]);
                    if(distance  < min_distance)
                    {
                        min_distance = distance;
                        val = namany[i];
                    }    
                }
            }
            return val;
        }
        public void passe(Personne passina,Personne izy,Ball ballon)
        {
            ballon.setIdEquipe(passina.getIdEquipe());
            ballon.setIdJo(passina.getId());
            ballon.SetxPosition(passina.GetxPosition());
            ballon.SetyPosition(passina.GetyPosition());
        }
    }
}
