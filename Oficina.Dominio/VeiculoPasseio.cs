using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{

    //ToDo: heranca com a classe (:) com a classe Veiculo
    public class VeiculoPasseio: Veiculo
    {
        public Carroceria Carroceria { get; set; }

        //ToDo OO: - Polimorficsmo por sobrescrita 
        public override List<string> Validar()
        {
            var erros = base.ValidarBase();

            if (!Enum.IsDefined(typeof(Carroceria), Carroceria))
            {
                erros.Add($"Carroceria informada ({Carroceria}) nao é valida!");
            }

            return erros;
        }
    }
}
