using System;

namespace FR.Estudo.CSharp.DesignPatterns.Creational.AbratractFactory.Exemplo1
{
    public class GuinchoCreator
    {
        public static Guincho Criar(Porte porte)
        {
            return porte switch
            {
                Porte.Pequeno => new GuinchoPequeno(porte),
                Porte.Medio => new GuinchoMedio(porte),
                Porte.Grande=> new GuinchoGrande(porte),
                _ => throw new ArgumentException("Porte de Guincho desconhecido.")
            };
        }
    }
}
