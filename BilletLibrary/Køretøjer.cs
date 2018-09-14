using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// En abstract klasse som forskellige slags køretøjer nedarver fra. 
    /// </summary>
    public abstract class Køretøjer
    {
        #region Properties
        /// <summary>
        /// Køretøjets nummerplade
        /// </summary>
        public string NummerPlade { get; set; }

        /// <summary>
        /// Hvornår køretøjet krydsede broen
        /// </summary>
        public DateTime Dato { get; set; }


        #endregion



        #region Constructors

        /// <summary>
        /// Constructor til køretøjer når der skal gives en nummerplade og dato
        /// </summary>
        /// <param name="nummerPlade"></param>
        /// <param name="dato"></param>
        public Køretøjer(string nummerPlade, DateTime dato)
        {
            if (nummerPlade.Length <= 7)
            {
                NummerPlade = nummerPlade;
            }
            else
            {
                throw new ArgumentException("Nummerpladen du har indtastet indeholder for mange cifre");
            }
            Dato = dato;
        }

        /// <summary>
        /// Default constructor til køretøjer
        /// </summary>
        public Køretøjer()
        {
            
        }

        #endregion



        #region Methods

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
        
        #endregion

    }
}
