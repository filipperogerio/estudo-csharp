namespace FR.Estudo.CSharp.DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// Concrete Factort
    /// </summary>
    internal class SqlFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerDbConnector(connectionString);
        }
    }
}