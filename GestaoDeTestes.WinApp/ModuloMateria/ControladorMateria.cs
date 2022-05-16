using GestaoDeTarefas.Dominio.ModuloMateria;
using GestaoDeTestes.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeTestes.WinApp.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private IRepositorioMateria repositorioMateria;
        private TabelaMateriaControl tabelaMaterias;

        public SeriesEnum StatusSelecioando { get; private set; }

        public ControladorMateria(IRepositorioMateria repositorioMateria)
        {
            this.repositorioMateria = repositorioMateria;
        }

        public override void Inserir()
        {
            TelaCadastroMateria tela = new TelaCadastroMateria();
            tela.Materia = new Materia();

            tela.GravarRegistro = repositorioMateria.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarMaterias();
            }
        }

        public override void Editar()
        {
            Materia materiaSelecionada = ObtemMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma materia primeiro",
                "Edição de Materias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroMateria tela = new TelaCadastroMateria();

            tela.Materia = materiaSelecionada;

            tela.GravarRegistro = repositorioMateria.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarMaterias();
            }
        }

        public override void Excluir()
        {
            Materia materiaSelecionada = ObtemMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma materia primeiro",
                "Exclusão de Materias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a materias?",
                "Exclusão de Materias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioMateria.Excluir(materiaSelecionada);
                CarregarMaterias();
            }
        }

        /*public override void Filtrar()
        {
            TelaFiltroTarefaForm telaFiltro = new TelaFiltroTarefaForm();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                StatusSelecioando = telaFiltro.StatusSelecionado;

                CarregarTarefas();
            }
        }*/

        public override UserControl ObtemListagem()
        {
            if (tabelaMaterias == null)
                tabelaMaterias = new TabelaMateriaControl();

            CarregarMaterias();

            return tabelaMaterias;
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxMateria();
        }

        private void CarregarMaterias()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos(StatusSelecioando);

            string tipoMateria;

            switch (StatusSelecioando)
            {
                case SeriesEnum.Primeira: tipoMateria = "primeira"; break;

                case SeriesEnum.Segunda: tipoMateria = "segunda"; break;

                default: tipoMateria = ""; break;
            }

            tabelaMaterias.AtualizarRegistros(materias);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {materias.Count} materia(s) {tipoMateria}");
        }

        private Materia ObtemMateriaSelecionada()
        {
            var numero = tabelaMaterias.ObtemNumeroMateriaSelecionado();

            return repositorioMateria.SelecionarPorNumero(numero);
        }
    }
}

