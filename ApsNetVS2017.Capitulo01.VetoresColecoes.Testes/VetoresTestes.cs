using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApsNetVS2017.Capitulo01.VetoresColecoes.Testes
{
    [TestClass]
    public class VetoresTestes
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var strings = new string[10];

            strings[0] = "A";
            strings[9] = "B";

            var decimais = new decimal[3] { 0.5m, 78, 59, };

            //decimal[] novoDecimais = {2, 3, 5.9m };

            foreach (var @decimal in decimais)
            {
                Console.WriteLine(@decimal);
            }

            Console.WriteLine($"Tamanho do vetor: {decimais.Length } ");

        }

        [TestMethod]
        public void RedimencionamentoTeste()
        {
            var decimais = new decimal[] { 0.5m, 78, 59, };

            Array.Resize(ref decimais, 5);

            decimais[3] = 20.01m;

        }


        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] {35.89m, 0.5m, 78, 59, 42.23m};

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], 0.5m);
            
        }


        [TestMethod]
        private decimal Media( decimal numero1, decimal numero2)
        {


            return (numero1  + numero2) / 2;
        }


        //chamando o metodo por parametros
        [TestMethod]
        private decimal Media2(params decimal[] valores )
        {

            //metodo do codigo com uma linha.
            return valores.Average();

            /* esta certo tambem;
            decimal q = 0;
            decimal m = 0;
            decimal i = 0; 

            foreach (var @decimal in valores)
            {
               q += @decimal;
                i++;
            }

            m = q / i;
            return m;
            */

        }


        [TestMethod]
        public void ParamsTeste()
        {
            var decimais = new decimal[] { 35.89m, 0.5m, 78, 59, 42.23m };

            Console.WriteLine(Media2(decimais));
            Console.WriteLine(Media2(2,8,9.8m));

        }

        [TestMethod]
        public void TodaStringEhUmVetorTeste()
        {
            const string nome = "Hejlsberg";

            Assert.AreEqual(nome[0], 'H');

            foreach (var @char in nome)
            {
                Console.WriteLine(@char);
            }

        }



    }
}
