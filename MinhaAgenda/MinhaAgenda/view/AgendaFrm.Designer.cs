namespace MinhaAgenda
{
    partial class AgendaFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.informacaoLbl = new System.Windows.Forms.Label();
            this.adicionarBtn = new System.Windows.Forms.Button();
            this.removerBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.pesquisarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscarTodosBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(242, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.informacaoLbl);
            this.panel1.Location = new System.Drawing.Point(6, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 54);
            this.panel1.TabIndex = 1;
            // 
            // informacaoLbl
            // 
            this.informacaoLbl.AutoSize = true;
            this.informacaoLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacaoLbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.informacaoLbl.Location = new System.Drawing.Point(12, 9);
            this.informacaoLbl.Name = "informacaoLbl";
            this.informacaoLbl.Size = new System.Drawing.Size(47, 15);
            this.informacaoLbl.TabIndex = 0;
            this.informacaoLbl.Text = "label2";
            this.informacaoLbl.Visible = false;
            // 
            // adicionarBtn
            // 
            this.adicionarBtn.Location = new System.Drawing.Point(12, 87);
            this.adicionarBtn.Name = "adicionarBtn";
            this.adicionarBtn.Size = new System.Drawing.Size(142, 23);
            this.adicionarBtn.TabIndex = 3;
            this.adicionarBtn.Text = "Adicionar";
            this.adicionarBtn.UseVisualStyleBackColor = true;
            this.adicionarBtn.Click += new System.EventHandler(this.adicionarBtn_Click);
            this.adicionarBtn.MouseEnter += new System.EventHandler(this.adicionarBtn_MouseEnter);
            this.adicionarBtn.MouseLeave += new System.EventHandler(this.adicionarBtn_MouseLeave);
            // 
            // removerBtn
            // 
            this.removerBtn.Location = new System.Drawing.Point(160, 87);
            this.removerBtn.Name = "removerBtn";
            this.removerBtn.Size = new System.Drawing.Size(139, 23);
            this.removerBtn.TabIndex = 4;
            this.removerBtn.Text = "Remover";
            this.removerBtn.UseVisualStyleBackColor = true;
            this.removerBtn.MouseEnter += new System.EventHandler(this.removerBtn_MouseEnter);
            this.removerBtn.MouseLeave += new System.EventHandler(this.removerBtn_MouseLeave);
            // 
            // editarBtn
            // 
            this.editarBtn.Location = new System.Drawing.Point(305, 87);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(138, 23);
            this.editarBtn.TabIndex = 5;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = true;
            this.editarBtn.MouseEnter += new System.EventHandler(this.editarBtn_MouseEnter);
            this.editarBtn.MouseLeave += new System.EventHandler(this.editarBtn_MouseLeave);
            // 
            // pesquisarBtn
            // 
            this.pesquisarBtn.Location = new System.Drawing.Point(449, 87);
            this.pesquisarBtn.Name = "pesquisarBtn";
            this.pesquisarBtn.Size = new System.Drawing.Size(126, 23);
            this.pesquisarBtn.TabIndex = 6;
            this.pesquisarBtn.Text = "Pesquisar";
            this.pesquisarBtn.UseVisualStyleBackColor = true;
            this.pesquisarBtn.Click += new System.EventHandler(this.pesquisarBtn_Click);
            this.pesquisarBtn.MouseEnter += new System.EventHandler(this.pesquisarBtn_MouseEnter);
            this.pesquisarBtn.MouseLeave += new System.EventHandler(this.pesquisarBtn_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 71);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // buscarTodosBtn
            // 
            this.buscarTodosBtn.Location = new System.Drawing.Point(12, 119);
            this.buscarTodosBtn.Name = "buscarTodosBtn";
            this.buscarTodosBtn.Size = new System.Drawing.Size(563, 23);
            this.buscarTodosBtn.TabIndex = 8;
            this.buscarTodosBtn.Text = "Ver contatos";
            this.buscarTodosBtn.UseVisualStyleBackColor = true;
            this.buscarTodosBtn.Click += new System.EventHandler(this.buscarTodosBtn_Click);
            // 
            // AgendaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 257);
            this.Controls.Add(this.buscarTodosBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pesquisarBtn);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.removerBtn);
            this.Controls.Add(this.adicionarBtn);
            this.Controls.Add(this.label1);
            this.Name = "AgendaFrm";
            this.Text = "Agenda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button adicionarBtn;
        private System.Windows.Forms.Button removerBtn;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Button pesquisarBtn;
        private System.Windows.Forms.Label informacaoLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buscarTodosBtn;
    }
}

