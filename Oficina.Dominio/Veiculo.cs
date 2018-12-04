using System;
using System.Collections.Generic;

namespace Oficina.Dominio
{

    /*  IMPEDIR QUE A CLASSE SEJA INSTANCIADA
     * 
     * ABSTRACT
     *       CLASSES INCOMPLETAS
     *       
     */

// ToDo: Orientacao Ao Objeto: classe entidade ou abstracao


    public abstract class Veiculo
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        // ToDo: Orientacao Ao Objeto: encapsulamento
        private string placa;

        public string Placa
        {
            get { return placa?.ToUpper(); }
            set { placa = value?.ToUpper(); }
        }
        

        //public string Placa { get; set; }
        public int Ano { get; set; }
        public string Observacao { get; set; }
        public Modelo Modelo { get; set; }
        public Cor Cor { get; set; }
        public Combustivel Combustivel { get; set; }
        public Cambio Cambio { get; set; }

        // ToDo: Orientacao Ao Objeto: encapsulamento
        public DateTime Agora {
            get
            { return DateTime.Now; }

        }
        

        public abstract List<string> Validar();

        protected List<string> ValidarBase()
        {
            var erros = new List<string>();

            if (Ano <= 1979 || Ano > DateTime.Now.Year + 1)
            {
                erros.Add($"O ano informado({Ano}) nao e valido!!");
            }

            return erros;
        }

        //2018-12-03
        // a palavra reservada OVERRIDE

        public override string ToString()
        {
            return string.Format("{0} {1} {2})", Modelo.Marca.Nome, Modelo.Marca, Placa);
        }
    }


}
