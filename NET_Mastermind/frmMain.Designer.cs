
namespace NET_Mastermind {
    partial class frmMain {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.mnuApp = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cómoJugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeMastermindNETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbColoresDisponibles = new System.Windows.Forms.GroupBox();
            this.pnlColoresDisponibles = new System.Windows.Forms.TableLayoutPanel();
            this.gbSolucion = new System.Windows.Forms.GroupBox();
            this.pnlCombinacionSecreta = new System.Windows.Forms.TableLayoutPanel();
            this.pnlJugadas = new System.Windows.Forms.TableLayoutPanel();
            this.pnIntentos = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuApp.SuspendLayout();
            this.gbColoresDisponibles.SuspendLayout();
            this.gbSolucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuApp
            // 
            this.mnuApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mnuApp.Location = new System.Drawing.Point(0, 0);
            this.mnuApp.Name = "mnuApp";
            this.mnuApp.Size = new System.Drawing.Size(883, 24);
            this.mnuApp.TabIndex = 0;
            this.mnuApp.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoJuegoToolStripMenuItem,
            this.nivelToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoJuegoToolStripMenuItem
            // 
            this.nuevoJuegoToolStripMenuItem.Name = "nuevoJuegoToolStripMenuItem";
            this.nuevoJuegoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.nuevoJuegoToolStripMenuItem.Text = "Nuevo juego";
            this.nuevoJuegoToolStripMenuItem.Click += new System.EventHandler(this.nuevoJuegoToolStripMenuItem_Click);
            // 
            // nivelToolStripMenuItem
            // 
            this.nivelToolStripMenuItem.Name = "nivelToolStripMenuItem";
            this.nivelToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.nivelToolStripMenuItem.Text = "Nivel";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cómoJugarToolStripMenuItem,
            this.acercaDeMastermindNETToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // cómoJugarToolStripMenuItem
            // 
            this.cómoJugarToolStripMenuItem.Name = "cómoJugarToolStripMenuItem";
            this.cómoJugarToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.cómoJugarToolStripMenuItem.Text = "¿Cómo jugar?";
            // 
            // acercaDeMastermindNETToolStripMenuItem
            // 
            this.acercaDeMastermindNETToolStripMenuItem.Name = "acercaDeMastermindNETToolStripMenuItem";
            this.acercaDeMastermindNETToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.acercaDeMastermindNETToolStripMenuItem.Text = "Acerca de Mastermind .NET";
            // 
            // gbColoresDisponibles
            // 
            this.gbColoresDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbColoresDisponibles.Controls.Add(this.pnlColoresDisponibles);
            this.gbColoresDisponibles.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbColoresDisponibles.Location = new System.Drawing.Point(635, 43);
            this.gbColoresDisponibles.Name = "gbColoresDisponibles";
            this.gbColoresDisponibles.Size = new System.Drawing.Size(236, 100);
            this.gbColoresDisponibles.TabIndex = 1;
            this.gbColoresDisponibles.TabStop = false;
            this.gbColoresDisponibles.Text = "Colores disponibles";
            // 
            // pnlColoresDisponibles
            // 
            this.pnlColoresDisponibles.ColumnCount = 4;
            this.pnlColoresDisponibles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlColoresDisponibles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlColoresDisponibles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlColoresDisponibles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlColoresDisponibles.Location = new System.Drawing.Point(6, 38);
            this.pnlColoresDisponibles.Name = "pnlColoresDisponibles";
            this.pnlColoresDisponibles.RowCount = 1;
            this.pnlColoresDisponibles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlColoresDisponibles.Size = new System.Drawing.Size(224, 56);
            this.pnlColoresDisponibles.TabIndex = 5;
            this.pnlColoresDisponibles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CambiarColorSeleccionado);
            // 
            // gbSolucion
            // 
            this.gbSolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSolucion.Controls.Add(this.pnlCombinacionSecreta);
            this.gbSolucion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbSolucion.Location = new System.Drawing.Point(635, 149);
            this.gbSolucion.Name = "gbSolucion";
            this.gbSolucion.Size = new System.Drawing.Size(236, 100);
            this.gbSolucion.TabIndex = 2;
            this.gbSolucion.TabStop = false;
            this.gbSolucion.Text = "Combinación secreta";
            // 
            // pnlCombinacionSecreta
            // 
            this.pnlCombinacionSecreta.ColumnCount = 4;
            this.pnlCombinacionSecreta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCombinacionSecreta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCombinacionSecreta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCombinacionSecreta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCombinacionSecreta.Location = new System.Drawing.Point(6, 38);
            this.pnlCombinacionSecreta.Name = "pnlCombinacionSecreta";
            this.pnlCombinacionSecreta.RowCount = 1;
            this.pnlCombinacionSecreta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCombinacionSecreta.Size = new System.Drawing.Size(224, 56);
            this.pnlCombinacionSecreta.TabIndex = 5;
            // 
            // pnlJugadas
            // 
            this.pnlJugadas.ColumnCount = 4;
            this.pnlJugadas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlJugadas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlJugadas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlJugadas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlJugadas.Location = new System.Drawing.Point(12, 43);
            this.pnlJugadas.Name = "pnlJugadas";
            this.pnlJugadas.RowCount = 1;
            this.pnlJugadas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlJugadas.Size = new System.Drawing.Size(224, 56);
            this.pnlJugadas.TabIndex = 3;
            // 
            // pnIntentos
            // 
            this.pnIntentos.ColumnCount = 4;
            this.pnIntentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnIntentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnIntentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnIntentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnIntentos.Location = new System.Drawing.Point(275, 43);
            this.pnIntentos.Name = "pnIntentos";
            this.pnIntentos.RowCount = 1;
            this.pnIntentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnIntentos.Size = new System.Drawing.Size(224, 56);
            this.pnIntentos.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(204, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 66);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnIntentos);
            this.Controls.Add(this.pnlJugadas);
            this.Controls.Add(this.gbSolucion);
            this.Controls.Add(this.gbColoresDisponibles);
            this.Controls.Add(this.mnuApp);
            this.MainMenuStrip = this.mnuApp;
            this.Name = "frmMain";
            this.Text = "Mastermind .NET";
            this.mnuApp.ResumeLayout(false);
            this.mnuApp.PerformLayout();
            this.gbColoresDisponibles.ResumeLayout(false);
            this.gbSolucion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuApp;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbColoresDisponibles;
        private System.Windows.Forms.GroupBox gbSolucion;
        private System.Windows.Forms.ToolStripMenuItem nivelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cómoJugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeMastermindNETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel pnlJugadas;
        private System.Windows.Forms.TableLayoutPanel pnIntentos;
        private System.Windows.Forms.TableLayoutPanel pnlColoresDisponibles;
        private System.Windows.Forms.TableLayoutPanel pnlCombinacionSecreta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

