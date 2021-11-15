using System;
using System.Net.Sockets;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using System.Text;


namespace ServidorTest
{
    class Program
    {
        
       static Services Services = new Services();

        static void Main(string[] args)
        {

            Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket conexion;
            IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7000);

            listen.Bind(connect);
            listen.Listen(10);
            conexion = listen.Accept();
            Console.WriteLine("Conexion Aceptada");

            int dataType = 0;

            try
            {
                getIndex();
            }
            catch(NullReferenceException)
            {

            }

            while (conexion.Connected) { 
            byte[] recibir_info = new byte[100];
            string data = "";
            int array_size = 0;
            array_size = conexion.Receive(recibir_info, 0, recibir_info.Length, 0);
            Array.Resize(ref recibir_info, array_size);
            data = Encoding.Default.GetString(recibir_info);

                switch (dataType)
                {
                    case 0:
                        Console.WriteLine("la info es: {0} ", data);
                        Services.Turn = int.Parse(data);                        
                        dataType++;
                        guardarTurnos();
                        GuardarIndice();
                        Console.WriteLine("se llevan jugados en total: "+ Services.lastIndex + " Turnos");
                        break;
                    case 1:
                        Console.WriteLine("la info es: {0} ", data);
                        Services.Turn = int.Parse(data);
                        dataType++;
                        guardarTurnos();
                        GuardarIndice();
                        Console.WriteLine("se llevan jugados en total: " + Services.lastIndex +  " Turnos");

                        continue;
                    case 2:                        
                        Console.WriteLine("la info es: {0} ", data);                     
                        Services.Player1 = int.Parse(data);
                        dataType++;
                        guardarPoints();
                        continue;
                    case 3:
                        Console.WriteLine("la info es: {0} ", data);
                        Services.Player2 = int.Parse(data);
                        dataType=0;
                        guardarPoints();
                        break;
                }
            }
        }

       static void guardarTurnos()
        {
            Services.GuardarTurn();
        }

        static void guardarPoints()
        {
            Services.GuardarHistory();
        }

        static void getIndex()
        {
            Services.getIndex();
        }

        static void GuardarIndice()
        {
            Services.GuardarIndex();
        }

    }
}

