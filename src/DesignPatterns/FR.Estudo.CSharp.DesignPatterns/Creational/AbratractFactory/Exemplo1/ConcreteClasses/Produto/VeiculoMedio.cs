namespace FR.Estudo.CSharp.DesignPatterns.Creational.AbratractFactory.Exemplo1
{
    //Concrete Product
    public class VeiculoMedio : Veiculo
    {
        public VeiculoMedio(string modelo, Porte porte) : base(modelo, porte)
        {
        }
    }
}
