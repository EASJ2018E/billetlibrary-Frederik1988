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
        public abstract decimal Pris();

        public abstract string Køretøj();
    }
}
