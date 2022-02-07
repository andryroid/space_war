namespace Joueur_1
{
    partial class FormJoueur1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ArmeJoueur1 = new System.Windows.Forms.Timer(this.components);
            this.cloneArmeJ2 = new System.Windows.Forms.Timer(this.components);
            this.cloneVaisseau2 = new System.Windows.Forms.PictureBox();
            this.vaisseau1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cloneVaisseau2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaisseau1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ArmeJoueur1
            // 
            this.ArmeJoueur1.Interval = 50;
            this.ArmeJoueur1.Tick += new System.EventHandler(this.ArmeJoueur1_Tick);
            // 
            // cloneArmeJ2
            // 
            this.cloneArmeJ2.Interval = 50;
            this.cloneArmeJ2.Tick += new System.EventHandler(this.cloneArmeJ2_Tick);
            // 
            // cloneVaisseau2
            // 
            this.cloneVaisseau2.BackColor = System.Drawing.Color.Transparent;
            this.cloneVaisseau2.BackgroundImage = global::Joueur_1.Properties.Resources.V1;
            this.cloneVaisseau2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cloneVaisseau2.Location = new System.Drawing.Point(382, 410);
            this.cloneVaisseau2.Name = "cloneVaisseau2";
            this.cloneVaisseau2.Size = new System.Drawing.Size(100, 50);
            this.cloneVaisseau2.TabIndex = 1;
            this.cloneVaisseau2.TabStop = false;
            // 
            // vaisseau1
            // 
            this.vaisseau1.BackColor = System.Drawing.Color.Transparent;
            this.vaisseau1.BackgroundImage = global::Joueur_1.Properties.Resources.V3;
            this.vaisseau1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vaisseau1.Location = new System.Drawing.Point(0, 0);
            this.vaisseau1.Name = "vaisseau1";
            this.vaisseau1.Size = new System.Drawing.Size(100, 50);
            this.vaisseau1.TabIndex = 0;
            this.vaisseau1.TabStop = false;
            // 
            // FormJoueur1
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Joueur_1.Properties.Resources._19429947_10155391082618426_2255702020109935948_n;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.cloneVaisseau2);
            this.Controls.Add(this.vaisseau1);
            this.Name = "FormJoueur1";
            this.Text = "JOUEUR 1";
            this.Load += new System.EventHandler(this.FormJoueur1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormJoueur1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormJoueur1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormJoueur1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.cloneVaisseau2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaisseau1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer ArmeJoueur1;
        private System.Windows.Forms.Timer cloneArmeJ2;
        private System.Windows.Forms.PictureBox vaisseau1;
        private System.Windows.Forms.PictureBox cloneVaisseau2;
    }
}