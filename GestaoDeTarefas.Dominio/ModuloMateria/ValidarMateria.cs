using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTarefas.Dominio.ModuloMateria
{
    public class ValidarMateria : AbstractValidator<Materia>
    {
        public ValidarMateria()
        {
            RuleFor(x => x.Nome)
                .NotNull().NotEmpty();
        }
    }
}
