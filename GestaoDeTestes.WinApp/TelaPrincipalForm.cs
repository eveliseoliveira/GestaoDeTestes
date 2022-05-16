using GestaoDeTestes.Infra.Arquivos;
using GestaoDeTestes.Infra.Arquivos.ModuloMateria;
using GestaoDeTestes.WinApp.Compartilhado;
using GestaoDeTestes.WinApp.ModuloMateria;
using GestaoDeTestes.WinApp.ModuloQuestoes;
using GestaoDeTestes.WinApp.ModuloTestes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeTestes.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        private DataContext contextoDados;

        public TelaPrincipalForm(DataContext contextoDados)
        {
            InitializeComponent();

           /* Instancia = this;

            labelRodape.Text = string.Empty;
            labelTipoCadastro.Text = string.Empty;

            this.contextoDados = contextoDados;

            InicializarControladores();*/
        }
        public static TelaPrincipalForm Instancia
        {
            get;
            private set;
        }

        public void AtualizarRodape(string mensagem)
        {
            //labelRodape.Text = mensagem;
        }

        private void cadastrosQuestoesMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoToolboxQuestoes configuracao = new ConfiguracaoToolboxQuestoes();

            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;

            ListagemQuestoesControl listagem = new ListagemQuestoesControl();

            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void testesMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoToolboxTestes configuracao = new ConfiguracaoToolboxTestes();

            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;

            ListagemTestesControl listagem = new ListagemTestesControl();

            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void cadastroMateriaMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoToolboxMateria configuracao = new ConfiguracaoToolboxMateria();

            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;

            ListagemMateriaControl listagem =  new ListagemMateriaControl();

            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        /*private void cadastroDisciplinaMenuItem_Click_1(object sender, EventArgs e)
        {
            ConfiguracaoToolboxDisciplina configuracao = new ConfiguracaoToolboxDisciplina();

            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;


            ListagemDisciplinaControl listagem = new ListagemDisciplinaControl();

            listagem.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }*/

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }
        private void InicializarControladores()
        {
            var repositorioMateria = new RepositorioMateriaEmArquivo(contextoDados);


            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("Materias", new ControladorMateria(repositorioMateria));
        }
    }
}
