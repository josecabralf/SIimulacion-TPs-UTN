namespace TP2_WF.Presentacion
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
            this.gvw_datos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvw_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // gvw_datos
            // 
            this.gvw_datos.AllowUserToAddRows = false;
            this.gvw_datos.AllowUserToDeleteRows = false;
            this.gvw_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvw_datos.Location = new System.Drawing.Point(1056, 12);
            this.gvw_datos.Name = "gvw_datos";
            this.gvw_datos.ReadOnly = true;
            this.gvw_datos.Size = new System.Drawing.Size(175, 519);
            this.gvw_datos.TabIndex = 0;
            // 
            // PantallaVisualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 543);
            this.Controls.Add(this.gvw_datos);
            this.Name = "PantallaVisualizacion";
            this.Text = "Visualización de Datos Generados";
            ((System.ComponentModel.ISupportInitialize)(this.gvw_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvw_datos;
    }
}