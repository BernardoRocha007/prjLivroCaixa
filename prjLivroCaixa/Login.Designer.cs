namespace prjLivroCaixa
{
    partial class Login
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.btAcesso = new System.Windows.Forms.Button();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.pnTrocaSenha = new System.Windows.Forms.Panel();
            this.btOkPainel = new System.Windows.Forms.Button();
            this.tbSenhaB = new System.Windows.Forms.TextBox();
            this.lbTituloTrocaSenha = new System.Windows.Forms.Label();
            this.tbSenhaA = new System.Windows.Forms.TextBox();
            this.lbSenhaB = new System.Windows.Forms.Label();
            this.lbSenhaA = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.OpCadUser = new System.Windows.Forms.ToolStripMenuItem();
            this.OpFluxoCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.btSair = new System.Windows.Forms.Button();
            this.pnTrocaSenha.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(147, 84);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(48, 20);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login";
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(147, 115);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(56, 20);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha";
            this.lbSenha.Click += new System.EventHandler(this.lbSenha_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(201, 84);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(86, 20);
            this.tbLogin.TabIndex = 2;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(201, 115);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(86, 20);
            this.tbSenha.TabIndex = 3;
            this.tbSenha.TextChanged += new System.EventHandler(this.tbSenha_TextChanged);
            // 
            // btAcesso
            // 
            this.btAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcesso.Location = new System.Drawing.Point(192, 151);
            this.btAcesso.Name = "btAcesso";
            this.btAcesso.Size = new System.Drawing.Size(75, 31);
            this.btAcesso.TabIndex = 4;
            this.btAcesso.Text = "Acessar";
            this.btAcesso.UseVisualStyleBackColor = true;
            this.btAcesso.Click += new System.EventHandler(this.btAcesso_Click);
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagem.Location = new System.Drawing.Point(44, 398);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(17, 24);
            this.lbMensagem.TabIndex = 5;
            this.lbMensagem.Text = "*";
            // 
            // pnTrocaSenha
            // 
            this.pnTrocaSenha.Controls.Add(this.btOkPainel);
            this.pnTrocaSenha.Controls.Add(this.tbSenhaB);
            this.pnTrocaSenha.Controls.Add(this.lbTituloTrocaSenha);
            this.pnTrocaSenha.Controls.Add(this.tbSenhaA);
            this.pnTrocaSenha.Controls.Add(this.lbSenhaB);
            this.pnTrocaSenha.Controls.Add(this.lbSenhaA);
            this.pnTrocaSenha.Location = new System.Drawing.Point(151, 207);
            this.pnTrocaSenha.Name = "pnTrocaSenha";
            this.pnTrocaSenha.Size = new System.Drawing.Size(313, 166);
            this.pnTrocaSenha.TabIndex = 6;
            this.pnTrocaSenha.Visible = false;
            this.pnTrocaSenha.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTrocaSenha_Paint);
            // 
            // btOkPainel
            // 
            this.btOkPainel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOkPainel.Location = new System.Drawing.Point(50, 111);
            this.btOkPainel.Name = "btOkPainel";
            this.btOkPainel.Size = new System.Drawing.Size(156, 31);
            this.btOkPainel.TabIndex = 8;
            this.btOkPainel.Text = "Confirmar";
            this.btOkPainel.UseVisualStyleBackColor = true;
            this.btOkPainel.Click += new System.EventHandler(this.btOkPainel_Click);
            // 
            // tbSenhaB
            // 
            this.tbSenhaB.Location = new System.Drawing.Point(120, 67);
            this.tbSenhaB.Name = "tbSenhaB";
            this.tbSenhaB.PasswordChar = '*';
            this.tbSenhaB.Size = new System.Drawing.Size(86, 20);
            this.tbSenhaB.TabIndex = 11;
            // 
            // lbTituloTrocaSenha
            // 
            this.lbTituloTrocaSenha.AutoSize = true;
            this.lbTituloTrocaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloTrocaSenha.ForeColor = System.Drawing.Color.Crimson;
            this.lbTituloTrocaSenha.Location = new System.Drawing.Point(3, 9);
            this.lbTituloTrocaSenha.Name = "lbTituloTrocaSenha";
            this.lbTituloTrocaSenha.Size = new System.Drawing.Size(296, 24);
            this.lbTituloTrocaSenha.TabIndex = 8;
            this.lbTituloTrocaSenha.Text = "Primeiro acesso,troque sua senha";
            // 
            // tbSenhaA
            // 
            this.tbSenhaA.Location = new System.Drawing.Point(120, 36);
            this.tbSenhaA.Name = "tbSenhaA";
            this.tbSenhaA.PasswordChar = '*';
            this.tbSenhaA.Size = new System.Drawing.Size(86, 20);
            this.tbSenhaA.TabIndex = 10;
            // 
            // lbSenhaB
            // 
            this.lbSenhaB.AutoSize = true;
            this.lbSenhaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenhaB.Location = new System.Drawing.Point(47, 67);
            this.lbSenhaB.Name = "lbSenhaB";
            this.lbSenhaB.Size = new System.Drawing.Size(75, 20);
            this.lbSenhaB.TabIndex = 9;
            this.lbSenhaB.Text = "Senha B:";
            // 
            // lbSenhaA
            // 
            this.lbSenhaA.AutoSize = true;
            this.lbSenhaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenhaA.Location = new System.Drawing.Point(47, 36);
            this.lbSenhaA.Name = "lbSenhaA";
            this.lbSenhaA.Size = new System.Drawing.Size(75, 20);
            this.lbSenhaA.TabIndex = 8;
            this.lbSenhaA.Text = "Senha A:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.Crimson;
            this.lbTitulo.Location = new System.Drawing.Point(255, 35);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(57, 24);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "Login";
            this.lbTitulo.Click += new System.EventHandler(this.lbTitulo_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpCadUser,
            this.OpFluxoCaixa});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(580, 24);
            this.menu.TabIndex = 8;
            this.menu.Text = "menuStrip1";
            this.menu.Visible = false;
            // 
            // OpCadUser
            // 
            this.OpCadUser.Name = "OpCadUser";
            this.OpCadUser.Size = new System.Drawing.Size(66, 20);
            this.OpCadUser.Text = "Cad User";
            this.OpCadUser.Click += new System.EventHandler(this.OpCadUser_Click);
            // 
            // OpFluxoCaixa
            // 
            this.OpFluxoCaixa.Name = "OpFluxoCaixa";
            this.OpFluxoCaixa.Size = new System.Drawing.Size(96, 20);
            this.OpFluxoCaixa.Text = "Fluxo de Caixa";
            this.OpFluxoCaixa.Click += new System.EventHandler(this.OpFluxoCaixa_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(493, 415);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.pnTrocaSenha);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.btAcesso);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnTrocaSenha.ResumeLayout(false);
            this.pnTrocaSenha.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Button btAcesso;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.Panel pnTrocaSenha;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbTituloTrocaSenha;
        private System.Windows.Forms.Button btOkPainel;
        private System.Windows.Forms.TextBox tbSenhaB;
        private System.Windows.Forms.TextBox tbSenhaA;
        private System.Windows.Forms.Label lbSenhaB;
        private System.Windows.Forms.Label lbSenhaA;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem OpCadUser;
        private System.Windows.Forms.ToolStripMenuItem OpFluxoCaixa;
        private System.Windows.Forms.Button btSair;
    }
}