using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas.Dominio.ModuloMateria
{
    [Serializable]
    public class SelecionaSerie
    {
        public string Titulo { get; set; }

        public bool Serie { get; set; }

        public override string ToString()
        {
            return Titulo;
        }

        public void Primeira()
        {
            Serie = true;
        }

        internal void Segunda()
        {
            Serie = false;
        }
    }
}
