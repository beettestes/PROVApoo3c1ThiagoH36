namespace _3c1ThiagoHenrique46
{
    partial class Form1
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
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.inserir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.excluir = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.listar = new System.Windows.Forms.Button();
            this.NOMEtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PRECOtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID do brinquedo:";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(447, 12);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(100, 20);
            this.IDtxt.TabIndex = 1;
            // 
            // inserir
            // 
            this.inserir.Location = new System.Drawing.Point(15, 63);
            this.inserir.Name = "inserir";
            this.inserir.Size = new System.Drawing.Size(100, 36);
            this.inserir.TabIndex = 2;
            this.inserir.Text = "Inserir";
            this.inserir.UseVisualStyleBackColor = true;
            this.inserir.Click += new System.EventHandler(this.inserir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 173);
            this.dataGridView1.TabIndex = 3;
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(343, 63);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(204, 36);
            this.excluir.TabIndex = 4;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(227, 63);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(100, 36);
            this.editar.TabIndex = 5;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // listar
            // 
            this.listar.Location = new System.Drawing.Point(121, 63);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(100, 36);
            this.listar.TabIndex = 6;
            this.listar.Text = "Listar";
            this.listar.UseVisualStyleBackColor = true;
            this.listar.Click += new System.EventHandler(this.listar_Click);
            // 
            // NOMEtxt
            // 
            this.NOMEtxt.Location = new System.Drawing.Point(121, 12);
            this.NOMEtxt.Name = "NOMEtxt";
            this.NOMEtxt.Size = new System.Drawing.Size(208, 20);
            this.NOMEtxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do brinquedo:";
            // 
            // PRECOtxt
            // 
            this.PRECOtxt.Location = new System.Drawing.Point(121, 38);
            this.PRECOtxt.Name = "PRECOtxt";
            this.PRECOtxt.Size = new System.Drawing.Size(208, 20);
            this.PRECOtxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Preço do brinquedo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 297);
            this.Controls.Add(this.PRECOtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NOMEtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inserir);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Button inserir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button listar;
        private System.Windows.Forms.TextBox NOMEtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PRECOtxt;
        private System.Windows.Forms.Label label3;
    }
}

