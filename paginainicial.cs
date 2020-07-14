using Calculadora1;
using cores1;
using Silabas;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Colabore
{
    public partial class paginainicial : Form
    {
        public paginainicial()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        Thread nt;
        int x = 0;

        private void btFrutas_Click(object sender, EventArgs e)
        {
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            for (int i = 0; i <= 1000000000; i++)
            {
                x++;
            }

            this.Close();
        }
        private void novoForm()
        {
            Application.Run(new frutas());
        }

        

        private void btAlfabeto_Click(object sender, EventArgs e)
        {


            nt = new Thread(NewForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            for (int i = 0; i <= 1000000000; i++)
            {
                x++;
            }
            this.Close();

        }

        private void NewForm()
        {
            Application.Run(new Alfabeto());
        }

        private void btAnimais_Click(object sender, EventArgs e)
        {


            nt = new Thread(NewqForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            for (int i = 0; i <= 1000000000; i++)
            {
                x++;
            }
            this.Close();
        }
        private void NewqForm()
        {
            Application.Run(new animais());
        }

        private void btSilabas_Click(object sender, EventArgs e)
        {
            nt = new Thread(NewaForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            for (int i = 0; i <= 1000000000; i++)
            {
                x++;
            }
            this.Close();
        }
        private void NewaForm()
        {
            Application.Run(new silabas());
        }

        private void btCores_Click(object sender, EventArgs e)
        {

            nt = new Thread(NaForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            for (int i = 0; i <= 1000000000; i++)
            {
                x++;
            }
            this.Close();
        }
        private void NaForm()
        {
            Application.Run(new coresForm());
        }

        private void paginainicial_Load(object sender, EventArgs e)
        {
            pnPagInicial.BackColor = Color.Transparent;

        }


        private void btFechar_MouseMove(object sender, MouseEventArgs e)
        {
            btFechar.BackColor = Color.Red;

        }

        private void paginainicial_MouseMove(object sender, MouseEventArgs e)
        {
            btFechar.BackColor = Color.Transparent;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btNumeros_Click(object sender, EventArgs e)
        {
            

            nt = new Thread(NumForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            for (int i = 0; i <= 1000000000; i++)
            {
                x++;
            }
            this.Close();

        }
        private void NumForm()
        {
            Application.Run(new numerosForm());
        }
    }
}


