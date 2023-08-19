namespace CalculadoraElbicho
{
    public partial class Form1 : Form

    {
        double Numero1 = 0, Numero2 = 0;
        char operador;



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

        private void clickOperador(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtresultado.Text);
            if (operador == '+')
            {
                txtresultado.Text = Convert.ToString(Numero1 + Numero2);


            }
            else if (operador == '-')
            {
                txtresultado.Text = Convert.ToString(Numero1 - Numero2);
            }
            else if (operador == '*')
            {
                txtresultado.Text = Convert.ToString(Numero1 * Numero2);
            
            }
            else if (operador == '^')
            {
                txtresultado.Text = Convert.ToString(Math.Pow(Numero1, Numero2));
            }else if (operador == '%')
            {
                txtresultado.Text = Convert.ToString((Numero1 * Numero2) / 100);
            }
            else if (operador == '/')
            {
                txtresultado.Text = Convert.ToString(Numero1 / Numero2);
            }


        }

        private void Mas_Click(object sender, EventArgs e)
        {

        }

        private void Mas_Click_1(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtresultado.Text);
            txtresultado.Text = "";
            operador = '+';


        }

        private void dividir_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtresultado.Text);
            txtresultado.Text = "";
            operador = '/';
        }

        private void RaizCuadrada_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtresultado.Text);
            txtresultado.Text = Convert.ToString(Math.Sqrt(Numero1));
        private void Menos_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtresultado.Text);
            txtresultado.Text = "";
            operador = '-';
        private void Potencia_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtresultado.Text);
            txtresultado.Text = "";
            operador = '^';
        }

        private void ValorAbsoluti_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtresultado.Text);

            if (Numero1 < -1)
            {
                txtresultado.Text = Convert.ToString(Numero1 * (-1));
            }
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtresultado.Text);
            txtresultado.Text = "";
            operador = '*';
        }

        private void dividir_Click(object sender, EventArgs e)
        {


        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void pocentaje_Click(object sender, EventArgs e)
        {
            Numero1 = Convert .ToDouble(txtresultado.Text);
            txtresultado.Text = "";
            operador = '%';
        }
    }

}