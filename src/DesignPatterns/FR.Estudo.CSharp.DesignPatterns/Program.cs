using FR.Estudo.CSharp.DesignPatterns.Creational.AbratractFactory.Exemplo1;
using FR.Estudo.CSharp.DesignPatterns.Creational.FactoryMethod;
using FR.Estudo.CSharp.DesignPatterns.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace FR.Estudo.CSharp.DesignPatterns
{
    public static class Program
    {
        public static void Main()
        {

            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("------------------------");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("------------------------");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Factory Method");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("------------------------");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("6 - Composite");
            Console.WriteLine("------------------------");
            Console.WriteLine("Behavioral Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("7 - Command");
            Console.WriteLine("8 - Strategy");
            Console.WriteLine("9 - Observer");
            Console.WriteLine("------------------------");

            var opcao = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");


            ObterOpcao(opcao.KeyChar).Invoke();

            Console.ReadKey();
            Console.Clear();
            Main();
        }

        public static Action ObterOpcao(char opcao) => opcao switch
        {
            '0' => () => { Environment.Exit(0); }
            ,
            '1' => () => { ExecucaoAbstractFactoryExemplo1.Executar(); }
            ,
            '2' => () => { ExecucaoFactoryMethod.Execute(); }
            ,
            '3' => () => { ExecucaoSingleton.Executar(); }
            ,
            _ => throw new ArgumentException()
        };

    }
}
