using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// En klasse for køretøjer som er motorcykler. Arver properties fra Køretøjer
    /// </summary>
    public class MC : Køretøjer , IBroBizz
    {
        #region Constructors
        
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public MC(string nummerPlade, DateTime dato) : base(nummerPlade, dato)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
        }

        
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public MC()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
        }
        #endregion

        #region Methods
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

        /// <summary>
        /// Beregner BroBizz rabat for motorcykler
        /// </summary>
        /// <returns></returns>
        public decimal BroBizz()
        {
            
            return Pris() * (0.95m);
        }
        #endregion

    }
}
