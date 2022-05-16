using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTestes.Infra.Arquivos.Compartilhado
{
    public interface ISerializador
    {
        DataContext CarregarDadosDoArquivo();

        void GravarDadosEmArquivo(DataContext dados);
    }
}
