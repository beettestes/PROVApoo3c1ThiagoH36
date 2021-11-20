
namespace _3c1THIAGOHENRIQUE46
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nometxt = new System.Windows.Forms.TextBox();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.precotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inserir = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.listar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID do brinquedo:";
            // 
            // Nometxt
            // 
            this.Nometxt.Location = new System.Drawing.Point(167, 46);
            this.Nometxt.Name = "Nometxt";
            this.Nometxt.Size = new System.Drawing.Size(154, 27);
            this.Nometxt.TabIndex = 1;
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(167, 13);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(154, 27);
            this.IDtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do brinquedo:";
            // 
            // precotxt
            // 
            this.precotxt.Location = new System.Drawing.Point(167, 79);
            this.precotxt.Name = "precotxt";
            this.precotxt.Size = new System.Drawing.Size(154, 27);
            this.precotxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço do brinquedo:";
            // 
            // inserir
            // 
            this.inserir.Location = new System.Drawing.Point(13, 120);
            this.inserir.Name = "inserir";
            this.inserir.Size = new System.Drawing.Size(148, 141);
            this.inserir.TabIndex = 6;
            this.inserir.Text = "inserir";
            this.inserir.UseVisualStyleBackColor = true;
            this.inserir.Click += new System.EventHandler(this.inserir_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(167, 120);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(154, 29);
            this.editar.TabIndex = 7;
            this.editar.Text = "editar";
            this.editar.UseVisualStyleBackColor = true;
            // 
            // listar
            // 
            this.listar.Location = new System.Drawing.Point(167, 155);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(154, 71);
            this.listar.TabIndex = 8;
            this.listar.Text = "listar";
            this.listar.UseVisualStyleBackColor = true;
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(167, 232);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(154, 29);
            this.excluir.TabIndex = 9;
            this.excluir.Text = "excluir";
            this.excluir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(503, 248);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 280);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.listar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.inserir);
            this.Controls.Add(this.precotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nometxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nometxt;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inserir;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button listar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

