using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// En klasse for køretøjer som er motorcykler
    /// </summary>
    public class MC
    {
        public string NummerPlade { get; set; }

        public DateTime Dato { get; set; }

        public decimal Pris()
        {
            return 125;
        }

        public string Køretøj()
        {
            return "MC";
        }
    }
}
