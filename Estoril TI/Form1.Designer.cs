namespace Estoril_TI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAnotacoes = new System.Windows.Forms.Button();
            this.btnPlanilhas = new System.Windows.Forms.Button();
            this.btnSoftware = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblEstoril = new System.Windows.Forms.Label();
            this.pcboxLogo = new System.Windows.Forms.PictureBox();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panelMenu.Controls.Add(this.btnSair);
            this.panelMenu.Controls.Add(this.btnAnotacoes);
            this.panelMenu.Controls.Add(this.btnPlanilhas);
            this.panelMenu.Controls.Add(this.btnSoftware);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.lblEstoril);
            this.panelMenu.Controls.Add(this.pcboxLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 664);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(221)))), ((int)(((byte)(65)))));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(83, 600);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(55, 35);
            this.btnSair.TabIndex = 6;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAnotacoes
            // 
            this.btnAnotacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnotacoes.FlatAppearance.BorderSize = 0;
            this.btnAnotacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnotacoes.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnotacoes.ForeColor = System.Drawing.Color.White;
            this.btnAnotacoes.Location = new System.Drawing.Point(3, 398);
            this.btnAnotacoes.Name = "btnAnotacoes";
            this.btnAnotacoes.Size = new System.Drawing.Size(220, 55);
            this.btnAnotacoes.TabIndex = 5;
            this.btnAnotacoes.Text = "Anotações";
            this.btnAnotacoes.UseVisualStyleBackColor = true;
            this.btnAnotacoes.Click += new System.EventHandler(this.btnAnotacoes_Click);
            // 
            // btnPlanilhas
            // 
            this.btnPlanilhas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanilhas.FlatAppearance.BorderSize = 0;
            this.btnPlanilhas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanilhas.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanilhas.ForeColor = System.Drawing.Color.White;
            this.btnPlanilhas.Location = new System.Drawing.Point(3, 337);
            this.btnPlanilhas.Name = "btnPlanilhas";
            this.btnPlanilhas.Size = new System.Drawing.Size(220, 55);
            this.btnPlanilhas.TabIndex = 4;
            this.btnPlanilhas.Text = "Planilhas";
            this.btnPlanilhas.UseVisualStyleBackColor = true;
            this.btnPlanilhas.Click += new System.EventHandler(this.btnPlanilhas_Click);
            // 
            // btnSoftware
            // 
            this.btnSoftware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoftware.FlatAppearance.BorderSize = 0;
            this.btnSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftware.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoftware.ForeColor = System.Drawing.Color.White;
            this.btnSoftware.Location = new System.Drawing.Point(3, 276);
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.Size = new System.Drawing.Size(220, 55);
            this.btnSoftware.TabIndex = 3;
            this.btnSoftware.Text = "Softwares";
            this.btnSoftware.UseVisualStyleBackColor = true;
            this.btnSoftware.Click += new System.EventHandler(this.btnSoftware_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(3, 203);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(220, 55);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblEstoril
            // 
            this.lblEstoril.AutoSize = true;
            this.lblEstoril.Font = new System.Drawing.Font("Roboto Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoril.ForeColor = System.Drawing.Color.White;
            this.lblEstoril.Location = new System.Drawing.Point(57, 132);
            this.lblEstoril.Name = "lblEstoril";
            this.lblEstoril.Size = new System.Drawing.Size(107, 23);
            this.lblEstoril.TabIndex = 1;
            this.lblEstoril.Text = "T.I - Estoril";
            // 
            // pcboxLogo
            // 
            this.pcboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcboxLogo.Image")));
            this.pcboxLogo.Location = new System.Drawing.Point(47, 12);
            this.pcboxLogo.Name = "pcboxLogo";
            this.pcboxLogo.Size = new System.Drawing.Size(127, 107);
            this.pcboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcboxLogo.TabIndex = 0;
            this.pcboxLogo.TabStop = false;
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.Color.Black;
            this.panelInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicio.Location = new System.Drawing.Point(220, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(788, 664);
            this.panelInicio.TabIndex = 1;
            this.panelInicio.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInicio_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 664);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pcboxLogo;
        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Label lblEstoril;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnSoftware;
        private System.Windows.Forms.Button btnAnotacoes;
        private System.Windows.Forms.Button btnPlanilhas;
        private System.Windows.Forms.Button btnSair;
    }
}

