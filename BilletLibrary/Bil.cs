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
        /// Hvor meget en bil skal betale for at køre over broen
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
