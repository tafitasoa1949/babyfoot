using System;

using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyFoot
{
    internal class Ball
    {
        Boolean mouve = false;
        int Xposition;
        int Yposition;
        Rectangle rectangle;
        int idJoueur;
        int idEquipe;
      
        public Boolean getMouve()
        {
            return this.mouve;
        }
        public void setMouve(Boolean mv)
        {
            this.mouve = mv;
        }
        public int getIdJo()
        {
            return this.idJoueur;
        }
        public void setIdJo(int jo)
        {
            this.idJoueur = jo;
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
        public Ball(int x, int y,int idJo,int idEq)
        {
            this.SetxPosition(x);
            this.SetyPosition(y);
            this.setIdJo(idJo);
            this.setIdEquipe(idEq);
            this.rectangle = new Rectangle();
            this.rectangle.Size = new Size(10, 10);
            if(this.idEquipe == 2)
            {
                this.rectangle.Location = new Point(this.GetxPosition(), this.GetyPosition() + 10);
            }
            else if(this.idEquipe == 1)
            {
                this.rectangle.Location = new Point(this.GetxPosition(), this.GetyPosition() - 20);
            }
            
        }
        public void Draw(Graphics g, Color c)
        {
            Brush br = new SolidBrush(c);
            g.FillRectangle(br, this.rectangle);
            this.rectangle.Location = new Point(this.Xposition,this.Yposition);
        }
        public void deplacement(int x,int y)
        {
            this.SetxPosition(x);
            this.SetyPosition(y);
        }
        public void tir()
        {
            if (this.getMouve())
            {
                if (this.getIdEquipe() == 1)
                {
                    this.rectangle.Location = new Point(this.Xposition, this.Yposition);
                    this.Yposition -= 20;
                }
                else if (this.getIdEquipe() == 2)
                {
                    this.rectangle.Location = new Point(this.Xposition, this.Yposition);
                    this.Yposition += 25;
                }
            }
        }
    }
}
