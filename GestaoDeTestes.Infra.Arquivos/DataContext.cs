using GestaoDeTestes.Dominio.ModuloDisciplina;
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
            Disciplinas = new List<Disciplina>();

        }

        public DataContext(ISerializador serializador) : this()
        {
            this.serializador = serializador;

            CarregarDados();
        }

        public List<Disciplina> Disciplinas { get; set; }


        public void GravarDados()
        {
            serializador.GravarDadosEmArquivo(this);
        }

        private void CarregarDados()
        {
            var ctx = serializador.CarregarDadosDoArquivo();

            if (ctx.Disciplinas.Any())
                this.Disciplinas.AddRange(ctx.Disciplinas);
        }
    }
}
