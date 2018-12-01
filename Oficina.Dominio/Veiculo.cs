using System;
using System.Collections.Generic;

namespace Oficina.Dominio
{

    /*  IMPEDIR QUE A CLASSE SEJA INSTANCIADA
     * 
     * ABSTRACT
     *       CLASSES INCOMPLETAS
     */

    public abstract class Veiculo
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Placa { get; set; }
        public int Ano { get; set; }
        public string Observacao { get; set; }
        public Modelo Modelo { get; set; }
        public Cor Cor { get; set; }
        public Combustivel Combustivel { get; set; }
        public Cambio Cambio { get; set; }

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
    }


}
