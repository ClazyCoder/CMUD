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
            // TODO : 게임 연산 부분
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
                    byte[] buffer = new byte[1024];
                    int size = ns.Read(buffer, 0, 1024);
                    string message = Encoding.ASCII.GetString(buffer, 0, size);
                    MessageProcessRoutine(message);
                }
            }
            catch(Exception)
            {
                
            }
        }
        public void MessageProcessRoutine(string message)
        {
            string[] parsedMessage = message.Split('/');
            if (parsedMessage[0] == "Login")
            {
                // TODO : 로그인
            }
            else if(parsedMessage[0] == "SignUp")
            {
                // TODO : 회원가입
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
