using GestaoDeTarefas.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeTestes.WinApp.ModuloMateria
{
    public partial class TelaCadastroMateria : Form
    {
        private Materia materia;
        public TelaCadastroMateria()
        {
            InitializeComponent();
        }

        private void CarregarPrioridades()
        {
            var prioridades = Enum.GetValues(typeof(SeriesEnum));

            foreach (var item in prioridades)
            {
                comboBoxSerie.Items.Add(item);
            }

            comboBoxSerie.SelectedItem = SeriesEnum.Primeira;
            comboBoxDisciplina.SelectedItem = DisciplinasEnum.Portugues;
        }

        public Func<Materia, ValidationResult> GravarRegistro { get; set; }

        public Materia Materia
        {
            get
            {
                return materia;
            }
            set
            {
                materia = value;
                txtNumero.Text = materia.Numero.ToString();
                txtNome.Text = materia.Nome;
                comboBoxSerie.SelectedItem = materia.SerieEnum;
            }
        }
    }
}
