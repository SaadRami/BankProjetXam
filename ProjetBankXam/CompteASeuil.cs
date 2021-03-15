using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetBank
{
    class CompteASeuil: Compte
    {
        // State
        private double Seuil { get; set; }

        // Constructors
        public CompteASeuil()
        {

        }
        
        public CompteASeuil(int numero, double solde, double seuil): base(numero, solde)
        {
            Seuil = seuil;
        }

        // Behavior
        public override string ToString()
        {
            return base.ToString() + "\nSeuil = " + Seuil;
        }

        public override void Retirer(double uneValeur)
        {
            double result = Solde - uneValeur;
            if(result >= Seuil)
            {
                Solde = result;
            }
        }
    }
}
