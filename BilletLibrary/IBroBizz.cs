using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// Interface til at beregne rabat med BroBizz
    /// </summary>
    public interface IBroBizz
    {
        /// <summary>
        /// Hvis der skal gives BroBizz rabat
        /// </summary>
        /// <returns></returns>
        decimal BroBizz();
    }
}
