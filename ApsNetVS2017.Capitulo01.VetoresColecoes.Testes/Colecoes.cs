using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ApsNetVS2017.Capitulo01.VetoresColecoes.Testes
{
    [TestClass]
    public class Colecoes
    {
        #region Atributos de teste adicionais
        //
        // É possível usar os seguintes atributos adicionais enquanto escreve os testes:
        //
        // Use ClassInitialize para executar código antes de executar o primeiro teste na classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para executar código após a execução de todos os testes em uma classe
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize para executar código antes de executar cada teste 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para executar código após execução de cada teste
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ListTeste()
        {
            //atribuindo valores em listas
            var inteiros = new List<int>(50) {21,5,6,8};

            //add insere o valor em sequencia
            //inteiros.Add(22);


            var maisinteiros = new List<int> {45, 6, 72, 14, 65 };

            inteiros.AddRange(maisinteiros);

            //inser insere o valor em uma posicao especifica
            //inteiros.Insert(1, 24);

            //remove os valores da lista
            //inteiros.Remove(3);

            //remove os valores da lista na posicao especifica
            //inteiros.RemoveAt(5);

            inteiros.Sort();

            //var primeiro = inteiros.FirstOrDefault();

            //var ultimo = inteiros.Last();
            // ou pode ser assim
            //var ultimo2 = inteiros[inteiros.Count -1];

            //saber se a lista esta vazia
            //var EstaVazia = inteiros.Count == 0;

            // mostrando o indice aonde o valor da lista está
            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}: {inteiro}");
            }

            for (int i = 0; i < inteiros.Count; i++)
            {
                Console.WriteLine($"Index = {i}: {inteiros[i]}");
            }


        }

        [TestMethod]
        public void Dictionary()
        {
            var feriados = new Dictionary<DateTime, string> ();

            feriados.Add(new DateTime(2018, 12, 25), "natal");
            feriados.Add(new DateTime(2019, 01, 01), "ano novo");
            feriados.Add(new DateTime(2019, 01, 25), "Niver SP");

            var natal = feriados[new DateTime(2018, 12, 25)];

            foreach (var feriado in feriados)
            {
                //pode ser exibido de 02 formas
                Console.WriteLine(string.Format("{0}: {1}", feriado.Key.ToShortDateString(), feriado.Value));

                //ou assim 
                Console.WriteLine(string.Format("{0:dd/MM}: {1}", feriado.Key, feriado.Value));

                //ou assim 
                Console.WriteLine(string.Format("{0}: {1}", feriado.Key.ToString("dd/MM"), feriado.Value));
                
            }

            Console.WriteLine(feriados.ContainsKey(new DateTime(2018, 12, 25)));
            Console.WriteLine(feriados.ContainsValue("ano novo"));

        }

    }
}
