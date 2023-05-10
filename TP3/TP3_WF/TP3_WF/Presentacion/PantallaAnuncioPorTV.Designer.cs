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
            lbl_noRecuerda = new Label();
            lbl_recuerda = new Label();
            lbl_probRecuerda = new Label();
            txt_noRecDud = new TextBox();
            txt_noRecSi = new TextBox();
            txt_recNo = new TextBox();
            txt_recDud = new TextBox();
            txt_recSi = new TextBox();
            txt_noRecNo = new TextBox();
            txt_probRec = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // lbl_nroExperimentos
            // 
            lbl_nroExperimentos.AutoSize = true;
            lbl_nroExperimentos.Location = new Point(13, 9);
            lbl_nroExperimentos.Name = "lbl_nroExperimentos";
            lbl_nroExperimentos.Size = new Size(178, 20);
            lbl_nroExperimentos.TabIndex = 0;
            lbl_nroExperimentos.Text = "Número de Experimentos";
            // 
            // lbl_desde
            // 
            lbl_desde.AutoSize = true;
            lbl_desde.Location = new Point(13, 62);
            lbl_desde.Name = "lbl_desde";
            lbl_desde.Size = new Size(51, 20);
            lbl_desde.TabIndex = 1;
            lbl_desde.Text = "Desde";
            // 
            // lbl_cant
            // 
            lbl_cant.AutoSize = true;
            lbl_cant.Location = new Point(13, 115);
            lbl_cant.Name = "lbl_cant";
            lbl_cant.Size = new Size(135, 20);
            lbl_cant.TabIndex = 2;
            lbl_cant.Text = "Cantidad de Lineas";
            // 
            // btn_generar
            // 
            btn_generar.BackColor = Color.Red;
            btn_generar.Location = new Point(235, 65);
            btn_generar.Name = "btn_generar";
            btn_generar.Size = new Size(171, 100);
            btn_generar.TabIndex = 3;
            btn_generar.Text = "Generar";
            btn_generar.UseVisualStyleBackColor = false;
            btn_generar.Click += btn_generar_Click;
            // 
            // txt_nroExperimento
            // 
            txt_nroExperimento.Location = new Point(13, 32);
            txt_nroExperimento.Name = "txt_nroExperimento";
            txt_nroExperimento.Size = new Size(184, 27);
            txt_nroExperimento.TabIndex = 4;
            txt_nroExperimento.KeyPress += txt_nroExperimento_KeyPress;
            // 
            // txt_desde
            // 
            txt_desde.Location = new Point(13, 85);
            txt_desde.Name = "txt_desde";
            txt_desde.Size = new Size(184, 27);
            txt_desde.TabIndex = 5;
            txt_desde.KeyPress += txt_desde_KeyPress;
            // 
            // txt_cant
            // 
            txt_cant.Location = new Point(13, 138);
            txt_cant.Name = "txt_cant";
            txt_cant.Size = new Size(184, 27);
            txt_cant.TabIndex = 6;
            txt_cant.KeyPress += txt_cant_KeyPress;
            // 
            // lbl_noRecuerda
            // 
            lbl_noRecuerda.AutoSize = true;
            lbl_noRecuerda.Location = new Point(311, 209);
            lbl_noRecuerda.Name = "lbl_noRecuerda";
            lbl_noRecuerda.Size = new Size(95, 20);
            lbl_noRecuerda.TabIndex = 7;
            lbl_noRecuerda.Text = "No Recuerda";
            // 
            // lbl_recuerda
            // 
            lbl_recuerda.AutoSize = true;
            lbl_recuerda.Location = new Point(13, 209);
            lbl_recuerda.Name = "lbl_recuerda";
            lbl_recuerda.Size = new Size(71, 20);
            lbl_recuerda.TabIndex = 8;
            lbl_recuerda.Text = "Recuerda";
            // 
            // lbl_probRecuerda
            // 
            lbl_probRecuerda.AutoSize = true;
            lbl_probRecuerda.Location = new Point(234, 9);
            lbl_probRecuerda.Name = "lbl_probRecuerda";
            lbl_probRecuerda.Size = new Size(161, 20);
            lbl_probRecuerda.TabIndex = 9;
            lbl_probRecuerda.Text = "Probabilidad Recuerda";
            // 
            // txt_noRecDud
            // 
            txt_noRecDud.Location = new Point(234, 305);
            txt_noRecDud.Name = "txt_noRecDud";
            txt_noRecDud.Size = new Size(172, 27);
            txt_noRecDud.TabIndex = 10;
            // 
            // txt_noRecSi
            // 
            txt_noRecSi.Location = new Point(234, 252);
            txt_noRecSi.Name = "txt_noRecSi";
            txt_noRecSi.Size = new Size(172, 27);
            txt_noRecSi.TabIndex = 11;
            // 
            // txt_recNo
            // 
            txt_recNo.Location = new Point(13, 358);
            txt_recNo.Name = "txt_recNo";
            txt_recNo.Size = new Size(161, 27);
            txt_recNo.TabIndex = 12;
            // 
            // txt_recDud
            // 
            txt_recDud.Location = new Point(12, 305);
            txt_recDud.Name = "txt_recDud";
            txt_recDud.Size = new Size(161, 27);
            txt_recDud.TabIndex = 13;
            // 
            // txt_recSi
            // 
            txt_recSi.Location = new Point(12, 252);
            txt_recSi.Name = "txt_recSi";
            txt_recSi.Size = new Size(161, 27);
            txt_recSi.TabIndex = 14;
            // 
            // txt_noRecNo
            // 
            txt_noRecNo.Location = new Point(234, 358);
            txt_noRecNo.Name = "txt_noRecNo";
            txt_noRecNo.Size = new Size(172, 27);
            txt_noRecNo.TabIndex = 15;
            // 
            // txt_probRec
            // 
            txt_probRec.Location = new Point(235, 32);
            txt_probRec.Name = "txt_probRec";
            txt_probRec.Size = new Size(171, 27);
            txt_probRec.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 229);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 17;
            label1.Text = "Definitivamente si";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 229);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 18;
            label2.Text = "Definitivamente si";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 282);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 19;
            label3.Text = "Dudosa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 282);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 20;
            label4.Text = "Dudosa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 335);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 21;
            label5.Text = "Definitivamente no";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 335);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 22;
            label6.Text = "Definitivamente no";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(133, 187);
            label7.Name = "label7";
            label7.Size = new Size(161, 20);
            label7.TabIndex = 23;
            label7.Text = "Parametros Opcionales";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 398);
            label8.Name = "label8";
            label8.Size = new Size(277, 20);
            label8.TabIndex = 24;
            label8.Text = "Los decimales deben introducirse con \",\"";
            // 
            // PantallaAnuncioPorTV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 427);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_probRec);
            Controls.Add(txt_noRecNo);
            Controls.Add(txt_recSi);
            Controls.Add(txt_recDud);
            Controls.Add(txt_recNo);
            Controls.Add(txt_noRecSi);
            Controls.Add(txt_noRecDud);
            Controls.Add(lbl_probRecuerda);
            Controls.Add(lbl_recuerda);
            Controls.Add(lbl_noRecuerda);
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
        private Label lbl_noRecuerda;
        private Label lbl_recuerda;
        private Label lbl_probRecuerda;
        private TextBox txt_noRecDud;
        private TextBox txt_noRecSi;
        private TextBox txt_recNo;
        private TextBox txt_recDud;
        private TextBox txt_recSi;
        private TextBox txt_noRecNo;
        private TextBox txt_probRec;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}