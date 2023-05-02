namespace TP3_WF.Presentacion
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
            this.gdw_expSolicitados = new System.Windows.Forms.DataGridView();
            this.lbl_probabilidad = new System.Windows.Forms.Label();
            this.txt_probabilidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdw_expSolicitados)).BeginInit();
            this.SuspendLayout();
            // 
            // gdw_expSolicitados
            // 
            this.gdw_expSolicitados.AllowUserToAddRows = false;
            this.gdw_expSolicitados.AllowUserToDeleteRows = false;
            this.gdw_expSolicitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdw_expSolicitados.Location = new System.Drawing.Point(24, 12);
            this.gdw_expSolicitados.Name = "gdw_expSolicitados";
            this.gdw_expSolicitados.ReadOnly = true;
            this.gdw_expSolicitados.RowTemplate.Height = 25;
            this.gdw_expSolicitados.Size = new System.Drawing.Size(754, 390);
            this.gdw_expSolicitados.TabIndex = 0;
            // 
            // lbl_probabilidad
            // 
            this.lbl_probabilidad.AutoSize = true;
            this.lbl_probabilidad.Location = new System.Drawing.Point(489, 415);
            this.lbl_probabilidad.Name = "lbl_probabilidad";
            this.lbl_probabilidad.Size = new System.Drawing.Size(122, 15);
            this.lbl_probabilidad.TabIndex = 1;
            this.lbl_probabilidad.Text = "Probabilidad de éxito:";
            // 
            // txt_probabilidad
            // 
            this.txt_probabilidad.Enabled = false;
            this.txt_probabilidad.Location = new System.Drawing.Point(617, 412);
            this.txt_probabilidad.Name = "txt_probabilidad";
            this.txt_probabilidad.Size = new System.Drawing.Size(161, 23);
            this.txt_probabilidad.TabIndex = 2;
            // 
            // PantallaVisualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_probabilidad);
            this.Controls.Add(this.lbl_probabilidad);
            this.Controls.Add(this.gdw_expSolicitados);
            this.Name = "PantallaVisualizacion";
            this.Text = "Visualización de Datos Solicitados";
            this.Load += new System.EventHandler(this.PantallaVisualizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdw_expSolicitados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gdw_expSolicitados;
        private Label lbl_probabilidad;
        private TextBox txt_probabilidad;
    }
}