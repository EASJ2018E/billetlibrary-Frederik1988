using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// En abstract klasse som forskellige slags køretøjer nedarver fra
    /// </summary>
    public abstract class Køretøjer
    {
        /// <summary>
        /// Sætter prisen køretøjet skal betale for at passere broen
        /// </summary>
        /// <returns></returns>
        public abstract decimal Pris();

        /// <summary>
        /// Returnerer hvilken slags køretøj der er tale om
        /// </summary>
        /// <returns></returns>
        public abstract string Køretøj();
    }
}
