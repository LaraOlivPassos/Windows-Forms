namespace Calculadora_de_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtRPeso_Enter(object sender, EventArgs e)
        {
            txtRAltura.BackColor = Color.White;
            txtRPeso.BackColor = Color.Red;
        }

        private void txtRAltura_Enter(object sender, EventArgs e)
        {
            txtRAltura.BackColor = Color.Red;
            txtRPeso.BackColor = Color.White;
        }
    }
}
