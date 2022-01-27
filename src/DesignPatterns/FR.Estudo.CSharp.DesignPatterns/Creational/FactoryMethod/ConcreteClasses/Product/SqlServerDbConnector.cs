using System;
using System.Collections.Generic;
using System.Text;

namespace FR.Estudo.CSharp.DesignPatterns.Creational.FactoryMethod
{

    /// <summary>
    /// Concrete Product
    /// </summary>
    public class SqlServerDbConnector : DbConnector
    {
        public SqlServerDbConnector(string connectionString) : base(connectionString) { }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco SQL Server");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
