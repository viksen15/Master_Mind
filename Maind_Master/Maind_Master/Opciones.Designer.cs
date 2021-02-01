
namespace Maind_Master
{
    partial class Opciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColoresBox = new System.Windows.Forms.FlowLayoutPanel();
            this.aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CON QUE COLORES DESEAS JUGAR?";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::Maind_Master.Properties.Resources.sm_5a9bfa737abc9_removebg_preview;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(7, 92);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 51);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(48, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Haz click para elegir.";
            // 
            // ColoresBox
            // 
            this.ColoresBox.Location = new System.Drawing.Point(51, 51);
            this.ColoresBox.Name = "ColoresBox";
            this.ColoresBox.Size = new System.Drawing.Size(175, 35);
            this.ColoresBox.TabIndex = 9;
            // 
            // aceptar
            // 
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(229, 101);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(74, 29);
            this.aceptar.TabIndex = 10;
            this.aceptar.Text = "ACEPTAR";
            this.aceptar.UseVisualStyleBackColor = true;
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 155);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.ColoresBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label1);
            this.Name = "Opciones";
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.Opciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FlowLayoutPanel ColoresBox;
        private System.Windows.Forms.Button aceptar;
    }
}