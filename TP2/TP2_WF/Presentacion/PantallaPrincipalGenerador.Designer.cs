﻿namespace TP2_WF
{
    partial class PantallaPrincipalGenerador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbo_selectInterval = new System.Windows.Forms.ComboBox();
            this.txt_tamM = new System.Windows.Forms.TextBox();
            this.txt_param1 = new System.Windows.Forms.TextBox();
            this.txt_param2 = new System.Windows.Forms.TextBox();
            this.lbl_tamM = new System.Windows.Forms.Label();
            this.lbl_param1 = new System.Windows.Forms.Label();
            this.lbl_param2 = new System.Windows.Forms.Label();
            this.cbo_selectDist = new System.Windows.Forms.ComboBox();
            this.lbl_selectDist = new System.Windows.Forms.Label();
            this.lbl_selectInterval = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbx_radioButtons = new System.Windows.Forms.GroupBox();
            this.rbt_media = new System.Windows.Forms.RadioButton();
            this.rbt_lambda = new System.Windows.Forms.RadioButton();
            this.gbx_radioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_selectInterval
            // 
            this.cbo_selectInterval.FormattingEnabled = true;
            this.cbo_selectInterval.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25"});
            this.cbo_selectInterval.Location = new System.Drawing.Point(343, 34);
            this.cbo_selectInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_selectInterval.Name = "cbo_selectInterval";
            this.cbo_selectInterval.Size = new System.Drawing.Size(209, 24);
            this.cbo_selectInterval.TabIndex = 0;
            // 
            // txt_tamM
            // 
            this.txt_tamM.Location = new System.Drawing.Point(16, 95);
            this.txt_tamM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tamM.Name = "txt_tamM";
            this.txt_tamM.Size = new System.Drawing.Size(255, 22);
            this.txt_tamM.TabIndex = 1;
            this.txt_tamM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tamM_KeyPress);
            // 
            // txt_param1
            // 
            this.txt_param1.Location = new System.Drawing.Point(16, 144);
            this.txt_param1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_param1.Name = "txt_param1";
            this.txt_param1.Size = new System.Drawing.Size(255, 22);
            this.txt_param1.TabIndex = 2;
            this.txt_param1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_param1_KeyPress);
            // 
            // txt_param2
            // 
            this.txt_param2.Location = new System.Drawing.Point(16, 197);
            this.txt_param2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_param2.Name = "txt_param2";
            this.txt_param2.Size = new System.Drawing.Size(255, 22);
            this.txt_param2.TabIndex = 3;
            this.txt_param2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_param2_KeyPress);
            // 
            // lbl_tamM
            // 
            this.lbl_tamM.AutoSize = true;
            this.lbl_tamM.Location = new System.Drawing.Point(16, 71);
            this.lbl_tamM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tamM.Name = "lbl_tamM";
            this.lbl_tamM.Size = new System.Drawing.Size(128, 16);
            this.lbl_tamM.TabIndex = 4;
            this.lbl_tamM.Text = "Tamaño de Muestra";
            // 
            // lbl_param1
            // 
            this.lbl_param1.AutoSize = true;
            this.lbl_param1.Location = new System.Drawing.Point(15, 123);
            this.lbl_param1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_param1.Name = "lbl_param1";
            this.lbl_param1.Size = new System.Drawing.Size(37, 16);
            this.lbl_param1.TabIndex = 5;
            this.lbl_param1.Text = "label";
            // 
            // lbl_param2
            // 
            this.lbl_param2.AutoSize = true;
            this.lbl_param2.Location = new System.Drawing.Point(16, 177);
            this.lbl_param2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_param2.Name = "lbl_param2";
            this.lbl_param2.Size = new System.Drawing.Size(44, 16);
            this.lbl_param2.TabIndex = 6;
            this.lbl_param2.Text = "label3";
            // 
            // cbo_selectDist
            // 
            this.cbo_selectDist.FormattingEnabled = true;
            this.cbo_selectDist.Items.AddRange(new object[] {
            "Uniforme",
            "Normal",
            "Exponencial Negativa"});
            this.cbo_selectDist.Location = new System.Drawing.Point(16, 34);
            this.cbo_selectDist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_selectDist.Name = "cbo_selectDist";
            this.cbo_selectDist.Size = new System.Drawing.Size(255, 24);
            this.cbo_selectDist.TabIndex = 7;
            this.cbo_selectDist.SelectedIndexChanged += new System.EventHandler(this.cbo_selectDist_SelectedIndexChanged);
            // 
            // lbl_selectDist
            // 
            this.lbl_selectDist.AutoSize = true;
            this.lbl_selectDist.Location = new System.Drawing.Point(16, 11);
            this.lbl_selectDist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_selectDist.Name = "lbl_selectDist";
            this.lbl_selectDist.Size = new System.Drawing.Size(220, 16);
            this.lbl_selectDist.TabIndex = 8;
            this.lbl_selectDist.Text = "Seleccione la Distribución deseada";
            // 
            // lbl_selectInterval
            // 
            this.lbl_selectInterval.AutoSize = true;
            this.lbl_selectInterval.Location = new System.Drawing.Point(339, 11);
            this.lbl_selectInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_selectInterval.Name = "lbl_selectInterval";
            this.lbl_selectInterval.Size = new System.Drawing.Size(212, 16);
            this.lbl_selectInterval.TabIndex = 9;
            this.lbl_selectInterval.Text = "Seleccione Cantidad de Intervalos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 127);
            this.button1.TabIndex = 10;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbx_radioButtons
            // 
            this.gbx_radioButtons.Controls.Add(this.rbt_media);
            this.gbx_radioButtons.Controls.Add(this.rbt_lambda);
            this.gbx_radioButtons.Location = new System.Drawing.Point(272, 95);
            this.gbx_radioButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_radioButtons.Name = "gbx_radioButtons";
            this.gbx_radioButtons.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_radioButtons.Size = new System.Drawing.Size(72, 127);
            this.gbx_radioButtons.TabIndex = 11;
            this.gbx_radioButtons.TabStop = false;
            // 
            // rbt_media
            // 
            this.rbt_media.AutoSize = true;
            this.rbt_media.Location = new System.Drawing.Point(8, 106);
            this.rbt_media.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbt_media.Name = "rbt_media";
            this.rbt_media.Size = new System.Drawing.Size(17, 16);
            this.rbt_media.TabIndex = 1;
            this.rbt_media.TabStop = true;
            this.rbt_media.UseVisualStyleBackColor = true;
            this.rbt_media.CheckedChanged += new System.EventHandler(this.rbt_media_CheckedChanged);
            // 
            // rbt_lambda
            // 
            this.rbt_lambda.AutoSize = true;
            this.rbt_lambda.Location = new System.Drawing.Point(8, 53);
            this.rbt_lambda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbt_lambda.Name = "rbt_lambda";
            this.rbt_lambda.Size = new System.Drawing.Size(17, 16);
            this.rbt_lambda.TabIndex = 0;
            this.rbt_lambda.TabStop = true;
            this.rbt_lambda.UseVisualStyleBackColor = true;
            this.rbt_lambda.CheckedChanged += new System.EventHandler(this.rbt_lambda_CheckedChanged);
            // 
            // PantallaPrincipalGenerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 247);
            this.Controls.Add(this.gbx_radioButtons);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_selectInterval);
            this.Controls.Add(this.lbl_selectDist);
            this.Controls.Add(this.cbo_selectDist);
            this.Controls.Add(this.lbl_param2);
            this.Controls.Add(this.lbl_param1);
            this.Controls.Add(this.lbl_tamM);
            this.Controls.Add(this.txt_param2);
            this.Controls.Add(this.txt_param1);
            this.Controls.Add(this.txt_tamM);
            this.Controls.Add(this.cbo_selectInterval);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PantallaPrincipalGenerador";
            this.Text = "Generador de Números Aleatorios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_radioButtons.ResumeLayout(false);
            this.gbx_radioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_selectInterval;
        private System.Windows.Forms.TextBox txt_tamM;
        private System.Windows.Forms.TextBox txt_param1;
        private System.Windows.Forms.TextBox txt_param2;
        private System.Windows.Forms.Label lbl_tamM;
        private System.Windows.Forms.Label lbl_param1;
        private System.Windows.Forms.Label lbl_param2;
        private System.Windows.Forms.ComboBox cbo_selectDist;
        private System.Windows.Forms.Label lbl_selectDist;
        private System.Windows.Forms.Label lbl_selectInterval;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbx_radioButtons;
        private System.Windows.Forms.RadioButton rbt_media;
        private System.Windows.Forms.RadioButton rbt_lambda;
    }
}

