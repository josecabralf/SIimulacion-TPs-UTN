using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_WF.Entidades;

namespace TP2_WF
{
    public partial class PantallaPrincipalGenerador : Form
    {
        ValidadorParametros validadorParametros;
        //GeneradorNros generadorNros;

        public PantallaPrincipalGenerador()
        {
            InitializeComponent();
            validadorParametros = new ValidadorParametros();
            //generadorNros = new GeneradorNros();

        }

        private void cbo_selectDist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_selectDist.SelectedIndex == 0)
            {
                lbl_param1.Text = "Límite Inferior del intervalo";
                lbl_param2.Text = "Límite Superior del intervalo";
                txt_param1.Enabled = true;
                txt_param2.Enabled = true;
                gbx_radioButtons.Hide();
                
            }
            else if (cbo_selectDist.SelectedIndex == 1)
            {
                lbl_param1.Text = "Media de la muestra";
                lbl_param2.Text = "Desviación Estandar de la muestra";
                txt_param1.Enabled = true;
                txt_param2.Enabled = true;
                gbx_radioButtons.Hide();


            }
            else
            {
                lbl_param1.Text = "Lambda de la muestra";
                lbl_param2.Text = "Media de la muestra";
                gbx_radioButtons.Show();
                txt_param1.Enabled = true;
                txt_param2.Enabled = false;
                rbt_lambda.Checked = true;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbo_selectDist.SelectedIndex = 0;
            cbo_selectInterval.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Se valida que el tamaño de muestra sea superior a cero
            /*bool muestraValida = validadorParametros.validarSuperiorACero(int.Parse(txt_tamM.Text));
            if (!muestraValida)
                {
                    MessageBox.Show("El tamaño de muestra no es valido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            */
            // Dependiendo la distribución el camino a tomar es distinto
            if (cbo_selectDist.SelectedIndex == 0)
            {
                Console.WriteLine("Soy Uniforme");
                /*
                bool parametrosValidos = validadorParametros.validarParametrosUniforme(double.Parse(txt_param1.Text), double.Parse(txt_param2.Text));
                // Verificamos que los parametros sean validos (limite inferior < limite superior)
                if (!parametrosValidos)
                {
                    MessageBox.Show("Los parametros ingresados no son validos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */
            }

            else if (cbo_selectDist.SelectedIndex == 1)
            {
                Console.WriteLine("Soy Normal");

                /*bool parametrosValidos = validadorParametros.validarSuperiorACero(double.Parse(txt_param2.Text));
                // Verificamos que la deviación estandar sea mayor a 0
                if (!parametrosValidos)
                {
                    MessageBox.Show("Los parametros ingresados no son validos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }

            else
            {
                if (rbt_lambda.Checked) {
                    Console.WriteLine("Soy Exponencial Negativa con param Lambda"); 
                } else
                {
                    Console.WriteLine("Soy Exponencial Negativa con param Media");
                } 
                
            }
        }

        private void rbt_lambda_CheckedChanged(object sender, EventArgs e)
        {
            txt_param1.Enabled = true;
            txt_param2.Enabled = false;
            
        }

        private void rbt_media_CheckedChanged(object sender, EventArgs e)
        {
            txt_param1.Enabled = false;
            txt_param2.Enabled = true;
        }
    }
}
