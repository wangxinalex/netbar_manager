using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netbar_manager {
    public partial class Server : Form {
        private ArrayList client_list;
        private TcpListener listener;
        private int listenport = 2500;
        private Thread processor;
        private Socket clientsocket;
        private Thread clientservice;
        private long buffer_size = 2048;
        private Char[] whitespaces = { '\0','\r','\n'};
        public Server() {
            InitializeComponent();
            client_list = new ArrayList();
            processor = new Thread(new ThreadStart(StartListening));
            processor.Start();
        }

        private void StartListening() {
            IPAddress ipAddress = IPAddress.Any;
            listener = new TcpListener(ipAddress,listenport);
            listener.Start();
            while (true) {
                try {
                    Socket s = listener.AcceptSocket();
                    clientsocket = s;
                    clientservice = new Thread(new ThreadStart(ServiceClient));
                    clientservice.Start();
                } catch (Exception e) {
                   Console.WriteLine("Server Error");
                }
            }
        }

        private void ServiceClient() {
            Console.WriteLine("Service Client");
            Socket client = clientsocket;
            bool alive = true;
            Byte[] buffer = new Byte[buffer_size];
            while(alive){
                Array.Clear(buffer, 0, buffer.Length);
                client.Receive(buffer);
                string client_command = System.Text.Encoding.Default.GetString(buffer).Trim(whitespaces);
                Console.WriteLine(client_command);
                string[] tokens = client_command.Split('|');
                handle_command(tokens, client);
            }
        }

        private void handle_command(string[] tokens, Socket client_socket) {
            if(tokens[0] == "CONNECT"){
                string user_name = tokens[1];
                Client c = new Client(user_name, client_socket, clientservice);
                Console.WriteLine("User:"+user_name+
                    " registered");
                string message = "CONNECT_ACK|\r\n";
                client_list.Add(c);
                send_to_client(c, message);

                

            }
        }

        private void send_to_client(Client c, string message) {
            try {
                byte[] buffer = System.Text.Encoding.Default.GetBytes(message);
                c.Socket.Send(buffer, buffer.Length, 0);
            } catch (Exception e) {
                c.Socket.Close();
                client_list.Remove(c);

            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                for (int i = 0; i < client_list.Count; i++) {
                    Client c = (Client)client_list[i];
                    send_to_client(c, "QUIT");
                    c.Socket.Close();
                    c.Thread.Abort();
                }
                listener.Stop();
                if (processor != null) {
                    processor.Abort();

                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            base.OnClosing(e);
        }
    }
}
