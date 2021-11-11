using System;
using System.Net.Sockets;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Server
{
    public class Server
    {
        Socket listen= new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket conexion;
        IPEndPoint connect= new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3000);

        public void startConnection()
        {
            listen.Bind(connect);
            listen.Listen(10);
            conexion = listen.Accept();


        }

        public string returnValues()
        {
            byte[] recibir_info = new byte[100];
            string data = "";
            int array_size = 0;

            array_size = conexion.Receive(recibir_info, 0, recibir_info.Length, 0);
            Array.Resize(ref recibir_info, array_size);
            data = Encoding.Default.GetString(recibir_info);
            return data;
        }

    }
}
