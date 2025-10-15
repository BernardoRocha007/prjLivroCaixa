namespace prjLivroCaixa
{
    partial class frmCadUser
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.rbAdm = new System.Windows.Forms.RadioButton();
            this.btOk = new System.Windows.Forms.Button();
            this.tbRelatorio = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.Crimson;
            this.lbTitulo.Location = new System.Drawing.Point(218, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(360, 39);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Cadastro de usuários";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(12, 55);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(85, 25);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome :  ";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.Location = new System.Drawing.Point(168, 55);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(68, 25);
            this.lbCpf.TabIndex = 2;
            this.lbCpf.Text = "CPF : ";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(297, 55);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(71, 25);
            this.lbLogin.TabIndex = 3;
            this.lbLogin.Text = "Login :";
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfil.Location = new System.Drawing.Point(475, 55);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(66, 25);
            this.lbPerfil.TabIndex = 4;
            this.lbPerfil.Text = "Perfil :";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(17, 83);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(128, 20);
            this.tbNome.TabIndex = 5;
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(173, 83);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(108, 20);
            this.tbCpf.TabIndex = 6;
           
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(302, 83);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(133, 20);
            this.tbLogin.TabIndex = 7;
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUsuario.Location = new System.Drawing.Point(551, 86);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(75, 21);
            this.rbUsuario.TabIndex = 8;
            this.rbUsuario.TabStop = true;
            this.rbUsuario.Text = "Usuário";
            this.rbUsuario.UseVisualStyleBackColor = true;
            // 
            // rbAdm
            // 
            this.rbAdm.AutoSize = true;
            this.rbAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdm.Location = new System.Drawing.Point(480, 86);
            this.rbAdm.Name = "rbAdm";
            this.rbAdm.Size = new System.Drawing.Size(65, 21);
            this.rbAdm.TabIndex = 9;
            this.rbAdm.TabStop = true;
            this.rbAdm.Text = "Admin";
            this.rbAdm.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Location = new System.Drawing.Point(632, 80);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(104, 31);
            this.btOk.TabIndex = 10;
            this.btOk.Text = "Cadastrar";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // tbRelatorio
            // 
            this.tbRelatorio.Location = new System.Drawing.Point(17, 119);
            this.tbRelatorio.Multiline = true;
            this.tbRelatorio.Name = "tbRelatorio";
            this.tbRelatorio.ReadOnly = true;
            this.tbRelatorio.Size = new System.Drawing.Size(816, 276);
            this.tbRelatorio.TabIndex = 11;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(669, 407);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(85, 31);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.Location = new System.Drawing.Point(26, 408);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(20, 25);
            this.lbMensagem.TabIndex = 14;
            this.lbMensagem.Text = "*";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(742, 86);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(46, 20);
            this.tbBuscar.TabIndex = 15;
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(794, 86);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(55, 21);
            this.btBuscar.TabIndex = 16;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(760, 407);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(73, 31);
            this.btExcluir.TabIndex = 18;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // frmCadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbRelatorio);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.rbAdm);
            this.Controls.Add(this.rbUsuario);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbPerfil);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbTitulo);
            this.Name = "frmCadUser";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmCadUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbPerfil;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.RadioButton rbUsuario;
        private System.Windows.Forms.RadioButton rbAdm;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox tbRelatorio;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btExcluir;
    }
}

