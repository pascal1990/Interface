using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInter
{
    public class AnimalSauvage : IAnimal
    {
        public string Nom { get; set; }

        public void LieuHabitation()
        {
            Console.WriteLine($"{Nom} Habite Dans la jungle");
        }

    }
}
