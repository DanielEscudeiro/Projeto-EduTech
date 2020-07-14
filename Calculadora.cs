using System;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class CalculadoraForm : Form
    {
        double primeiro;
        double segundo;
        string operador;

        public CalculadoraForm()
        {
            InitializeComponent();

        }

        Classes.Soma obj = new Classes.Soma();
        Classes.Subtracao obj2 = new Classes.Subtracao();
        Classes.Multiplicacao obj3 = new Classes.Multiplicacao();
        Classes.Divisao obj4 = new Classes.Divisao();




        private void button1_Click(object sender, EventArgs e)
        {
            tb_numeros.Text = tb_numeros.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_numeros.Text = tb_numeros.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb_numeros.Text = tb_numeros.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb_numeros.Text = tb_numeros.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tb_numeros.Text = tb_numeros.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tb_numeros.Text = tb_numeros.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tb_numeros.Text = tb_numeros.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tb_numeros.Text = tb_numeros.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tb_numeros.Text = tb_numeros.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            tb_numeros.Text = tb_numeros.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operador = "/";
            primeiro = double.Parse(tb_numeros.Text);
            tb_numeros.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operador = "*";
            primeiro = double.Parse(tb_numeros.Text);
            tb_numeros.Clear();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            operador = "-";
            primeiro = double.Parse(tb_numeros.Text);
            tb_numeros.Clear();

        }

        private void button15_Click(object sender, EventArgs e)
        {

            operador = "+";
            primeiro = double.Parse(tb_numeros.Text);
            tb_numeros.Clear();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tb_numeros.Text);

            double Sum;
            double Res;
            double Multi;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = obj.Somar((primeiro), (segundo));
                    tb_numeros.Text = Sum.ToString();
                    break;

                case "-":
                    Res = obj2.Resto((primeiro), (segundo));
                    tb_numeros.Text = Res.ToString();
                    break;

                case "*":
                    Multi = obj3.Multiplicar((primeiro), (segundo));
                    tb_numeros.Text = Multi.ToString();
                    break;

                case "/":
                    Div = obj4.Dividir((primeiro), (segundo));
                    tb_numeros.Text = Div.ToString();
                    break;
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            tb_numeros.Clear();
        }

        private void CalculadoraForm_Load(object sender, EventArgs e)
        {

        }
    }
}
