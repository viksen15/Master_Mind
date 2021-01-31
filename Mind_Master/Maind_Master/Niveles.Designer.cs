
namespace Maind_Master
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Bprincipiante = new System.Windows.Forms.RadioButton();
            this.Bmedio = new System.Windows.Forms.RadioButton();
            this.Bavanzado = new System.Windows.Forms.RadioButton();
            this.aceptarN = new System.Windows.Forms.Button();
            this.cancelarN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECCIONE NIVEL";
            // 
            // Bprincipiante
            // 
            this.Bprincipiante.AutoSize = true;
            this.Bprincipiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Bprincipiante.Location = new System.Drawing.Point(48, 45);
            this.Bprincipiante.Name = "Bprincipiante";
            this.Bprincipiante.Size = new System.Drawing.Size(100, 17);
            this.Bprincipiante.TabIndex = 2;
            this.Bprincipiante.TabStop = true;
            this.Bprincipiante.Text = "PRINCIPIANTE";
            this.Bprincipiante.UseVisualStyleBackColor = false;
            // 
            // Bmedio
            // 
            this.Bmedio.AutoSize = true;
            this.Bmedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Bmedio.Location = new System.Drawing.Point(48, 68);
            this.Bmedio.Name = "Bmedio";
            this.Bmedio.Size = new System.Drawing.Size(60, 17);
            this.Bmedio.TabIndex = 3;
            this.Bmedio.TabStop = true;
            this.Bmedio.Text = "MEDIO";
            this.Bmedio.UseVisualStyleBackColor = false;
            // 
            // Bavanzado
            // 
            this.Bavanzado.AutoSize = true;
            this.Bavanzado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Bavanzado.Location = new System.Drawing.Point(48, 91);
            this.Bavanzado.Name = "Bavanzado";
            this.Bavanzado.Size = new System.Drawing.Size(84, 17);
            this.Bavanzado.TabIndex = 4;
            this.Bavanzado.TabStop = true;
            this.Bavanzado.Text = "AVANZADO";
            this.Bavanzado.UseVisualStyleBackColor = false;
            // 
            // aceptarN
            // 
            this.aceptarN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.aceptarN.Location = new System.Drawing.Point(12, 128);
            this.aceptarN.Name = "aceptarN";
            this.aceptarN.Size = new System.Drawing.Size(64, 20);
            this.aceptarN.TabIndex = 5;
            this.aceptarN.Text = "Aceptar";
            this.aceptarN.UseVisualStyleBackColor = false;
            this.aceptarN.Click += new System.EventHandler(this.aceptarN_Click);
            // 
            // cancelarN
            // 
            this.cancelarN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelarN.Location = new System.Drawing.Point(101, 128);
            this.cancelarN.Name = "cancelarN";
            this.cancelarN.Size = new System.Drawing.Size(64, 20);
            this.cancelarN.TabIndex = 6;
            this.cancelarN.Text = "Cancelar";
            this.cancelarN.UseVisualStyleBackColor = false;
            this.cancelarN.Click += new System.EventHandler(this.cancelarN_Click);
            // 
            // Niveles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 153);
            this.Controls.Add(this.cancelarN);
            this.Controls.Add(this.aceptarN);
            this.Controls.Add(this.Bavanzado);
            this.Controls.Add(this.Bmedio);
            this.Controls.Add(this.Bprincipiante);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Niveles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Niveles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Bprincipiante;
        private System.Windows.Forms.RadioButton Bmedio;
        private System.Windows.Forms.RadioButton Bavanzado;
        private System.Windows.Forms.Button aceptarN;
        private System.Windows.Forms.Button cancelarN;
    }
}