using System;
using System.Runtime.CompilerServices;

namespace BilletLibrary
{
    /// <summary>
    /// En klasse for køretøjer som er biler
    /// </summary>
    public class Bil : Køretøjer
    {
        public string NummerPlade { get; set; }

        public DateTime Dato { get; set; }

        /// <summary>
        /// Sætter prisen køretøjet skal betale for at passere broen
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// Returnerer hvilken slags køretøj der er tale om
        /// </summary>
        /// <returns></returns>
        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
