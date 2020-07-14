namespace Silabas
{
    partial class silabas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(silabas));
            this.lbSilabas = new System.Windows.Forms.Label();
            this.tbSilabas = new System.Windows.Forms.TextBox();
            this.btReproduzir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btVoltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSilabas
            // 
            this.lbSilabas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSilabas.AutoSize = true;
            this.lbSilabas.BackColor = System.Drawing.Color.White;
            this.lbSilabas.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSilabas.Location = new System.Drawing.Point(73, 36);
            this.lbSilabas.Name = "lbSilabas";
            this.lbSilabas.Size = new System.Drawing.Size(267, 34);
            this.lbSilabas.TabIndex = 0;
            this.lbSilabas.Text = "Digite uma Sílaba:";
            this.lbSilabas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbSilabas
            // 
            this.tbSilabas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSilabas.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSilabas.Location = new System.Drawing.Point(55, 98);
            this.tbSilabas.MaxLength = 4;
            this.tbSilabas.Multiline = true;
            this.tbSilabas.Name = "tbSilabas";
            this.tbSilabas.Size = new System.Drawing.Size(314, 149);
            this.tbSilabas.TabIndex = 1;
            this.tbSilabas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btReproduzir
            // 
            this.btReproduzir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btReproduzir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReproduzir.Location = new System.Drawing.Point(138, 253);
            this.btReproduzir.Name = "btReproduzir";
            this.btReproduzir.Size = new System.Drawing.Size(140, 49);
            this.btReproduzir.TabIndex = 2;
            this.btReproduzir.Text = "Reproduzir";
            this.btReproduzir.UseVisualStyleBackColor = true;
            this.btReproduzir.Click += new System.EventHandler(this.btReproduzir_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tbSilabas);
            this.panel1.Controls.Add(this.btReproduzir);
            this.panel1.Controls.Add(this.lbSilabas);
            this.panel1.Location = new System.Drawing.Point(184, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 350);
            this.panel1.TabIndex = 3;
            // 
            // btVoltar
            // 
            this.btVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btVoltar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(647, 12);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(92, 36);
            this.btVoltar.TabIndex = 4;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // silabas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::EduTech.Properties.Resources.Silabas_panel_desfocado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 534);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "silabas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sílabas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSilabas;
        private System.Windows.Forms.TextBox tbSilabas;
        private System.Windows.Forms.Button btReproduzir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btVoltar;
    }
}

