namespace EditorDeCores
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
            this.TrackBarVermelho = new System.Windows.Forms.TrackBar();
            this.TrackBarVerde = new System.Windows.Forms.TrackBar();
            this.TrackBarAzul = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Painel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAzul)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackBarVermelho
            // 
            this.TrackBarVermelho.Dock = System.Windows.Forms.DockStyle.Top;
            this.TrackBarVermelho.Location = new System.Drawing.Point(0, 0);
            this.TrackBarVermelho.Maximum = 255;
            this.TrackBarVermelho.Name = "TrackBarVermelho";
            this.TrackBarVermelho.Size = new System.Drawing.Size(800, 45);
            this.TrackBarVermelho.TabIndex = 0;
            this.TrackBarVermelho.Scroll += new System.EventHandler(this.TrackBarVermelho_Scroll);
            // 
            // TrackBarVerde
            // 
            this.TrackBarVerde.Dock = System.Windows.Forms.DockStyle.Top;
            this.TrackBarVerde.Location = new System.Drawing.Point(0, 45);
            this.TrackBarVerde.Maximum = 255;
            this.TrackBarVerde.Name = "TrackBarVerde";
            this.TrackBarVerde.Size = new System.Drawing.Size(800, 45);
            this.TrackBarVerde.TabIndex = 1;
            this.TrackBarVerde.Scroll += new System.EventHandler(this.TrackBarVerde_Scroll);
            // 
            // TrackBarAzul
            // 
            this.TrackBarAzul.Dock = System.Windows.Forms.DockStyle.Top;
            this.TrackBarAzul.Location = new System.Drawing.Point(0, 90);
            this.TrackBarAzul.Maximum = 255;
            this.TrackBarAzul.Name = "TrackBarAzul";
            this.TrackBarAzul.Size = new System.Drawing.Size(800, 45);
            this.TrackBarAzul.TabIndex = 2;
            this.TrackBarAzul.Scroll += new System.EventHandler(this.TrackBarAzul_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vermelho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Verde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Azul";
            // 
            // Painel
            // 
            this.Painel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Painel.Location = new System.Drawing.Point(0, 141);
            this.Painel.Name = "Painel";
            this.Painel.Size = new System.Drawing.Size(800, 309);
            this.Painel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Painel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrackBarAzul);
            this.Controls.Add(this.TrackBarVerde);
            this.Controls.Add(this.TrackBarVermelho);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarAzul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TrackBarVermelho;
        private System.Windows.Forms.TrackBar TrackBarVerde;
        private System.Windows.Forms.TrackBar TrackBarAzul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Painel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

