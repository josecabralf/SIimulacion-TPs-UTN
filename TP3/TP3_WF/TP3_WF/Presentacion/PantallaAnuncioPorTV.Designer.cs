namespace TP3_WF
{
    partial class PantallaAnuncioPorTV
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
            this.lbl_nroExperimentos = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.txt_nroExperimento = new System.Windows.Forms.TextBox();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_nroExperimentos
            // 
            this.lbl_nroExperimentos.AutoSize = true;
            this.lbl_nroExperimentos.Location = new System.Drawing.Point(26, 10);
            this.lbl_nroExperimentos.Name = "lbl_nroExperimentos";
            this.lbl_nroExperimentos.Size = new System.Drawing.Size(142, 15);
            this.lbl_nroExperimentos.TabIndex = 0;
            this.lbl_nroExperimentos.Text = "Número de Experimentos";
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Location = new System.Drawing.Point(26, 61);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(39, 15);
            this.lbl_desde.TabIndex = 1;
            this.lbl_desde.Text = "Desde";
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.Location = new System.Drawing.Point(26, 113);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(107, 15);
            this.lbl_cant.TabIndex = 2;
            this.lbl_cant.Text = "Cantidad de Lineas";
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.Red;
            this.btn_generar.Location = new System.Drawing.Point(419, 23);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(216, 130);
            this.btn_generar.TabIndex = 3;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // txt_nroExperimento
            // 
            this.txt_nroExperimento.Location = new System.Drawing.Point(26, 28);
            this.txt_nroExperimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nroExperimento.Name = "txt_nroExperimento";
            this.txt_nroExperimento.Size = new System.Drawing.Size(344, 23);
            this.txt_nroExperimento.TabIndex = 4;
            this.txt_nroExperimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nroExperimento_KeyPress);
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(26, 78);
            this.txt_desde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(344, 23);
            this.txt_desde.TabIndex = 5;
            this.txt_desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_desde_KeyPress);
            // 
            // txt_cant
            // 
            this.txt_cant.Location = new System.Drawing.Point(26, 130);
            this.txt_cant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(344, 23);
            this.txt_cant.TabIndex = 6;
            this.txt_cant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cant_KeyPress);
            // 
            // PantallaAnuncioPorTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 176);
            this.Controls.Add(this.txt_cant);
            this.Controls.Add(this.txt_desde);
            this.Controls.Add(this.txt_nroExperimento);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.lbl_cant);
            this.Controls.Add(this.lbl_desde);
            this.Controls.Add(this.lbl_nroExperimentos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaAnuncioPorTV";
            this.Text = "Anuncio por Televisión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_nroExperimentos;
        private Label lbl_desde;
        private Label lbl_cant;
        private Button btn_generar;
        private TextBox txt_nroExperimento;
        private TextBox txt_desde;
        private TextBox txt_cant;
    }
}