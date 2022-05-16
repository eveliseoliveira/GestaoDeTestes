namespace GestaoDeTestes.WinApp.ModuloQuestoes
{
    partial class TelaCadastroQuestao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImprimeAlternativa = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlternativa = new System.Windows.Forms.TextBox();
            this.txtEnunciado = new System.Windows.Forms.RichTextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "N°:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disciplina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materia:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(112, 31);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(97, 27);
            this.txtNumero.TabIndex = 3;
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(112, 78);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(192, 28);
            this.comboBoxDisciplina.TabIndex = 4;
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Location = new System.Drawing.Point(112, 126);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(197, 28);
            this.comboBoxMateria.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enunciado:";
            // 
            // txtImprimeAlternativa
            // 
            this.txtImprimeAlternativa.Location = new System.Drawing.Point(112, 347);
            this.txtImprimeAlternativa.Name = "txtImprimeAlternativa";
            this.txtImprimeAlternativa.Size = new System.Drawing.Size(297, 82);
            this.txtImprimeAlternativa.TabIndex = 8;
            this.txtImprimeAlternativa.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alternativas:";
            // 
            // txtAlternativa
            // 
            this.txtAlternativa.Location = new System.Drawing.Point(112, 292);
            this.txtAlternativa.Name = "txtAlternativa";
            this.txtAlternativa.Size = new System.Drawing.Size(197, 27);
            this.txtAlternativa.TabIndex = 10;
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Location = new System.Drawing.Point(112, 180);
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(297, 82);
            this.txtEnunciado.TabIndex = 11;
            this.txtEnunciado.Text = "";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(315, 292);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(94, 29);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(210, 471);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(94, 29);
            this.btnGravar.TabIndex = 13;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(315, 471);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 529);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtEnunciado);
            this.Controls.Add(this.txtAlternativa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImprimeAlternativa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMateria);
            this.Controls.Add(this.comboBoxDisciplina);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroQuestao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Questao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtImprimeAlternativa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlternativa;
        private System.Windows.Forms.RichTextBox txtEnunciado;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
    }
}