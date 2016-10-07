using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExamplesXml
{
    class Program
    {
        static void Main(string[] args)
        {
            string local = Directory.GetCurrentDirectory() + "\\ArquivoDB.xml";

            // Declara um novo documento xml
            XmlDocument doc = new XmlDocument();

            // Declara uma nova tag (nesse caso é a tag pai) <Pessoas>
            XmlNode Pessoas = doc.CreateElement("Pessoas"); // doc.createElement("nomedoelemento") declara tags

            // Declara uma nova tag (nesse caso uma tag filho) <Pessoa>
            XmlNode Pessoa = doc.CreateElement("Pessoa");

            // Declaração dos tipos de atributo (do tipo XmlAttribute)
            XmlAttribute atributoNome;
            XmlAttribute atributoIdade;
            XmlAttribute atributoSalario;

            // Defini o nome dos atributos e cria eles
            atributoNome = doc.CreateAttribute("Nome");
            atributoIdade = doc.CreateAttribute("Idade");
            atributoSalario = doc.CreateAttribute("Salario");

  
            // Defini os valores para os atributos criados acima
            atributoNome.Value = "Felipe";
            atributoIdade.Value = "19";
            atributoSalario.Value = "Desempregado";

            //Defini os atributos para uma tag, antes dos Append esse valores ainda nao pertencem a ninguem
            Pessoa.Attributes.Append(atributoNome);
            Pessoa.Attributes.Append(atributoIdade);
            Pessoa.Attributes.Append(atributoSalario);

            // Defini que a tag filho é filho da tag pai Exemplo:(<Pessoas> <Pessoa/> <Pessoas>)
            Pessoas.AppendChild(Pessoa);

            // Coloca Pessoas dentro do XML (nodo raiz)
            doc.AppendChild(Pessoas);

            // salva o documento XML
            doc.Save(local);



            Pessoa = doc.CreateElement("Pessoa");

            atributoNome = doc.CreateAttribute("Nome");
            atributoIdade = doc.CreateAttribute("Idade");
            atributoSalario = doc.CreateAttribute("Salario");

            atributoNome.Value = "Felipes";
            atributoIdade.Value = "19dsfg";
            atributoSalario.Value = "Desdgsempregado";

            Pessoa.Attributes.Append(atributoNome);
            Pessoa.Attributes.Append(atributoIdade);
            Pessoa.Attributes.Append(atributoSalario);

            Pessoas.AppendChild(Pessoa);

            doc.AppendChild(Pessoas);
            doc.Save(local);




            XmlNode Funcionario = doc.CreateElement("Funcionario");
            atributoNome = doc.CreateAttribute("Nome");
            atributoIdade = doc.CreateAttribute("Idade");
            atributoSalario = doc.CreateAttribute("Salario");


            atributoIdade.Value = "22";
            atributoNome.Value = "Igor";
            atributoSalario.Value = "850.00";

            Funcionario.Attributes.Append(atributoNome);
            Funcionario.Attributes.Append(atributoIdade);
            Funcionario.Attributes.Append(atributoSalario);

            Pessoas.AppendChild(Funcionario);

            doc.AppendChild(Pessoas);

            doc.Save(local);



            //Leitura de um XML
            doc.Load(local); // carrega o arquivo para a memoria
            List<string> SalarioFuncionarios = new List<string>();
            foreach (XmlNode nodes in doc.DocumentElement.ChildNodes) // retorne os nodes filhos de nodes pais
            {
                foreach (XmlAttribute attribute in nodes.Attributes) // retorne atributo de atributos das nodes
                {
                    if (attribute.Name.Equals("Salario",StringComparison.OrdinalIgnoreCase)) //Testa se o nome do Atributo do node é Salario (ordinalignorecase é um tratamento que Ignora case, sempre tratar)
                    {
                        if (nodes.Name.Equals("Funcionario"))  //<-- testa se o nome do nodo é (****)
                            SalarioFuncionarios.Add(attribute.Value); // armazena na lista o atributo Salario do Funcionario
                    }
                }
            }         
           Console.ReadKey();
        }
    }
}
