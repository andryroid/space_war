using System;
using System.Collections.Generic;
using System.Text;
using WCFDataContract;
using System.ServiceModel;

namespace WCFInterface
{
    [ServiceContract]
    public interface Methodes
    {
        [OperationContract]
        Arme1 CreerArme1();

        [OperationContract]
        Vaisseau CreerVaisseau(string nom);


        [OperationContract]
        void SetPosition(int vaisseau, int position);

        [OperationContract]
        int GetPosition(int vaisseau);

        [OperationContract]
        void SetTir1(int vaisseau,int coord);
        [OperationContract]
        void SetTir2(int vaisseau, int coord);

        [OperationContract]
        int GetTir(int vaisseau);

        [OperationContract]
        bool isTrue1(int arg);

        [OperationContract]
        bool isTrue2();

        [OperationContract]
        bool Touché(int x,int y,int a,int b);

        [OperationContract]
        void setGagnant(int gagnant);

        [OperationContract]
        int getGagnant();

        [OperationContract]
        void init();

    }
}
