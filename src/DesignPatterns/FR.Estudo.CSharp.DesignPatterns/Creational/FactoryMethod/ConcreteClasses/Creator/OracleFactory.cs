namespace FR.Estudo.CSharp.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// Concrete Factory
    /// </summary>
    internal class OracleFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectionString)
        {
            return new OracleDbConnector(connectionString);
        }
    }
}