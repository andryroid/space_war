using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace WCFDataContract
{
    [DataContract]
    public class Bombardeur : Vaisseau
    {

        public Bombardeur()
        {
            this.vitesse = 5;
        }
        
        }
    }

