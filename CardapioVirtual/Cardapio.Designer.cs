namespace CardapioVirtual
{
    partial class cardapio
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
            this.grbAcoes = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnResumo = new System.Windows.Forms.Button();
            this.btnGravaTXT = new System.Windows.Forms.Button();
            this.btnGravaXML = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.tabControl_Detalhes = new System.Windows.Forms.TabControl();
            this.tbpDados = new System.Windows.Forms.TabPage();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnMandaItens = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.grbPedido = new System.Windows.Forms.GroupBox();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.tbpItens = new System.Windows.Forms.TabPage();
            this.grbItens = new System.Windows.Forms.GroupBox();
            this.tbpPedidos = new System.Windows.Forms.TabPage();
            this.grbResumo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbAcoes.SuspendLayout();
            this.tabControl_Detalhes.SuspendLayout();
            this.tbpDados.SuspendLayout();
            this.grbDados.SuspendLayout();
            this.grbPedido.SuspendLayout();
            this.tbpItens.SuspendLayout();
            this.tbpPedidos.SuspendLayout();
            this.grbResumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAcoes
            // 
            this.grbAcoes.BackColor = System.Drawing.Color.Khaki;
            this.grbAcoes.Controls.Add(this.btnCancelar);
            this.grbAcoes.Controls.Add(this.btnFechar);
            this.grbAcoes.Controls.Add(this.btnResumo);
            this.grbAcoes.Controls.Add(this.btnGravaTXT);
            this.grbAcoes.Controls.Add(this.btnGravaXML);
            this.grbAcoes.Controls.Add(this.btnNovoPedido);
            this.grbAcoes.Location = new System.Drawing.Point(12, 12);
            this.grbAcoes.Name = "grbAcoes";
            this.grbAcoes.Size = new System.Drawing.Size(931, 125);
            this.grbAcoes.TabIndex = 0;
            this.grbAcoes.TabStop = false;
            this.grbAcoes.Text = "Ações";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Gold;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(780, 25);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(121, 80);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnResumo
            // 
            this.btnResumo.BackColor = System.Drawing.Color.Gold;
            this.btnResumo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResumo.FlatAppearance.BorderSize = 0;
            this.btnResumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btnResumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumo.Location = new System.Drawing.Point(480, 25);
            this.btnResumo.Name = "btnResumo";
            this.btnResumo.Size = new System.Drawing.Size(121, 80);
            this.btnResumo.TabIndex = 3;
            this.btnResumo.Text = "Resumo dos Pedidos";
            this.btnResumo.UseVisualStyleBackColor = false;
            this.btnResumo.Click += new System.EventHandler(this.btnResumo_Click);
            // 
            // btnGravaTXT
            // 
            this.btnGravaTXT.BackColor = System.Drawing.Color.Gold;
            this.btnGravaTXT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGravaTXT.FlatAppearance.BorderSize = 0;
            this.btnGravaTXT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btnGravaTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravaTXT.Location = new System.Drawing.Point(330, 25);
            this.btnGravaTXT.Name = "btnGravaTXT";
            this.btnGravaTXT.Size = new System.Drawing.Size(121, 80);
            this.btnGravaTXT.TabIndex = 2;
            this.btnGravaTXT.Text = "&Gravar Pedido em TXT";
            this.btnGravaTXT.UseVisualStyleBackColor = false;
            this.btnGravaTXT.Click += new System.EventHandler(this.btnGravaTXT_Click);
            // 
            // btnGravaXML
            // 
            this.btnGravaXML.BackColor = System.Drawing.Color.Gold;
            this.btnGravaXML.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGravaXML.FlatAppearance.BorderSize = 0;
            this.btnGravaXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btnGravaXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravaXML.Location = new System.Drawing.Point(180, 25);
            this.btnGravaXML.Name = "btnGravaXML";
            this.btnGravaXML.Size = new System.Drawing.Size(121, 80);
            this.btnGravaXML.TabIndex = 1;
            this.btnGravaXML.Text = "&Gravar Pedido em XML";
            this.btnGravaXML.UseVisualStyleBackColor = false;
            this.btnGravaXML.Click += new System.EventHandler(this.btnGravaXML_Click);
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackColor = System.Drawing.Color.Gold;
            this.btnNovoPedido.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovoPedido.FlatAppearance.BorderSize = 0;
            this.btnNovoPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btnNovoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoPedido.Location = new System.Drawing.Point(30, 25);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(121, 80);
            this.btnNovoPedido.TabIndex = 0;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = false;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // tabControl_Detalhes
            // 
            this.tabControl_Detalhes.Controls.Add(this.tbpDados);
            this.tabControl_Detalhes.Controls.Add(this.tbpItens);
            this.tabControl_Detalhes.Controls.Add(this.tbpPedidos);
            this.tabControl_Detalhes.Enabled = false;
            this.tabControl_Detalhes.Location = new System.Drawing.Point(12, 154);
            this.tabControl_Detalhes.Name = "tabControl_Detalhes";
            this.tabControl_Detalhes.SelectedIndex = 0;
            this.tabControl_Detalhes.Size = new System.Drawing.Size(931, 501);
            this.tabControl_Detalhes.TabIndex = 6;
            // 
            // tbpDados
            // 
            this.tbpDados.BackColor = System.Drawing.SystemColors.Control;
            this.tbpDados.Controls.Add(this.grbDados);
            this.tbpDados.Location = new System.Drawing.Point(4, 29);
            this.tbpDados.Name = "tbpDados";
            this.tbpDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDados.Size = new System.Drawing.Size(923, 468);
            this.tbpDados.TabIndex = 0;
            this.tbpDados.Text = "Dados";
            // 
            // grbDados
            // 
            this.grbDados.BackColor = System.Drawing.Color.Khaki;
            this.grbDados.Controls.Add(this.dtpData);
            this.grbDados.Controls.Add(this.btnMandaItens);
            this.grbDados.Controls.Add(this.lblData);
            this.grbDados.Controls.Add(this.txtObs);
            this.grbDados.Controls.Add(this.lblObs);
            this.grbDados.Controls.Add(this.txtCliente);
            this.grbDados.Controls.Add(this.lblCliente);
            this.grbDados.Controls.Add(this.grbPedido);
            this.grbDados.Controls.Add(this.lblPedido);
            this.grbDados.Location = new System.Drawing.Point(3, 6);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(917, 462);
            this.grbDados.TabIndex = 6;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // dtpData
            // 
            this.dtpData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dtpData.Location = new System.Drawing.Point(200, 339);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(419, 26);
            this.dtpData.TabIndex = 8;
            this.dtpData.Value = new System.DateTime(2025, 4, 15, 11, 50, 12, 0);
            // 
            // btnMandaItens
            // 
            this.btnMandaItens.BackColor = System.Drawing.SystemColors.Control;
            this.btnMandaItens.FlatAppearance.BorderSize = 0;
            this.btnMandaItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMandaItens.Location = new System.Drawing.Point(773, 394);
            this.btnMandaItens.Name = "btnMandaItens";
            this.btnMandaItens.Size = new System.Drawing.Size(130, 53);
            this.btnMandaItens.TabIndex = 7;
            this.btnMandaItens.Text = "Lançar Itens ->";
            this.btnMandaItens.UseVisualStyleBackColor = false;
            this.btnMandaItens.Click += new System.EventHandler(this.btnMandaItens_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblData.Location = new System.Drawing.Point(108, 339);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(73, 29);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data:";
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtObs.Location = new System.Drawing.Point(200, 184);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(419, 110);
            this.txtObs.TabIndex = 5;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblObs.Location = new System.Drawing.Point(108, 184);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(73, 29);
            this.lblObs.TabIndex = 4;
            this.lblObs.Text = "OBS:";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCliente.Location = new System.Drawing.Point(200, 111);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(419, 44);
            this.txtCliente.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCliente.Location = new System.Drawing.Point(82, 120);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(99, 29);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            // 
            // grbPedido
            // 
            this.grbPedido.BackColor = System.Drawing.Color.Transparent;
            this.grbPedido.Controls.Add(this.lblNumeroPedido);
            this.grbPedido.Location = new System.Drawing.Point(200, 23);
            this.grbPedido.Name = "grbPedido";
            this.grbPedido.Size = new System.Drawing.Size(155, 65);
            this.grbPedido.TabIndex = 1;
            this.grbPedido.TabStop = false;
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNumeroPedido.Location = new System.Drawing.Point(59, 17);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(36, 39);
            this.lblNumeroPedido.TabIndex = 2;
            this.lblNumeroPedido.Text = "?";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPedido.Location = new System.Drawing.Point(55, 47);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(126, 29);
            this.lblPedido.TabIndex = 0;
            this.lblPedido.Text = "Pedido Nº";
            // 
            // tbpItens
            // 
            this.tbpItens.BackColor = System.Drawing.SystemColors.Control;
            this.tbpItens.Controls.Add(this.grbItens);
            this.tbpItens.Location = new System.Drawing.Point(4, 29);
            this.tbpItens.Name = "tbpItens";
            this.tbpItens.Padding = new System.Windows.Forms.Padding(3);
            this.tbpItens.Size = new System.Drawing.Size(923, 468);
            this.tbpItens.TabIndex = 1;
            this.tbpItens.Text = "Itens";
            // 
            // grbItens
            // 
            this.grbItens.BackColor = System.Drawing.Color.Khaki;
            this.grbItens.Location = new System.Drawing.Point(3, 6);
            this.grbItens.Name = "grbItens";
            this.grbItens.Size = new System.Drawing.Size(917, 462);
            this.grbItens.TabIndex = 7;
            this.grbItens.TabStop = false;
            this.grbItens.Text = "Itens";
            // 
            // tbpPedidos
            // 
            this.tbpPedidos.BackColor = System.Drawing.SystemColors.Control;
            this.tbpPedidos.Controls.Add(this.grbResumo);
            this.tbpPedidos.Location = new System.Drawing.Point(4, 29);
            this.tbpPedidos.Name = "tbpPedidos";
            this.tbpPedidos.Size = new System.Drawing.Size(923, 468);
            this.tbpPedidos.TabIndex = 2;
            this.tbpPedidos.Text = "Resumo dos Pedidos";
            // 
            // grbResumo
            // 
            this.grbResumo.BackColor = System.Drawing.Color.Khaki;
            this.grbResumo.Controls.Add(this.label1);
            this.grbResumo.Location = new System.Drawing.Point(3, 6);
            this.grbResumo.Name = "grbResumo";
            this.grbResumo.Size = new System.Drawing.Size(917, 462);
            this.grbResumo.TabIndex = 8;
            this.grbResumo.TabStop = false;
            this.grbResumo.Text = "Resumos dos Pedidos";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(77, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 321);
            this.label1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gold;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(630, 25);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 80);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(956, 667);
            this.Controls.Add(this.tabControl_Detalhes);
            this.Controls.Add(this.grbAcoes);
            this.Name = "cardapio";
            this.Text = "                                  ";
            this.grbAcoes.ResumeLayout(false);
            this.tabControl_Detalhes.ResumeLayout(false);
            this.tbpDados.ResumeLayout(false);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.grbPedido.ResumeLayout(false);
            this.grbPedido.PerformLayout();
            this.tbpItens.ResumeLayout(false);
            this.tbpPedidos.ResumeLayout(false);
            this.grbResumo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAcoes;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnResumo;
        private System.Windows.Forms.Button btnGravaTXT;
        private System.Windows.Forms.Button btnGravaXML;
        private System.Windows.Forms.TabControl tabControl_Detalhes;
        private System.Windows.Forms.TabPage tbpDados;
        private System.Windows.Forms.TabPage tbpItens;
        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.GroupBox grbItens;
        private System.Windows.Forms.TabPage tbpPedidos;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox grbPedido;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnMandaItens;
        private System.Windows.Forms.GroupBox grbResumo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
    }
}

