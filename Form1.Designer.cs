namespace _221048
{
    partial class TecnoMarket
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelVendaAtual = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxValorUnitario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxQuantidadeItemSelecionado = new System.Windows.Forms.TextBox();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonSalvarVenda = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
            // 
            // labelVendaAtual
            // 
            this.labelVendaAtual.AutoSize = true;
            this.labelVendaAtual.Location = new System.Drawing.Point(90, 9);
            this.labelVendaAtual.Name = "labelVendaAtual";
            this.labelVendaAtual.Size = new System.Drawing.Size(13, 13);
            this.labelVendaAtual.TabIndex = 3;
            this.labelVendaAtual.Text = "1";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(93, 33);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(286, 20);
            this.textBoxDescricao.TabIndex = 4;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(93, 58);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantidade.TabIndex = 5;
            // 
            // textBoxValorUnitario
            // 
            this.textBoxValorUnitario.Location = new System.Drawing.Point(93, 84);
            this.textBoxValorUnitario.Name = "textBoxValorUnitario";
            this.textBoxValorUnitario.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorUnitario.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor Unitário:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descrição,
            this.Quantidade,
            this.ValorUnitário});
            this.dataGridView.Location = new System.Drawing.Point(12, 113);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(367, 151);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // ValorUnitário
            // 
            this.ValorUnitário.HeaderText = "Valor Unitário";
            this.ValorUnitário.Name = "ValorUnitário";
            this.ValorUnitário.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quantidade do Item Selecionado:";
            // 
            // textBoxQuantidadeItemSelecionado
            // 
            this.textBoxQuantidadeItemSelecionado.Location = new System.Drawing.Point(180, 280);
            this.textBoxQuantidadeItemSelecionado.Name = "textBoxQuantidadeItemSelecionado";
            this.textBoxQuantidadeItemSelecionado.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantidadeItemSelecionado.TabIndex = 12;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(304, 273);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 13;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(304, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 14;
            this.button4.Text = "Cancelar Venda";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonSalvarVenda
            // 
            this.buttonSalvarVenda.Location = new System.Drawing.Point(223, 347);
            this.buttonSalvarVenda.Name = "buttonSalvarVenda";
            this.buttonSalvarVenda.Size = new System.Drawing.Size(75, 37);
            this.buttonSalvarVenda.TabIndex = 15;
            this.buttonSalvarVenda.Text = "Salvar Venda";
            this.buttonSalvarVenda.UseVisualStyleBackColor = true;
            this.buttonSalvarVenda.Click += new System.EventHandler(this.buttonSalvarVenda_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(304, 347);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 37);
            this.buttonFechar.TabIndex = 16;
            this.buttonFechar.Text = "Fechar Sistema";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelValorTotal.Location = new System.Drawing.Point(164, 312);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(29, 31);
            this.labelValorTotal.TabIndex = 18;
            this.labelValorTotal.Text = "0";
            // 
            // TecnoMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 396);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonSalvarVenda);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.textBoxQuantidadeItemSelecionado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxValorUnitario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelVendaAtual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TecnoMarket";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVendaAtual;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.TextBox textBoxValorUnitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitário;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxQuantidadeItemSelecionado;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonSalvarVenda;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelValorTotal;
    }
}

