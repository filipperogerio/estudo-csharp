namespace FR.Estudo.CSharp.DesignPatterns.Creational.AbratractFactory.Exemplo1
{
    //Concrete Product
    public class VeiculoPequeno : Veiculo
    {
        public VeiculoPequeno(string modelo, Porte porte) : base(modelo, porte)
        {
        }
    }
}
