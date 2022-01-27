namespace FR.Estudo.CSharp.DesignPatterns.Creational.AbratractFactory.Exemplo1
{
    //Abstract Product
    public abstract class Veiculo
    {
        public Veiculo(string modelo , Porte porte)
        {
            Modelo = modelo;
            Porte = porte;
        }

        public string Modelo { get; }
        public Porte Porte { get; }
    }
}
