namespace HomeFinance
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menustripPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.santanderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnCalcWindows = new System.Windows.Forms.ToolStripButton();
            this.menustripPrincipal.SuspendLayout();
            this.toolStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menustripPrincipal
            // 
            this.menustripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.movimentoToolStripMenuItem,
            this.acessórioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menustripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menustripPrincipal.Name = "menustripPrincipal";
            this.menustripPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menustripPrincipal.TabIndex = 0;
            this.menustripPrincipal.Text = "Menu Principal";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // movimentoToolStripMenuItem
            // 
            this.movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            this.movimentoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.movimentoToolStripMenuItem.Text = "Movimento";
            // 
            // acessórioToolStripMenuItem
            // 
            this.acessórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.calculadoraWindowsToolStripMenuItem,
            this.santanderToolStripMenuItem});
            this.acessórioToolStripMenuItem.Name = "acessórioToolStripMenuItem";
            this.acessórioToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.acessórioToolStripMenuItem.Text = "Acessório";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // calculadoraWindowsToolStripMenuItem
            // 
            this.calculadoraWindowsToolStripMenuItem.Name = "calculadoraWindowsToolStripMenuItem";
            this.calculadoraWindowsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculadoraWindowsToolStripMenuItem.Text = "Calculadora Windows";
            this.calculadoraWindowsToolStripMenuItem.Click += new System.EventHandler(this.calculadoraWindowsToolStripMenuItem_Click);
            // 
            // santanderToolStripMenuItem
            // 
            this.santanderToolStripMenuItem.Name = "santanderToolStripMenuItem";
            this.santanderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.santanderToolStripMenuItem.Text = "Santander";
            this.santanderToolStripMenuItem.Click += new System.EventHandler(this.santanderToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripPrincipal
            // 
            this.toolStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnCalcWindows});
            this.toolStripPrincipal.Location = new System.Drawing.Point(0, 24);
            this.toolStripPrincipal.Name = "toolStripPrincipal";
            this.toolStripPrincipal.Size = new System.Drawing.Size(800, 25);
            this.toolStripPrincipal.TabIndex = 1;
            this.toolStripPrincipal.Text = "toolStrip1";
            // 
            // toolStripBtnCalcWindows
            // 
            this.toolStripBtnCalcWindows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCalcWindows.Image = global::HomeFinance.Properties.Resources.calc;
            this.toolStripBtnCalcWindows.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCalcWindows.Name = "toolStripBtnCalcWindows";
            this.toolStripBtnCalcWindows.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnCalcWindows.Text = "Calculadora Windows";
            this.toolStripBtnCalcWindows.Click += new System.EventHandler(this.toolStripBtnCalcWindows_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripPrincipal);
            this.Controls.Add(this.menustripPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menustripPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Home Finance V1.00";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.menustripPrincipal.ResumeLayout(false);
            this.menustripPrincipal.PerformLayout();
            this.toolStripPrincipal.ResumeLayout(false);
            this.toolStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menustripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem santanderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripBtnCalcWindows;
    }
}

