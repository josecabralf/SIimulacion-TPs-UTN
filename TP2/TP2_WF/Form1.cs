using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_WF
{
    public partial class Form1 : Form
    {
        ValidadorParametros validadorParametros;
        //GeneradorNros generadorNros;

        public Form1()
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
                lbl_param2.Show();
                txt_param2.Show();
            }
            else if (cbo_selectDist.SelectedIndex == 1)
            {
                lbl_param1.Text = "Media de la muestra";
                lbl_param2.Text = "Desviación Estandar de la muestra";
                lbl_param2.Show();
                txt_param2.Show();

            }
            else
            {
                lbl_param1.Text = "Lambda de la muestra";
                lbl_param2.Hide();
                txt_param2.Hide();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbo_selectDist.SelectedIndex = 0;
            cbo_selectInterval.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbo_selectDist.SelectedIndex == 0)
            {
                Console.WriteLine("Soy Uniforme");
                bool bandera1 = validadorParametros.validarTamMuestra(int.Parse(txt_tamM.Text));
                bool bandera2 = validadorParametros.validarParametrosUniforme(double.Parse(txt_param1.Text), double.Parse(txt_param2.Text));

                if (bandera1)
                {
        
                } else {
                    MessageBox.Show("El tamaño de muestra no es valido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (bandera2)
                {
                } else {
                    MessageBox.Show("Se genero la muestra con distribución //DISTRIBUCION//.", "Mensaje de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
           
                
            }
            else if (cbo_selectDist.SelectedIndex == 1)
            {
                Console.WriteLine("Soy Normal");

            }
            else
            {
                Console.WriteLine("Soy Exp Neg");
            }
        }
    }
}
