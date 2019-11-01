namespace Criptografia
{
    partial class Criptografia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbChave = new System.Windows.Forms.TextBox();
            this.txbTexto = new System.Windows.Forms.TextBox();
            this.txbCifrado = new System.Windows.Forms.TextBox();
            this.lblMostra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDigita = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radCodificar = new System.Windows.Forms.RadioButton();
            this.radDescodificar = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnExecutar);
            this.panel1.Controls.Add(this.txbChave);
            this.panel1.Controls.Add(this.txbTexto);
            this.panel1.Controls.Add(this.txbCifrado);
            this.panel1.Controls.Add(this.lblMostra);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblDigita);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 392);
            this.panel1.TabIndex = 1;
            // 
            // txbChave
            // 
            this.txbChave.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F);
            this.txbChave.Location = new System.Drawing.Point(189, 102);
            this.txbChave.Name = "txbChave";
            this.txbChave.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txbChave.Size = new System.Drawing.Size(347, 30);
            this.txbChave.TabIndex = 1;
            // 
            // txbTexto
            // 
            this.txbTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txbTexto.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F);
            this.txbTexto.Location = new System.Drawing.Point(52, 209);
            this.txbTexto.Multiline = true;
            this.txbTexto.Name = "txbTexto";
            this.txbTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbTexto.Size = new System.Drawing.Size(338, 116);
            this.txbTexto.TabIndex = 2;
            // 
            // txbCifrado
            // 
            this.txbCifrado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F);
            this.txbCifrado.Location = new System.Drawing.Point(427, 209);
            this.txbCifrado.Multiline = true;
            this.txbCifrado.Name = "txbCifrado";
            this.txbCifrado.ReadOnly = true;
            this.txbCifrado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbCifrado.Size = new System.Drawing.Size(338, 116);
            this.txbCifrado.TabIndex = 5;
            // 
            // lblMostra
            // 
            this.lblMostra.AutoSize = true;
            this.lblMostra.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F);
            this.lblMostra.Location = new System.Drawing.Point(423, 170);
            this.lblMostra.Name = "lblMostra";
            this.lblMostra.Size = new System.Drawing.Size(113, 22);
            this.lblMostra.TabIndex = 4;
            this.lblMostra.Text = "Texto cifrado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F);
            this.label3.Location = new System.Drawing.Point(48, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite a chave:";
            // 
            // lblDigita
            // 
            this.lblDigita.AutoSize = true;
            this.lblDigita.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F);
            this.lblDigita.Location = new System.Drawing.Point(48, 170);
            this.lblDigita.Name = "lblDigita";
            this.lblDigita.Size = new System.Drawing.Size(227, 22);
            this.lblDigita.TabIndex = 2;
            this.lblDigita.Text = "Digite texto a ser codificado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F);
            this.label1.Location = new System.Drawing.Point(227, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Método de  Vigenère";
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F);
            this.btnExecutar.Location = new System.Drawing.Point(638, 346);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(127, 29);
            this.btnExecutar.TabIndex = 3;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radDescodificar);
            this.panel2.Controls.Add(this.radCodificar);
            this.panel2.Location = new System.Drawing.Point(580, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 88);
            this.panel2.TabIndex = 9;
            // 
            // radCodificar
            // 
            this.radCodificar.AutoSize = true;
            this.radCodificar.Checked = true;
            this.radCodificar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F);
            this.radCodificar.Location = new System.Drawing.Point(18, 16);
            this.radCodificar.Name = "radCodificar";
            this.radCodificar.Size = new System.Drawing.Size(98, 26);
            this.radCodificar.TabIndex = 0;
            this.radCodificar.TabStop = true;
            this.radCodificar.Text = "Codificar";
            this.radCodificar.UseVisualStyleBackColor = true;
            this.radCodificar.Click += new System.EventHandler(this.radCodificar_Click);
            // 
            // radDescodificar
            // 
            this.radDescodificar.AutoSize = true;
            this.radDescodificar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F);
            this.radDescodificar.Location = new System.Drawing.Point(18, 48);
            this.radDescodificar.Name = "radDescodificar";
            this.radDescodificar.Size = new System.Drawing.Size(123, 26);
            this.radDescodificar.TabIndex = 1;
            this.radDescodificar.Text = "Descodificar";
            this.radDescodificar.UseVisualStyleBackColor = true;
            this.radDescodificar.Click += new System.EventHandler(this.radDescodificar_Click);
            // 
            // Criptografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Criptografia";
            this.Text = "Criptografia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDigita;
        private System.Windows.Forms.TextBox txbChave;
        private System.Windows.Forms.TextBox txbTexto;
        private System.Windows.Forms.Label lblMostra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radDescodificar;
        private System.Windows.Forms.RadioButton radCodificar;
        private System.Windows.Forms.TextBox txbCifrado;
    }
}

