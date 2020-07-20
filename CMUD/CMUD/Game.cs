using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.InteropServices;

namespace CMUD
{
    class Game
    {
        bool _isRunning;
        TcpListener _server;
        List<Client> _clients;
        ObjectManager obj_mgr;
        MapManager map_mgr;
        Game()
        {
            _isRunning = false;
            _clients = new List<Client>();
            obj_mgr = new ObjectManager();
            map_mgr = new MapManager();
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
                    Thread t = new Thread(new ParameterizedThreadStart(ClientProcessRoutine));
                    t.Start(client);
                }
            }
        }
        public void ClientProcessRoutine(object obj)
        {
            try
            {
                Client client = obj as Client;
                NetworkStream ns = client.getStream();
                while (_isRunning)
                {

                }
            }
            catch(Exception)
            {
                
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
        public NetworkStream getStream()
        {
            return client.GetStream();
        }
    }
}
