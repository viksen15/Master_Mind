
namespace MasterMind
{
    partial class Niveles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.avanzadoB = new System.Windows.Forms.RadioButton();
            this.medioB = new System.Windows.Forms.RadioButton();
            this.principianteB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cancelar);
            this.panel1.Controls.Add(this.aceptar);
            this.panel1.Controls.Add(this.avanzadoB);
            this.panel1.Controls.Add(this.medioB);
            this.panel1.Controls.Add(this.principianteB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 208);
            this.panel1.TabIndex = 0;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(103, 179);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 5;
            this.cancelar.Text = "CANCELAR";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(3, 178);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 4;
            this.aceptar.Text = "ACEPTAR";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // avanzadoB
            // 
            this.avanzadoB.AutoSize = true;
            this.avanzadoB.Location = new System.Drawing.Point(38, 133);
            this.avanzadoB.Name = "avanzadoB";
            this.avanzadoB.Size = new System.Drawing.Size(84, 17);
            this.avanzadoB.TabIndex = 3;
            this.avanzadoB.TabStop = true;
            this.avanzadoB.Text = "AVANZADO";
            this.avanzadoB.UseVisualStyleBackColor = true;
            // 
            // medioB
            // 
            this.medioB.AutoSize = true;
            this.medioB.Location = new System.Drawing.Point(38, 96);
            this.medioB.Name = "medioB";
            this.medioB.Size = new System.Drawing.Size(60, 17);
            this.medioB.TabIndex = 2;
            this.medioB.TabStop = true;
            this.medioB.Text = "MEDIO";
            this.medioB.UseVisualStyleBackColor = true;
            // 
            // principianteB
            // 
            this.principianteB.AutoSize = true;
            this.principianteB.Location = new System.Drawing.Point(38, 62);
            this.principianteB.Name = "principianteB";
            this.principianteB.Size = new System.Drawing.Size(100, 17);
            this.principianteB.TabIndex = 1;
            this.principianteB.TabStop = true;
            this.principianteB.Text = "PRINCIPIANTE";
            this.principianteB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIONE NIVEL";
            // 
            // Niveles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 228);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Niveles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Niveles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton avanzadoB;
        private System.Windows.Forms.RadioButton medioB;
        private System.Windows.Forms.RadioButton principianteB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
    }
}