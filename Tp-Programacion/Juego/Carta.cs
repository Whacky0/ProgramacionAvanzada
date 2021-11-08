using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Carta
    {
        private Palo palo;

        public Carta(Palo palo)
        {
            this.palo = palo;
        }

        public enum Palo { Basto, Espada, Oro, Copa }

        public int Numero
        {
            get; set;
        }
        
    }

}
