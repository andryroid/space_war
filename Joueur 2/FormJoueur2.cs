using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.Threading;

namespace Joueur_2
{
    public partial class FormJoueur2 : Form
    {
        WCFDataContract.Vaisseau x;
        WCFDataContract.Arme a;
        PictureBox ArmeJ2,ArmeJ1;
        private ChannelFactory<WCFInterface.Methodes> canal = null;
        private WCFInterface.Methodes services = null;
        public FormJoueur2()
        {
            InitializeComponent();
            MessageBox.Show(@"Joueur 2 prêt
                                
                                Cliquez su OK quand le service sera en écoute
                                
                                Le jeu se termine si l'un touche l'autre
                                
                                Didacticiel:
                                    A:   Gauche
                                    B:   Droite
                                    Z:   Tirer 

                                Le redémarrage du jeu sera necéssaire après chaque victoire!
                            ");

        }

        public void test()
        {
            if (services.getGagnant() != 0)
            {
                stop("vous avez perdu!");
            }
            if (services.isTrue1(1))
            {
                ArmeJ1.Visible = true;
                cloneArmeJ1.Start();
                int x = services.GetTir(1);
            }
                cloneVaisseau1.Location = new Point(services.GetPosition(1), 0);
            
        }

        private void FormJoueur2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                if (vaisseau2.Location.X < this.Width - vaisseau2.Width)
                {
                    services.SetPosition(2, vaisseau2.Location.X);
                    vaisseau2.Location = new Point(vaisseau2.Location.X + x.Vitesse, this.Height-100);
                }

            }
            if (e.KeyCode == Keys.A)
            {

                if (vaisseau2.Location.X > 0)
                {
                    services.SetPosition(2, vaisseau2.Location.X);
                    vaisseau2.Location = new Point(vaisseau2.Location.X - x.Vitesse, this.Height - 100);
                }

            }
        }

        private void FormJoueur2_Load(object sender, EventArgs e)
        {
            init();
            timer1.Start();   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            test();
        }

        private void ArmeJoueur2_Tick(object sender, EventArgs e)
        {
            if (ArmeJ2.Location.Y <=0)
            {
                if (services.Touché(ArmeJ2.Location.X,
                                         (ArmeJ2.Location.X + ArmeJ2.Width),
                                         cloneVaisseau1.Location.X,
                                         (cloneVaisseau1.Location.X + cloneVaisseau1.Width)
                                         ))
                {
                    services.setGagnant(2);
                    stop("vous avez gagné");
                }
                ArmeJ2.Location = new Point(vaisseau2.Location.X,vaisseau2.Location.Y);
                ArmeJoueur2.Stop();
                ArmeJ2.Visible = false;
            }
            ArmeJ2.Location = new Point(vaisseau2.Location.X, ArmeJ2.Location.Y - 10);
        }

        private void cloneArmeJ1_Tick(object sender, EventArgs e)
        {

            if (ArmeJ1.Location.Y >= this.Height)
            {
                ArmeJ1.Location = new Point(cloneVaisseau1.Location.X, cloneVaisseau1.Location.Y);
                cloneArmeJ1.Stop();
                ArmeJ1.Visible = false;
            }
            ArmeJ1.Location = new Point(cloneVaisseau1.Location.X, ArmeJ1.Location.Y + 10);
            
        }

        private void FormJoueur2_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.E)
            {
                if (vaisseau2.Location.X < this.Width - vaisseau2.Width)
                {
                    services.SetPosition(2, vaisseau2.Location.X);
                    vaisseau2.Location = new Point(vaisseau2.Location.X + x.Vitesse, this.Height -100);
                }

            }
            if (e.KeyCode == Keys.A)
            {

                if (vaisseau2.Location.X > 0)
                {
                    services.SetPosition(2, vaisseau2.Location.X);
                    vaisseau2.Location = new Point(vaisseau2.Location.X - x.Vitesse, this.Height - 100);
                }

            }
            if (e.KeyCode == Keys.Z)
            {
                services.SetTir2(2, vaisseau2.Location.X);
                ArmeJ2.Visible = true;
                ArmeJ2.Location = new Point(vaisseau2.Location.X, vaisseau2.Location.Y);
                ArmeJoueur2.Start();
            }
        }

        public void stop(string message)
        {
            timer1.Stop();
            ArmeJoueur2.Stop();
            MessageBox.Show("Joueur 2 fin de partie" + " " + message.ToUpper());
        }
        public void init()
        {
           
            //////////////////////////////////////
            canal = new ChannelFactory<WCFInterface.Methodes>(
                                       new NetTcpBinding(),
                                       "net.tcp://127.0.0.1:1993/SpaceWarServices"
               );
            services = canal.CreateChannel();


            //////////////////////////////////////
            x = services.CreerVaisseau("bombardeur");
            a = services.CreerArme1();
            x.Arme = a;
            //////////////////////////////////////

            //vaisseau2 = new PictureBox();
            //cloneVaisseau1 = new PictureBox();
            //vaisseau2.BackColor = Color.Black;
            //cloneVaisseau1.BackColor = Color.Black;
            //this.Controls.Add(vaisseau2);
            //this.Controls.Add(cloneVaisseau1);
            //vaisseau2.Location = new Point(this.Width - vaisseau2.Width, this.Height - vaisseau2.Height);
            //cloneVaisseau1.Location = new Point(0, 0);


            ArmeJ2 = new PictureBox();
            ArmeJ2.Width = 50; ArmeJ2.Height = 50;
            ArmeJ1 = new PictureBox();
            ArmeJ1.Width = 50; ArmeJ1.Height = 50;
            //ArmeJ2.BackColor = Color.Red;
            //ArmeJ1.BackColor = Color.Black;

            ArmeJ1.BackgroundImage = Joueur_2.Properties.Resources.b1;
            ArmeJ2.BackgroundImage = Joueur_2.Properties.Resources.b2;
            ArmeJ1.BackColor = Color.Transparent; ArmeJ2.BackColor = Color.Transparent;
            this.Controls.Add(ArmeJ2);
            this.Controls.Add(ArmeJ1);
            ArmeJ1.Visible = false;
            ArmeJ2.Visible = false;
            this.ArmeJ2.Location = new Point(vaisseau2.Location.X, vaisseau2.Location.Y);
            this.ArmeJ1.Location = new Point(cloneVaisseau1.Location.X, cloneVaisseau1.Location.Y);


            ArmeJoueur2.Interval = x.Arme.Vitesse;
        }
    }
}
