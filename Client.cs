using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Netbar_manager {
    class Client {
        private string s_name;

        public string Name {
            get { return s_name; }
            set { s_name = value; }
        }

        private Socket socket;

        public Socket Socket {
            get { return socket; }
            set { socket = value; }
        }
    }
}
