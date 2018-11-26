using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNetVS2017.Capitulo01.Repeticao.Testes
{
    [TestClass]
    public class RepeticaoTeste
    {
        [TestMethod]
        public void ForAninhadoTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int x = 1; x <= 10; x++)
                {
                    //i = i * x;
                    Console.WriteLine($"{i} * {x} = {i * x}");
                }

                Console.WriteLine(new string('-', 50));
            }
        }

        [TestMethod]
        public void EstruturaForTeste()
        {
            var i = 1;

            for (Console.WriteLine("Iniciou"); i <= 3; Console.WriteLine(i))
            {
                i++;
            }


            /*
            for (1 - inicialização; 2 -condicao; 4 -pos execucao)
            {
                3 - execução
            }
            */

        }

        [TestMethod]
        public void ForApenasCondicaoTeste()
        {
            var i = 1;

            for (; i <= 3;)
            {
                Console.WriteLine(i++);
            }

        }

        [TestMethod]
        public void ContinueTest()
        {

            for (int i = 0; i < 10; i++)
            {
                if (i <=5 )
                {
                    continue;
                }

                Console.WriteLine(i);
            }

        }


        [TestMethod]
        public void BreakTest()
        {

            for (int i = 0; i < 10; i++)
            {
                if (i > 5)
                {
                    break;
                }

                Console.WriteLine(i);
            }

        }





    }

}
