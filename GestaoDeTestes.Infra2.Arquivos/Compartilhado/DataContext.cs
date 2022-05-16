using GestaoDeTarefas.Dominio.ModuloMateria;
using GestaoDeTestes.Infra.Arquivos.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTestes.Infra.Arquivos
{
    [Serializable]
    public class DataContext
    {
        private readonly ISerializador serializador;

        public DataContext()
        {
            Materias = new List<Materia>();

        }

        public DataContext(ISerializador serializador) : this()
        {
            this.serializador = serializador;

            CarregarDados();
        }

        public List<Materia> Materias { get; set; }


        public void GravarDados()
        {
            serializador.GravarDadosEmArquivo(this);
        }

        private void CarregarDados()
        {
            var ctx = serializador.CarregarDadosDoArquivo();

            if (ctx.Materias.Any())
                this.Materias.AddRange(ctx.Materias);
        }
    }
}
