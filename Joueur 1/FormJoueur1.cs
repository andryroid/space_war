using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;

namespace Joueur_1
{
    public partial class FormJoueur1 : Form
    {
        PictureBox ArmeJ1, ArmeJ2;
        WCFDataContract.Vaisseau x;
        WCFDataContract.Arme a;
        private ChannelFactory<WCFInterface.Methodes> canal = null;
        private WCFInterface.Methodes services = null;
        public FormJoueur1()
        {
            InitializeComponent();
            
            MessageBox.Show(@"Joueur 1 prêt
                                
                                Cliquez su OK quand le service sera en écoute
                                
                                Le jeu se termine si l'un touche l'autre
                                
                                Didacticiel:
                                    A:   Gauche
                                    B:   Droite
                                    Z:   Tirer 


                                Le redémarrage du jeu sera necéssaire après chaque victoire!
                            ");
            
        }

        private void FormJoueur1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                if (vaisseau1.Location.X < this.Width- vaisseau1.Width)
                {
                    services.SetPosition(1, vaisseau1.Location.X);
                   vaisseau1.Location = new Point(vaisseau1.Location.X +x.Vitesse, 0);
                }
                
            }
            if (e.KeyCode == Keys.A)
            {
                if (vaisseau1.Location.X > 0)
                {
                    services.SetPosition(1, vaisseau1.Location.X);
                    vaisseau1.Location = new Point(vaisseau1.Location.X - x.Vitesse, 0);
                }
                
            }
            if (e.KeyCode == Keys.Z)
            {
                services.SetTir1(1, vaisseau1.Location.X);
                ArmeJ1.Visible = true;
                ArmeJ1.Location = new Point(vaisseau1.Location.X, vaisseau1.Location.Y);
                ArmeJoueur1.Start();
            }
        }

        private void FormJoueur1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                if (vaisseau1.Location.X < this.Width - vaisseau1.Width)
                {
                   services.SetPosition(1, vaisseau1.Location.X);
                   vaisseau1.Location = new Point(vaisseau1.Location.X + x.Vitesse, 0);
                }
            }
            if (e.KeyCode == Keys.A)
            {
                if (vaisseau1.Location.X > 0)
                {
                    services.SetPosition(1, vaisseau1.Location.X);
                    vaisseau1.Location = new Point(vaisseau1.Location.X - x.Vitesse, 0);
                }
            }
        }

        private void FormJoueur1_Load(object sender, EventArgs e)
        {
            init();
           timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            test();
        }

        private void FormJoueur1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ArmeJoueur1_Tick(object sender, EventArgs e)
        {
            if (ArmeJ1.Location.Y >= (this.Height-cloneVaisseau2.Height) )
            {
               if( services.Touché(ArmeJ1.Location.X,
                                         (ArmeJ1.Location.X + ArmeJ1.Width),
                                         cloneVaisseau2.Location.X,
                                         (cloneVaisseau2.Location.X + cloneVaisseau2.Width)
                                         ))
                {
                    services.setGagnant(1);
                    stop("vous avez gagné");

                }
                    
                    
                
                
                ArmeJ1.Location = new Point(-20, -20);
                ArmeJoueur1.Stop();
                ArmeJ1.Visible = false;
            }
            ArmeJ1.Location = new Point(vaisseau1.Location.X,ArmeJ1.Location.Y+10);
        }

        private void cloneArmeJ2_Tick(object sender, EventArgs e)
        {
            if (ArmeJ2.Location.Y <=0 )
            {
                ArmeJ2.Location = new Point(cloneVaisseau2.Location.X, cloneVaisseau2.Location.Y);
                cloneArmeJ2.Stop();
                ArmeJ2.Visible = false;
            }
            ArmeJ2.Location = new Point(cloneVaisseau2.Location.X, ArmeJ2.Location.Y - 10);
        }

        public void test()
        {
            if (services.getGagnant() != 0)
            {
                stop("vous avez perdu!");
            }
                if (services.isTrue2())
                {
                    ArmeJ2.Visible = true;
                    cloneArmeJ2.Start();
                    int x = services.GetTir(2);
                }
                cloneVaisseau2.Location = new Point(services.GetPosition(2), this.Height - cloneVaisseau2.Height-50);
            
        }
        public void stop(string message)
        {
            timer1.Stop();
            ArmeJoueur1.Stop();
            MessageBox.Show("Joueur 1 fin de partie"+" "+message.ToUpper());
        }
        public void init()
        {
           
            canal = new ChannelFactory<WCFInterface.Methodes>(
                                        new NetTcpBinding(),
                                        "net.tcp://127.0.0.1:1993/SpaceWarServices"
                );
            services = canal.CreateChannel();



            //////////////////////////////////////
            x = services.CreerVaisseau("sonic");
            a = services.CreerArme1();
            x.Arme = a;
            //////////////////////////////////////


            //vaisseau1 = new PictureBox();
            //cloneVaisseau2 = new PictureBox();
            //vaisseau1.BackgroundImage=Joueur_1.Properties.Resources.V1;
   
            //vaisseau1.ImageLocation ="50,50";
            


            ////vaisseau1.BackColor = Color.Black;
            //cloneVaisseau2.BackColor = Color.Black;


            //this.Controls.Add(vaisseau1);
            //this.Controls.Add(cloneVaisseau2);


            //vaisseau1.Location = new Point(0, 0);
            //////////////////vaisseau 2
            //cloneVaisseau2.Location = new Point(this.Width-cloneVaisseau2.Width, this.Height - cloneVaisseau2.Height+20);

           

            //////////////arme////////////////////////

            ArmeJ1 = new PictureBox(); ArmeJ2 = new PictureBox();
            ArmeJ1.Width = 50; ArmeJ1.Height = 50; ArmeJ2.Width = 50; ArmeJ2.Height = 50;
            ArmeJ1.BackgroundImage = Joueur_1.Properties.Resources.b1;
            ArmeJ2.BackgroundImage = Joueur_1.Properties.Resources.b2;
            ArmeJ1.BackColor = Color.Transparent; ArmeJ2.BackColor = Color.Transparent;
            //ArmeJ1.BackColor = Color.Black; ArmeJ2.BackColor = Color.Red;
            this.Controls.Add(ArmeJ1); this.Controls.Add(ArmeJ2);
            this.ArmeJ1.Location = new Point(vaisseau1.Location.X, vaisseau1.Location.Y);
            this.ArmeJ2.Location = new Point(cloneVaisseau2.Location.X, cloneVaisseau2.Location.Y);
            this.ArmeJ1.Visible = false;
            this.ArmeJ2.Visible = false;

            ArmeJoueur1.Interval = x.Arme.Vitesse;
        }
    }
}
