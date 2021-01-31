
namespace MasterMind
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.coloresDisponibles = new System.Windows.Forms.GroupBox();
            this.btnProbar = new System.Windows.Forms.Button();
            this.coloresSecretos = new System.Windows.Forms.GroupBox();
            this.combinacionesProbadas = new System.Windows.Forms.FlowLayoutPanel();
            this.resultados = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.partidaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.comenzarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dificultadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dificultadMenuFacil = new System.Windows.Forms.ToolStripMenuItem();
            this.dificultadMenuMediana = new System.Windows.Forms.ToolStripMenuItem();
            this.dificultadMenuDificil = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarPartidaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoJugarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coloresDisponibles
            // 
            this.coloresDisponibles.Location = new System.Drawing.Point(499, 73);
            this.coloresDisponibles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coloresDisponibles.Name = "coloresDisponibles";
            this.coloresDisponibles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coloresDisponibles.Size = new System.Drawing.Size(144, 52);
            this.coloresDisponibles.TabIndex = 4;
            this.coloresDisponibles.TabStop = false;
            this.coloresDisponibles.Text = "Colores disponibles";
            // 
            // btnProbar
            // 
            this.btnProbar.Enabled = false;
            this.btnProbar.Location = new System.Drawing.Point(218, 73);
            this.btnProbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(69, 27);
            this.btnProbar.TabIndex = 11;
            this.btnProbar.Text = "Probar";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.button1_Click);
            // 
            // coloresSecretos
            // 
            this.coloresSecretos.Location = new System.Drawing.Point(499, 145);
            this.coloresSecretos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coloresSecretos.Name = "coloresSecretos";
            this.coloresSecretos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coloresSecretos.Size = new System.Drawing.Size(144, 52);
            this.coloresSecretos.TabIndex = 5;
            this.coloresSecretos.TabStop = false;
            this.coloresSecretos.Text = "Colores secretos";
            // 
            // combinacionesProbadas
            // 
            this.combinacionesProbadas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.combinacionesProbadas.Location = new System.Drawing.Point(12, 73);
            this.combinacionesProbadas.Name = "combinacionesProbadas";
            this.combinacionesProbadas.Size = new System.Drawing.Size(200, 345);
            this.combinacionesProbadas.TabIndex = 12;
            // 
            // resultados
            // 
            this.resultados.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.resultados.Location = new System.Drawing.Point(293, 73);
            this.resultados.Name = "resultados";
            this.resultados.Size = new System.Drawing.Size(200, 345);
            this.resultados.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Fuchsia;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partidaMenu,
            this.ayudaMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // partidaMenu
            // 
            this.partidaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comenzarMenu,
            this.dificultadMenu,
            this.cancelarPartidaMenu});
            this.partidaMenu.Name = "partidaMenu";
            this.partidaMenu.Size = new System.Drawing.Size(56, 20);
            this.partidaMenu.Text = "Partida";
            // 
            // comenzarMenu
            // 
            this.comenzarMenu.Name = "comenzarMenu";
            this.comenzarMenu.Size = new System.Drawing.Size(168, 22);
            this.comenzarMenu.Text = "Comenzar partida";
            // 
            // dificultadMenu
            // 
            this.dificultadMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dificultadMenuFacil,
            this.dificultadMenuMediana,
            this.dificultadMenuDificil});
            this.dificultadMenu.Name = "dificultadMenu";
            this.dificultadMenu.Size = new System.Drawing.Size(168, 22);
            this.dificultadMenu.Text = "Dificultad";
            // 
            // dificultadMenuFacil
            // 
            this.dificultadMenuFacil.Checked = true;
            this.dificultadMenuFacil.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dificultadMenuFacil.Name = "dificultadMenuFacil";
            this.dificultadMenuFacil.Size = new System.Drawing.Size(120, 22);
            this.dificultadMenuFacil.Text = "Facil";
            // 
            // dificultadMenuMediana
            // 
            this.dificultadMenuMediana.Name = "dificultadMenuMediana";
            this.dificultadMenuMediana.Size = new System.Drawing.Size(120, 22);
            this.dificultadMenuMediana.Text = "Mediana";
            // 
            // dificultadMenuDificil
            // 
            this.dificultadMenuDificil.Name = "dificultadMenuDificil";
            this.dificultadMenuDificil.Size = new System.Drawing.Size(120, 22);
            this.dificultadMenuDificil.Text = "Dificil";
            // 
            // cancelarPartidaMenu
            // 
            this.cancelarPartidaMenu.Enabled = false;
            this.cancelarPartidaMenu.Name = "cancelarPartidaMenu";
            this.cancelarPartidaMenu.Size = new System.Drawing.Size(168, 22);
            this.cancelarPartidaMenu.Text = "Cancelar partida";
            // 
            // ayudaMenu
            // 
            this.ayudaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoJugarMenu,
            this.acercaDeMenu});
            this.ayudaMenu.Name = "ayudaMenu";
            this.ayudaMenu.Size = new System.Drawing.Size(53, 20);
            this.ayudaMenu.Text = "Ayuda";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // comoJugarMenu
            // 
            this.comoJugarMenu.Name = "comoJugarMenu";
            this.comoJugarMenu.Size = new System.Drawing.Size(137, 22);
            this.comoJugarMenu.Text = "Como jugar";
            // 
            // acercaDeMenu
            // 
            this.acercaDeMenu.Name = "acercaDeMenu";
            this.acercaDeMenu.Size = new System.Drawing.Size(137, 22);
            this.acercaDeMenu.Text = "Acerca de";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 430);
            this.Controls.Add(this.resultados);
            this.Controls.Add(this.combinacionesProbadas);
            this.Controls.Add(this.coloresSecretos);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.coloresDisponibles);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "MasterMind";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox coloresDisponibles;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.GroupBox coloresSecretos;
        private System.Windows.Forms.FlowLayoutPanel combinacionesProbadas;
        private System.Windows.Forms.FlowLayoutPanel resultados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dificultadMenu;
        private System.Windows.Forms.ToolStripMenuItem dificultadMenuFacil;
        private System.Windows.Forms.ToolStripMenuItem dificultadMenuMediana;
        private System.Windows.Forms.ToolStripMenuItem dificultadMenuDificil;
        private System.Windows.Forms.ToolStripMenuItem partidaMenu;
        private System.Windows.Forms.ToolStripMenuItem comenzarMenu;
        private System.Windows.Forms.ToolStripMenuItem cancelarPartidaMenu;
        private System.Windows.Forms.ToolStripMenuItem ayudaMenu;
        private System.Windows.Forms.ToolStripMenuItem comoJugarMenu;
        private System.Windows.Forms.ToolStripMenuItem acercaDeMenu;
    }
}

