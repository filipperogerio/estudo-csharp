using System;

namespace FR.Estudo.CSharp.DesignPatterns.Creational.AbratractFactory.Exemplo1
{
    class VeiculoCreator
    {
        public static Veiculo Criar(string modelo, Porte porte)
        {
            return porte switch
            {
                Porte.Pequeno => new VeiculoPequeno(modelo, porte),
                Porte.Medio => new VeiculoMedio(modelo, porte),
                Porte.Grande => new VeiculoGrande(modelo, porte),
                _ => throw new ArgumentException("Porte de veiculo desconhecido.")
            };
        }
    }
}
