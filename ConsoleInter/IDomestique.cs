using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInter
{
    interface IDomestique : IAnimal
    {
        string NomProprietaire { get; set; }
        string Adresse { get; set; }
    }
}
