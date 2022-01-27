using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

//[assembly: InternalsVisibleTo("FR.Estudo.CSharp.ModificadoresB")]
namespace FR.Estudo.CSharp.ModificadoresA
{
    public class Publica
    {
        public void TestePublico() { }
        private void TestePrivado() { }
        protected void TesteProtegido() { }
        internal void TesteInterno() { }
        private protected void TestePrivadoProtegido() { }
        protected internal void TesteProtegidoInterno() { }

    }

    public sealed class Selada { }
    class Privada
    {
        public void TestePublico() { }
        private void TestePrivado() { }
        protected void TesteProtegido() { }
        internal void TesteInterno() { }
        private protected void TestePrivadoProtegido() { }
        protected internal void TesteProtegidoInterno() { }
    }

    internal class Interna
    {
        public void TestePublico() { }
        private void TestePrivado() { }
        protected void TesteProtegido() { }
        internal void TesteInterno() { }
        private protected void TestePrivadoProtegido() { }
        protected internal void TesteProtegidoInterno() { }
    }
    abstract class Abstrata { }


}
