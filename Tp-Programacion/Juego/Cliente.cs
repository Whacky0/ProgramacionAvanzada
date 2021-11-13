using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Juego
{
    class Cliente
    {
        public void sendData(int points)
        {
            Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3000);
            listen.Connect(connect);

            byte[] enviarInfo = new byte[100];
            int data;

            data = points;
            enviarInfo = Encoding.Default.GetBytes(data.ToString());
            listen.Send(enviarInfo);

        }
    }
}
