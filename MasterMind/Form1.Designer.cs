
namespace MasterMind
{
    partial class Form1
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
            this.coloresDisponibles = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.coloresSecretos = new System.Windows.Forms.GroupBox();
            this.combinacionesProbadas = new System.Windows.Forms.FlowLayoutPanel();
            this.resultados = new System.Windows.Forms.FlowLayoutPanel();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 430);
            this.Controls.Add(this.resultados);
            this.Controls.Add(this.combinacionesProbadas);
            this.Controls.Add(this.coloresSecretos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.coloresDisponibles);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox coloresDisponibles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox coloresSecretos;
        private System.Windows.Forms.FlowLayoutPanel combinacionesProbadas;
        private System.Windows.Forms.FlowLayoutPanel resultados;
    }
}

