using System;
using System.Collections.Generic;
using System.Text;
using WCFDataContract;
using WCFInterface;

namespace WCFServices
{
    public class MesServices : Methodes
    {
        static int gagnant=0;
        static int positionVaisseau1;
        static int positionVaisseau2;

        static int coordVaisseau1;
        static int coordVaisseau2;

        static bool token1;
        static bool token2;

       
       public Arme1 CreerArme1()
        {
            Arme1 a = new Arme1();
            a.Vitesse = 50;
            return a;
        }
        public Vaisseau CreerVaisseau(String nom)
        {
            if (nom=="sonic")
            {
                Vaisseau v = new Vaisseau();
                return v;
            }
            else if (nom == "bombardeur")
            {
                Vaisseau v= new Vaisseau();
                return v;
            }

            return null;
           
        }

        public int GetPosition(int vaisseau)
        {
            if (vaisseau == 1) { return positionVaisseau1; }
            return positionVaisseau2;
        }

        public int GetTir(int vaisseau)
        {
            if (vaisseau == 1) { token1 = false; return coordVaisseau1; }
            if (vaisseau == 2) { token2 = false; return coordVaisseau2; }
            return -1;
        }

        public void SetPosition(int vaisseau, int position)
        {
            if (vaisseau == 1) { MesServices.positionVaisseau1 = position; }
            else { MesServices.positionVaisseau2 = position; }
        }

        public void SetTir1(int vaisseau, int coord)
        {
            if (vaisseau == 1) { coordVaisseau1 = coord; token1 = true; }
        }
        public void SetTir2(int vaisseau, int coord)
        {
            if (vaisseau == 2) { coordVaisseau2 = coord; token2 = true; }
        }
        public bool isTrue1(int arg)
        {
            if (arg == 1)
            {
                if (token1 == true) { return true; }
                else { return false; }

            }

            return false;
        }
        public bool isTrue2()
        {
            return token2;
        }

        public bool Touché(int x, int y, int a,int b)
        {
            if ((x >= a && x <= b) || (y >= a && y <= b)) return true;
            return false;
        }
        public void setGagnant(int gagnant)
        {
            if (MesServices.gagnant == 0) MesServices.gagnant = gagnant;
        }
        public int getGagnant()
        {
            return gagnant;
        }
        public void init()
        {
            MesServices.gagnant = 0;
            token1 = false;
            token2 = false;
        }
    }
}
