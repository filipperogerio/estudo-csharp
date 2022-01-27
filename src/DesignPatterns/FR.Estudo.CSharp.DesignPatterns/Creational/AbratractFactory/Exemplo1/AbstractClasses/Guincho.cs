namespace FR.Estudo.CSharp.DesignPatterns.Creational.AbratractFactory.Exemplo1
{

    //Abstract Product

    public abstract class Guincho
    {
        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);

        public Porte Porte { get; set; }
    }
}
