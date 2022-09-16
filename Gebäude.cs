using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gebäude
{
    public class Gebaeude
    {
        public string Name { get; set; } //Attribut der Klasse Gebäude

        public int Fläche { get; set; }

        public int Stockwerke { get; set; }

 
        public Gebaeude(string Name, int Fläche, int Stockwerke)
        {
            this.Name = Name;
            this.Fläche = Fläche;
            this.Stockwerke = Stockwerke;
        }

        
    }
}
