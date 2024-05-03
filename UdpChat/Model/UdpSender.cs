using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UdpChat.Model
{
    public class UdpSender
    {
        private UdpClient _udpClient;

        public UdpSender(UdpClient udpClient)
        {
            ArgumentNullException.ThrowIfNull(udpClient);
            _udpClient = udpClient;
        }

        public void Send(string message) 
        {
            byte[] array = Encoding.UTF8.GetBytes(message);
            _udpClient.Send(array, array.Length);
            

        }
    }
}
