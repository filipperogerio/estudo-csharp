﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FR.Estudo.CSharp.DesignPatterns.Creational.Singleton
{
    public class ExecucaoSingleton
    {
        public static void Executar()
        {
            var lb1 = LoadBalancer.GetLoadBalancer();
            var lb2 = LoadBalancer.GetLoadBalancer();
            var lb3 = LoadBalancer.GetLoadBalancer();
            var lb4 = LoadBalancer.GetLoadBalancer();

            if (lb1 == lb2 && lb2 == lb3 && lb3 == lb4)
            {
                Console.WriteLine("Mesma instância\n");
            }

            var balancer = LoadBalancer.GetLoadBalancer();

            for (int i = 0; i < 15; i++)
            {
                var serverName = balancer.NextServer.Name;
                Console.WriteLine($"Disparando request para: {serverName}");
            }

        }
    }
}
