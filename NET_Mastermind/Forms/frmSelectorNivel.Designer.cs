
namespace NET_Mastermind {
    partial class frmSelectorNivel {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gbSelectorNivel = new System.Windows.Forms.GroupBox();
            this.rbDificil = new System.Windows.Forms.RadioButton();
            this.rbIntermedio = new System.Windows.Forms.RadioButton();
            this.rbPrincipiante = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbSelectorNivel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSelectorNivel
            // 
            this.gbSelectorNivel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSelectorNivel.Controls.Add(this.rbDificil);
            this.gbSelectorNivel.Controls.Add(this.rbIntermedio);
            this.gbSelectorNivel.Controls.Add(this.rbPrincipiante);
            this.gbSelectorNivel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbSelectorNivel.Location = new System.Drawing.Point(12, 12);
            this.gbSelectorNivel.Name = "gbSelectorNivel";
            this.gbSelectorNivel.Size = new System.Drawing.Size(199, 157);
            this.gbSelectorNivel.TabIndex = 0;
            this.gbSelectorNivel.TabStop = false;
            this.gbSelectorNivel.Text = "Niveles disponibles";
            // 
            // rbDificil
            // 
            this.rbDificil.AutoSize = true;
            this.rbDificil.Location = new System.Drawing.Point(20, 125);
            this.rbDificil.Name = "rbDificil";
            this.rbDificil.Size = new System.Drawing.Size(52, 17);
            this.rbDificil.TabIndex = 2;
            this.rbDificil.Tag = "2";
            this.rbDificil.Text = "Difícil";
            this.rbDificil.UseVisualStyleBackColor = true;
            // 
            // rbIntermedio
            // 
            this.rbIntermedio.AutoSize = true;
            this.rbIntermedio.Location = new System.Drawing.Point(20, 82);
            this.rbIntermedio.Name = "rbIntermedio";
            this.rbIntermedio.Size = new System.Drawing.Size(74, 17);
            this.rbIntermedio.TabIndex = 1;
            this.rbIntermedio.Tag = "1";
            this.rbIntermedio.Text = "Intermedio";
            this.rbIntermedio.UseVisualStyleBackColor = true;
            // 
            // rbPrincipiante
            // 
            this.rbPrincipiante.AutoSize = true;
            this.rbPrincipiante.Checked = true;
            this.rbPrincipiante.Location = new System.Drawing.Point(20, 39);
            this.rbPrincipiante.Name = "rbPrincipiante";
            this.rbPrincipiante.Size = new System.Drawing.Size(80, 17);
            this.rbPrincipiante.TabIndex = 0;
            this.rbPrincipiante.TabStop = true;
            this.rbPrincipiante.Tag = "0";
            this.rbPrincipiante.Text = "Principiante";
            this.rbPrincipiante.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(31, 175);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(112, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmSelectorNivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 218);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbSelectorNivel);
            this.Name = "frmSelectorNivel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SelectorNivel";
            this.gbSelectorNivel.ResumeLayout(false);
            this.gbSelectorNivel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelectorNivel;
        private System.Windows.Forms.RadioButton rbDificil;
        private System.Windows.Forms.RadioButton rbIntermedio;
        private System.Windows.Forms.RadioButton rbPrincipiante;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}