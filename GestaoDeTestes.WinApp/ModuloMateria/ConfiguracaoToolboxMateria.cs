using GestaoDeTestes.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeTestes.WinApp.ModuloMateria
{
    public class ConfiguracaoToolboxMateria : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Materias";
        public override string TooltipInserir { get { return "Inserir uma nova matéria"; } }

        public override string TooltipEditar { get { return "Editar uma nova matéria"; } }

        public override string TooltipExcluir { get { return "Excluir uma nova matéria"; } }

        public override string TooltipFiltrar { get { return "Filtrar Tarefas por Status"; } }
    }
}
