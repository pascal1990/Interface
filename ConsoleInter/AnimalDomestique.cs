using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInter
{
    public class AnimalDomestique : IDomestique
    {
        public string Nom { get; set; }

        public string Adresse { get; set; } = "100 Center Douala";

        public string NomProprietaire { get ; set ; }

        public void LieuHabitation()
        {
            Console.WriteLine($"{Nom} peux habiter avec l'homme");
        }
    }
}
