using System;

namespace FR.Estudo.CSharp.DesignPatterns.Creational.AbratractFactory.Exemplo1
{
    //Concrete Product
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte)
        {
        }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine("Socorrendo Carro Grande - Modelo " + veiculo.Modelo);
        }
    }
}
