using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebäude
{
    public class Haus : Gebaeude
    {
        public int Bewohner { get; set; }

        public Haus(string Name, int Fläche, int Stockwerke, int Bewohner) : base(Name, Fläche, Stockwerke)
        {
            this.Bewohner = Bewohner;
        }
    }
}
