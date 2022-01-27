using System;

namespace FR.Estudo.CSharp.DesignPatterns.Creational.AbratractFactory.Exemplo1
{
    //Concrete Product
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte)
        {
        }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine("Socorrendo Carro Medio - Modelo " + veiculo.Modelo);
        }
    }
}