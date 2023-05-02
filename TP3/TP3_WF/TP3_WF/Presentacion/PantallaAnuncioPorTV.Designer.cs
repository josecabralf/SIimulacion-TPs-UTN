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
            lbl_nroExperimentos = new Label();
            lbl_desde = new Label();
            lbl_cant = new Label();
            btn_generar = new Button();
            txt_nroExperimento = new TextBox();
            txt_desde = new TextBox();
            txt_cant = new TextBox();
            SuspendLayout();
            // 
            // lbl_nroExperimentos
            // 
            lbl_nroExperimentos.AutoSize = true;
            lbl_nroExperimentos.Location = new Point(30, 14);
            lbl_nroExperimentos.Name = "lbl_nroExperimentos";
            lbl_nroExperimentos.Size = new Size(178, 20);
            lbl_nroExperimentos.TabIndex = 0;
            lbl_nroExperimentos.Text = "Número de Experimentos";
            // 
            // lbl_desde
            // 
            lbl_desde.AutoSize = true;
            lbl_desde.Location = new Point(30, 81);
            lbl_desde.Name = "lbl_desde";
            lbl_desde.Size = new Size(51, 20);
            lbl_desde.TabIndex = 1;
            lbl_desde.Text = "Desde";
            // 
            // lbl_cant
            // 
            lbl_cant.AutoSize = true;
            lbl_cant.Location = new Point(30, 151);
            lbl_cant.Name = "lbl_cant";
            lbl_cant.Size = new Size(135, 20);
            lbl_cant.TabIndex = 2;
            lbl_cant.Text = "Cantidad de Lineas";
            // 
            // btn_generar
            // 
            btn_generar.BackColor = SystemColors.Desktop;
            btn_generar.Location = new Point(479, 31);
            btn_generar.Name = "btn_generar";
            btn_generar.Size = new Size(247, 173);
            btn_generar.TabIndex = 3;
            btn_generar.Text = "Generar";
            btn_generar.UseVisualStyleBackColor = false;
            // 
            // txt_nroExperimento
            // 
            txt_nroExperimento.Location = new Point(30, 37);
            txt_nroExperimento.Name = "txt_nroExperimento";
            txt_nroExperimento.Size = new Size(392, 27);
            txt_nroExperimento.TabIndex = 4;
            txt_nroExperimento.KeyPress += txt_nroExperimento_KeyPress;
            // 
            // txt_desde
            // 
            txt_desde.Location = new Point(30, 104);
            txt_desde.Name = "txt_desde";
            txt_desde.Size = new Size(392, 27);
            txt_desde.TabIndex = 5;
            txt_desde.KeyPress += txt_desde_KeyPress;
            // 
            // txt_cant
            // 
            txt_cant.Location = new Point(30, 174);
            txt_cant.Name = "txt_cant";
            txt_cant.Size = new Size(392, 27);
            txt_cant.TabIndex = 6;
            txt_cant.KeyPress += txt_cant_KeyPress;
            // 
            // PantallaAnuncioPorTV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 235);
            Controls.Add(txt_cant);
            Controls.Add(txt_desde);
            Controls.Add(txt_nroExperimento);
            Controls.Add(btn_generar);
            Controls.Add(lbl_cant);
            Controls.Add(lbl_desde);
            Controls.Add(lbl_nroExperimentos);
            Name = "PantallaAnuncioPorTV";
            Text = "Anuncio por Televisión";
            ResumeLayout(false);
            PerformLayout();
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