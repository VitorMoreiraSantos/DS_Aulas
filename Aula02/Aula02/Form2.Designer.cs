namespace Aula02
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu21ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonExibir = new System.Windows.Forms.Button();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.labelProduto = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem,
            this.menu2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenu1ToolStripMenuItem,
            this.subMenu2ToolStripMenuItem});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.menu1ToolStripMenuItem.Text = "&Cadastro";
            // 
            // subMenu1ToolStripMenuItem
            // 
            this.subMenu1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("subMenu1ToolStripMenuItem.Image")));
            this.subMenu1ToolStripMenuItem.Name = "subMenu1ToolStripMenuItem";
            this.subMenu1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subMenu1ToolStripMenuItem.Text = "&Produto";
            this.subMenu1ToolStripMenuItem.Click += new System.EventHandler(this.subMenu1ToolStripMenuItem_Click);
            // 
            // subMenu2ToolStripMenuItem
            // 
            this.subMenu2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("subMenu2ToolStripMenuItem.Image")));
            this.subMenu2ToolStripMenuItem.Name = "subMenu2ToolStripMenuItem";
            this.subMenu2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subMenu2ToolStripMenuItem.Text = "&Usuário";
            this.subMenu2ToolStripMenuItem.Click += new System.EventHandler(this.subMenu2ToolStripMenuItem_Click);
            // 
            // menu2ToolStripMenuItem
            // 
            this.menu2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenu21ToolStripMenuItem});
            this.menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            this.menu2ToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menu2ToolStripMenuItem.Text = "Ajuda";
            // 
            // subMenu21ToolStripMenuItem
            // 
            this.subMenu21ToolStripMenuItem.Name = "subMenu21ToolStripMenuItem";
            this.subMenu21ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subMenu21ToolStripMenuItem.Text = "Sobre";
            this.subMenu21ToolStripMenuItem.Click += new System.EventHandler(this.subMenu21ToolStripMenuItem_Click);
            // 
            // buttonExibir
            // 
            this.buttonExibir.BackColor = System.Drawing.Color.Blue;
            this.buttonExibir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonExibir.Location = new System.Drawing.Point(702, 223);
            this.buttonExibir.Name = "buttonExibir";
            this.buttonExibir.Size = new System.Drawing.Size(86, 34);
            this.buttonExibir.TabIndex = 14;
            this.buttonExibir.Text = "Exibir";
            this.buttonExibir.UseVisualStyleBackColor = false;
            this.buttonExibir.Click += new System.EventHandler(this.buttonExibir_Click);
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProduto.Location = new System.Drawing.Point(21, 107);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(404, 26);
            this.textBoxProduto.TabIndex = 11;
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelProduto.Location = new System.Drawing.Point(17, 79);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(160, 24);
            this.labelProduto.TabIndex = 10;
            this.labelProduto.Text = "Nome do Produto";
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.Red;
            this.buttonFechar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonFechar.Location = new System.Drawing.Point(702, 52);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(86, 34);
            this.buttonFechar.TabIndex = 9;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(356, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(58, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "CadProd";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButtonCadProd";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButtonCadUser";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonExibir);
            this.Controls.Add(this.textBoxProduto);
            this.Controls.Add(this.labelProduto);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subMenu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subMenu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subMenu21ToolStripMenuItem;
        private System.Windows.Forms.Button buttonExibir;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}