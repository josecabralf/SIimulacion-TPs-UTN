namespace TP5
{
    partial class PantallaVisualizacion
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
            gdw_iteracionesSolicitadas = new DataGridView();
            lbl_tiempoPromedioEspera = new Label();
            lbl_porcRetiraSinJugar = new Label();
            txt_tiempoPromEsperaF = new TextBox();
            txt_porcRetiraSinJugar = new TextBox();
            txt_tiempoPromEsperaHB = new TextBox();
            txt_tiempoPromEsperaBB = new TextBox();
            lbl_tiempoPromEsperaF = new Label();
            lbl_tiempoPromEsperaBB = new Label();
            lbl_tiempoPromEsperaHB = new Label();
            ((System.ComponentModel.ISupportInitialize)gdw_iteracionesSolicitadas).BeginInit();
            SuspendLayout();
            // 
            // gdw_iteracionesSolicitadas
            // 
            gdw_iteracionesSolicitadas.AllowUserToAddRows = false;
            gdw_iteracionesSolicitadas.AllowUserToDeleteRows = false;
            gdw_iteracionesSolicitadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdw_iteracionesSolicitadas.Location = new Point(10, 12);
            gdw_iteracionesSolicitadas.Margin = new Padding(3, 4, 3, 4);
            gdw_iteracionesSolicitadas.Name = "gdw_iteracionesSolicitadas";
            gdw_iteracionesSolicitadas.ReadOnly = true;
            gdw_iteracionesSolicitadas.RowHeadersWidth = 51;
            gdw_iteracionesSolicitadas.RowTemplate.Height = 25;
            gdw_iteracionesSolicitadas.Size = new Size(1329, 592);
            gdw_iteracionesSolicitadas.TabIndex = 0;
            // 
            // lbl_tiempoPromedioEspera
            // 
            lbl_tiempoPromedioEspera.AutoSize = true;
            lbl_tiempoPromedioEspera.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tiempoPromedioEspera.Location = new Point(461, 623);
            lbl_tiempoPromedioEspera.Name = "lbl_tiempoPromedioEspera";
            lbl_tiempoPromedioEspera.Size = new Size(290, 23);
            lbl_tiempoPromedioEspera.TabIndex = 1;
            lbl_tiempoPromedioEspera.Text = "Tiempo promedio de espera (min):";
            // 
            // lbl_porcRetiraSinJugar
            // 
            lbl_porcRetiraSinJugar.AutoSize = true;
            lbl_porcRetiraSinJugar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_porcRetiraSinJugar.Location = new Point(838, 657);
            lbl_porcRetiraSinJugar.Name = "lbl_porcRetiraSinJugar";
            lbl_porcRetiraSinJugar.Size = new Size(374, 23);
            lbl_porcRetiraSinJugar.TabIndex = 2;
            lbl_porcRetiraSinJugar.Text = "Porcentaje de grupos que se retiran sin jugar:";
            // 
            // txt_tiempoPromEsperaF
            // 
            txt_tiempoPromEsperaF.Enabled = false;
            txt_tiempoPromEsperaF.Location = new Point(838, 620);
            txt_tiempoPromEsperaF.Margin = new Padding(3, 4, 3, 4);
            txt_tiempoPromEsperaF.Name = "txt_tiempoPromEsperaF";
            txt_tiempoPromEsperaF.Size = new Size(114, 27);
            txt_tiempoPromEsperaF.TabIndex = 3;
            // 
            // txt_porcRetiraSinJugar
            // 
            txt_porcRetiraSinJugar.Enabled = false;
            txt_porcRetiraSinJugar.Location = new Point(1225, 655);
            txt_porcRetiraSinJugar.Margin = new Padding(3, 4, 3, 4);
            txt_porcRetiraSinJugar.Name = "txt_porcRetiraSinJugar";
            txt_porcRetiraSinJugar.Size = new Size(114, 27);
            txt_porcRetiraSinJugar.TabIndex = 4;
            // 
            // txt_tiempoPromEsperaHB
            // 
            txt_tiempoPromEsperaHB.Enabled = false;
            txt_tiempoPromEsperaHB.Location = new Point(1029, 619);
            txt_tiempoPromEsperaHB.Margin = new Padding(3, 4, 3, 4);
            txt_tiempoPromEsperaHB.Name = "txt_tiempoPromEsperaHB";
            txt_tiempoPromEsperaHB.Size = new Size(114, 27);
            txt_tiempoPromEsperaHB.TabIndex = 5;
            // 
            // txt_tiempoPromEsperaBB
            // 
            txt_tiempoPromEsperaBB.Enabled = false;
            txt_tiempoPromEsperaBB.Location = new Point(1225, 619);
            txt_tiempoPromEsperaBB.Margin = new Padding(3, 4, 3, 4);
            txt_tiempoPromEsperaBB.Name = "txt_tiempoPromEsperaBB";
            txt_tiempoPromEsperaBB.Size = new Size(114, 27);
            txt_tiempoPromEsperaBB.TabIndex = 6;
            // 
            // lbl_tiempoPromEsperaF
            // 
            lbl_tiempoPromEsperaF.AutoSize = true;
            lbl_tiempoPromEsperaF.Location = new Point(784, 623);
            lbl_tiempoPromEsperaF.Name = "lbl_tiempoPromEsperaF";
            lbl_tiempoPromEsperaF.Size = new Size(51, 20);
            lbl_tiempoPromEsperaF.TabIndex = 7;
            lbl_tiempoPromEsperaF.Text = "Fútbol";
            // 
            // lbl_tiempoPromEsperaBB
            // 
            lbl_tiempoPromEsperaBB.AutoSize = true;
            lbl_tiempoPromEsperaBB.Location = new Point(1150, 620);
            lbl_tiempoPromEsperaBB.Name = "lbl_tiempoPromEsperaBB";
            lbl_tiempoPromEsperaBB.Size = new Size(77, 20);
            lbl_tiempoPromEsperaBB.TabIndex = 8;
            lbl_tiempoPromEsperaBB.Text = "Basketball";
            // 
            // lbl_tiempoPromEsperaHB
            // 
            lbl_tiempoPromEsperaHB.AutoSize = true;
            lbl_tiempoPromEsperaHB.Location = new Point(959, 620);
            lbl_tiempoPromEsperaHB.Name = "lbl_tiempoPromEsperaHB";
            lbl_tiempoPromEsperaHB.Size = new Size(70, 20);
            lbl_tiempoPromEsperaHB.TabIndex = 9;
            lbl_tiempoPromEsperaHB.Text = "Handball";
            // 
            // PantallaVisualizacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 693);
            Controls.Add(lbl_tiempoPromEsperaHB);
            Controls.Add(lbl_tiempoPromEsperaBB);
            Controls.Add(lbl_tiempoPromEsperaF);
            Controls.Add(txt_tiempoPromEsperaBB);
            Controls.Add(txt_tiempoPromEsperaHB);
            Controls.Add(txt_porcRetiraSinJugar);
            Controls.Add(txt_tiempoPromEsperaF);
            Controls.Add(lbl_porcRetiraSinJugar);
            Controls.Add(lbl_tiempoPromedioEspera);
            Controls.Add(gdw_iteracionesSolicitadas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PantallaVisualizacion";
            Text = "Visualización de Simulación Polideportivo";
            Load += PantallaVisualizacion_Load;
            ((System.ComponentModel.ISupportInitialize)gdw_iteracionesSolicitadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gdw_iteracionesSolicitadas;
        private Label lbl_tiempoPromedioEspera;
        private Label lbl_porcRetiraSinJugar;
        private TextBox txt_tiempoPromEsperaF;
        private TextBox txt_porcRetiraSinJugar;
        private TextBox txt_tiempoPromEsperaHB;
        private TextBox txt_tiempoPromEsperaBB;
        private Label lbl_tiempoPromEsperaF;
        private Label lbl_tiempoPromEsperaBB;
        private Label lbl_tiempoPromEsperaHB;
    }
}