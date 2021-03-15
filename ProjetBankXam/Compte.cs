using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetBank
{
    class Compte
    {
        // State
        public int Numero { get; private set; }
        public double Solde { get;  set; }

        // Constructors
        public Compte()
        {

        }

        public Compte(int numero, double solde)
        {
            Numero = numero;
            Solde = solde;
        }


        // Behavior
        public override string ToString()
        {
            return String.Format("Compte N°{0}\nSolde = {1}", Numero, Solde);
        }

        public void Ajouter(double unMontant)
        {
            Solde += unMontant;
        }

        public virtual void Retirer(double unMontant)
        {
            double Result = Solde - unMontant;
            if(Result >= 0)
            {
                Solde = Result;
            }
        }
    }
}
