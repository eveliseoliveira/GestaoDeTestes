using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace GestaoDeTestes.Dominio.ModuloDisciplina
{
    public class ValidadorDisciplina : AbstractValidator<Disciplina>
    {
        public ValidadorDisciplina()
        {
            RuleFor(x => x.Nome)
                .NotNull().NotEmpty();

        }
    }
}
