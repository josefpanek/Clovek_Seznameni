using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clovek_Seznameni
{
    /// <summary>
    /// Třída reprezentuje člověka
    /// </summary>
    internal class Clovek
    {
        /// <summary>
        /// Celé jméno
        /// </summary>
        public string jmeno;
        /// <summary>
        /// Věk
        /// </summary>
        public int vek;
        /// <summary>
        /// Kamarád
        /// </summary>
        public Clovek kamarad;

        /// <summary>
        /// Vypíše text, ve kterém se človek představí
        /// </summary>
        public void PredstavSe()
        {
            Console.WriteLine("Ahoj, já jsem {0}, je mi {1} let a můj kamarád je {2}", jmeno, vek, kamarad.jmeno);
        }
    }
}