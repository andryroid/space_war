namespace Joueur_2
{
    partial class FormJoueur2
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
            this.ArmeJoueur2 = new System.Windows.Forms.Timer(this.components);
            this.cloneArmeJ1 = new System.Windows.Forms.Timer(this.components);
            this.vaisseau2 = new System.Windows.Forms.PictureBox();
            this.cloneVaisseau1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vaisseau2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloneVaisseau1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ArmeJoueur2
            // 
            this.ArmeJoueur2.Interval = 50;
            this.ArmeJoueur2.Tick += new System.EventHandler(this.ArmeJoueur2_Tick);
            // 
            // cloneArmeJ1
            // 
            this.cloneArmeJ1.Interval = 50;
            this.cloneArmeJ1.Tick += new System.EventHandler(this.cloneArmeJ1_Tick);
            // 
            // vaisseau2
            // 
            this.vaisseau2.BackColor = System.Drawing.Color.Transparent;
            this.vaisseau2.BackgroundImage = global::Joueur_2.Properties.Resources.V1;
            this.vaisseau2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vaisseau2.Location = new System.Drawing.Point(382, 408);
            this.vaisseau2.Name = "vaisseau2";
            this.vaisseau2.Size = new System.Drawing.Size(100, 50);
            this.vaisseau2.TabIndex = 1;
            this.vaisseau2.TabStop = false;
            // 
            // cloneVaisseau1
            // 
            this.cloneVaisseau1.BackColor = System.Drawing.Color.Transparent;
            this.cloneVaisseau1.BackgroundImage = global::Joueur_2.Properties.Resources.V3;
            this.cloneVaisseau1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cloneVaisseau1.Location = new System.Drawing.Point(2, 1);
            this.cloneVaisseau1.Name = "cloneVaisseau1";
            this.cloneVaisseau1.Size = new System.Drawing.Size(100, 50);
            this.cloneVaisseau1.TabIndex = 0;
            this.cloneVaisseau1.TabStop = false;
            // 
            // FormJoueur2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Joueur_2.Properties.Resources._19429947_10155391082618426_2255702020109935948_n;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.vaisseau2);
            this.Controls.Add(this.cloneVaisseau1);
            this.Name = "FormJoueur2";
            this.Text = "JOUEUR 2";
            this.Load += new System.EventHandler(this.FormJoueur2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormJoueur2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormJoueur2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.vaisseau2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloneVaisseau1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer ArmeJoueur2;
        private System.Windows.Forms.Timer cloneArmeJ1;
        private System.Windows.Forms.PictureBox cloneVaisseau1;
        private System.Windows.Forms.PictureBox vaisseau2;
    }
}