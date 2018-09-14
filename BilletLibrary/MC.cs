using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// En klasse for køretøjer som er motorcykler
    /// </summary>
    public class MC : Køretøjer
    {
        public string NummerPlade { get; set; }

        public DateTime Dato { get; set; }

        /// <summary>
        /// Sætter prisen køretøjet skal betale for at passere broen
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 125;
        }
        /// <summary>
        /// Returnerer hvilken slags køretøj der er tale om
        /// </summary>
        /// <returns></returns>
        public override string Køretøj()
        {
            return "MC";
        }
    }
}
