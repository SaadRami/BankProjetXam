using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetBank
{
    class CompteRemunere: Compte
    {
        // State
        private double Taux { get; set; }

        // Constructors
        public CompteRemunere(int numero, double solde, double taux): base(numero, solde)
        {
            Taux = taux;
        }

        public CompteRemunere()
        {

        }

        // Behavior
        public override string ToString()
        {
            return base.ToString() + "\nTaux = " + Taux;
        }

        public double CalculerInterets()
        {
            return Taux * Solde;
        }

        public void VerserInterets()
        {
            Solde += CalculerInterets();
        }
    }
}
