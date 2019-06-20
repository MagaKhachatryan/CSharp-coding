using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MathServer
{
    public class TCP : INetworkService
    {
        int port = 8001;
        IPAddress localAddr = IPAddress.Parse("127.0.0.1");

        public void SendResult()
        {
            IPEndPoint endpoint = new IPEndPoint(localAddr, port);
            TcpListener listener = new TcpListener(endpoint);
            //listener.Start();
            Console.WriteLine(@"Started listening requests at: {0}:{1}  ", endpoint.Address, endpoint.Port);
            while (true)
            {
                listener.Start();
                string messeage = null;

                TcpClient sender = listener.AcceptTcpClient();
                byte[] buffer = new byte[sender.ReceiveBufferSize];
                Console.WriteLine("Request is accepted");
                sender.GetStream().Read(buffer, 0, buffer.Length);
                messeage = cleanMessage(buffer);
                MathService ms = new MathService();
                double res = ms.PerformOperation(messeage);
                byte[] bytes = ASCIIEncoding.ASCII.GetBytes("Your answer is " + res);
                sender.GetStream().Write(bytes, 0, bytes.Length);
                sender.Close();
                listener.Stop();

            }

        }
        private static string cleanMessage(byte[] bytes)
        {
            string message = ASCIIEncoding.ASCII.GetString(bytes);

            string messageToPrint = null;
            foreach (var nullChar in message)
            {
                if (nullChar != '\0')
                {
                    messageToPrint += nullChar;
                }
            }
            return messageToPrint;
        }
    }
}
