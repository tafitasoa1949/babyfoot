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
    internal class Piste : Panel
    {
        //Score
        int score1 = 0;
        int score2 = 0;
        //Joueur en action
        int indice_P1;
        int indice_P2;
        //timer
        public Timer timer;
        //mouve
        private bool isKeyPressedA = false;
        private bool isKeyPressedQ = false;
        public Stade stade;
        int width { get; set; }
        int height;
        public int xPos { get; set; }
        public int yPos { get; set; }
        //Buts
        public Rectangle but1;
        public Rectangle but2;
        //equipe
        //Joueur1
        Equipe equipe1 = new Equipe(1);

        Personne[] Joueur1 = new Personne[12];

        Personne P1_G1;

        Personne P1_D1;
        Personne P1_D2;
        Personne P1_D3;

        Personne P1_M1;
        Personne P1_M2;
        Personne P1_M3;
        Personne P1_M4;
        Personne P1_M5;

        Personne P1_A1;
        Personne P1_A2;
        Personne P1_A3;

        //Joueur2
        Equipe equipe2 = new Equipe(2);

        Personne[] Joueur2 = new Personne[12];

        Personne P2_G1;

        Personne P2_D1;
        Personne P2_D2;
        Personne P2_D3;

        Personne P2_M1;
        Personne P2_M2;
        Personne P2_M3;
        Personne P2_M4;
        Personne P2_M5;

        Personne P2_A1;
        Personne P2_A2;
        Personne P2_A3;

        //ballon
        Ball ballon { get; set; }
        public int getScore1()
        {
            return this.score1;
        }
        public void setScore1(int sc)
        {
            this.score1 = sc;
        }
        public int getScore2()
        {
            return this.score2;
        }
        public void setScore2(int sc)
        {
            this.score2 = sc;
        }
        public Rectangle getBut1()
        {
            return this.but1;
        }
        public Rectangle getBut2()
        {
            return this.but2;
        }

        public Piste(Stade st)
        {

            this.stade = st;
            this.width = this.stade.Width / 2;
            this.height = (int)((int)this.width * 1.4);
            this.xPos = 15;
            this.yPos = 10;
            this.BackColor = Color.SeaGreen;
            this.Location = new Point(xPos, yPos);
            this.Name = "Piste";
            this.Size = new System.Drawing.Size(this.width, this.height);
            //but
            this.but1 = new Rectangle();
            this.but2 = new Rectangle();

            this.but1.Size = new Size(this.width / 3, 20);
            this.but1.Location = new Point(this.width / 3, -1);

            this.but2.Size = new Size(this.width / 3, 20);
            this.but2.Location = new Point(this.width / 3, this.Height - 20);
            this.DoubleBuffered = true;
            //equipe
            //Joueur1
            P1_G1 = new Personne(1,this.equipe1.getId(),310, 830);
            this.Joueur1[0] = this.P1_G1;

            P1_D1 = new Personne(2,this.equipe1.getId(), 100, 700);
            this.Joueur1[1] = this.P1_D1;
            P1_D2 = new Personne(3,this.equipe1.getId(), 310, 730);
            this.Joueur1[2] = this.P1_D2;
            P1_D3 = new Personne(4,this.equipe1.getId(), 510, 750);
            this.Joueur1[3] = this.P1_D3;

            P1_M1 = new Personne(5,this.equipe1.getId(), 20, 500);
            this.Joueur1[4] = this.P1_M1;
            P1_M2 = new Personne(6,this.equipe1.getId(), 150, 500);
            this.Joueur1[5] = this.P1_M2;
            P1_M3 = new Personne(7,this.equipe1.getId(), 300, 500);
            this.Joueur1[6] = this.P1_M3;
            P1_M4 = new Personne(8,this.equipe1.getId(), 450, 500);
            this.Joueur1[7] = this.P1_M4;
            P1_M5 = new Personne(9,this.equipe1.getId(), 600, 500);
            this.Joueur1[8] = this.P1_M5;

            P1_A1 = new Personne(10,this.equipe1.getId(), 100, 260);
            this.Joueur1[9] = this.P1_A1;
            P1_A2 = new Personne(11,this.equipe1.getId(), 310, 260);
            this.Joueur1[10] = this.P1_A2;
            P1_A3 = new Personne(12,this.equipe1.getId(), 510, 260);
            this.Joueur1[11] = this.P1_A3;

            this.equipe1.nom = "PSG";
            this.equipe1.olona = this.Joueur1;

            //Joueur2
            P2_G1 = new Personne(0,this.equipe2.getId(), 310, 50);
            this.Joueur2[0] = this.P2_G1;

            P2_D1 = new Personne(1,this.equipe2.getId(), 100, 150);
            this.Joueur2[1] = this.P2_D1;
            P2_D2 = new Personne(2,this.equipe2.getId(), 310, 150);
            this.Joueur2[2] = this.P2_D2;
            P2_D3 = new Personne(3,this.equipe2.getId(), 510, 150);
            this.Joueur2[3] = this.P2_D3;

            P2_M1 = new Personne(4,this.equipe2.getId(), 20, 370);
            this.Joueur2[4] = this.P2_M1;
            P2_M2 = new Personne(5,this.equipe2.getId(), 150, 370);
            this.Joueur2[5] = this.P2_M2;
            P2_M3 = new Personne(6,this.equipe2.getId(), 300, 370);
            this.Joueur2[6] = this.P2_M3;
            P2_M4 = new Personne(7,this.equipe2.getId(), 450, 370);
            this.Joueur2[7] = this.P2_M4;
            P2_M5 = new Personne(8,this.equipe2.getId(), 600, 370);
            this.Joueur2[8] = this.P2_M5;

            P2_A1 = new Personne(9,this.equipe2.getId(), 100, 610);
            this.Joueur2[9] = this.P2_A1;
            P2_A2 = new Personne(10,this.equipe2.getId(), 310, 610);
            this.Joueur2[10] = this.P2_A2;
            P2_A3 = new Personne(11,this.equipe2.getId(),510, 610);
            this.Joueur2[11] = this.P2_A3;

            this.equipe2.nom = "Barca";
            this.equipe2.olona = this.Joueur2;

            //ballon
            this.ballon = new Ball(this.P1_G1.GetxPosition(),this.P1_G1.GetyPosition(),this.P1_G1.getId(),this.P1_G1.getIdEquipe());
            //timer
            //this.components = new Container();
            this.timer = new Timer();
            this.timer.Interval = 5;
            this.timer.Tick += this.mouvement;
            //this.timer.Enabled = true;
            this.timer.Start();

            this.P1_G1.IsSelected = true;
            this.P2_G1.IsSelected = true;
            this.indice_P1 = 0;
            this.indice_P2 = 0;

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            //les buts 
            Pen pe = new Pen(Color.Black, 2);
            g.DrawRectangle(pe, but1);
            g.DrawRectangle(pe, but2);
            //
            formation(g);
        }

        public void formation(Graphics g)
        {
            //equipe
            //Joueur1
            for (int i = 0; i < this.Joueur1.Length; i++)
            {
                this.Joueur1[i].Draw(g, Color.RoyalBlue);
            }
            //Joueur2
            for (int j = 0; j < this.Joueur2.Length; j++)
            {
                this.Joueur2[j].Draw(g, Color.Yellow);
            }
            //ballon
            this.ballon.Draw(g, Color.White);
        }
        //mouvement
        public void keyIsDown(object sender,KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //Joueur1
                case Keys.Left:
                    if (this.ballon.getIdJo() == this.Joueur1[indice_P1].getId())
                    {
                        if (this.Joueur1[indice_P1].GetxPosition() > 10)
                        {
                            this.Joueur1[indice_P1].mouve_left();
                            this.ballon.deplacement(this.Joueur1[indice_P1].GetxPosition(), this.Joueur1[indice_P1].GetyPosition());
                        }
                    }
                    else
                    {
                        if (this.Joueur1[indice_P1].GetxPosition() > 10)
                        {
                            this.Joueur1[indice_P1].mouve_left();
                        }
                    }
                    break;
                case Keys.Right:
                    if (this.ballon.getIdJo() == this.Joueur1[indice_P1].getId())
                    {
                        if (this.Joueur1[indice_P1].GetxPosition() < 620)
                        {
                            this.Joueur1[indice_P1].mouve_rigth();
                            this.ballon.deplacement(this.Joueur1[indice_P1].GetxPosition(), this.Joueur1[indice_P1].GetyPosition());
                        } 
                    }
                    else
                    {
                        if (this.Joueur1[indice_P1].GetxPosition() < 620)
                        {
                            this.Joueur1[indice_P1].mouve_rigth();
                        }
                    }
                    break;
                case Keys.Up:
                    if (this.ballon.getIdJo() == this.Joueur1[indice_P1].getId())
                    {
                        if (this.Joueur1[indice_P1].GetyPosition() > yPos + 15 )
                        {
                            this.Joueur1[indice_P1].mouve_avant();
                            this.ballon.deplacement(this.Joueur1[indice_P1].GetxPosition(), this.Joueur1[indice_P1].GetyPosition());
                        }                    
                    }
                    else
                    {
                        if (this.Joueur1[indice_P1].GetyPosition() > yPos + 15)
                        {
                            this.Joueur1[indice_P1].mouve_avant();
                        }
                    }
                    break;
                case Keys.Down:
                    if (this.ballon.getIdJo() == this.Joueur1[indice_P1].getId())
                    {
                        if (this.Joueur1[indice_P1].GetyPosition() < 900 )
                        {
                            this.Joueur1[indice_P1].mouve_arriere();
                            this.ballon.deplacement(this.Joueur1[indice_P1].GetxPosition(), this.Joueur1[indice_P1].GetyPosition());
                        }  
                    }
                    else
                    {
                        if (this.Joueur1[indice_P1].GetyPosition() < 900)
                        {
                            this.Joueur1[indice_P1].mouve_arriere();
                        }
                    }
                    break;
                //Joueur2
                case Keys.A:
                    if (this.ballon.getIdJo() == this.Joueur2[indice_P2].getId())
                    {
                        if (this.Joueur2[indice_P2].GetxPosition() > 10)
                        {
                            this.Joueur2[indice_P2].mouve_left();
                            this.ballon.deplacement(this.Joueur2[indice_P2].GetxPosition(), this.Joueur2[indice_P2].GetyPosition());
                        }
                    }
                    else
                    {
                        if (this.Joueur2[indice_P2].GetxPosition() > 10)
                        {
                            this.Joueur2[indice_P2].mouve_left();
                        }
                    }
                    break;
                case Keys.E:
                    if (this.ballon.getIdJo() == this.Joueur2[indice_P2].getId())
                    {
                        if (this.Joueur2[indice_P2].GetxPosition() < 620)
                        {
                            this.Joueur2[indice_P2].mouve_rigth();
                            this.ballon.deplacement(this.Joueur2[indice_P2].GetxPosition(), this.Joueur2[indice_P2].GetyPosition());
                        }
                    }
                    else
                    {
                        if (this.Joueur2[indice_P2].GetxPosition() < 620)
                        {
                            this.Joueur2[indice_P2].mouve_rigth();
                        }
                    }
                    break;
                case Keys.S:
                    if (this.ballon.getIdJo() == this.Joueur2[indice_P2].getId())
                    {
                        if (this.Joueur2[indice_P2].GetyPosition() > yPos + 15)
                        {
                            this.Joueur2[indice_P2].mouve_avant();
                            this.ballon.deplacement(this.Joueur2[indice_P2].GetxPosition(), this.Joueur2[indice_P2].GetyPosition());
                        }
                    }
                    else
                    {
                        if (this.Joueur2[indice_P2].GetyPosition() > yPos + 15)
                        {
                            this.Joueur2[indice_P2].mouve_avant();
                        }
                    }
                    break;
                case Keys.Z:
                    if (this.ballon.getIdJo() == this.Joueur2[indice_P2].getId())
                    {
                        if (this.Joueur2[indice_P2].GetyPosition() < 900)
                        {
                            this.Joueur2[indice_P2].mouve_arriere();
                            this.ballon.deplacement(this.Joueur2[indice_P2].GetxPosition(), this.Joueur2[indice_P2].GetyPosition());
                        }
                    }
                    else
                    {
                        if (this.Joueur2[indice_P2].GetyPosition() < 900)
                        {
                            this.Joueur2[indice_P2].mouve_arriere();
                        }
                    }
                    break;
                //Passe et curseur
                //Joueur1
                case Keys.P:
                    if(this.ballon.getIdJo() == this.Joueur1[indice_P1].getId())
                    {
                        Personne Jo_passe = this.Joueur1[indice_P1].coequipier_plus_proche(this.Joueur1, this.Joueur1[indice_P1]);
                        this.Joueur1[indice_P1].passe(Jo_passe, this.Joueur1[indice_P1], ballon);
                        this.Joueur1[indice_P1].IsSelected = false;
                        Jo_passe.IsSelected = true;
                        indice_P1 = Jo_passe.getId() - 1;
                    }
                    else if(this.ballon.getIdJo() == this.Joueur2[indice_P2].getId())
                    {
                        Personne Jo_passe2 = this.Joueur2[indice_P2].coequipier_plus_proche(this.Joueur2, this.Joueur2[indice_P2]);
                        this.Joueur2[indice_P2].passe(Jo_passe2, this.Joueur2[indice_P2], ballon);
                        this.Joueur2[indice_P2].IsSelected = false;
                        Jo_passe2.IsSelected = true;
                        indice_P2 = Jo_passe2.getId() ;
                        Console.WriteLine(indice_P2);
                    }
                    break;
                //Joueur1
                case Keys.M:
                    Personne namany = this.Joueur1[indice_P1].coequipier_plus_proche(this.Joueur1, this.Joueur1[indice_P1]);
                    this.Joueur1[indice_P1].IsSelected = false;
                    namany.IsSelected = true;
                    indice_P1 = namany.getId() - 1;
                    //Console.WriteLine(indice_P1);
                    break;
                case Keys.W:
                    Personne namany2 = this.Joueur2[indice_P2].coequipier_plus_proche(this.Joueur2, this.Joueur2[indice_P2]);
                    this.Joueur2[indice_P2].IsSelected = false;
                    namany2.IsSelected = true;
                    indice_P2 = namany2.getId();
                    //Console.WriteLine(indice_P1);
                    break;
                case Keys.Enter:
                    this.ballon.setMouve(true);
                    break;
                default:
                    
                    break;
            }

           
        }
        public void KeyIsUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                
                default:
                    
                    break;

            }
        }
        /*public void Intercept()
        {
            for(int i=0; i< this.Joueur1.Length; i++)
            {
                if(this.Joueur1[i].GetRectangle().IntersectsWith(this.ballon.GetRectangle()))
                {
                    ballon.setIdEquipe(Joueur1[i].getIdEquipe());
                    ballon.setIdJo(Joueur1[i].getId());
                    ballon.SetxPosition(Joueur1[i].GetxPosition());
                    ballon.SetyPosition(Joueur1[i].GetyPosition());
                    //change autom curseur
                    this.Joueur1[indice_P1].IsSelected = false;
                    this.Joueur1[i].IsSelected = true;
                    indice_P1 = this.Joueur1[i].getId() - 1;
                    //this.ballon.setMouve(false);

                }
            }
            for (int i = 0; i < this.Joueur2.Length; i++)
            {
                if (this.Joueur2[i].GetRectangle().IntersectsWith(this.ballon.GetRectangle()))
                {
                    ballon.setIdEquipe(Joueur2[i].getIdEquipe());
                    ballon.setIdJo(Joueur2[i].getId());
                    ballon.SetxPosition(Joueur2[i].GetxPosition());
                    ballon.SetyPosition(Joueur2[i].GetyPosition());
                    //change autom curseur
                    this.Joueur2[indice_P2].IsSelected = false;
                    this.Joueur2[i].IsSelected = true;
                    indice_P2 = this.Joueur2[i].getId() ;
                    //this.ballon.setMouve(false);
                }
            }
        }*/

        public void IsGoal()
        {
            if (this.but1.IntersectsWith(this.ballon.GetRectangle()) && this.ballon.getMouve())
            {
                this.setScore1(this.getScore1() + 1);
                MessageBox.Show("Goal Equipe 1 Score: " + score1);
                this.ballon.setMouve(false);
                this.ballon.setIdEquipe(this.P2_G1.getIdEquipe());
                this.ballon.setIdJo(this.P2_G1.getId());
                this.ballon.SetxPosition(this.P2_G1.GetxPosition());
                this.ballon.SetyPosition(this.P2_G1.GetyPosition());
                this.P2_G1.IsSelected = true;
                this.indice_P2 = this.P2_G1.getId();
            }
            if (this.but2.IntersectsWith(this.ballon.GetRectangle()) && this.ballon.getMouve())
            {
                this.setScore2(this.getScore2() + 1);
                MessageBox.Show("Goal Equipe 2 Score: " + score2);
                this.ballon.setMouve(false);
                this.ballon.setIdEquipe(this.P1_G1.getIdEquipe());
                this.ballon.setIdJo(this.P1_G1.getId());
                this.ballon.SetxPosition(this.P1_G1.GetxPosition());
                this.ballon.SetyPosition(this.P1_G1.GetyPosition());
                this.P1_G1.IsSelected = true;
                this.indice_P1 = this.P1_G1.getId() - 1;
            }
        }
        public void IsCorner()
        {
            if(this.ballon.GetyPosition() == 0)
            {
                this.ballon.setMouve(false);
                this.ballon.setIdEquipe(this.P1_G1.getIdEquipe());
                this.ballon.setIdJo(this.P1_G1.getId());
                this.ballon.SetxPosition(this.P1_G1.GetxPosition());
                this.ballon.SetyPosition(this.P1_G1.GetyPosition());
                this.P2_G1.IsSelected = true;
                this.indice_P1 = this.P1_G1.getId() - 1;
            }
            else if(this.ballon.GetyPosition() < 50 && !this.but2.IntersectsWith(this.ballon.GetRectangle()))
            {
                this.ballon.setMouve(false);
                this.ballon.setIdEquipe(this.P2_G1.getIdEquipe());
                this.ballon.setIdJo(this.P2_G1.getId());
                this.ballon.SetxPosition(this.P2_G1.GetxPosition());
                this.ballon.SetyPosition(this.P2_G1.GetyPosition());
                this.P2_G1.IsSelected = true;
                this.indice_P2 = this.P2_G1.getId();
            }
        }
        public void mouvement(object sender, EventArgs e)
        {
            this.ballon.tir();
            //this.IsCorner();
            this.IsGoal();
            this.Invalidate();
        }
    }
}
