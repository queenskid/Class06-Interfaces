using LAB06Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB06Interfaces
{
    class Attackers : IDamage
    {
        public int Damage { get; set; }

        public void CausePain()
        {
            Random random = new Random();
            int pain = random.Next(0, 11);
            Damage = Damage - pain;
            Console.Write("");
            Console.WriteLine("");
        }

    }
}