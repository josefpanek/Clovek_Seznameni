using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clovek_Seznameni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vytvoření lidí
            Clovek karel = new Clovek();
            karel.jmeno = "Karel Novák";
            karel.vek = 33;
            Clovek josef = new Clovek();
            josef.jmeno = "Josef Nový";
            josef.vek = 27;
            // Spřátelení
            karel.kamarad = josef;
            josef.kamarad = karel;
            // Představení
            karel.PredstavSe();
            josef.PredstavSe();
            Console.ReadKey();
        }
    }
}
