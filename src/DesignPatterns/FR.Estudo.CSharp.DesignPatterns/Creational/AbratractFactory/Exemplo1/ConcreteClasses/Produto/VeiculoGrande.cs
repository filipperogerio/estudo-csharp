namespace FR.Estudo.CSharp.DesignPatterns.Creational.AbratractFactory.Exemplo1
{
    //Concrete Product
    public class VeiculoGrande : Veiculo
    {
        public VeiculoGrande(string modelo, Porte porte) : base(modelo, porte)
        {
        }
    }
}
