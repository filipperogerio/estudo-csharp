using System;
using System.Collections.Generic;

namespace FR.Estudo.CSharp.DesignPatterns.Creational.Singleton
{
    internal sealed class LoadBalancer
    {
        private static readonly LoadBalancer Instance = new LoadBalancer();
        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server{Id = Guid.NewGuid() , Name = "Server 1" , IP = "192.168.0.1"},
                new Server{Id = Guid.NewGuid() , Name = "Server 2" , IP = "192.168.0.2"},
                new Server{Id = Guid.NewGuid() , Name = "Server 3" , IP = "192.168.0.3"},
                new Server{Id = Guid.NewGuid() , Name = "Server 4" , IP = "192.168.0.4"}
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                var index = _random.Next(_servers.Count);
                return _servers[index];
            }
        }
    }
}
