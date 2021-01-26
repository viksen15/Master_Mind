
namespace MasterMind
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegoNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoJugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.coloresDispo = new System.Windows.Forms.TableLayoutPanel();
            this.color6 = new System.Windows.Forms.PictureBox();
            this.color4 = new System.Windows.Forms.PictureBox();
            this.color3 = new System.Windows.Forms.PictureBox();
            this.color2 = new System.Windows.Forms.PictureBox();
            this.color1 = new System.Windows.Forms.PictureBox();
            this.color5 = new System.Windows.Forms.PictureBox();
            this.solucion = new System.Windows.Forms.TableLayoutPanel();
            this.solucion3 = new System.Windows.Forms.PictureBox();
            this.solucion2 = new System.Windows.Forms.PictureBox();
            this.solucion1 = new System.Windows.Forms.PictureBox();
            this.solucion4 = new System.Windows.Forms.PictureBox();
            this.check1 = new System.Windows.Forms.Button();
            this.check2 = new System.Windows.Forms.Button();
            this.check3 = new System.Windows.Forms.Button();
            this.check4 = new System.Windows.Forms.Button();
            this.check5 = new System.Windows.Forms.Button();
            this.check6 = new System.Windows.Forms.Button();
            this.check7 = new System.Windows.Forms.Button();
            this.check8 = new System.Windows.Forms.Button();
            this.check9 = new System.Windows.Forms.Button();
            this.check10 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.coloresDispo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color5)).BeginInit();
            this.solucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solucion3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solucion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solucion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solucion4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nivelToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.juegoNuevoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nivelToolStripMenuItem
            // 
            this.nivelToolStripMenuItem.Name = "nivelToolStripMenuItem";
            this.nivelToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.nivelToolStripMenuItem.Text = "Nivel";
            this.nivelToolStripMenuItem.Click += new System.EventHandler(this.nivelToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // juegoNuevoToolStripMenuItem
            // 
            this.juegoNuevoToolStripMenuItem.Name = "juegoNuevoToolStripMenuItem";
            this.juegoNuevoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.juegoNuevoToolStripMenuItem.Text = "Juego nuevo";
            this.juegoNuevoToolStripMenuItem.Click += new System.EventHandler(this.juegoNuevoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoJugarToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // comoJugarToolStripMenuItem
            // 
            this.comoJugarToolStripMenuItem.Name = "comoJugarToolStripMenuItem";
            this.comoJugarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.comoJugarToolStripMenuItem.Text = "Como jugar -->";
            this.comoJugarToolStripMenuItem.Click += new System.EventHandler(this.comoJugarToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(216, 480);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(244, 73);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 20;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(49, 480);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // coloresDispo
            // 
            this.coloresDispo.BackColor = System.Drawing.Color.Transparent;
            this.coloresDispo.ColumnCount = 1;
            this.coloresDispo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.coloresDispo.Controls.Add(this.color6, 0, 5);
            this.coloresDispo.Controls.Add(this.color4, 0, 3);
            this.coloresDispo.Controls.Add(this.color3, 0, 2);
            this.coloresDispo.Controls.Add(this.color2, 0, 1);
            this.coloresDispo.Controls.Add(this.color1, 0, 0);
            this.coloresDispo.Controls.Add(this.color5, 0, 4);
            this.coloresDispo.Location = new System.Drawing.Point(331, 183);
            this.coloresDispo.Name = "coloresDispo";
            this.coloresDispo.RowCount = 6;
            this.coloresDispo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.coloresDispo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.coloresDispo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.coloresDispo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.coloresDispo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.coloresDispo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.coloresDispo.Size = new System.Drawing.Size(51, 307);
            this.coloresDispo.TabIndex = 16;
            // 
            // color6
            // 
            this.color6.BackColor = System.Drawing.Color.Transparent;
            this.color6.Location = new System.Drawing.Point(3, 258);
            this.color6.Name = "color6";
            this.color6.Size = new System.Drawing.Size(43, 44);
            this.color6.TabIndex = 5;
            this.color6.TabStop = false;
            this.color6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clicRaton);
            // 
            // color4
            // 
            this.color4.BackColor = System.Drawing.Color.Transparent;
            this.color4.Location = new System.Drawing.Point(3, 156);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(44, 43);
            this.color4.TabIndex = 3;
            this.color4.TabStop = false;
            this.color4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clicRaton);
            // 
            // color3
            // 
            this.color3.BackColor = System.Drawing.Color.Transparent;
            this.color3.Location = new System.Drawing.Point(3, 105);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(44, 43);
            this.color3.TabIndex = 2;
            this.color3.TabStop = false;
            this.color3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clicRaton);
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.Color.Transparent;
            this.color2.Location = new System.Drawing.Point(3, 54);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(44, 43);
            this.color2.TabIndex = 1;
            this.color2.TabStop = false;
            this.color2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clicRaton);
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.Transparent;
            this.color1.Location = new System.Drawing.Point(3, 3);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(44, 43);
            this.color1.TabIndex = 0;
            this.color1.TabStop = false;
            this.color1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clicRaton);
            // 
            // color5
            // 
            this.color5.BackColor = System.Drawing.Color.Transparent;
            this.color5.Location = new System.Drawing.Point(3, 207);
            this.color5.Name = "color5";
            this.color5.Size = new System.Drawing.Size(43, 44);
            this.color5.TabIndex = 4;
            this.color5.TabStop = false;
            this.color5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clicRaton);
            // 
            // solucion
            // 
            this.solucion.BackColor = System.Drawing.Color.Transparent;
            this.solucion.ColumnCount = 4;
            this.solucion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.solucion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.solucion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.solucion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.solucion.Controls.Add(this.solucion3, 2, 0);
            this.solucion.Controls.Add(this.solucion2, 1, 0);
            this.solucion.Controls.Add(this.solucion1, 0, 0);
            this.solucion.Controls.Add(this.solucion4, 3, 0);
            this.solucion.Location = new System.Drawing.Point(22, 570);
            this.solucion.Name = "solucion";
            this.solucion.RowCount = 1;
            this.solucion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.solucion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.solucion.Size = new System.Drawing.Size(216, 38);
            this.solucion.TabIndex = 18;
            // 
            // solucion3
            // 
            this.solucion3.Location = new System.Drawing.Point(111, 3);
            this.solucion3.Name = "solucion3";
            this.solucion3.Size = new System.Drawing.Size(46, 33);
            this.solucion3.TabIndex = 3;
            this.solucion3.TabStop = false;
            // 
            // solucion2
            // 
            this.solucion2.Location = new System.Drawing.Point(57, 3);
            this.solucion2.Name = "solucion2";
            this.solucion2.Size = new System.Drawing.Size(46, 33);
            this.solucion2.TabIndex = 2;
            this.solucion2.TabStop = false;
            // 
            // solucion1
            // 
            this.solucion1.Location = new System.Drawing.Point(3, 3);
            this.solucion1.Name = "solucion1";
            this.solucion1.Size = new System.Drawing.Size(46, 33);
            this.solucion1.TabIndex = 1;
            this.solucion1.TabStop = false;
            // 
            // solucion4
            // 
            this.solucion4.Location = new System.Drawing.Point(165, 3);
            this.solucion4.Name = "solucion4";
            this.solucion4.Size = new System.Drawing.Size(46, 33);
            this.solucion4.TabIndex = 0;
            this.solucion4.TabStop = false;
            // 
            // check1
            // 
            this.check1.BackgroundImage = global::MasterMind.Properties.Resources.checkButton;
            this.check1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check1.Location = new System.Drawing.Point(0, 91);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(19, 18);
            this.check1.TabIndex = 19;
            this.check1.UseVisualStyleBackColor = true;
     //       this.check1.Click += new System.EventHandler(this.check);
            // 
            // check2
            // 
            this.check2.BackgroundImage = global::MasterMind.Properties.Resources.checkButton;
            this.check2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check2.Location = new System.Drawing.Point(0, 139);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(19, 18);
            this.check2.TabIndex = 20;
            this.check2.UseVisualStyleBackColor = true;
       //     this.check2.Click += new System.EventHandler(this.check);
            // 
            // check3
            // 
            this.check3.BackgroundImage = global::MasterMind.Properties.Resources.checkButton;
            this.check3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check3.Location = new System.Drawing.Point(0, 185);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(19, 18);
            this.check3.TabIndex = 21;
            this.check3.UseVisualStyleBackColor = true;
      //      this.check3.Click += new System.EventHandler(this.check);
            // 
            // check4
            // 
            this.check4.BackgroundImage = global::MasterMind.Properties.Resources.checkButton;
            this.check4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check4.Location = new System.Drawing.Point(0, 234);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(19, 18);
            this.check4.TabIndex = 22;
            this.check4.UseVisualStyleBackColor = true;
      //      this.check4.Click += new System.EventHandler(this.check);
            // 
            // check5
            // 
            this.check5.BackgroundImage = global::MasterMind.Properties.Resources.checkButton;
            this.check5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check5.Location = new System.Drawing.Point(0, 281);
            this.check5.Name = "check5";
            this.check5.Size = new System.Drawing.Size(19, 18);
            this.check5.TabIndex = 23;
            this.check5.UseVisualStyleBackColor = true;
      //      this.check5.Click += new System.EventHandler(this.check);
            // 
            // check6
            // 
            this.check6.BackgroundImage = global::MasterMind.Properties.Resources.checkButton;
            this.check6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check6.Location = new System.Drawing.Point(0, 330);
            this.check6.Name = "check6";
            this.check6.Size = new System.Drawing.Size(19, 18);
            this.check6.TabIndex = 24;
            this.check6.UseVisualStyleBackColor = true;
     //       this.check6.Click += new System.EventHandler(this.check);
            // 
            // check7
            // 
            this.check7.BackgroundImage = global::MasterMind.Properties.Resources.checkButton;
            this.check7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check7.Location = new System.Drawing.Point(1, 378);
            this.check7.Name = "check7";
            this.check7.Size = new System.Drawing.Size(19, 18);
            this.check7.TabIndex = 25;
            this.check7.UseVisualStyleBackColor = true;
      //      this.check7.Click += new System.EventHandler(this.check);
            // 
            // check8
            // 
            this.check8.BackgroundImage = global::MasterMind.Properties.Resources.checkButton;
            this.check8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check8.Location = new System.Drawing.Point(1, 426);
            this.check8.Name = "check8";
            this.check8.Size = new System.Drawing.Size(18, 18);
            this.check8.TabIndex = 26;
            this.check8.UseVisualStyleBackColor = true;
      //      this.check8.Click += new System.EventHandler(this.check);
            // 
            // check9
            // 
            this.check9.BackgroundImage = global::MasterMind.Properties.Resources.checkButton;
            this.check9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check9.Location = new System.Drawing.Point(1, 472);
            this.check9.Name = "check9";
            this.check9.Size = new System.Drawing.Size(18, 18);
            this.check9.TabIndex = 27;
            this.check9.UseVisualStyleBackColor = true;
     //       this.check9.Click += new System.EventHandler(this.check);
            // 
            // check10
            // 
            this.check10.BackgroundImage = global::MasterMind.Properties.Resources.checkButton;
            this.check10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.check10.Location = new System.Drawing.Point(0, 520);
            this.check10.Name = "check10";
            this.check10.Size = new System.Drawing.Size(19, 18);
            this.check10.TabIndex = 28;
            this.check10.UseVisualStyleBackColor = true;
      //      this.check10.Click += new System.EventHandler(this.check);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 614);
            this.Controls.Add(this.check7);
            this.Controls.Add(this.check8);
            this.Controls.Add(this.check9);
            this.Controls.Add(this.check5);
            this.Controls.Add(this.check10);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.check2);
            this.Controls.Add(this.check4);
            this.Controls.Add(this.check3);
            this.Controls.Add(this.check6);
            this.Controls.Add(this.solucion);
            this.Controls.Add(this.coloresDispo);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Mind \\\\VIIKSEN//";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.coloresDispo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color5)).EndInit();
            this.solucion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.solucion3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solucion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solucion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solucion4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel coloresDispo;
        private System.Windows.Forms.TableLayoutPanel solucion;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juegoNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.PictureBox color6;
        private System.Windows.Forms.PictureBox color4;
        private System.Windows.Forms.PictureBox color3;
        private System.Windows.Forms.PictureBox color2;
        private System.Windows.Forms.PictureBox color1;
        private System.Windows.Forms.PictureBox color5;
        private System.Windows.Forms.ToolStripMenuItem comoJugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox solucion3;
        private System.Windows.Forms.PictureBox solucion2;
        private System.Windows.Forms.PictureBox solucion1;
        private System.Windows.Forms.PictureBox solucion4;
        private System.Windows.Forms.ToolStripMenuItem nivelToolStripMenuItem;
        private System.Windows.Forms.Button check1;
        private System.Windows.Forms.Button check2;
        private System.Windows.Forms.Button check3;
        private System.Windows.Forms.Button check4;
        private System.Windows.Forms.Button check5;
        private System.Windows.Forms.Button check6;
        private System.Windows.Forms.Button check7;
        private System.Windows.Forms.Button check8;
        private System.Windows.Forms.Button check9;
        private System.Windows.Forms.Button check10;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
    }
}

