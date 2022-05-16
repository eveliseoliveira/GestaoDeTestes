using GestaoDeTarefas.Dominio.Compartilhado;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using GestaoDeTarefas.Dominio.ModuloMateria;
using FluentValidation.Results;

namespace GestaoDeTestes.Infra.Arquivos.ModuloMateria
{
    public class RepositorioMateriaEmArquivo : RepositorioEmArquivoBase<Materia>, IRepositorioMateria
    {
        public RepositorioMateriaEmArquivo(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Materias.Count > 0)
                contador = dataContext.Materias.Max(x => x.Numero);
        }

        public ValidationResult Inserir(Materia novoRegistro)
        {
            var resultadoValidacao = Validar(novoRegistro);

            if (resultadoValidacao.IsValid)
            {
                novoRegistro.Numero = ++contador;

                var registros = ObterRegistros();

                registros.Add(novoRegistro);
            }

            return resultadoValidacao;
        }

        public ValidationResult Editar(Materia registro)
        {
            var resultadoValidacao = Validar(registro);

            if (resultadoValidacao.IsValid)
            {
                var registros = ObterRegistros();

                foreach (var item in registros)
                {
                    if (item.Numero == registro.Numero)
                    {
                        item.Atualizar(registro);
                        break;
                    }
                }
            }

            return resultadoValidacao;
        }

        private ValidationResult Validar(Materia registro)
        {
            var validator = ObterValidador();

            var resultadoValidacao = validator.Validate(registro);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            var nomeEncontrado = ObterRegistros()
               .Select(x => x.Nome)
               .Contains(registro.Nome);

            if (nomeEncontrado && registro.Numero == 0)
                resultadoValidacao.Errors.Add(new ValidationFailure("", "Matéria já está cadastrada"));

            return resultadoValidacao;
        }
        
        public override List<Materia> ObterRegistros()
        {
            return dataContext.Materias;
        }



        public override List<Materia> SelecionarTodos()
        {
            return base.SelecionarTodos()
                .OrderByDescending(x => x.SerieEnum)
                .ToList();
        }

        public override AbstractValidator<Materia> ObterValidador()
        {
            return new ValidarMateria();
        }
    }
}
