using System;

namespace ProjetBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Client1", "Client1", 25);
            Compte compte = new Compte(12, 155.0d);

            client.AjouterCompte(compte);

            compte = new Compte(15, 188.00d);

            client.AjouterCompte(compte);

            compte = new CompteRemunere();

            client.AjouterCompte(compte);

            Console.WriteLine(client);

            client.Remunerer();

           
            Console.WriteLine(client);
        }
    }
}
