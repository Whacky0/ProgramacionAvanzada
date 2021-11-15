using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;
namespace Juego
{
    public class Cliente
    {
        Socket listen=new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public void startConnection()
        {
            IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7000);
            listen.Connect(connect);
        }
        public void sendTurn(int points)
        {
            byte[] enviarInfo = new byte[100];
            int data;
            data = points;
            enviarInfo = Encoding.Default.GetBytes(data.ToString());
            listen.Send(enviarInfo);
        }
        public void sendPointsPlayer1(int pointsPlayer1 , int pointsPlayer2)
        {
            byte[] enviarInfo = new byte[100];
            int data;
            data = pointsPlayer1;
            enviarInfo = Encoding.Default.GetBytes(data.ToString());
            listen.Send(enviarInfo);
            sendPointsPlayer2(pointsPlayer2);
        }

        async void sendPointsPlayer2(int points)
        {
            await Task.Delay(200);
            byte[] enviarInfo = new byte[100];
            int data;
            data = points;
            enviarInfo = Encoding.Default.GetBytes(data.ToString());
            listen.Send(enviarInfo);
        }

    }
}
