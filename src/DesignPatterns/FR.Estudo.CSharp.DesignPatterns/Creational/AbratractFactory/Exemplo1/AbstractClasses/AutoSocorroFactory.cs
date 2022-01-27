namespace FR.Estudo.CSharp.DesignPatterns.Creational.AbratractFactory.Exemplo1
{
    //Abstract Factory

    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();
        public abstract Veiculo CriarVeiculo(string modelo , Porte porte);
    }
}
