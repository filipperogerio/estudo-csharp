using System;

namespace FR.Estudo.CSharp.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class OracleDbConnector : DbConnector
    {
        public OracleDbConnector(string connectionString) : base(connectionString) { }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco Oracle...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
