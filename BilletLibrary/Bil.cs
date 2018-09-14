using System;
using System.Runtime.CompilerServices;

namespace BilletLibrary
{
    /// <summary>
    /// En klasse for køretøjer som er biler. Arver properties fra Køretøjer
    /// </summary>
    public class Bil : Køretøjer , IBroBizz
    {

        #region Constructors
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public Bil(string nummerPlade, DateTime dato) : base(nummerPlade, dato)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public Bil()
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

        /// <summary>
        /// Beregner BroBizz rabat for biler
        /// </summary>
        /// <returns></returns>
        public decimal BroBizz()
        {
            return Pris() * (0.95m);
        }
        #endregion


    }
}
