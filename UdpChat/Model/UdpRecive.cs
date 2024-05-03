using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UdpChat.Model
{
    public class UdpRecive
    {
        private UdpClient _udpClient;

        public UdpRecive(UdpClient udpClient)
        {
            ArgumentNullException.ThrowIfNull(udpClient);
            _udpClient = udpClient;
        }

        public void StartRecive(string youName)
        {

        }
    }
}
