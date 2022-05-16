namespace GestaoDeTestes.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolbox = new System.Windows.Forms.MenuStrip();
            this.MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosQuestoesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMateriaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnPDF = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.toolbox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbox
            // 
            this.toolbox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem});
            this.toolbox.Location = new System.Drawing.Point(0, 0);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(800, 28);
            this.toolbox.TabIndex = 0;
            this.toolbox.Text = "menuStrip1";
            // 
            // MenuItem
            // 
            this.MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosQuestoesMenuItem,
            this.testesMenuItem,
            this.cadastroMateriaMenuItem});
            this.MenuItem.Name = "MenuItem";
            this.MenuItem.Size = new System.Drawing.Size(60, 24);
            this.MenuItem.Text = "Menu";
            // 
            // cadastrosQuestoesMenuItem
            // 
            this.cadastrosQuestoesMenuItem.Name = "cadastrosQuestoesMenuItem";
            this.cadastrosQuestoesMenuItem.Size = new System.Drawing.Size(239, 26);
            this.cadastrosQuestoesMenuItem.Text = "Cadastro De Questões";
            this.cadastrosQuestoesMenuItem.Click += new System.EventHandler(this.cadastrosQuestoesMenuItem_Click);
            // 
            // testesMenuItem
            // 
            this.testesMenuItem.Name = "testesMenuItem";
            this.testesMenuItem.Size = new System.Drawing.Size(239, 26);
            this.testesMenuItem.Text = "Gerar Testes";
            this.testesMenuItem.Click += new System.EventHandler(this.testesMenuItem_Click);
            // 
            // cadastroMateriaMenuItem
            // 
            this.cadastroMateriaMenuItem.Name = "cadastroMateriaMenuItem";
            this.cadastroMateriaMenuItem.Size = new System.Drawing.Size(239, 26);
            this.cadastroMateriaMenuItem.Text = "Cadastro Matéria";
            this.cadastroMateriaMenuItem.Click += new System.EventHandler(this.cadastroMateriaMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnExcluir,
            this.btnPDF});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 37);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            this.btnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserir.Image = global::GestaoDeTestes.WinApp.Properties.Resources.add_FILL0_wght400_GRAD0_opsz48;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Padding = new System.Windows.Forms.Padding(5);
            this.btnInserir.Size = new System.Drawing.Size(34, 34);
            this.btnInserir.Text = "Inserir";
            this.btnInserir.ToolTipText = "Inserir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::GestaoDeTestes.WinApp.Properties.Resources.edit_FILL0_wght400_GRAD0_opsz48;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(5);
            this.btnEditar.Size = new System.Drawing.Size(34, 34);
            this.btnEditar.Text = "Editar";
            this.btnEditar.ToolTipText = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = global::GestaoDeTestes.WinApp.Properties.Resources.delete_FILL0_wght400_GRAD0_opsz48;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Size = new System.Drawing.Size(34, 34);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.ToolTipText = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPDF.Image = global::GestaoDeTestes.WinApp.Properties.Resources.picture_as_pdf_FILL0_wght400_GRAD0_opsz48;
            this.btnPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Padding = new System.Windows.Forms.Padding(5);
            this.btnPDF.Size = new System.Drawing.Size(34, 34);
            this.btnPDF.Text = "PDF";
            this.btnPDF.ToolTipText = "PDF";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelRegistros
            // 
            this.panelRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistros.Location = new System.Drawing.Point(0, 65);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(800, 363);
            this.panelRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolbox);
            this.MainMenuStrip = this.toolbox;
            this.Name = "TelaPrincipalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão De Testes";
            this.toolbox.ResumeLayout(false);
            this.toolbox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip toolbox;
        private System.Windows.Forms.ToolStripMenuItem MenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosQuestoesMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelRegistros;
        private System.Windows.Forms.ToolStripMenuItem testesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroMateriaMenuItem;
        private System.Windows.Forms.ToolStripButton btnInserir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnPDF;
    }
}
