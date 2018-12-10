using Pessoal.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// utilizacao Interfaces
namespace Pessoal.Dominio.Interfaces
{
    public interface ITarefaRepositorio
    {
        int Inserir(Tarefa Tarefa);
        Tarefa Selecionar(int id);
        List <Tarefa> Selecionar();
        void Atualizar(Tarefa Tarefa);
        void Excluir(int id);

    }
}
