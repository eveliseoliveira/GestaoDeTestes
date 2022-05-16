using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GestaoDeTestes.Infra.Arquivos.Compartilhado
{
    internal class SerializadorDadosEmJson : ISerializador
    {
        private const string arquivo = @"C:\Users\SAMSUNG\Documents\Visual Studio\GestaoDeTestes.json";

        public DataContext CarregarDadosDoArquivo()
        {
            if (File.Exists(arquivo) == false)
                return new DataContext();

            string json = File.ReadAllText(arquivo);

            return JsonSerializer.Deserialize<DataContext>(json);
        }

        public void GravarDadosEmArquivo(DataContext dados)
        {
            var config = new JsonSerializerOptions { WriteIndented = true };

            string json = JsonSerializer.Serialize(dados, config);

            File.WriteAllText(arquivo, json);
        }
    }
}
