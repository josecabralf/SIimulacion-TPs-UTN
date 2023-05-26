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


    }
}