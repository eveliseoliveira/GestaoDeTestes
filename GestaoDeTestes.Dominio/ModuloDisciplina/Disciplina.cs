using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoDeTestes.Dominio.Compartilhado;

namespace GestaoDeTestes.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public Disciplina()
        {
        }

        public Disciplina(int numero, string nome) : this()
        {
            Numero = numero;
            Nome = nome;
        }

        public int Numero { get; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"Número: {Numero}, Nome: {Nome}";
        }

        public override void Atualizar(Disciplina registro)
        {
            this.Nome = registro.Nome;
        }
    }
}
