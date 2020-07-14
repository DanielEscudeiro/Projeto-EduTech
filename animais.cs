using System;
using System.Threading;
using System.Windows.Forms;
using WMPLib;

namespace Colabore
{
    public partial class animais : Form
    {
       
        public animais()
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

        int x = 0;
        Thread na;

        private void btVoltar_Click(object sender, EventArgs e)
        {

            na = new Thread(ReturForm);
            na.SetApartmentState(ApartmentState.STA);
            na.Start();
            for (int i = 0; i <= 100000000; i++)
            {
                x++;
            }
            this.Close();
        }

        private void ReturForm()
        {
            Application.Run(new paginainicial());
        }

        WindowsMediaPlayer som1, som2, som3, som4, som5, som6, som7, som8, som9, som10,
            som11, som12, som13, som14, som15, som16, som17, som18, som19, som20;

        private void btCachorro_Click(object sender, EventArgs e)
        {
            lbCachorro.Visible = false;
            lbCachorro.Text = "Cachorro";
            lbCachorro.Visible = true;

            try
            {

                if (som1 == null)
                {
                    som1 = new WindowsMediaPlayer();
                    som1.URL = Application.StartupPath + @"\mp3\Cachorro.mp3";
                    som1.controls.play();

                }
                if (som1 != null)
                {
                    som1.controls.play();
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }

        }

        private void btLeao_Click(object sender, EventArgs e)
        {
            lbLeao.Visible = false;
            lbLeao.Text = "Leão";
            lbLeao.Visible = true;

            try
            {

                if (som2 == null)
                {
                    som2 = new WindowsMediaPlayer();
                    som2.URL = Application.StartupPath + @"\mp3\Leão.mp3";
                    som2.controls.play();
                }

                if (som2 != null)
                {
                    som2.controls.play();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void btGato_Click(object sender, EventArgs e)
        {
            lbGato.Visible = false;
            lbGato.Text = "Gato";
            lbGato.Visible = true;

            try
            {

                if (som3 == null)
                {
                    som3 = new WindowsMediaPlayer();
                    som3.URL = Application.StartupPath + @"\mp3\Gato.mp3";
                    som3.controls.play();
                }

                if (som3 != null)
                {
                    som3.controls.play();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void btElefante_Click(object sender, EventArgs e)
        {
            lbElefante.Visible = false;
            lbElefante.Text = "Elefante";
            lbElefante.Visible = true;

            try
            {

                if (som4 == null)
                {
                    som4 = new WindowsMediaPlayer();
                    som4.URL = Application.StartupPath + @"\mp3\Elefante.mp3";
                    som4.controls.play();
                }

                if (som4 != null)
                {
                    som4.controls.play();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void btMacaco_Click(object sender, EventArgs e)
        {
            lbMacaco.Visible = false;
            lbMacaco.Text = "Macaco";
            lbMacaco.Visible = true;

            try
            {

                if (som5 == null)
                {
                    som5 = new WindowsMediaPlayer();
                    som5.URL = Application.StartupPath + @"\mp3\Macaco.mp3";
                    som5.controls.play();
                }

                if (som5 != null)
                {
                    som5.controls.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void btGalinha_Click(object sender, EventArgs e)
        {
            lbGalinha.Visible = false;
            lbGalinha.Text = "Galinha";
            lbGalinha.Visible = true;

            try
            {

                if (som6 == null)
                {
                    som6 = new WindowsMediaPlayer();
                    som6.URL = Application.StartupPath + @"\mp3\Galinha.mp3";
                    som6.controls.play();
                }

                if (som6 != null)
                {
                    som6.controls.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void btCavalo_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label7.Text = "Cavalo";
            label7.Visible = true;

            try
            {

                if (som7 == null)
                {
                    som7 = new WindowsMediaPlayer();
                    som7.URL = Application.StartupPath + @"\mp3\Cavalo.mp3";
                    som7.controls.play();
                }

                if (som7 != null)
                {
                    som7.controls.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void btSapo_Click(object sender, EventArgs e)
        {
            lbSapo.Visible = false;
            lbSapo.Text = "Sapo";
            lbSapo.Visible = true;

            try
            {

                if (som8 == null)
                {
                    som8 = new WindowsMediaPlayer();
                    som8.URL = Application.StartupPath + @"\mp3\Sapo.mp3";
                    som8.controls.play();
                }

                if (som8 != null)
                {
                    som8.controls.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void btCoruja_Click(object sender, EventArgs e)
        {
            lbCoruja.Visible = false;
            lbCoruja.Text = "Coruja";
            lbCoruja.Visible = true;

            try
            {

                if (som9 == null)
                {
                    som9 = new WindowsMediaPlayer();
                    som9.URL = Application.StartupPath + @"\mp3\Coruja.mp3";
                    som9.controls.play();
                }

                if (som9 != null)
                {
                    som9.controls.play();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void pbCoruja_Click(object sender, EventArgs e)
        {

            try
            {

                if (som10 == null)
                {
                    som10 = new WindowsMediaPlayer();
                    som10.URL = Application.StartupPath + @"\mp3\CorujaC.mp3";
                    som10.controls.play();
                }

                if (som10 != null)
                {
                    som10.controls.play();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void pbCachorro_Click(object sender, EventArgs e)
        {
            try
            {

                if (som11 == null)
                {
                    som11 = new WindowsMediaPlayer();
                    som11.URL = Application.StartupPath + @"\mp3\CachorroL.mp3";
                    som11.controls.play();
                }

                if (som11 != null)
                {
                    som11.controls.play();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void pbLeao_Click(object sender, EventArgs e)
        {
            try
            {

                if (som12 == null)
                {
                    som12 = new WindowsMediaPlayer();
                    som12.URL = Application.StartupPath + @"\mp3\LeaoR.mp3";
                    som12.controls.play();
                }

                if (som12 != null)
                {
                    som12.controls.play();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void pbGato_Click(object sender, EventArgs e)
        {
            try
            {

                if (som13 == null)
                {
                    som13 = new WindowsMediaPlayer();
                    som13.URL = Application.StartupPath + @"\mp3\GatoM.mp3";
                    som13.controls.play();
                }

                if (som13 != null)
                {
                    som13.controls.play();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void pbElefante_Click(object sender, EventArgs e)
        {
            try
            {

                if (som14 == null)
                {
                    som14 = new WindowsMediaPlayer();
                    som14.URL = Application.StartupPath + @"\mp3\ElefanteA.mp3";
                    som14.controls.play();
                }

                if (som14 != null)
                {
                    som14.controls.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void pbMacaco_Click(object sender, EventArgs e)
        {
            try
            {

                if (som15 == null)
                {
                    som15 = new WindowsMediaPlayer();
                    som15.URL = Application.StartupPath + @"\mp3\MacacoM.mp3";
                    som15.controls.play();
                }

                if (som15 != null)
                {
                    som15.controls.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void pbGalinha_Click(object sender, EventArgs e)
        {

            try
            {

                if (som16 == null)
                {
                    som16 = new WindowsMediaPlayer();
                    som16.URL = Application.StartupPath + @"\mp3\GalinhaC.mp3";
                    som16.controls.play();
                }

                if (som16 != null)
                {
                    som16.controls.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void pbCavalo_Click(object sender, EventArgs e)
        {
            try
            {

                if (som17 == null)
                {
                    som17 = new WindowsMediaPlayer();
                    som17.URL = Application.StartupPath + @"\mp3\CavaloR.mp3";
                    som17.controls.play();
                }

                if (som17 != null)
                {
                    som17.controls.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void pbSapo_Click(object sender, EventArgs e)
        {
            try
            {

                if (som18 == null)
                {
                    som18 = new WindowsMediaPlayer();
                    som18.URL = Application.StartupPath + @"\mp3\SapoW.mp3";
                    som18.controls.play();
                }

                if (som18 != null)
                {
                    som18.controls.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void btArara_Click(object sender, EventArgs e)
        {
            lbArara.Visible = false;
            lbArara.Text = "Arara";
            lbArara.Visible = true;

            try
            {

                if (som19 == null)
                {
                    som19 = new WindowsMediaPlayer();
                    som19.URL = Application.StartupPath + @"\mp3\Arara.mp3";
                    som19.controls.play();
                }

                if (som19 != null)
                {
                    som19.controls.play();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void pbArara_Click(object sender, EventArgs e)
        {
            try
            {

                if (som20 == null)
                {
                    som20 = new WindowsMediaPlayer();
                    som20.URL = Application.StartupPath + @"\mp3\AraraF.mp3";
                    som20.controls.play();
                }

                if (som20 != null)
                {
                    som20.controls.play();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            lbCachorro.Text = "";
            lbLeao.Text = "";
            lbGato.Text = "";
            lbElefante.Text = "";
            lbMacaco.Text = "";
            lbGalinha.Text = "";
            label7.Text = "";
            lbSapo.Text = "";
            lbCoruja.Text = "";
            lbArara.Text = "";

        }

        private void btAjuda_Click(object sender, EventArgs e)
        {

            MessageBox.Show("PARA REPRODUZIR O SOM DO ANIMAL CLIQUE NA FOTO, " +
                "E PARA OUVIR E VER COMO SE ESCREVE O SEU NOME CLIQUE " +
                "EM REPRODUZIR!!", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
