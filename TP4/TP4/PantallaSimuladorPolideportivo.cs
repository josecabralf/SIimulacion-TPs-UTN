using TP4.Entidades;

namespace TP4
{
    public partial class PantallaSimuladorPolideportivo : Form
    {
        ValidadorParamentros validadorParametros;
        public PantallaSimuladorPolideportivo()
        {
            InitializeComponent();
            validadorParametros = new ValidadorParamentros();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {

        }


        private void txt_DoubleParam_KeyPress(object sender, KeyPressEventArgs e)
        {
        // Permitir solo digitos, caracteres de control y un solo punto decimal o signo menos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ',' || ((TextBox)sender).Text.Contains(",")) &&
                (e.KeyChar != '-' || ((TextBox)sender).Text.Length != 0))
            {
                e.Handled = true;
            }
        }

        private void txt_IntParam_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo digitos y caracteres de control 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}