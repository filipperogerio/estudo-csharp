using FR.Estudo.CSharp.ModificadoresA;
using System;

namespace FR.Estudo.CSharp.ModificadoresB
{
    class TesteClassHerdandoClassePublica : Publica
    {
        public TesteClassHerdandoClassePublica()
        {
            base.TestePublico();
            //base.TesteInterno();
            base.TesteProtegido();
            //base.TestePrivadoProtegido();
            base.TesteProtegidoInterno();
            //base.TestePrivado(); 
        }
    }

    class TesteClassInstanciarClassePublica
    {
        public TesteClassInstanciarClassePublica()
        {
            var publica = new Publica();
            publica.TestePublico();
            //publica.TesteInterno();
            //publica.TesteProtegidoInterno();
            //publica.TesteProtegido();
            //publica.TestePrivadoProtegido();
        }

    }
}
