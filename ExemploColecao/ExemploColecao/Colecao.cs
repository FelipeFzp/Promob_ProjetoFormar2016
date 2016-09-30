using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExemploColecao
{
    public class Colecao
    {
        private List<Objeto.Objeto> _objetos;

        public void ExemploArrayList()
        {
            Objeto.Objeto obj = new Objeto.Objeto();

            ArrayList lista = new ArrayList();
            lista.Add("Casa");
            lista.Add(1);
            lista.Add(true);
            lista.Add(obj);     

            bool constains = lista.Contains(obj); //verifica se lista contém objeto


            lista.Remove(1); //remove objeto do parâmetro
            lista.RemoveAt(2); //remove indíce 2

            ArrayList lista2 = new ArrayList();
            lista2.AddRange(lista); //adiciona uma lista inteira em outra lista

            lista.Clear(); //limpa
        }

        public void ExemploLista()
        {
            List<int> lista = new List<int>(); //pode ser de vários tipos
            lista.Add(1);
            lista.Add(3);
            lista.Add(3);
            lista.Add(4);


            List<int> lista2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 }; // outro tipo de inicialização da lista

            int posicao = lista[3]; //variável posição é atribuída com valor da posição 3 da lista
            lista[0] = 56; // posição 0 da lista recebe o valor 56
        }

        public void ExemploListaObjeto()
        {
           _objetos = new List<Objeto.Objeto>();
            _objetos.Add(new Objeto.Objeto() { Id = 1, Descricao = "Objeto 1" });
            _objetos.Add(new Objeto.Objeto() { Id = 2, Descricao = "Objeto 2" });
            _objetos.Add(new Objeto.Objeto() { Id = 3, Descricao = "Objeto 3" });
            _objetos.Add(new Objeto.Objeto() { Id = 4, Descricao = "Objeto 4" });

            for (int i = 0; i < _objetos.Count; i++)
            {
                Objeto.Objeto valor = _objetos[i]; //acesso precisa ser através de indíce
            }

            foreach (var obj in _objetos)
            {
                Objeto.Objeto valor = obj; //acesso pode ser através da variável "obj", a cada iteração o valor muda
            }
        }

        public void ExemploDictionary()
        {
            Dictionary<int, string> nomes = new Dictionary<int, string>(); //é composto por chave e valor
            nomes.Add(45, "João");
            nomes.Add(6, "Maria");
            nomes.Add(14, "Maria");

            nomes.Remove(6); //remove através da chave

            bool existe = nomes.ContainsKey(2);  //verifica se existe um registro com chave 2
            bool valueExiste = nomes.ContainsValue("José"); //verifica se existe algum registro com valor "José"
            var valores = nomes.Values; //retorna todos os valores do dicionário (de todas as chaves)


            foreach (var dic in nomes)
            {
                var chave = dic.Key;  //acesso a chave
                var valor = dic.Value; //acesso ao valor
            }
        }

        public void ExemploDictionaryObjetos()
        {

            Dictionary<int, Objeto.Objeto> objetos = new Dictionary<int, Objeto.Objeto>();
            objetos.Add(1, new Objeto.Objeto() { Id = 1, Descricao = "Objeto 1" });
            objetos.Add(5, new Objeto.Objeto() { Id = 2, Descricao = "Objeto 2" });
            objetos.Add(10, new Objeto.Objeto() { Id = 3, Descricao = "Objeto 3" });
            objetos.Add(3, new Objeto.Objeto() { Id = 4, Descricao = "Objeto 4" });

            foreach (var obj in objetos)
            {
                var chave = obj.Key;  //acesso a chave
                var valor = obj.Value; //acesso ao valor que é do tipo Objeto

                var descricaoObj = obj.Value.Descricao; 
            }
        }

        public void ExemploDictionaryListaObjetos()
        {
            Dictionary<int, List<Objeto.Objeto>> objetos = new Dictionary<int, List<Objeto.Objeto>>();

            objetos.Add(1, new List<Objeto.Objeto> { new Objeto.Objeto() { Id = 1, Descricao = "Objeto 1" }});
            objetos.Add(5, new List<Objeto.Objeto> { new Objeto.Objeto() { Id = 2, Descricao = "Objeto 2" } });
            objetos.Add(10, new List<Objeto.Objeto> { new Objeto.Objeto() { Id = 3, Descricao = "Objeto 3" } });
            objetos.Add(3, new List<Objeto.Objeto> { new Objeto.Objeto() { Id = 4, Descricao = "Objeto 4" } });

            foreach (var obj in objetos) //percorre o dicionário
            {
                var chave = obj.Key;  //acesso a chave

                foreach (var valor in obj.Value)  //percorre a lista de objetos
                {
                    var value = valor; //acesso ao valor que é do tipo Objeto
                    var descricaoObj = valor.Descricao;
                }
            }
        }

        public void ExemplosLinq()
        {
            var newList = _objetos.Where(x => x.Descricao == "Objeto"); //retorna os itens da lista que tem a descriação "Objeto"

            var newListCar3 = _objetos.Max(x => x.Id); //retorna o item da lista que tem o maior id
            var newListCar4 = _objetos.Last();  //retorna o último item da lista. ERRO se a lista estiver vazia
            var newListCar5 = _objetos.First();  //retorna o primeiro item da lista. ERRO se a lista estiver vazia

            var newListCar6 = _objetos.LastOrDefault(); //retorna o último item da lista (se tiver) ou valor default (se lista for vazia)
            var newListCar7 = _objetos.FirstOrDefault();//retorna o primeria item da lista (se tiver) ou valor default (se lista for vazia)        
        }
    }
}
