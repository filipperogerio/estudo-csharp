using System;

namespace FR.Estudo.CSharp.DesignPatterns.Creational.AbratractFactory.Exemplo1
{
    //Concrete Product
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte)
        {
        }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine("Socorrendo Carro Pequeno - Modelo " + veiculo.Modelo);
        }
    }
}
