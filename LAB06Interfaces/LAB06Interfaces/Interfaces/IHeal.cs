using System;
using System.Collections.Generic;
using System.Text;

namespace LAB06Interfaces.Interfaces
{
    interface IHeal
    {
        int Restore { get; set; }

        void MoreHealth();
    }
}