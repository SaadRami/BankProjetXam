using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetBank
{
    class Client
    {
        // State
        private String Nom { get; set; }
        private String Prenom { get; set; }

        private int Numero { get; set; }

        private Compte[] Comptes = new Compte[5];
        
        // Constructors
        public Client(String nom, String prenom, int numero)
        {
            Nom = nom;
            Prenom = prenom;
            Numero = numero;
        }


        // Behavior
        public void AjouterCompte(Compte UnCompte)
        {
            int Index = 0;
            while(Index < Comptes.Length)
            {
                Compte compte = Comptes[Index];
                if (compte == null)
                {
                    Comptes[Index] = UnCompte;
                    return;
                }
                Index++;
            }

            Console.WriteLine("Cannot Add Account");
        }

        public Compte GetCompte(int numeroCompte)
        {
         
            foreach(Compte compte in Comptes)
            {
                if(compte == null)
                {
                    Console.WriteLine("Account not found");
                    break;
                }

                if(compte.Numero == numeroCompte)
                {
                    return compte;
                }
            }

            return null;
        }



        public void Remunerer()
        {
            foreach(Compte compte in this.Comptes)
            {
                if(nameof(compte) == nameof(CompteRemunere))
                {
                    //var toto = nameof(CompteRemunere);
                    ((CompteRemunere)compte).VerserInterets();
                }
            }
        }

        public override string ToString()
        {
            StringBuilder Output = new StringBuilder("Nom = ");
            Output.Append(Nom)
                .Append("\nPrenom = ")
                .Append(Prenom)
                .Append("\nNumero = ")
                .Append(Numero)
                .Append("\nComptes : \n");

            foreach(Compte compte in this.Comptes)
            {
                if (compte != null)
                {
                    Output.Append(compte)
                        .Append("\n======\n");
                }
            }

            return Output.ToString();
        }

    }
}
