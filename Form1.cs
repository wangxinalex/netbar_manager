using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netbar_manager {
    public partial class Server : Form {
        private ArrayList user_list;
        private TcpListener listener;
        private int listenport = 2500;
        private Thread processor;
        private Socket clientsocket;
        private Thread clientservice;
        private long buffer_size = 2048;

        public Server() {
            InitializeComponent();
            user_list = new ArrayList();
            processor = new Thread(new ThreadStart(StartListening));
            processor.Start();
        }

        private void StartListening() {
            listener = new TcpListener(listenport);
            listener.Start();
            while (true) {
                try {
                    Socket s = listener.AcceptSocket();
                    clientsocket = s;
                    clientservice = new Thread(new ThreadStart(ServiceClient));
                    clientservice.Start();
                } catch (Exception e) {
                    MessageBox.Show(this, e.Message,"Server Error");
                }
            }
        }

        private void ServiceClient() {
            Socket client = clientsocket;
            bool alive = true;
            Byte[] buffer = new Byte[buffer_size];
            while(alive){
                Array.Clear(buffer, 0, buffer.Length);
                client.Receive(buffer);
                string clientcommand = System.Text.Encoding.Default.GetString(buffer);
                string[] tokens = clientcommand.Split('|');
                handle_command(tokens);
            }
        }

        private void handle_command(string[] tokens) {
            if(tokens[0] == "CONNECT"){
                

            }
        }

    }
}
