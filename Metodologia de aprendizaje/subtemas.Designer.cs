namespace Metodologia_de_aprendizaje
{
    partial class subtemas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subtemas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarEvaluacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarTemasToolStripMenuItem,
            this.toolStripSeparator1,
            this.buscarEvaluacionesToolStripMenuItem});
            this.menúToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // listarTemasToolStripMenuItem
            // 
            this.listarTemasToolStripMenuItem.Name = "listarTemasToolStripMenuItem";
            this.listarTemasToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.listarTemasToolStripMenuItem.Text = "Listar Temas";
            this.listarTemasToolStripMenuItem.Click += new System.EventHandler(this.listarTemasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // buscarEvaluacionesToolStripMenuItem
            // 
            this.buscarEvaluacionesToolStripMenuItem.Name = "buscarEvaluacionesToolStripMenuItem";
            this.buscarEvaluacionesToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.buscarEvaluacionesToolStripMenuItem.Text = "Buscar Evaluaciones";
            this.buscarEvaluacionesToolStripMenuItem.Click += new System.EventHandler(this.buscarEvaluacionesToolStripMenuItem_Click);
            // 
            // subtemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 627);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "subtemas";
            this.Text = "subtemas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem buscarEvaluacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
    }
}