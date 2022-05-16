using GestaoDeTarefas.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas.Dominio.ModuloMateria
{
    public interface IRepositorioMateria : IRepositorio<Materia>
    {
        List<Materia> SelecionarTodos(SeriesEnum status);
    }
}
