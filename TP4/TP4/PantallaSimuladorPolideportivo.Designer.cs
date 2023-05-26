namespace TP4
{
    partial class PantallaSimuladorPolideportivo
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
            this.lbl_tiempoSimulacion = new System.Windows.Forms.Label();
            this.txt_tiempoSimulacion = new System.Windows.Forms.TextBox();
            this.lbl_unidadTSim = new System.Windows.Forms.Label();
            this.txt_cantIteraciones = new System.Windows.Forms.TextBox();
            this.lbl_cantIteraciones = new System.Windows.Forms.Label();
            this.txt_horaDesde = new System.Windows.Forms.TextBox();
            this.lbl_horaDesde = new System.Windows.Forms.Label();
            this.lbl_paramsOpc = new System.Windows.Forms.Label();
            this.lbl_unidadTLim = new System.Windows.Forms.Label();
            this.txt_tiempoLimpieza = new System.Windows.Forms.TextBox();
            this.lbl_tiempoLimpieza = new System.Windows.Forms.Label();
            this.lbl_disciplina = new System.Windows.Forms.Label();
            this.lbl_futbol = new System.Windows.Forms.Label();
            this.lbl_handball = new System.Windows.Forms.Label();
            this.lbl_basketball = new System.Windows.Forms.Label();
            this.lbl_llegadas = new System.Windows.Forms.Label();
            this.lbl_ocupacion = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.lbl_distLlegHB1 = new System.Windows.Forms.Label();
            this.txt_distLlegHBDesde = new System.Windows.Forms.TextBox();
            this.lbl_distLlegHB2 = new System.Windows.Forms.Label();
            this.lbl_distLlegHB3 = new System.Windows.Forms.Label();
            this.txt_distLlegHBHasta = new System.Windows.Forms.TextBox();
            this.txt_distLlegBBHasta = new System.Windows.Forms.TextBox();
            this.lbl_distLlegBB3 = new System.Windows.Forms.Label();
            this.lbl_distLlegBB2 = new System.Windows.Forms.Label();
            this.txt_distLlegBBDesde = new System.Windows.Forms.TextBox();
            this.lbl_distLlegBB1 = new System.Windows.Forms.Label();
            this.txt_distOcupBBHasta = new System.Windows.Forms.TextBox();
            this.lbl_distoOcupBB3 = new System.Windows.Forms.Label();
            this.lbl_distoOcupBB2 = new System.Windows.Forms.Label();
            this.txt_distOcupBBDesde = new System.Windows.Forms.TextBox();
            this.lbl_distoOcupBB1 = new System.Windows.Forms.Label();
            this.txt_distOcupHBHasta = new System.Windows.Forms.TextBox();
            this.lbl_distoOcupHB3 = new System.Windows.Forms.Label();
            this.lbl_distoOcupHB2 = new System.Windows.Forms.Label();
            this.txt_distOcupHBDesde = new System.Windows.Forms.TextBox();
            this.lbl_distoOcupHB1 = new System.Windows.Forms.Label();
            this.txt_distOcupFHasta = new System.Windows.Forms.TextBox();
            this.lbl_distoOcupF3 = new System.Windows.Forms.Label();
            this.lbl_distoOcupF2 = new System.Windows.Forms.Label();
            this.txt_distOcupFDesde = new System.Windows.Forms.TextBox();
            this.lbl_distoOcupF1 = new System.Windows.Forms.Label();
            this.txt_distLlegF = new System.Windows.Forms.TextBox();
            this.lbl_distLlegF1 = new System.Windows.Forms.Label();
            this.lbl_distLlegF2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_tiempoSimulacion
            // 
            this.lbl_tiempoSimulacion.AutoSize = true;
            this.lbl_tiempoSimulacion.Location = new System.Drawing.Point(12, 9);
            this.lbl_tiempoSimulacion.Name = "lbl_tiempoSimulacion";
            this.lbl_tiempoSimulacion.Size = new System.Drawing.Size(124, 15);
            this.lbl_tiempoSimulacion.TabIndex = 0;
            this.lbl_tiempoSimulacion.Text = "Tiempo de simulación";
            // 
            // txt_tiempoSimulacion
            // 
            this.txt_tiempoSimulacion.Location = new System.Drawing.Point(12, 27);
            this.txt_tiempoSimulacion.Name = "txt_tiempoSimulacion";
            this.txt_tiempoSimulacion.Size = new System.Drawing.Size(100, 23);
            this.txt_tiempoSimulacion.TabIndex = 1;
            this.txt_tiempoSimulacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DoubleParam_KeyPress);
            // 
            // lbl_unidadTSim
            // 
            this.lbl_unidadTSim.AutoSize = true;
            this.lbl_unidadTSim.Location = new System.Drawing.Point(118, 30);
            this.lbl_unidadTSim.Name = "lbl_unidadTSim";
            this.lbl_unidadTSim.Size = new System.Drawing.Size(28, 15);
            this.lbl_unidadTSim.TabIndex = 2;
            this.lbl_unidadTSim.Text = "min";
            // 
            // txt_cantIteraciones
            // 
            this.txt_cantIteraciones.Location = new System.Drawing.Point(12, 80);
            this.txt_cantIteraciones.Name = "txt_cantIteraciones";
            this.txt_cantIteraciones.Size = new System.Drawing.Size(131, 23);
            this.txt_cantIteraciones.TabIndex = 4;
            this.txt_cantIteraciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IntParam_KeyPress);
            // 
            // lbl_cantIteraciones
            // 
            this.lbl_cantIteraciones.AutoSize = true;
            this.lbl_cantIteraciones.Location = new System.Drawing.Point(12, 62);
            this.lbl_cantIteraciones.Name = "lbl_cantIteraciones";
            this.lbl_cantIteraciones.Size = new System.Drawing.Size(131, 15);
            this.lbl_cantIteraciones.TabIndex = 3;
            this.lbl_cantIteraciones.Text = "Cantidad de iteraciones";
            // 
            // txt_horaDesde
            // 
            this.txt_horaDesde.Location = new System.Drawing.Point(190, 80);
            this.txt_horaDesde.Name = "txt_horaDesde";
            this.txt_horaDesde.Size = new System.Drawing.Size(131, 23);
            this.txt_horaDesde.TabIndex = 6;
            this.txt_horaDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DoubleParam_KeyPress);
            // 
            // lbl_horaDesde
            // 
            this.lbl_horaDesde.AutoSize = true;
            this.lbl_horaDesde.Location = new System.Drawing.Point(190, 62);
            this.lbl_horaDesde.Name = "lbl_horaDesde";
            this.lbl_horaDesde.Size = new System.Drawing.Size(66, 15);
            this.lbl_horaDesde.TabIndex = 5;
            this.lbl_horaDesde.Text = "Desde hora";
            // 
            // lbl_paramsOpc
            // 
            this.lbl_paramsOpc.AutoSize = true;
            this.lbl_paramsOpc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_paramsOpc.Location = new System.Drawing.Point(12, 130);
            this.lbl_paramsOpc.Name = "lbl_paramsOpc";
            this.lbl_paramsOpc.Size = new System.Drawing.Size(132, 15);
            this.lbl_paramsOpc.TabIndex = 7;
            this.lbl_paramsOpc.Text = "Parametros opcionales";
            // 
            // lbl_unidadTLim
            // 
            this.lbl_unidadTLim.AutoSize = true;
            this.lbl_unidadTLim.Location = new System.Drawing.Point(118, 183);
            this.lbl_unidadTLim.Name = "lbl_unidadTLim";
            this.lbl_unidadTLim.Size = new System.Drawing.Size(28, 15);
            this.lbl_unidadTLim.TabIndex = 10;
            this.lbl_unidadTLim.Text = "min";
            // 
            // txt_tiempoLimpieza
            // 
            this.txt_tiempoLimpieza.Location = new System.Drawing.Point(16, 175);
            this.txt_tiempoLimpieza.Name = "txt_tiempoLimpieza";
            this.txt_tiempoLimpieza.Size = new System.Drawing.Size(100, 23);
            this.txt_tiempoLimpieza.TabIndex = 9;
            this.txt_tiempoLimpieza.Text = "10";
            this.txt_tiempoLimpieza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DoubleParam_KeyPress);
            // 
            // lbl_tiempoLimpieza
            // 
            this.lbl_tiempoLimpieza.AutoSize = true;
            this.lbl_tiempoLimpieza.Location = new System.Drawing.Point(12, 154);
            this.lbl_tiempoLimpieza.Name = "lbl_tiempoLimpieza";
            this.lbl_tiempoLimpieza.Size = new System.Drawing.Size(110, 15);
            this.lbl_tiempoLimpieza.TabIndex = 8;
            this.lbl_tiempoLimpieza.Text = "Tiempo de limpieza";
            // 
            // lbl_disciplina
            // 
            this.lbl_disciplina.AutoSize = true;
            this.lbl_disciplina.Location = new System.Drawing.Point(16, 218);
            this.lbl_disciplina.Name = "lbl_disciplina";
            this.lbl_disciplina.Size = new System.Drawing.Size(58, 15);
            this.lbl_disciplina.TabIndex = 11;
            this.lbl_disciplina.Text = "Disciplina";
            // 
            // lbl_futbol
            // 
            this.lbl_futbol.AutoSize = true;
            this.lbl_futbol.Location = new System.Drawing.Point(16, 254);
            this.lbl_futbol.Name = "lbl_futbol";
            this.lbl_futbol.Size = new System.Drawing.Size(41, 15);
            this.lbl_futbol.TabIndex = 12;
            this.lbl_futbol.Text = "Fútbol";
            // 
            // lbl_handball
            // 
            this.lbl_handball.AutoSize = true;
            this.lbl_handball.Location = new System.Drawing.Point(16, 291);
            this.lbl_handball.Name = "lbl_handball";
            this.lbl_handball.Size = new System.Drawing.Size(55, 15);
            this.lbl_handball.TabIndex = 13;
            this.lbl_handball.Text = "Handball";
            // 
            // lbl_basketball
            // 
            this.lbl_basketball.AutoSize = true;
            this.lbl_basketball.Location = new System.Drawing.Point(20, 335);
            this.lbl_basketball.Name = "lbl_basketball";
            this.lbl_basketball.Size = new System.Drawing.Size(60, 15);
            this.lbl_basketball.TabIndex = 14;
            this.lbl_basketball.Text = "Basketball";
            // 
            // lbl_llegadas
            // 
            this.lbl_llegadas.AutoSize = true;
            this.lbl_llegadas.Location = new System.Drawing.Point(121, 218);
            this.lbl_llegadas.Name = "lbl_llegadas";
            this.lbl_llegadas.Size = new System.Drawing.Size(53, 15);
            this.lbl_llegadas.TabIndex = 15;
            this.lbl_llegadas.Text = "Llegadas";
            // 
            // lbl_ocupacion
            // 
            this.lbl_ocupacion.AutoSize = true;
            this.lbl_ocupacion.Location = new System.Drawing.Point(315, 218);
            this.lbl_ocupacion.Name = "lbl_ocupacion";
            this.lbl_ocupacion.Size = new System.Drawing.Size(127, 15);
            this.lbl_ocupacion.TabIndex = 16;
            this.lbl_ocupacion.Text = "Ocupación de canchas";
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.Red;
            this.btn_generar.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_generar.ForeColor = System.Drawing.Color.Cyan;
            this.btn_generar.Location = new System.Drawing.Point(16, 430);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(456, 94);
            this.btn_generar.TabIndex = 17;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // lbl_distLlegHB1
            // 
            this.lbl_distLlegHB1.AutoSize = true;
            this.lbl_distLlegHB1.Location = new System.Drawing.Point(121, 291);
            this.lbl_distLlegHB1.Name = "lbl_distLlegHB1";
            this.lbl_distLlegHB1.Size = new System.Drawing.Size(19, 15);
            this.lbl_distLlegHB1.TabIndex = 18;
            this.lbl_distLlegHB1.Text = "U(";
            // 
            // txt_distLlegHBDesde
            // 
            this.txt_distLlegHBDesde.Location = new System.Drawing.Point(139, 288);
            this.txt_distLlegHBDesde.Name = "txt_distLlegHBDesde";
            this.txt_distLlegHBDesde.Size = new System.Drawing.Size(47, 23);
            this.txt_distLlegHBDesde.TabIndex = 19;
            this.txt_distLlegHBDesde.Text = "10";
            this.txt_distLlegHBDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DoubleParam_KeyPress);
            // 
            // lbl_distLlegHB2
            // 
            this.lbl_distLlegHB2.AutoSize = true;
            this.lbl_distLlegHB2.Location = new System.Drawing.Point(187, 296);
            this.lbl_distLlegHB2.Name = "lbl_distLlegHB2";
            this.lbl_distLlegHB2.Size = new System.Drawing.Size(10, 15);
            this.lbl_distLlegHB2.TabIndex = 20;
            this.lbl_distLlegHB2.Text = ",";
            // 
            // lbl_distLlegHB3
            // 
            this.lbl_distLlegHB3.AutoSize = true;
            this.lbl_distLlegHB3.Location = new System.Drawing.Point(247, 291);
            this.lbl_distLlegHB3.Name = "lbl_distLlegHB3";
            this.lbl_distLlegHB3.Size = new System.Drawing.Size(26, 15);
            this.lbl_distLlegHB3.TabIndex = 21;
            this.lbl_distLlegHB3.Text = ") hs";
            // 
            // txt_distLlegHBHasta
            // 
            this.txt_distLlegHBHasta.Location = new System.Drawing.Point(194, 288);
            this.txt_distLlegHBHasta.Name = "txt_distLlegHBHasta";
            this.txt_distLlegHBHasta.Size = new System.Drawing.Size(47, 23);
            this.txt_distLlegHBHasta.TabIndex = 23;
            this.txt_distLlegHBHasta.Text = "14";
            this.txt_distLlegHBHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DoubleParam_KeyPress);
            // 
            // txt_distLlegBBHasta
            // 
            this.txt_distLlegBBHasta.Location = new System.Drawing.Point(194, 332);
            this.txt_distLlegBBHasta.Name = "txt_distLlegBBHasta";
            this.txt_distLlegBBHasta.Size = new System.Drawing.Size(47, 23);
            this.txt_distLlegBBHasta.TabIndex = 28;
            this.txt_distLlegBBHasta.Text = "10";
            this.txt_distLlegBBHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DoubleParam_KeyPress);
            // 
            // lbl_distLlegBB3
            // 
            this.lbl_distLlegBB3.AutoSize = true;
            this.lbl_distLlegBB3.Location = new System.Drawing.Point(247, 335);
            this.lbl_distLlegBB3.Name = "lbl_distLlegBB3";
            this.lbl_distLlegBB3.Size = new System.Drawing.Size(26, 15);
            this.lbl_distLlegBB3.TabIndex = 27;
            this.lbl_distLlegBB3.Text = ") hs";
            // 
            // lbl_distLlegBB2
            // 
            this.lbl_distLlegBB2.AutoSize = true;
            this.lbl_distLlegBB2.Location = new System.Drawing.Point(187, 340);
            this.lbl_distLlegBB2.Name = "lbl_distLlegBB2";
            this.lbl_distLlegBB2.Size = new System.Drawing.Size(10, 15);
            this.lbl_distLlegBB2.TabIndex = 26;
            this.lbl_distLlegBB2.Text = ",";
            // 
            // txt_distLlegBBDesde
            // 
            this.txt_distLlegBBDesde.Location = new System.Drawing.Point(139, 332);
            this.txt_distLlegBBDesde.Name = "txt_distLlegBBDesde";
            this.txt_distLlegBBDesde.Size = new System.Drawing.Size(47, 23);
            this.txt_distLlegBBDesde.TabIndex = 25;
            this.txt_distLlegBBDesde.Text = "6";
            this.txt_distLlegBBDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DoubleParam_KeyPress);
            // 
            // lbl_distLlegBB1
            // 
            this.lbl_distLlegBB1.AutoSize = true;
            this.lbl_distLlegBB1.Location = new System.Drawing.Point(121, 335);
            this.lbl_distLlegBB1.Name = "lbl_distLlegBB1";
            this.lbl_distLlegBB1.Size = new System.Drawing.Size(19, 15);
            this.lbl_distLlegBB1.TabIndex = 24;
            this.lbl_distLlegBB1.Text = "U(";
            // 
            // txt_distOcupBBHasta
            // 
            this.txt_distOcupBBHasta.Location = new System.Drawing.Point(388, 335);
            this.txt_distOcupBBHasta.Name = "txt_distOcupBBHasta";
            this.txt_distOcupBBHasta.Size = new System.Drawing.Size(47, 23);
            this.txt_distOcupBBHasta.TabIndex = 33;
            this.txt_distOcupBBHasta.Text = "130";
            this.txt_distOcupBBHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DoubleParam_KeyPress);
            // 
            // lbl_distoOcupBB3
            // 
            this.lbl_distoOcupBB3.AutoSize = true;
            this.lbl_distoOcupBB3.Location = new System.Drawing.Point(441, 338);
            this.lbl_distoOcupBB3.Name = "lbl_distoOcupBB3";
            this.lbl_distoOcupBB3.Size = new System.Drawing.Size(35, 15);
            this.lbl_distoOcupBB3.TabIndex = 32;
            this.lbl_distoOcupBB3.Text = ") min";
            // 
            // lbl_distoOcupBB2
            // 
            this.lbl_distoOcupBB2.AutoSize = true;
            this.lbl_distoOcupBB2.Location = new System.Drawing.Point(381, 343);
            this.lbl_distoOcupBB2.Name = "lbl_distoOcupBB2";
            this.lbl_distoOcupBB2.Size = new System.Drawing.Size(10, 15);
            this.lbl_distoOcupBB2.TabIndex = 31;
            this.lbl_distoOcupBB2.Text = ",";
            // 
            // txt_distOcupBBDesde
            // 
            this.txt_distOcupBBDesde.Location = new System.Drawing.Point(333, 335);
            this.txt_distOcupBBDesde.Name = "txt_distOcupBBDesde";
            this.txt_distOcupBBDesde.Size = new System.Drawing.Size(47, 23);
            this.txt_distOcupBBDesde.TabIndex = 30;
            this.txt_distOcupBBDesde.Text = "70";
            this.txt_distOcupBBDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DoubleParam_KeyPress);
            // 
            // lbl_distoOcupBB1
            // 
            this.lbl_distoOcupBB1.AutoSize = true;
            this.lbl_distoOcupBB1.Location = new System.Drawing.Point(315, 338);
            this.lbl_distoOcupBB1.Name = "lbl_distoOcupBB1";
            this.lbl_distoOcupBB1.Size = new System.Drawing.Size(19, 15);
            this.lbl_distoOcupBB1.TabIndex = 29;
            this.lbl_distoOcupBB1.Text = "U(";
            // 
            // txt_distOcupHBHasta
            // 
            this.txt_distOcupHBHasta.Location = new System.Drawing.Point(388, 288);
            this.txt_distOcupHBHasta.Name = "txt_distOcupHBHasta";
            this.txt_distOcupHBHasta.Size = new System.Drawing.Size(47, 23);
            this.txt_distOcupHBHasta.TabIndex = 38;
            this.txt_distOcupHBHasta.Text = "100";
            this.txt_distOcupHBHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DoubleParam_KeyPress);
            // 
            // lbl_distoOcupHB3
            // 
            this.lbl_distoOcupHB3.AutoSize = true;
            this.lbl_distoOcupHB3.Location = new System.Drawing.Point(441, 291);
            this.lbl_distoOcupHB3.Name = "lbl_distoOcupHB3";
            this.lbl_distoOcupHB3.Size = new System.Drawing.Size(35, 15);
            this.lbl_distoOcupHB3.TabIndex = 37;
            this.lbl_distoOcupHB3.Text = ") min";
            // 
            // lbl_distoOcupHB2
            // 
            this.lbl_distoOcupHB2.AutoSize = true;
            this.lbl_distoOcupHB2.Location = new System.Drawing.Point(381, 296);
            this.lbl_distoOcupHB2.Name = "lbl_distoOcupHB2";
            this.lbl_distoOcupHB2.Size = new System.Drawing.Size(10, 15);
            this.lbl_distoOcupHB2.TabIndex = 36;
            this.lbl_distoOcupHB2.Text = ",";
            // 
            // txt_distOcupHBDesde
            // 
            this.txt_distOcupHBDesde.Location = new System.Drawing.Point(333, 288);
            this.txt_distOcupHBDesde.Name = "txt_distOcupHBDesde";
            this.txt_distOcupHBDesde.Size = new System.Drawing.Size(47, 23);
            this.txt_distOcupHBDesde.TabIndex = 35;
            this.txt_distOcupHBDesde.Text = "60";
            this.txt_distOcupHBDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DoubleParam_KeyPress);
            // 
            // lbl_distoOcupHB1
            // 
            this.lbl_distoOcupHB1.AutoSize = true;
            this.lbl_distoOcupHB1.Location = new System.Drawing.Point(315, 291);
            this.lbl_distoOcupHB1.Name = "lbl_distoOcupHB1";
            this.lbl_distoOcupHB1.Size = new System.Drawing.Size(19, 15);
            this.lbl_distoOcupHB1.TabIndex = 34;
            this.lbl_distoOcupHB1.Text = "U(";
            // 
            // txt_distOcupFHasta
            // 
            this.txt_distOcupFHasta.Location = new System.Drawing.Point(388, 251);
            this.txt_distOcupFHasta.Name = "txt_distOcupFHasta";
            this.txt_distOcupFHasta.Size = new System.Drawing.Size(47, 23);
            this.txt_distOcupFHasta.TabIndex = 43;
            this.txt_distOcupFHasta.Text = "100";
            this.txt_distOcupFHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DoubleParam_KeyPress);
            // 
            // lbl_distoOcupF3
            // 
            this.lbl_distoOcupF3.AutoSize = true;
            this.lbl_distoOcupF3.Location = new System.Drawing.Point(441, 254);
            this.lbl_distoOcupF3.Name = "lbl_distoOcupF3";
            this.lbl_distoOcupF3.Size = new System.Drawing.Size(35, 15);
            this.lbl_distoOcupF3.TabIndex = 42;
            this.lbl_distoOcupF3.Text = ") min";
            // 
            // lbl_distoOcupF2
            // 
            this.lbl_distoOcupF2.AutoSize = true;
            this.lbl_distoOcupF2.Location = new System.Drawing.Point(381, 259);
            this.lbl_distoOcupF2.Name = "lbl_distoOcupF2";
            this.lbl_distoOcupF2.Size = new System.Drawing.Size(10, 15);
            this.lbl_distoOcupF2.TabIndex = 41;
            this.lbl_distoOcupF2.Text = ",";
            // 
            // txt_distOcupFDesde
            // 
            this.txt_distOcupFDesde.Location = new System.Drawing.Point(333, 251);
            this.txt_distOcupFDesde.Name = "txt_distOcupFDesde";
            this.txt_distOcupFDesde.Size = new System.Drawing.Size(47, 23);
            this.txt_distOcupFDesde.TabIndex = 40;
            this.txt_distOcupFDesde.Text = "80";
            this.txt_distOcupFDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DoubleParam_KeyPress);
            // 
            // lbl_distoOcupF1
            // 
            this.lbl_distoOcupF1.AutoSize = true;
            this.lbl_distoOcupF1.Location = new System.Drawing.Point(315, 254);
            this.lbl_distoOcupF1.Name = "lbl_distoOcupF1";
            this.lbl_distoOcupF1.Size = new System.Drawing.Size(19, 15);
            this.lbl_distoOcupF1.TabIndex = 39;
            this.lbl_distoOcupF1.Text = "U(";
            // 
            // txt_distLlegF
            // 
            this.txt_distLlegF.Location = new System.Drawing.Point(184, 248);
            this.txt_distLlegF.Name = "txt_distLlegF";
            this.txt_distLlegF.Size = new System.Drawing.Size(47, 23);
            this.txt_distLlegF.TabIndex = 44;
            this.txt_distLlegF.Text = "10";
            this.txt_distLlegF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DoubleParam_KeyPress);
            // 
            // lbl_distLlegF1
            // 
            this.lbl_distLlegF1.AutoSize = true;
            this.lbl_distLlegF1.Location = new System.Drawing.Point(121, 251);
            this.lbl_distLlegF1.Name = "lbl_distLlegF1";
            this.lbl_distLlegF1.Size = new System.Drawing.Size(57, 15);
            this.lbl_distLlegF1.TabIndex = 45;
            this.lbl_distLlegF1.Text = "Exp. Neg.";
            // 
            // lbl_distLlegF2
            // 
            this.lbl_distLlegF2.AutoSize = true;
            this.lbl_distLlegF2.Location = new System.Drawing.Point(237, 254);
            this.lbl_distLlegF2.Name = "lbl_distLlegF2";
            this.lbl_distLlegF2.Size = new System.Drawing.Size(22, 15);
            this.lbl_distLlegF2.TabIndex = 46;
            this.lbl_distLlegF2.Text = " hs";
            // 
            // PantallaSimuladorPolideportivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 536);
            this.Controls.Add(this.lbl_distLlegF2);
            this.Controls.Add(this.lbl_distLlegF1);
            this.Controls.Add(this.txt_distLlegF);
            this.Controls.Add(this.txt_distOcupFHasta);
            this.Controls.Add(this.lbl_distoOcupF3);
            this.Controls.Add(this.lbl_distoOcupF2);
            this.Controls.Add(this.txt_distOcupFDesde);
            this.Controls.Add(this.lbl_distoOcupF1);
            this.Controls.Add(this.txt_distOcupHBHasta);
            this.Controls.Add(this.lbl_distoOcupHB3);
            this.Controls.Add(this.lbl_distoOcupHB2);
            this.Controls.Add(this.txt_distOcupHBDesde);
            this.Controls.Add(this.lbl_distoOcupHB1);
            this.Controls.Add(this.txt_distOcupBBHasta);
            this.Controls.Add(this.lbl_distoOcupBB3);
            this.Controls.Add(this.lbl_distoOcupBB2);
            this.Controls.Add(this.txt_distOcupBBDesde);
            this.Controls.Add(this.lbl_distoOcupBB1);
            this.Controls.Add(this.txt_distLlegBBHasta);
            this.Controls.Add(this.lbl_distLlegBB3);
            this.Controls.Add(this.lbl_distLlegBB2);
            this.Controls.Add(this.txt_distLlegBBDesde);
            this.Controls.Add(this.lbl_distLlegBB1);
            this.Controls.Add(this.txt_distLlegHBHasta);
            this.Controls.Add(this.lbl_distLlegHB3);
            this.Controls.Add(this.lbl_distLlegHB2);
            this.Controls.Add(this.txt_distLlegHBDesde);
            this.Controls.Add(this.lbl_distLlegHB1);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.lbl_ocupacion);
            this.Controls.Add(this.lbl_llegadas);
            this.Controls.Add(this.lbl_basketball);
            this.Controls.Add(this.lbl_handball);
            this.Controls.Add(this.lbl_futbol);
            this.Controls.Add(this.lbl_disciplina);
            this.Controls.Add(this.lbl_unidadTLim);
            this.Controls.Add(this.txt_tiempoLimpieza);
            this.Controls.Add(this.lbl_tiempoLimpieza);
            this.Controls.Add(this.lbl_paramsOpc);
            this.Controls.Add(this.txt_horaDesde);
            this.Controls.Add(this.lbl_horaDesde);
            this.Controls.Add(this.txt_cantIteraciones);
            this.Controls.Add(this.lbl_cantIteraciones);
            this.Controls.Add(this.lbl_unidadTSim);
            this.Controls.Add(this.txt_tiempoSimulacion);
            this.Controls.Add(this.lbl_tiempoSimulacion);
            this.Name = "PantallaSimuladorPolideportivo";
            this.Text = "Pantalla Simulador Polideportivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_tiempoSimulacion;
        private TextBox txt_tiempoSimulacion;
        private Label lbl_unidadTSim;
        private TextBox txt_cantIteraciones;
        private Label lbl_cantIteraciones;
        private TextBox txt_horaDesde;
        private Label lbl_horaDesde;
        private Label lbl_paramsOpc;
        private Label lbl_unidadTLim;
        private TextBox txt_tiempoLimpieza;
        private Label lbl_tiempoLimpieza;
        private Label lbl_disciplina;
        private Label lbl_futbol;
        private Label lbl_handball;
        private Label lbl_basketball;
        private Label lbl_llegadas;
        private Label lbl_ocupacion;
        private Button btn_generar;
        private Label lbl_distLlegHB1;
        private TextBox txt_distLlegHBDesde;
        private Label lbl_distLlegHB2;
        private Label lbl_distLlegHB3;
        private TextBox txt_distLlegHBHasta;
        private TextBox txt_distLlegBBHasta;
        private Label lbl_distLlegBB3;
        private Label lbl_distLlegBB2;
        private TextBox txt_distLlegBBDesde;
        private Label lbl_distLlegBB1;
        private TextBox txt_distOcupBBHasta;
        private Label lbl_distoOcupBB3;
        private Label lbl_distoOcupBB2;
        private TextBox txt_distOcupBBDesde;
        private Label lbl_distoOcupBB1;
        private TextBox txt_distOcupHBHasta;
        private Label lbl_distoOcupHB3;
        private Label lbl_distoOcupHB2;
        private TextBox txt_distOcupHBDesde;
        private Label lbl_distoOcupHB1;
        private TextBox txt_distOcupFHasta;
        private Label lbl_distoOcupF3;
        private Label lbl_distoOcupF2;
        private TextBox txt_distOcupFDesde;
        private Label lbl_distoOcupF1;
        private TextBox txt_distLlegF;
        private Label lbl_distLlegF1;
        private Label lbl_distLlegF2;
    }
}