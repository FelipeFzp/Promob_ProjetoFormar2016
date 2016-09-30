using System;

namespace ExemploColecao
{
    class Program
    {
        static void Main(string[] args)
        {
            Colecao colecao = new Colecao();
            colecao.ExemploArrayList();
            colecao.ExemploLista();
            colecao.ExemploListaObjeto();
            colecao.ExemploDictionary();
            colecao.ExemploDictionaryObjetos();
            colecao.ExemploDictionaryListaObjetos();
            colecao.ExemplosLinq();

            Console.ReadLine();
        }
    }
}
