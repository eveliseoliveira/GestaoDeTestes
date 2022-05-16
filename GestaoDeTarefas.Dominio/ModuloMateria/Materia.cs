using GestaoDeTarefas.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        private List<SelecionaSerie> series = new List<SelecionaSerie>();

        public Materia()
        {
            SerieEnum = SeriesEnum.Primeira;
        }

        public Materia(int n, string t) : this()
        {
            Numero = n;
            Nome = t;
        }

        public string Nome { get; set; }
        public SeriesEnum SerieEnum { get; set; }
        public List<SelecionaSerie> Series { get { return series; } }


        public override string ToString()
        {
            return $"Número: {Numero}, Nome: {Nome}, Série: {SerieEnum}";
        }

        public void Primeira(SelecionaSerie serie)
        {
            SelecionaSerie selecionaSerie = series.Find(x => x.Equals(serie));

            selecionaSerie?.Primeira();
        }

        public void Segunda(SelecionaSerie serie)
        {
            SelecionaSerie selecionaSerie = series.Find(x => x.Equals(serie));

            selecionaSerie?.Segunda();
        }

        public override void Atualizar(Materia registro)
        {
            this.Nome = registro.Nome;
        }
    }
}
