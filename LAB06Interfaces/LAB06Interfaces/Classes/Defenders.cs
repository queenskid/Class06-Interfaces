using LAB06Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB06Interfaces
{
    class Defenders : IHeal
    {
        public int Restore { get; set; }

        public void MoreHealth()
        {
            Random random = new Random();
            int health = random.Next(0, 6);
            Restore = Restore - health;
            Console.Write("");
            Console.WriteLine("");
        }

    }
}
