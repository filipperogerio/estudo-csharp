using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FR.DependencyInjection.CasesDI
{
    public class Generics<T> : IGenerics<T> where T : class
    {
        public void ExecuteMyGeneric(T genericObject)
        {
            //Execute my generic code =)
        }
    }

    public interface IGenerics<T> where T : class
    {
        void ExecuteMyGeneric(T genericObject);
    }

    public class GenericsObject
    {
        public string YourMesage { get; set; }
    }
}
