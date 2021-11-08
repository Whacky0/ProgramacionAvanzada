using System;
using System.Collections.Generic;
using System.Text;

namespace Juego
{
   public class Mazo
    {
        public List <Carta> Cartas = new List<Carta>();
        

        public void agregarCarta(Carta carta)
        {
            Cartas.Add(carta);

        }

    }
}
