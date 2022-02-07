using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;


namespace WCFDataContract
{
    [DataContract]
    public  class Vaisseau
    {
       
        protected int vitesse;
        [DataMember]
        public int Vitesse
        {
            get
            {
                return this.vitesse;
            }
            protected set
            {
                this.vitesse = 5;
            }
        }

            [DataMember]
        public Arme Arme { get; set; }
        public Vaisseau() { }



    }

    [DataContract]
    public abstract class Arme
    {
        [DataMember]
        public int Vitesse { get; set; }
        public abstract string GetInfo();
    }


    [DataContract]
    public class Arme1 : Arme
    {
        public override string GetInfo()
        {
            return "Arme 1 avec vitesse de " + this.Vitesse;
        }
    }
   

    }