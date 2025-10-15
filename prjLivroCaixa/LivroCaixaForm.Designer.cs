namespace prjLivroCaixa
{
    partial class LivroCaixaForm
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
            this.tbRelatorio = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.rbDebito = new System.Windows.Forms.RadioButton();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbRelatorio
            // 
            this.tbRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRelatorio.Location = new System.Drawing.Point(9, 136);
            this.tbRelatorio.Multiline = true;
            this.tbRelatorio.Name = "tbRelatorio";
            this.tbRelatorio.ReadOnly = true;
            this.tbRelatorio.Size = new System.Drawing.Size(786, 286);
            this.tbRelatorio.TabIndex = 22;
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.ForeColor = System.Drawing.Color.Indigo;
            this.btOk.Location = new System.Drawing.Point(720, 85);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 43);
            this.btOk.TabIndex = 21;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // rbDebito
            // 
            this.rbDebito.AutoSize = true;
            this.rbDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDebito.ForeColor = System.Drawing.Color.Indigo;
            this.rbDebito.Location = new System.Drawing.Point(629, 106);
            this.rbDebito.Name = "rbDebito";
            this.rbDebito.Size = new System.Drawing.Size(80, 24);
            this.rbDebito.TabIndex = 20;
            this.rbDebito.TabStop = true;
            this.rbDebito.Text = "Débito";
            this.rbDebito.UseVisualStyleBackColor = true;
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCredito.ForeColor = System.Drawing.Color.Indigo;
            this.rbCredito.Location = new System.Drawing.Point(629, 76);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(85, 24);
            this.rbCredito.TabIndex = 19;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "Crédito";
            this.rbCredito.UseVisualStyleBackColor = true;
            // 
            // tbValor
            // 
            this.tbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValor.Location = new System.Drawing.Point(513, 93);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 26);
            this.tbValor.TabIndex = 18;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(116, 93);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(384, 26);
            this.tbDescricao.TabIndex = 17;
            // 
            // tbData
            // 
            this.tbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbData.Location = new System.Drawing.Point(9, 93);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(100, 26);
            this.tbData.TabIndex = 16;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.ForeColor = System.Drawing.Color.Indigo;
            this.lbValor.Location = new System.Drawing.Point(509, 66);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(54, 24);
            this.lbValor.TabIndex = 15;
            this.lbValor.Text = "Valor";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.ForeColor = System.Drawing.Color.Indigo;
            this.lbDescricao.Location = new System.Drawing.Point(112, 66);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(94, 24);
            this.lbDescricao.TabIndex = 14;
            this.lbDescricao.Text = "Descrição";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.Color.Indigo;
            this.lbData.Location = new System.Drawing.Point(5, 66);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(47, 24);
            this.lbData.TabIndex = 13;
            this.lbData.Text = "Data";
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.ForeColor = System.Drawing.Color.Indigo;
            this.lbMensagem.Location = new System.Drawing.Point(12, 425);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(17, 24);
            this.lbMensagem.TabIndex = 23;
            this.lbMensagem.Text = "*";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.Indigo;
            this.lbTitulo.Location = new System.Drawing.Point(32, 21);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(74, 29);
            this.lbTitulo.TabIndex = 24;
            this.lbTitulo.Text = "Titulo";
            // 
            // LivroCaixaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.tbRelatorio);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.rbDebito);
            this.Controls.Add(this.rbCredito);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.lbData);
            this.Name = "LivroCaixaForm";
            this.Text = "LivroCaixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRelatorio;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.RadioButton rbDebito;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.Label lbTitulo;
    }
}