
namespace FR.Estudo.CSharp.ModificadoresA.testes
{

    /// <summary>
    /// TestePrivado() não pode ser usado fora da classe.
    /// </summary>
    class TesteClassHerdandoClassePublica : Publica
    {
        public TesteClassHerdandoClassePublica()
        {
            base.TestePublico();
            base.TesteInterno();
            base.TesteProtegido();
            base.TestePrivadoProtegido();
            base.TesteProtegidoInterno();
            //base.TestePrivado(); 
        }
    }


    /// <summary>
    /// TesteProtegido()  não pode ser usado pois a classe publica precisa ser herdada
    /// TestePrivadoProtegido() não pode ser usado pois a classe publica precisa ser herdada e só 
    /// pode ser usada dentro do mesmo assembly
    /// </summary>
    class TesteClassInstanciarClassePublica
    {
        public TesteClassInstanciarClassePublica()
        {
            var publica = new Publica();
            publica.TestePublico();
            publica.TesteInterno();
            publica.TesteProtegidoInterno();
            // publica.TesteProtegido(); 
            // publica.TestePrivadoProtegido(); 
        }
    }


    /// <summary>
    /// A diferença classe privada para a classe publica é que a privada só
    /// pode ser utilizada no mesmo Assembly
    /// </summary>
    class TesteClassHerdarClassePrivada : Privada
    {
        public TesteClassHerdarClassePrivada()
        {
            base.TestePublico();
            base.TesteInterno();
            base.TesteProtegido();
            base.TestePrivadoProtegido();
            base.TesteProtegidoInterno();
        }
    }

    class TesteClassInstanciarClassePrivada 
    {
        public TesteClassInstanciarClassePrivada()
        {
            var privada = new Privada();
            privada.TestePublico();
            privada.TesteInterno();
            privada.TesteProtegidoInterno();
        }
    }


    class TesteClassHerdarClasseInterna : Interna
    {
        public TesteClassHerdarClasseInterna()
        {
            base.TestePublico();
            base.TesteInterno();
            base.TesteProtegido();
            base.TestePrivadoProtegido();
            base.TesteProtegidoInterno();
        }
    }

    class TesteClassInstanciarClasseInterna
    {
        public TesteClassInstanciarClasseInterna()
        {
            var interna = new Interna();
            interna.TestePublico();
            interna.TesteInterno();
            interna.TesteProtegidoInterno();
        }
    }
}
