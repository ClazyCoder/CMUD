using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Numerics;

namespace CMUD
{
    class Game
    {
        bool _isRunning;
        TcpListener _server;
        List<Client> _clients;
        Game()
        {
            _isRunning = false;
            _clients = new List<Client>();
        }
        void Calc()
        {

        }
        public void Start()
        {
            _isRunning = true;
            Thread ServerThread = new Thread(new ThreadStart(ServerThreadRoutine));
        }
        public void ServerThreadRoutine()
        {
            _server = new TcpListener(new IPEndPoint(IPAddress.Any,5252));
            _server.Start();
            while (_isRunning)
            {
                Client client = new Client(_server.AcceptTcpClient());
                lock (_clients)
                {
                    _clients.Add(client);
                }
            }
        }
    }
    class Client
    {
        TcpClient client;
        Player player;
        public Client(TcpClient client)
        {

        }
    }
}
