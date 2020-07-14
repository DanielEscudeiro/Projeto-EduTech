using Colabore;
using System;
using System.Threading;
using System.Windows.Forms;
using WMPLib;

namespace cores1
{
    public partial class coresForm : Form
    {
        public coresForm()
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

        WindowsMediaPlayer som;

        private void btReproduzirAZ_Click(object sender, EventArgs e)
        {
            try
            {
                lbAzul.Visible = false;
                lbAzul.Text = "Azul";
                lbAzul.Visible = true;

                som = new WindowsMediaPlayer();
                som.URL = Application.StartupPath + @"\mp3\AZUL.mp3";
                som.controls.play();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReproduzirAM_Click(object sender, EventArgs e)
        {
            try
            {
                lbAmarelo.Visible = false;
                lbAmarelo.Text = "Amarelo";
                lbAmarelo.Visible = true;

                som = new WindowsMediaPlayer();
                som.URL = Application.StartupPath + @"\mp3\AMARELO.mp3";
                som.controls.play();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReproduzirVM_Click(object sender, EventArgs e)
        {
            try
            {
                lbVermelho.Visible = false;
                lbVermelho.Text = "Vermelho";
                lbVermelho.Visible = true;

                som = new WindowsMediaPlayer();
                som.URL = Application.StartupPath + @"\mp3\VERMELHO.mp3";
                som.controls.play();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReproduzirLA_Click(object sender, EventArgs e)
        {
            try
            {
                lbLaranja.Visible = false;
                lbLaranja.Text = "Laranja";
                lbLaranja.Visible = true;

                som = new WindowsMediaPlayer();
                som.URL = Application.StartupPath + @"\mp3\LARANJA.mp3";
                som.controls.play();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReproduzirVD_Click(object sender, EventArgs e)
        {
            try
            {
                lbVerde.Visible = false;
                lbVerde.Text = "Verde";
                lbVerde.Visible = true;

                som = new WindowsMediaPlayer();
                som.URL = Application.StartupPath + @"\mp3\VERDE.mp3";
                som.controls.play();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReproduzirRX_Click(object sender, EventArgs e)
        {
            try
            {
                lbRoxo.Visible = false;
                lbRoxo.Text = "Roxo";
                lbRoxo.Visible = true;

                som = new WindowsMediaPlayer();
                som.URL = Application.StartupPath + @"\mp3\ROXO.mp3";
                som.controls.play();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReproduzirRO_Click(object sender, EventArgs e)
        {
            try
            {
                lbRosa.Visible = false;
                lbRosa.Text = "Rosa";
                lbRosa.Visible = true;

                som = new WindowsMediaPlayer();
                som.URL = Application.StartupPath + @"\mp3\ROSA.mp3";
                som.controls.play();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReproduzirMA_Click(object sender, EventArgs e)
        {
            try
            {
                lbMarrom.Visible = false;
                lbMarrom.Text = "Marrom";
                lbMarrom.Visible = true;

                som = new WindowsMediaPlayer();
                som.URL = Application.StartupPath + @"\mp3\MARROM.mp3";
                som.controls.play();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReproduzirPR_Click(object sender, EventArgs e)
        {
            try
            {
                lbPreto.Visible = false;
                lbPreto.Text = "Preto";
                lbPreto.Visible = true;

                som = new WindowsMediaPlayer();
                som.URL = Application.StartupPath + @"\mp3\PRETO.mp3";
                som.controls.play();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReproduzirBR_Click(object sender, EventArgs e)
        {
            try
            {
                lbBranco.Visible = false;
                lbBranco.Text = "Branco";
                lbBranco.Visible = true;

                som = new WindowsMediaPlayer();
                som.URL = Application.StartupPath + @"\mp3\BRANCO.mp3";
                som.controls.play();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            lbAzul.Text = "";
            lbAmarelo.Text = "";
            lbVermelho.Text = "";
            lbLaranja.Text = "";
            lbVerde.Text = "";
            lbRoxo.Text = "";
            lbRosa.Text = "";
            lbMarrom.Text = "";
            lbPreto.Text = "";
            lbBranco.Text = "";
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Thread nb;

            nb = new Thread(returForm);
            nb.SetApartmentState(ApartmentState.STA);
            nb.Start();
            for (int i = 0; i <= 100000000; i++)
            {

            }
            this.Close();

        }
        private void returForm()
        {
            Application.Run(new paginainicial());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }



}
