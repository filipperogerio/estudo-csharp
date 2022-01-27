using System;
using System.Collections.Generic;
using System.Text;

namespace FR.Estudo.CSharp.DesignPatterns.Creational.FactoryMethod
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        public bool Opened { get; set; }

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine("Executando comando: " + command);
        }

        public void Open()
        {
            Opened = true;
            Console.WriteLine("Conexão aberta");
        }

        public void Close()
        {
            if (!Opened) return;

            Console.WriteLine("Conexão fechada");
        }

    }
}
