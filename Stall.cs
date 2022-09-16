using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebäude
{
    public class Stall : Gebaeude 
    {

        public int Pferde { set; get; }

        public Stall(string Name, int Fläche, int Stockwerke, int Pferde) : base(Name, Fläche, Stockwerke)
        {
            this.Pferde = Pferde;
        }

    }

}
