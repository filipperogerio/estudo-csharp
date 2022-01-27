using System;
using System.Collections.Generic;
using System.Text;

namespace FR.Estudo.CSharp.DesignPatterns.Creational.FactoryMethod
{
    public class ExecucaoFactoryMethod
    {
        public static void Execute()
        {
            ObterConexaoSqlServer();

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            ObterConexaoOracle();
        }

        private static void ObterConexaoOracle()
        {
            var oracleConn = DbFactory.Database(DataBase.Oracle)
                                      .CreateConnector("connectionString")
                                      .Connect();

            oracleConn.ExecuteCommand("select * from minhasTarefas");
            oracleConn.Close();
        }

        private static void ObterConexaoSqlServer()
        {
            var sqlConn = DbFactory.Database(DataBase.SqlServer)
                                               .CreateConnector("connectionString")
                                               .Connect();

            sqlConn.ExecuteCommand("select * from meusEstudos");
            sqlConn.Close();
        }
    }
}
