namespace ComercialTDSDesk
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            incluirToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            forncedorToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            incluirToolStripMenuItem2 = new ToolStripMenuItem();
            listarToolStripMenuItem2 = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            incluirToolStripMenuItem1 = new ToolStripMenuItem();
            listarToolStripMenuItem1 = new ToolStripMenuItem();
            nveisToolStripMenuItem = new ToolStripMenuItem();
            operaçãoToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem3 = new ToolStripMenuItem();
            movimentoToolStripMenuItem = new ToolStripMenuItem();
            caixaToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            terminalToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem1 = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            terminalToolStripMenuItem1 = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem2 = new ToolStripMenuItem();
            emitirNotaToolStripMenuItem = new ToolStripMenuItem();
            conficraçõesToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tsslUsuarioLogado = new ToolStripStatusLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            trocarDeUsuárioToolStripMenuItem = new ToolStripMenuItem();
            pnlCentral = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, operaçãoToolStripMenuItem, movimentoToolStripMenuItem, conficraçõesToolStripMenuItem, sairToolStripMenuItem1, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1356, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, produtosToolStripMenuItem, categoriasToolStripMenuItem, fornecedoresToolStripMenuItem, usuáriosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(145, 22);
            clienteToolStripMenuItem.Text = "&Clientes";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incluirToolStripMenuItem, listarToolStripMenuItem, forncedorToolStripMenuItem, categoriaToolStripMenuItem, estoqueToolStripMenuItem });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(145, 22);
            produtosToolStripMenuItem.Text = "&Produtos";
            // 
            // incluirToolStripMenuItem
            // 
            incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            incluirToolStripMenuItem.Size = new Size(134, 22);
            incluirToolStripMenuItem.Text = "&Incluir";
            incluirToolStripMenuItem.Click += incluirToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(134, 22);
            listarToolStripMenuItem.Text = "&Listar";
            listarToolStripMenuItem.Click += listarToolStripMenuItem_Click;
            // 
            // forncedorToolStripMenuItem
            // 
            forncedorToolStripMenuItem.Name = "forncedorToolStripMenuItem";
            forncedorToolStripMenuItem.Size = new Size(134, 22);
            forncedorToolStripMenuItem.Text = "&Fornecedor";
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(134, 22);
            categoriaToolStripMenuItem.Text = "&Categoria";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(134, 22);
            estoqueToolStripMenuItem.Text = "&Estoque";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(145, 22);
            categoriasToolStripMenuItem.Text = "&Categorias";
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incluirToolStripMenuItem2, listarToolStripMenuItem2 });
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(145, 22);
            fornecedoresToolStripMenuItem.Text = "&Fornecedores";
            // 
            // incluirToolStripMenuItem2
            // 
            incluirToolStripMenuItem2.Name = "incluirToolStripMenuItem2";
            incluirToolStripMenuItem2.Size = new Size(107, 22);
            incluirToolStripMenuItem2.Text = "&Incluir";
            // 
            // listarToolStripMenuItem2
            // 
            listarToolStripMenuItem2.Name = "listarToolStripMenuItem2";
            listarToolStripMenuItem2.Size = new Size(107, 22);
            listarToolStripMenuItem2.Text = "&Listar";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incluirToolStripMenuItem1, listarToolStripMenuItem1, nveisToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(145, 22);
            usuáriosToolStripMenuItem.Text = "&Usuários";
            // 
            // incluirToolStripMenuItem1
            // 
            incluirToolStripMenuItem1.Name = "incluirToolStripMenuItem1";
            incluirToolStripMenuItem1.Size = new Size(107, 22);
            incluirToolStripMenuItem1.Text = "&Incluir";
            incluirToolStripMenuItem1.Click += incluirToolStripMenuItem1_Click;
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new Size(107, 22);
            listarToolStripMenuItem1.Text = "&Listar";
            // 
            // nveisToolStripMenuItem
            // 
            nveisToolStripMenuItem.Name = "nveisToolStripMenuItem";
            nveisToolStripMenuItem.Size = new Size(107, 22);
            nveisToolStripMenuItem.Text = "&Níveis";
            nveisToolStripMenuItem.Click += nveisToolStripMenuItem_Click;
            // 
            // operaçãoToolStripMenuItem
            // 
            operaçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pedidosToolStripMenuItem });
            operaçãoToolStripMenuItem.Name = "operaçãoToolStripMenuItem";
            operaçãoToolStripMenuItem.Size = new Size(70, 20);
            operaçãoToolStripMenuItem.Text = "&Operação";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, consultarToolStripMenuItem, listarToolStripMenuItem3 });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(116, 22);
            pedidosToolStripMenuItem.Text = "&Pedidos";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(125, 22);
            novoToolStripMenuItem.Text = "&Novo";
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(125, 22);
            consultarToolStripMenuItem.Text = "&Consultar";
            // 
            // listarToolStripMenuItem3
            // 
            listarToolStripMenuItem3.Name = "listarToolStripMenuItem3";
            listarToolStripMenuItem3.Size = new Size(125, 22);
            listarToolStripMenuItem3.Text = "&Listar";
            // 
            // movimentoToolStripMenuItem
            // 
            movimentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caixaToolStripMenuItem, terminalToolStripMenuItem1, vendasToolStripMenuItem });
            movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            movimentoToolStripMenuItem.Size = new Size(81, 20);
            movimentoToolStripMenuItem.Text = "&Movimento";
            // 
            // caixaToolStripMenuItem
            // 
            caixaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, terminalToolStripMenuItem, consultarToolStripMenuItem1, relatórioToolStripMenuItem });
            caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            caixaToolStripMenuItem.Size = new Size(120, 22);
            caixaToolStripMenuItem.Text = "&Caixa";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(125, 22);
            abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // terminalToolStripMenuItem
            // 
            terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
            terminalToolStripMenuItem.Size = new Size(125, 22);
            terminalToolStripMenuItem.Text = "&Terminal";
            // 
            // consultarToolStripMenuItem1
            // 
            consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            consultarToolStripMenuItem1.Size = new Size(125, 22);
            consultarToolStripMenuItem1.Text = "&Consultar";
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(125, 22);
            relatórioToolStripMenuItem.Text = "&Relatório";
            // 
            // terminalToolStripMenuItem1
            // 
            terminalToolStripMenuItem1.Name = "terminalToolStripMenuItem1";
            terminalToolStripMenuItem1.Size = new Size(120, 22);
            terminalToolStripMenuItem1.Text = "&Terminal";
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarToolStripMenuItem2, emitirNotaToolStripMenuItem });
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(120, 22);
            vendasToolStripMenuItem.Text = "&Vendas";
            // 
            // consultarToolStripMenuItem2
            // 
            consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            consultarToolStripMenuItem2.Size = new Size(134, 22);
            consultarToolStripMenuItem2.Text = "&Consultar";
            // 
            // emitirNotaToolStripMenuItem
            // 
            emitirNotaToolStripMenuItem.Name = "emitirNotaToolStripMenuItem";
            emitirNotaToolStripMenuItem.Size = new Size(134, 22);
            emitirNotaToolStripMenuItem.Text = "&Emitir Nota";
            // 
            // conficraçõesToolStripMenuItem
            // 
            conficraçõesToolStripMenuItem.Name = "conficraçõesToolStripMenuItem";
            conficraçõesToolStripMenuItem.Size = new Size(96, 20);
            conficraçõesToolStripMenuItem.Text = "Con&figurações";
            conficraçõesToolStripMenuItem.Click += conficraçõesToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.Size = new Size(71, 20);
            sairToolStripMenuItem1.Text = "&Relatórios";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "&Sair";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslUsuarioLogado, toolStripDropDownButton1 });
            statusStrip1.Location = new Point(0, 637);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1356, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslUsuarioLogado
            // 
            tsslUsuarioLogado.Name = "tsslUsuarioLogado";
            tsslUsuarioLogado.Size = new Size(12, 17);
            tsslUsuarioLogado.Text = "-";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { trocarDeUsuárioToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 20);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // trocarDeUsuárioToolStripMenuItem
            // 
            trocarDeUsuárioToolStripMenuItem.Name = "trocarDeUsuárioToolStripMenuItem";
            trocarDeUsuárioToolStripMenuItem.Size = new Size(166, 22);
            trocarDeUsuárioToolStripMenuItem.Text = "Trocar de Usuário";
            trocarDeUsuárioToolStripMenuItem.Click += trocarDeUsuárioToolStripMenuItem_Click;
            // 
            // pnlCentral
            // 
            pnlCentral.Location = new Point(117, 27);
            pnlCentral.Name = "pnlCentral";
            pnlCentral.Size = new Size(1044, 517);
            pnlCentral.TabIndex = 4;
            pnlCentral.Visible = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 659);
            Controls.Add(pnlCentral);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Sistema Comercial TDS T01";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslUsuarioLogado;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem trocarDeUsuárioToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem operaçãoToolStripMenuItem;
        private ToolStripMenuItem movimentoToolStripMenuItem;
        private ToolStripMenuItem conficraçõesToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem incluirToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem forncedorToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem incluirToolStripMenuItem2;
        private ToolStripMenuItem listarToolStripMenuItem2;
        private ToolStripMenuItem incluirToolStripMenuItem1;
        private ToolStripMenuItem listarToolStripMenuItem1;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem nveisToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem3;
        private ToolStripMenuItem caixaToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem terminalToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem1;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem1;
        private ToolStripMenuItem terminalToolStripMenuItem1;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem2;
        private ToolStripMenuItem emitirNotaToolStripMenuItem;
        private Panel pnlCentral;
    }
}