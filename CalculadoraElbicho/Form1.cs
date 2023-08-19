namespace CalculadoraElbicho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            agregarNumero("5");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            agregarNumero("8");
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void Seis_Click(object sender, EventArgs e)
        {
            agregarNumero("6");


        }
        private void agregarNumero(string numero)
        {
            if (txtresultado.Text == "0")
                txtresultado.Text = "";
            txtresultado.Text += numero;


        }

        private void Uno_Click(object sender, EventArgs e)
        {
            agregarNumero("1");
        }

        private void Dos_Click(object sender, EventArgs e)
        {
            agregarNumero("2");
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            agregarNumero("3");
        }

        private void Cuatro_Click(object sender, EventArgs e)
        {
            agregarNumero("4");
        }

        private void Siete_Click(object sender, EventArgs e)
        {
            agregarNumero("7");
        }

        private void Nueve_Click(object sender, EventArgs e)
        {
            agregarNumero("9");
        }

        private void coma_Click(object sender, EventArgs e)
        {
            agregarNumero(",");
        }

        private void Punto_Click(object sender, EventArgs e)
        {
            agregarNumero(".");
        }

        private void Cero_Click(object sender, EventArgs e)
        {
            agregarNumero("0");
        }
    }

}