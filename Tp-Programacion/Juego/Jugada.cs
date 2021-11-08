using System;
using System.Collections.Generic;
using System.Text;

namespace Juego
{
    public class Jugada
    {
        IA ia = new IA();
        Jugador jugador = new Jugador();
        Carta cartaIA;
        Carta cartaPlayer;

        public enum resultPlayer {gano, perdio, empato };

        public resultPlayer puntoPlayer()
        {
            try { 
                if (cartaIA.Numero>cartaPlayer.Numero)
                {
                    return resultPlayer.perdio;
                }
                else if(cartaPlayer.Numero>cartaIA.Numero)
                {
                    return resultPlayer.gano;
                }
                else if (cartaIA.Numero==cartaPlayer.Numero)
                {
                return resultPlayer.empato;
                }
            }
            catch (NullReferenceException) {

            }
            return resultPlayer.empato;

        }
        public void jugadaIA(Carta cartaIA)
        {
            if (cartaIA != null) 
                this.cartaIA = cartaIA;
            
        }
        public void jugadaPlayer(Carta cartaPlayer)
        {
            if (cartaIA != null)
                this.cartaPlayer = cartaPlayer;
        }
    }
}
