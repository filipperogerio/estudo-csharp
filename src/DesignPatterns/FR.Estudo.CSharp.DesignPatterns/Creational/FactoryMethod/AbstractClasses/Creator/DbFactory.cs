using System;
using System.Collections.Generic;
using System.Text;

namespace FR.Estudo.CSharp.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// Abstract Creator
    /// </summary>
    public abstract class DbFactory
    {
        /// <summary>
        /// Factor method
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(DataBase dataBase) => dataBase switch
        {
            DataBase.SqlServer => new SqlFactory(),
            DataBase.Oracle => new OracleFactory(),
            _ => throw new ArgumentException()
        };
    }
}
