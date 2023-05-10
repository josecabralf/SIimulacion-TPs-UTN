using TP3_WF.Entidades;
using TP3_WF.Presentacion;

namespace TP3_WF
{
    public partial class PantallaAnuncioPorTV : Form
    {
        ValidadorParametros validadorParametros;
        public PantallaAnuncioPorTV()
        {
            InitializeComponent();
            validadorParametros = new ValidadorParametros();
        }

        private void txt_nroExperimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo digitos y caracteres de control 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo digitos y caracteres de control 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_cant_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo digitos y caracteres de control 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool estaVacio(string texto)
        {
            return texto == "";
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            double? recueda;
            double[]? probsRec;
            double[]? probsNoRec;

            if (!estaVacio(txt_probRec.Text)) recueda = Double.Parse(txt_probRec.Text);
            else recueda = null;

            if (!estaVacio(txt_recSi.Text)) probsRec = new double[] { Double.Parse(txt_recSi.Text), Double.Parse(txt_recDud.Text), Double.Parse(txt_recNo.Text) };
            else probsRec = null;

            if (!estaVacio(txt_noRecSi.Text)) probsNoRec = new double[] { Double.Parse(txt_noRecSi.Text), Double.Parse(txt_noRecDud.Text), Double.Parse(txt_noRecNo.Text) };
            else probsNoRec = null;

            GestorExperimento gestor = new GestorExperimento(recueda, probsRec, probsNoRec);

            // Se valida que los textBoxes no esten vacios
            if (estaVacio(txt_nroExperimento.Text) || estaVacio(txt_desde.Text) || estaVacio(txt_cant.Text))
            {
                MessageBox.Show("Faltan parametros!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nroExperimento = int.Parse(txt_nroExperimento.Text);
            int desde = int.Parse(txt_desde.Text);
            int cant = int.Parse(txt_cant.Text);

            // Valida que el número de experimentos sea mayor a 0
            if (!validadorParametros.validarSuperiorACero(nroExperimento))
            {
                MessageBox.Show("El número de experimento ingresado debe ser mayor a 0.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valida que sea superior a 0 y no caiga fuera de rango el experimento desde el cual se va a visualizar

            if (!validadorParametros.validarSuperiorACero(desde))
            {
                MessageBox.Show("El número de experimento ingresado debe ser mayor a 0.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (validadorParametros.validarDesde(nroExperimento, desde))
            {
                MessageBox.Show("El número de experimento desde el cual se va visualizar el experimento es mayor a la número de experimentos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valida que cantidad sea superior a 0 y que los experimentos a visualizar no caigan fuera de rango

            if (!validadorParametros.validarSuperiorACero(cant))
            {
                MessageBox.Show("El número de experimento ingresado debe ser mayor a 0.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (validadorParametros.validarCant(nroExperimento, desde, cant))
            {
                MessageBox.Show("La cantidad de lineas que se van visualizar desde el número de experimento ingresado sobrepasa el número de experimentos realizados.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Se realizan los experimentos

            gestor.RealizarExperimento(nroExperimento, desde, cant);

            // Se instancia la pantalla visualización y se le envian los datos por parametro

            PantallaVisualizacion pantallaVisualizacion = new PantallaVisualizacion(gestor.getArchivoCSV());
            pantallaVisualizacion.ShowDialog();

        }
    }
}