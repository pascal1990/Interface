using System;
using System.Collections.Generic;

namespace ConsoleInter
{
    class Program
    {
        static void Main(string[] args)
        {
             List<IAnimal> listAnimaux = AddSampleData();

            foreach(IAnimal elt in listAnimaux)
            {
                elt.LieuHabitation();
                if(elt is IDomestique domestique)
                {
                    Console.WriteLine($"j'appartiens a {domestique.NomProprietaire} et je suis a cette Adresse {domestique.Adresse}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static List<IAnimal> AddSampleData()
        {
            List<IAnimal> output = new List<IAnimal>();

            output.Add(new AnimalSauvage() { Nom = "Lion" });
            output.Add(new AnimalSauvage() { Nom = "Crocodile" });
            output.Add(new AnimalDomestique() { Nom = "Chat",Adresse = "100 NB Canada", NomProprietaire = "Pascal Fossouo" });
            return output;
        }

       
    }
}
