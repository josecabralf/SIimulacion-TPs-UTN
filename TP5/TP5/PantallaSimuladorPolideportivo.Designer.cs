namespace TP5
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
            lbl_tiempoSimulacion = new Label();
            txt_tiempoSimulacion = new TextBox();
            lbl_unidadTSim = new Label();
            txt_cantIteraciones = new TextBox();
            lbl_cantIteraciones = new Label();
            txt_horaDesde = new TextBox();
            lbl_horaDesde = new Label();
            lbl_paramsOpc = new Label();
            txt_hTLimpieza = new TextBox();
            lbl_tiempoLimpieza = new Label();
            lbl_disciplina = new Label();
            lbl_futbol = new Label();
            lbl_handball = new Label();
            lbl_basketball = new Label();
            lbl_llegadas = new Label();
            lbl_ocupacion = new Label();
            btn_generar = new Button();
            lbl_distLlegHB1 = new Label();
            txt_distLlegHBDesde = new TextBox();
            lbl_distLlegHB2 = new Label();
            lbl_distLlegHB3 = new Label();
            txt_distLlegHBHasta = new TextBox();
            txt_distLlegBBHasta = new TextBox();
            lbl_distLlegBB3 = new Label();
            lbl_distLlegBB2 = new Label();
            txt_distLlegBBDesde = new TextBox();
            lbl_distLlegBB1 = new Label();
            txt_distOcupBBHasta = new TextBox();
            lbl_distoOcupBB3 = new Label();
            lbl_distoOcupBB2 = new Label();
            txt_distOcupBBDesde = new TextBox();
            lbl_distoOcupBB1 = new Label();
            txt_distOcupHBHasta = new TextBox();
            lbl_distoOcupHB3 = new Label();
            lbl_distoOcupHB2 = new Label();
            txt_distOcupHBDesde = new TextBox();
            lbl_distoOcupHB1 = new Label();
            txt_distOcupFHasta = new TextBox();
            lbl_distoOcupF3 = new Label();
            lbl_distoOcupF2 = new Label();
            txt_distOcupFDesde = new TextBox();
            lbl_distoOcupF1 = new Label();
            txt_distLlegF = new TextBox();
            lbl_distLlegF1 = new Label();
            lbl_distLlegF2 = new Label();
            lbl_hTLimpieza = new Label();
            lbl_DGeneral = new Label();
            lbl_DFutbol = new Label();
            lbl_DHandball = new Label();
            lbl_DBasketball = new Label();
            txt_DFutbol = new TextBox();
            txt_DHandball = new TextBox();
            txt_DBasketball = new TextBox();
            SuspendLayout();
            // 
            // lbl_tiempoSimulacion
            // 
            lbl_tiempoSimulacion.AutoSize = true;
            lbl_tiempoSimulacion.Location = new Point(14, 12);
            lbl_tiempoSimulacion.Name = "lbl_tiempoSimulacion";
            lbl_tiempoSimulacion.Size = new Size(156, 20);
            lbl_tiempoSimulacion.TabIndex = 0;
            lbl_tiempoSimulacion.Text = "Tiempo de simulación";
            // 
            // txt_tiempoSimulacion
            // 
            txt_tiempoSimulacion.Location = new Point(14, 36);
            txt_tiempoSimulacion.Margin = new Padding(3, 4, 3, 4);
            txt_tiempoSimulacion.Name = "txt_tiempoSimulacion";
            txt_tiempoSimulacion.Size = new Size(114, 27);
            txt_tiempoSimulacion.TabIndex = 1;
            txt_tiempoSimulacion.KeyPress += txt_IntParam_KeyPress;
            // 
            // lbl_unidadTSim
            // 
            lbl_unidadTSim.AutoSize = true;
            lbl_unidadTSim.Location = new Point(135, 40);
            lbl_unidadTSim.Name = "lbl_unidadTSim";
            lbl_unidadTSim.Size = new Size(34, 20);
            lbl_unidadTSim.TabIndex = 2;
            lbl_unidadTSim.Text = "min";
            // 
            // txt_cantIteraciones
            // 
            txt_cantIteraciones.Location = new Point(14, 107);
            txt_cantIteraciones.Margin = new Padding(3, 4, 3, 4);
            txt_cantIteraciones.Name = "txt_cantIteraciones";
            txt_cantIteraciones.Size = new Size(149, 27);
            txt_cantIteraciones.TabIndex = 4;
            txt_cantIteraciones.KeyPress += txt_IntParam_KeyPress;
            // 
            // lbl_cantIteraciones
            // 
            lbl_cantIteraciones.AutoSize = true;
            lbl_cantIteraciones.Location = new Point(14, 83);
            lbl_cantIteraciones.Name = "lbl_cantIteraciones";
            lbl_cantIteraciones.Size = new Size(166, 20);
            lbl_cantIteraciones.TabIndex = 3;
            lbl_cantIteraciones.Text = "Cantidad de iteraciones";
            // 
            // txt_horaDesde
            // 
            txt_horaDesde.Location = new Point(200, 107);
            txt_horaDesde.Margin = new Padding(3, 4, 3, 4);
            txt_horaDesde.Name = "txt_horaDesde";
            txt_horaDesde.Size = new Size(149, 27);
            txt_horaDesde.TabIndex = 6;
            txt_horaDesde.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // lbl_horaDesde
            // 
            lbl_horaDesde.AutoSize = true;
            lbl_horaDesde.Location = new Point(200, 83);
            lbl_horaDesde.Name = "lbl_horaDesde";
            lbl_horaDesde.Size = new Size(85, 20);
            lbl_horaDesde.TabIndex = 5;
            lbl_horaDesde.Text = "Desde hora";
            // 
            // lbl_paramsOpc
            // 
            lbl_paramsOpc.AutoSize = true;
            lbl_paramsOpc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_paramsOpc.Location = new Point(14, 173);
            lbl_paramsOpc.Name = "lbl_paramsOpc";
            lbl_paramsOpc.Size = new Size(168, 20);
            lbl_paramsOpc.TabIndex = 7;
            lbl_paramsOpc.Text = "Parametros opcionales";
            // 
            // txt_hTLimpieza
            // 
            txt_hTLimpieza.Location = new Point(41, 455);
            txt_hTLimpieza.Margin = new Padding(3, 4, 3, 4);
            txt_hTLimpieza.Name = "txt_hTLimpieza";
            txt_hTLimpieza.Size = new Size(114, 27);
            txt_hTLimpieza.TabIndex = 9;
            txt_hTLimpieza.Text = "0,1";
            txt_hTLimpieza.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // lbl_tiempoLimpieza
            // 
            lbl_tiempoLimpieza.AutoSize = true;
            lbl_tiempoLimpieza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tiempoLimpieza.Location = new Point(14, 424);
            lbl_tiempoLimpieza.Name = "lbl_tiempoLimpieza";
            lbl_tiempoLimpieza.Size = new Size(145, 20);
            lbl_tiempoLimpieza.TabIndex = 8;
            lbl_tiempoLimpieza.Text = "Tiempo de limpieza";
            // 
            // lbl_disciplina
            // 
            lbl_disciplina.AutoSize = true;
            lbl_disciplina.Location = new Point(18, 216);
            lbl_disciplina.Name = "lbl_disciplina";
            lbl_disciplina.Size = new Size(74, 20);
            lbl_disciplina.TabIndex = 11;
            lbl_disciplina.Text = "Disciplina";
            // 
            // lbl_futbol
            // 
            lbl_futbol.AutoSize = true;
            lbl_futbol.Location = new Point(18, 264);
            lbl_futbol.Name = "lbl_futbol";
            lbl_futbol.Size = new Size(51, 20);
            lbl_futbol.TabIndex = 12;
            lbl_futbol.Text = "Fútbol";
            // 
            // lbl_handball
            // 
            lbl_handball.AutoSize = true;
            lbl_handball.Location = new Point(18, 313);
            lbl_handball.Name = "lbl_handball";
            lbl_handball.Size = new Size(70, 20);
            lbl_handball.TabIndex = 13;
            lbl_handball.Text = "Handball";
            // 
            // lbl_basketball
            // 
            lbl_basketball.AutoSize = true;
            lbl_basketball.Location = new Point(18, 372);
            lbl_basketball.Name = "lbl_basketball";
            lbl_basketball.Size = new Size(77, 20);
            lbl_basketball.TabIndex = 14;
            lbl_basketball.Text = "Basketball";
            // 
            // lbl_llegadas
            // 
            lbl_llegadas.AutoSize = true;
            lbl_llegadas.Location = new Point(138, 216);
            lbl_llegadas.Name = "lbl_llegadas";
            lbl_llegadas.Size = new Size(68, 20);
            lbl_llegadas.TabIndex = 15;
            lbl_llegadas.Text = "Llegadas";
            // 
            // lbl_ocupacion
            // 
            lbl_ocupacion.AutoSize = true;
            lbl_ocupacion.Location = new Point(360, 216);
            lbl_ocupacion.Name = "lbl_ocupacion";
            lbl_ocupacion.Size = new Size(157, 20);
            lbl_ocupacion.TabIndex = 16;
            lbl_ocupacion.Text = "Ocupación de canchas";
            // 
            // btn_generar
            // 
            btn_generar.BackColor = Color.FromArgb(0, 192, 0);
            btn_generar.Font = new Font("Snap ITC", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            btn_generar.ForeColor = Color.Fuchsia;
            btn_generar.Location = new Point(23, 687);
            btn_generar.Margin = new Padding(3, 4, 3, 4);
            btn_generar.Name = "btn_generar";
            btn_generar.Size = new Size(521, 125);
            btn_generar.TabIndex = 17;
            btn_generar.Text = "Generar";
            btn_generar.UseVisualStyleBackColor = false;
            btn_generar.Click += btn_generar_Click;
            // 
            // lbl_distLlegHB1
            // 
            lbl_distLlegHB1.AutoSize = true;
            lbl_distLlegHB1.Location = new Point(138, 313);
            lbl_distLlegHB1.Name = "lbl_distLlegHB1";
            lbl_distLlegHB1.Size = new Size(24, 20);
            lbl_distLlegHB1.TabIndex = 18;
            lbl_distLlegHB1.Text = "U(";
            // 
            // txt_distLlegHBDesde
            // 
            txt_distLlegHBDesde.Location = new Point(159, 309);
            txt_distLlegHBDesde.Margin = new Padding(3, 4, 3, 4);
            txt_distLlegHBDesde.Name = "txt_distLlegHBDesde";
            txt_distLlegHBDesde.Size = new Size(53, 27);
            txt_distLlegHBDesde.TabIndex = 19;
            txt_distLlegHBDesde.Text = "10";
            txt_distLlegHBDesde.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // lbl_distLlegHB2
            // 
            lbl_distLlegHB2.AutoSize = true;
            lbl_distLlegHB2.Location = new Point(214, 320);
            lbl_distLlegHB2.Name = "lbl_distLlegHB2";
            lbl_distLlegHB2.Size = new Size(12, 20);
            lbl_distLlegHB2.TabIndex = 20;
            lbl_distLlegHB2.Text = ",";
            // 
            // lbl_distLlegHB3
            // 
            lbl_distLlegHB3.AutoSize = true;
            lbl_distLlegHB3.Location = new Point(282, 313);
            lbl_distLlegHB3.Name = "lbl_distLlegHB3";
            lbl_distLlegHB3.Size = new Size(32, 20);
            lbl_distLlegHB3.TabIndex = 21;
            lbl_distLlegHB3.Text = ") hs";
            // 
            // txt_distLlegHBHasta
            // 
            txt_distLlegHBHasta.Location = new Point(222, 309);
            txt_distLlegHBHasta.Margin = new Padding(3, 4, 3, 4);
            txt_distLlegHBHasta.Name = "txt_distLlegHBHasta";
            txt_distLlegHBHasta.Size = new Size(53, 27);
            txt_distLlegHBHasta.TabIndex = 23;
            txt_distLlegHBHasta.Text = "14";
            txt_distLlegHBHasta.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // txt_distLlegBBHasta
            // 
            txt_distLlegBBHasta.Location = new Point(222, 368);
            txt_distLlegBBHasta.Margin = new Padding(3, 4, 3, 4);
            txt_distLlegBBHasta.Name = "txt_distLlegBBHasta";
            txt_distLlegBBHasta.Size = new Size(53, 27);
            txt_distLlegBBHasta.TabIndex = 28;
            txt_distLlegBBHasta.Text = "10";
            txt_distLlegBBHasta.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // lbl_distLlegBB3
            // 
            lbl_distLlegBB3.AutoSize = true;
            lbl_distLlegBB3.Location = new Point(282, 372);
            lbl_distLlegBB3.Name = "lbl_distLlegBB3";
            lbl_distLlegBB3.Size = new Size(32, 20);
            lbl_distLlegBB3.TabIndex = 27;
            lbl_distLlegBB3.Text = ") hs";
            // 
            // lbl_distLlegBB2
            // 
            lbl_distLlegBB2.AutoSize = true;
            lbl_distLlegBB2.Location = new Point(214, 379);
            lbl_distLlegBB2.Name = "lbl_distLlegBB2";
            lbl_distLlegBB2.Size = new Size(12, 20);
            lbl_distLlegBB2.TabIndex = 26;
            lbl_distLlegBB2.Text = ",";
            // 
            // txt_distLlegBBDesde
            // 
            txt_distLlegBBDesde.Location = new Point(159, 368);
            txt_distLlegBBDesde.Margin = new Padding(3, 4, 3, 4);
            txt_distLlegBBDesde.Name = "txt_distLlegBBDesde";
            txt_distLlegBBDesde.Size = new Size(53, 27);
            txt_distLlegBBDesde.TabIndex = 25;
            txt_distLlegBBDesde.Text = "6";
            txt_distLlegBBDesde.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // lbl_distLlegBB1
            // 
            lbl_distLlegBB1.AutoSize = true;
            lbl_distLlegBB1.Location = new Point(138, 372);
            lbl_distLlegBB1.Name = "lbl_distLlegBB1";
            lbl_distLlegBB1.Size = new Size(24, 20);
            lbl_distLlegBB1.TabIndex = 24;
            lbl_distLlegBB1.Text = "U(";
            // 
            // txt_distOcupBBHasta
            // 
            txt_distOcupBBHasta.Location = new Point(443, 372);
            txt_distOcupBBHasta.Margin = new Padding(3, 4, 3, 4);
            txt_distOcupBBHasta.Name = "txt_distOcupBBHasta";
            txt_distOcupBBHasta.Size = new Size(53, 27);
            txt_distOcupBBHasta.TabIndex = 33;
            txt_distOcupBBHasta.Text = "130";
            txt_distOcupBBHasta.KeyPress += txt_IntParam_KeyPress;
            // 
            // lbl_distoOcupBB3
            // 
            lbl_distoOcupBB3.AutoSize = true;
            lbl_distoOcupBB3.Location = new Point(504, 376);
            lbl_distoOcupBB3.Name = "lbl_distoOcupBB3";
            lbl_distoOcupBB3.Size = new Size(43, 20);
            lbl_distoOcupBB3.TabIndex = 32;
            lbl_distoOcupBB3.Text = ") min";
            // 
            // lbl_distoOcupBB2
            // 
            lbl_distoOcupBB2.AutoSize = true;
            lbl_distoOcupBB2.Location = new Point(435, 383);
            lbl_distoOcupBB2.Name = "lbl_distoOcupBB2";
            lbl_distoOcupBB2.Size = new Size(12, 20);
            lbl_distoOcupBB2.TabIndex = 31;
            lbl_distoOcupBB2.Text = ",";
            // 
            // txt_distOcupBBDesde
            // 
            txt_distOcupBBDesde.Location = new Point(381, 372);
            txt_distOcupBBDesde.Margin = new Padding(3, 4, 3, 4);
            txt_distOcupBBDesde.Name = "txt_distOcupBBDesde";
            txt_distOcupBBDesde.Size = new Size(53, 27);
            txt_distOcupBBDesde.TabIndex = 30;
            txt_distOcupBBDesde.Text = "70";
            txt_distOcupBBDesde.KeyPress += txt_IntParam_KeyPress;
            // 
            // lbl_distoOcupBB1
            // 
            lbl_distoOcupBB1.AutoSize = true;
            lbl_distoOcupBB1.Location = new Point(360, 376);
            lbl_distoOcupBB1.Name = "lbl_distoOcupBB1";
            lbl_distoOcupBB1.Size = new Size(24, 20);
            lbl_distoOcupBB1.TabIndex = 29;
            lbl_distoOcupBB1.Text = "U(";
            // 
            // txt_distOcupHBHasta
            // 
            txt_distOcupHBHasta.Location = new Point(443, 309);
            txt_distOcupHBHasta.Margin = new Padding(3, 4, 3, 4);
            txt_distOcupHBHasta.Name = "txt_distOcupHBHasta";
            txt_distOcupHBHasta.Size = new Size(53, 27);
            txt_distOcupHBHasta.TabIndex = 38;
            txt_distOcupHBHasta.Text = "100";
            txt_distOcupHBHasta.KeyPress += txt_IntParam_KeyPress;
            // 
            // lbl_distoOcupHB3
            // 
            lbl_distoOcupHB3.AutoSize = true;
            lbl_distoOcupHB3.Location = new Point(504, 313);
            lbl_distoOcupHB3.Name = "lbl_distoOcupHB3";
            lbl_distoOcupHB3.Size = new Size(43, 20);
            lbl_distoOcupHB3.TabIndex = 37;
            lbl_distoOcupHB3.Text = ") min";
            // 
            // lbl_distoOcupHB2
            // 
            lbl_distoOcupHB2.AutoSize = true;
            lbl_distoOcupHB2.Location = new Point(435, 320);
            lbl_distoOcupHB2.Name = "lbl_distoOcupHB2";
            lbl_distoOcupHB2.Size = new Size(12, 20);
            lbl_distoOcupHB2.TabIndex = 36;
            lbl_distoOcupHB2.Text = ",";
            // 
            // txt_distOcupHBDesde
            // 
            txt_distOcupHBDesde.Location = new Point(381, 309);
            txt_distOcupHBDesde.Margin = new Padding(3, 4, 3, 4);
            txt_distOcupHBDesde.Name = "txt_distOcupHBDesde";
            txt_distOcupHBDesde.Size = new Size(53, 27);
            txt_distOcupHBDesde.TabIndex = 35;
            txt_distOcupHBDesde.Text = "60";
            txt_distOcupHBDesde.KeyPress += txt_IntParam_KeyPress;
            // 
            // lbl_distoOcupHB1
            // 
            lbl_distoOcupHB1.AutoSize = true;
            lbl_distoOcupHB1.Location = new Point(360, 313);
            lbl_distoOcupHB1.Name = "lbl_distoOcupHB1";
            lbl_distoOcupHB1.Size = new Size(24, 20);
            lbl_distoOcupHB1.TabIndex = 34;
            lbl_distoOcupHB1.Text = "U(";
            // 
            // txt_distOcupFHasta
            // 
            txt_distOcupFHasta.Location = new Point(443, 260);
            txt_distOcupFHasta.Margin = new Padding(3, 4, 3, 4);
            txt_distOcupFHasta.Name = "txt_distOcupFHasta";
            txt_distOcupFHasta.Size = new Size(53, 27);
            txt_distOcupFHasta.TabIndex = 43;
            txt_distOcupFHasta.Text = "100";
            txt_distOcupFHasta.KeyPress += txt_IntParam_KeyPress;
            // 
            // lbl_distoOcupF3
            // 
            lbl_distoOcupF3.AutoSize = true;
            lbl_distoOcupF3.Location = new Point(504, 264);
            lbl_distoOcupF3.Name = "lbl_distoOcupF3";
            lbl_distoOcupF3.Size = new Size(43, 20);
            lbl_distoOcupF3.TabIndex = 42;
            lbl_distoOcupF3.Text = ") min";
            // 
            // lbl_distoOcupF2
            // 
            lbl_distoOcupF2.AutoSize = true;
            lbl_distoOcupF2.Location = new Point(435, 271);
            lbl_distoOcupF2.Name = "lbl_distoOcupF2";
            lbl_distoOcupF2.Size = new Size(12, 20);
            lbl_distoOcupF2.TabIndex = 41;
            lbl_distoOcupF2.Text = ",";
            // 
            // txt_distOcupFDesde
            // 
            txt_distOcupFDesde.Location = new Point(381, 260);
            txt_distOcupFDesde.Margin = new Padding(3, 4, 3, 4);
            txt_distOcupFDesde.Name = "txt_distOcupFDesde";
            txt_distOcupFDesde.Size = new Size(53, 27);
            txt_distOcupFDesde.TabIndex = 40;
            txt_distOcupFDesde.Text = "80";
            txt_distOcupFDesde.KeyPress += txt_IntParam_KeyPress;
            // 
            // lbl_distoOcupF1
            // 
            lbl_distoOcupF1.AutoSize = true;
            lbl_distoOcupF1.Location = new Point(360, 264);
            lbl_distoOcupF1.Name = "lbl_distoOcupF1";
            lbl_distoOcupF1.Size = new Size(24, 20);
            lbl_distoOcupF1.TabIndex = 39;
            lbl_distoOcupF1.Text = "U(";
            // 
            // txt_distLlegF
            // 
            txt_distLlegF.Location = new Point(210, 256);
            txt_distLlegF.Margin = new Padding(3, 4, 3, 4);
            txt_distLlegF.Name = "txt_distLlegF";
            txt_distLlegF.Size = new Size(53, 27);
            txt_distLlegF.TabIndex = 44;
            txt_distLlegF.Text = "10";
            txt_distLlegF.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // lbl_distLlegF1
            // 
            lbl_distLlegF1.AutoSize = true;
            lbl_distLlegF1.Location = new Point(138, 260);
            lbl_distLlegF1.Name = "lbl_distLlegF1";
            lbl_distLlegF1.Size = new Size(71, 20);
            lbl_distLlegF1.TabIndex = 45;
            lbl_distLlegF1.Text = "Exp. Neg.";
            // 
            // lbl_distLlegF2
            // 
            lbl_distLlegF2.AutoSize = true;
            lbl_distLlegF2.Location = new Point(271, 264);
            lbl_distLlegF2.Name = "lbl_distLlegF2";
            lbl_distLlegF2.Size = new Size(27, 20);
            lbl_distLlegF2.TabIndex = 46;
            lbl_distLlegF2.Text = " hs";
            // 
            // lbl_hTLimpieza
            // 
            lbl_hTLimpieza.AutoSize = true;
            lbl_hTLimpieza.Location = new Point(18, 459);
            lbl_hTLimpieza.Name = "lbl_hTLimpieza";
            lbl_hTLimpieza.Size = new Size(17, 20);
            lbl_hTLimpieza.TabIndex = 10;
            lbl_hTLimpieza.Text = "h";
            // 
            // lbl_DGeneral
            // 
            lbl_DGeneral.AutoSize = true;
            lbl_DGeneral.Location = new Point(14, 503);
            lbl_DGeneral.Name = "lbl_DGeneral";
            lbl_DGeneral.Size = new Size(230, 20);
            lbl_DGeneral.TabIndex = 47;
            lbl_DGeneral.Text = "Valores de D para cada disciplina";
            // 
            // lbl_DFutbol
            // 
            lbl_DFutbol.AutoSize = true;
            lbl_DFutbol.Location = new Point(23, 543);
            lbl_DFutbol.Name = "lbl_DFutbol";
            lbl_DFutbol.Size = new Size(51, 20);
            lbl_DFutbol.TabIndex = 48;
            lbl_DFutbol.Text = "Fútbol";
            // 
            // lbl_DHandball
            // 
            lbl_DHandball.AutoSize = true;
            lbl_DHandball.Location = new Point(22, 595);
            lbl_DHandball.Name = "lbl_DHandball";
            lbl_DHandball.Size = new Size(70, 20);
            lbl_DHandball.TabIndex = 49;
            lbl_DHandball.Text = "Handball";
            // 
            // lbl_DBasketball
            // 
            lbl_DBasketball.AutoSize = true;
            lbl_DBasketball.Location = new Point(23, 647);
            lbl_DBasketball.Name = "lbl_DBasketball";
            lbl_DBasketball.Size = new Size(77, 20);
            lbl_DBasketball.TabIndex = 50;
            lbl_DBasketball.Text = "Basketball";
            // 
            // txt_DFutbol
            // 
            txt_DFutbol.Location = new Point(103, 539);
            txt_DFutbol.Margin = new Padding(3, 4, 3, 4);
            txt_DFutbol.Name = "txt_DFutbol";
            txt_DFutbol.Size = new Size(114, 27);
            txt_DFutbol.TabIndex = 51;
            txt_DFutbol.Text = "100";
            txt_DFutbol.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // txt_DHandball
            // 
            txt_DHandball.Location = new Point(103, 591);
            txt_DHandball.Margin = new Padding(3, 4, 3, 4);
            txt_DHandball.Name = "txt_DHandball";
            txt_DHandball.Size = new Size(114, 27);
            txt_DHandball.TabIndex = 52;
            txt_DHandball.Text = "200";
            txt_DHandball.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // txt_DBasketball
            // 
            txt_DBasketball.Location = new Point(103, 643);
            txt_DBasketball.Margin = new Padding(3, 4, 3, 4);
            txt_DBasketball.Name = "txt_DBasketball";
            txt_DBasketball.Size = new Size(114, 27);
            txt_DBasketball.TabIndex = 53;
            txt_DBasketball.Text = "300";
            txt_DBasketball.KeyPress += txt_DoubleParam_KeyPress;
            // 
            // PantallaSimuladorPolideportivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(566, 828);
            Controls.Add(txt_DBasketball);
            Controls.Add(txt_DHandball);
            Controls.Add(txt_DFutbol);
            Controls.Add(lbl_DBasketball);
            Controls.Add(lbl_DHandball);
            Controls.Add(lbl_DFutbol);
            Controls.Add(lbl_DGeneral);
            Controls.Add(lbl_distLlegF2);
            Controls.Add(lbl_distLlegF1);
            Controls.Add(txt_distLlegF);
            Controls.Add(txt_distOcupFHasta);
            Controls.Add(lbl_distoOcupF3);
            Controls.Add(lbl_distoOcupF2);
            Controls.Add(txt_distOcupFDesde);
            Controls.Add(lbl_distoOcupF1);
            Controls.Add(txt_distOcupHBHasta);
            Controls.Add(lbl_distoOcupHB3);
            Controls.Add(lbl_distoOcupHB2);
            Controls.Add(txt_distOcupHBDesde);
            Controls.Add(lbl_distoOcupHB1);
            Controls.Add(txt_distOcupBBHasta);
            Controls.Add(lbl_distoOcupBB3);
            Controls.Add(lbl_distoOcupBB2);
            Controls.Add(txt_distOcupBBDesde);
            Controls.Add(lbl_distoOcupBB1);
            Controls.Add(txt_distLlegBBHasta);
            Controls.Add(lbl_distLlegBB3);
            Controls.Add(lbl_distLlegBB2);
            Controls.Add(txt_distLlegBBDesde);
            Controls.Add(lbl_distLlegBB1);
            Controls.Add(txt_distLlegHBHasta);
            Controls.Add(lbl_distLlegHB3);
            Controls.Add(lbl_distLlegHB2);
            Controls.Add(txt_distLlegHBDesde);
            Controls.Add(lbl_distLlegHB1);
            Controls.Add(btn_generar);
            Controls.Add(lbl_ocupacion);
            Controls.Add(lbl_llegadas);
            Controls.Add(lbl_basketball);
            Controls.Add(lbl_handball);
            Controls.Add(lbl_futbol);
            Controls.Add(lbl_disciplina);
            Controls.Add(lbl_hTLimpieza);
            Controls.Add(txt_hTLimpieza);
            Controls.Add(lbl_tiempoLimpieza);
            Controls.Add(lbl_paramsOpc);
            Controls.Add(txt_horaDesde);
            Controls.Add(lbl_horaDesde);
            Controls.Add(txt_cantIteraciones);
            Controls.Add(lbl_cantIteraciones);
            Controls.Add(lbl_unidadTSim);
            Controls.Add(txt_tiempoSimulacion);
            Controls.Add(lbl_tiempoSimulacion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PantallaSimuladorPolideportivo";
            Text = "Pantalla Simulador Polideportivo";
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txt_hTLimpieza;
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
        private Label lbl_hTLimpieza;
        private Label lbl_DGeneral;
        private Label lbl_DFutbol;
        private Label lbl_DHandball;
        private Label lbl_DBasketball;
        private TextBox txt_DFutbol;
        private TextBox txt_DHandball;
        private TextBox txt_DBasketball;
    }
}