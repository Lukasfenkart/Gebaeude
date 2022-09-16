using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebäude
{
    public class Schule : Gebaeude
    {
        public string Schueler;

        public int Schulkinder;
        public Schule(string Name, int Fläche, int Stockwerke, string Schueler) : base(Name, Fläche, Stockwerke)
        {
            this.Schueler = Schueler;
        }

        public Schule(string Name, int Fläche, int Stockwerke, int Schulkinder) : base(Name, Fläche, Stockwerke)
        {
            this.Schulkinder = Schulkinder;
        }


    }
}
