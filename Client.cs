using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Netbar_manager {
    class Client {
        public Client(String name, Socket socket, Thread thread) {
            this.Name = name;
            this.Socket = socket;
            this.Thread = thread;
        }
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

        private Thread thread;

        public Thread Thread {
            get { return thread; }
            set { thread = value; }
        }

    }
}
