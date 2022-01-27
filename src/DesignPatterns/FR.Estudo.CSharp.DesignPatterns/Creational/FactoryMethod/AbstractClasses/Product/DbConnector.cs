using System;
using System.Collections.Generic;
using System.Text;

namespace FR.Estudo.CSharp.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// Abstrac Product
    /// </summary>
    public abstract class DbConnector
    {
        protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected string ConnectionString { get; set; }

        public abstract Connection Connect();
    }
}
