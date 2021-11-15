using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Juego;
using System.Data.SqlClient;

namespace Tp_Programacion
{
    public partial class Form1 : Form
    {
        public List<PictureBox> cards= new List<PictureBox>();
        string cardsPath= Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()) + "\\Cards\\";

        PictureBox IACards = new PictureBox();
        PictureBox playerCards = new PictureBox();

       int playerTurn=0;
        //search the index
        List <int> cardManager = new List< int>();

        Mazo mazo;

        IA ia;
        Jugador jugador;

        Cliente cliente = new Cliente();
        Jugada jugada = new Jugada();


        public Form1()
        {
            InitializeComponent();
             mazo = new Mazo();
            jugador = new Jugador();
            ia = new IA();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createCardsImage();
            suitCards();
            startGame();
        }

        private void createCardsImage()
        {
            for(int j = 0; j < 4; j++) { 

                for(int i =1; i <= 12;i++)
                {
                var newPictureBox = new PictureBox();
                newPictureBox.Width = 200;
                newPictureBox.Height = 300;
                newPictureBox.BorderStyle = BorderStyle.Fixed3D;
                string name;
                    switch (j) {
                        case 0:
                            name = i.ToString() + "B";
                          cards.Add(sizeImage(newPictureBox, name ));
                          break;
                        case 1:
                            name = i.ToString() + "E";
                            cards.Add(sizeImage(newPictureBox, name));
                            break;
                        case 2:
                            name = i.ToString() + "O";
                            cards.Add(sizeImage(newPictureBox, name));
                            break;
                        case 3:
                            name = i.ToString() + "C";
                            cards.Add(sizeImage(newPictureBox, name));
                            break;

                    }
                }

            }


        }

        public PictureBox sizeImage(PictureBox pb, string name)
        {
            Image img = Image.FromFile(cardsPath + name + ".png");
            pb.Image = img;
            pb.Name = name;
            pb.SizeMode = PictureBoxSizeMode.CenterImage;
            return pb;
        }

        private void suitCards()
        {
            for(int i=0; i < 4; i++) { 

                for(int j=1;j<=12;j++)
                {
                    switch (i)
                    {
                        case 0:
                            foreach (var card in cards)
                            {
                                if (card.Name == j.ToString() + "B")
                                {
                                    Carta carta = new Carta(Carta.Palo.Basto);
                                    carta.Numero = j;
                                    mazo.agregarCarta(carta);
                                    cardManager.Add(cards.IndexOf(card));
                                }                            
                            }
                            break;
                        case 1:
                            foreach (var card in cards)
                            {
                                if (card.Name == j.ToString() + "E")
                                {
                                    Carta carta = new Carta(Carta.Palo.Espada);
                                    carta.Numero = j;
                                    mazo.agregarCarta(carta);
                                    cardManager.Add(cards.IndexOf(card));
                                }
                            }
                            break;
                        case 2:
                            foreach (var card in cards)
                            {
                                if (card.Name == j.ToString() + "O")
                                {
                                    Carta carta = new Carta(Carta.Palo.Oro);
                                    carta.Numero = j;
                                    mazo.agregarCarta(carta);
                                    cardManager.Add(cards.IndexOf(card));
                                }
                            }
                            break;
                        case 3:
                            foreach (var card in cards)
                            {
                                if (card.Name == j.ToString() + "C")
                                {
                                    Carta carta = new Carta(Carta.Palo.Copa);
                                    carta.Numero = j;
                                    mazo.agregarCarta(carta);
                                    cardManager.Add(cards.IndexOf(card));
                                }
                            }
                            break;
                    }
                
                }
            }
        }

        void jugadaMostrar(Jugada jugada)
        {
            if (jugada.puntoPlayer() == Jugada.resultPlayer.gano)
            {
                jugador.puntaje++;
                playerPuntaje.Text = jugador.puntaje.ToString();
            }
            else if (jugada.puntoPlayer() == Jugada.resultPlayer.perdio)
            {
                ia.puntaje++;
                Player2Puntaje.Text = ia.puntaje.ToString();
            }
            else if (jugada.puntoPlayer() == Jugada.resultPlayer.empato)
            {
                playerPuntaje.Text = jugador.puntaje.ToString();
                Player2Puntaje.Text = ia.puntaje.ToString();
            }
            cliente.sendPointsPlayer1(jugador.puntaje,ia.puntaje);

        }

        private void display()
        {
            IACards.Left=(200 + 250);
            playerCards.Left = (50 + 100);
            this.Controls.Add(IACards);
            this.Controls.Add(playerCards);       
        }

        private void startGame()
        {
            //server.startConnection();
            cliente.startConnection();
            jugador.puntaje = 0;
            ia.puntaje = 0;

            List<PictureBox> shuffledCardsImg = new List<PictureBox>();
            List<Carta> shuffledCards = new List<Carta>();

            for (int i = 0; i < 48; i++)
            {
                Random rnd = new Random();
                int n = new int();
                n = rnd.Next(0, cards.Count);
                shuffledCardsImg.Add(cards[n]);
                shuffledCards.Add(mazo.Cartas[n]);
                cards.RemoveAt(n);
                mazo.Cartas.RemoveAt(n);
            }


            mazo.Cartas = shuffledCards;
            cards = shuffledCardsImg;

        }

        private void IACard(Jugada jugada)
        {
            IACards.Width = 1;
            IACards.Height = 1;
            IACards.BorderStyle = BorderStyle.Fixed3D;
            IACards.SizeMode= PictureBoxSizeMode.CenterImage;
            foreach (var card in cards)
            {
                IACards = card;
                cards.Remove(card);
                break;
            }
            foreach (var card in mazo.Cartas)
            {
                jugada.jugadaIA(card);
                ia.cartasIA.Add(card);
                mazo.Cartas.Remove(card);
                break;
            }
        }

        private void playerCard(Jugada jugada)
        {            
            playerCards.Width = 1;
            playerCards.Height = 1;
            playerCards.BorderStyle = BorderStyle.Fixed3D;
            IACards.SizeMode = PictureBoxSizeMode.CenterImage;

            foreach (var card in cards)
            {
                playerCards = card;
                cards.Remove(card);
                break;
            }

            foreach (var card in mazo.Cartas)
            {
                jugada.jugadaPlayer(card);
                jugador.cartasPlayer.Add(card);
                mazo.Cartas.Remove(card);
                break;
            }
        }

        private void deal_Click(object sender, EventArgs e)
        {
            if (playerTurn==0) {
                playerCard(jugada);
                display();
                playerTurn = 1;
                cliente.sendTurn(playerTurn);

            }
        }

        private void playPlayer2_Click(object sender, EventArgs e)
        {
            if (playerTurn==1) {
                IACard(jugada);
                display();
                jugada.checkResult = true;
                playerTurn = 0;
                cliente.sendTurn(playerTurn);
                jugadaMostrar(jugada);
            }
            
        }

    }
}
