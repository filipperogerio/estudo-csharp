using System;
using System.Collections.Generic;
using System.Text;

namespace FR.Estudo.CSharp.DesignPatterns.Creational.AbratractFactory.Exemplo1
{
    public class ExecucaoAbstractFactoryExemplo1
    {
        public static void Executar()
        {
            var veiculoSocorro = new List<Veiculo>
            {
                VeiculoCreator.Criar("Fiat Uno" , Porte.Pequeno ),
                VeiculoCreator.Criar("Nissan Kicks" , Porte.Medio),
                VeiculoCreator.Criar("Dodge Ram", Porte.Grande)
            };

            veiculoSocorro.ForEach(veiculo => AutoSocorro.CriarAutoSocorro(veiculo).RealizarAtendimento());
        }
    }
}
