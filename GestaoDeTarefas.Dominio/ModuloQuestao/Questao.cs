using GestaoDeTarefas.Dominio.Compartilhado;
using GestaoDeTarefas.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas.Dominio.ModuloQuestao
{
    [Serializable]
    public class Questao : EntidadeBase<Questao>
    {

        public string Enunciado { get; set; }


        public DisciplinasEnum Disciplinas { get; set; }

        public SelecionaSerie Series { get; set; }

        public override void Atualizar(Questao registro)
        {

        }

        public override string ToString()
        {
            return $"Número: {Numero}, Enunciado: {Enunciado}, Disciplinas: {Disciplinas}, Serie: {Series}";
        }
    }
}
