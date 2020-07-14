using System;
using System.Threading;
using System.Windows.Forms;
using WMPLib;


namespace Colabore
{
    public partial class frutas : Form
    {
        
        public frutas()
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

            na = new Thread(returForm);
            na.SetApartmentState(ApartmentState.STA);
            na.Start();
            for (int i = 0; i <= 100000000; i++)
            {
                x++;
            }
            this.Close();

        }

        private void returForm()
        {
            Application.Run(new paginainicial());
        }

        

        WindowsMediaPlayer som1, som2, som3, som4, som5, som6, som7, som8, som9, som10;


        private void btAbacaxi_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label1.Text = "Abacaxi";
            label1.Visible = true;

            try
            {

                if (som1 == null)
                {
                    som1 = new WindowsMediaPlayer();
                    som1.URL = Application.StartupPath + @"\mp3\Abacaxi.mp3";
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



        private void btMaca_Click(object sender, EventArgs e)
        {

            label2.Visible = false;
            label2.Text = "Maçã";
            label2.Visible = true;

            try
            {

                if (som2 == null)
                {
                    som2 = new WindowsMediaPlayer();
                    som2.URL = Application.StartupPath + @"\mp3\Maçã.mp3";
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

       

        private void btMamao_Click(object sender, EventArgs e)
        {

            label3.Visible = false;
            label3.Text = "Mamão";
            label3.Visible = true;

            try
            {

                if (som3 == null)
                {
                    som3 = new WindowsMediaPlayer();
                    som3.URL = Application.StartupPath + @"\mp3\Mamão.mp3";
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

        private void btMorango_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label4.Text = "Morango";
            label4.Visible = true;

            try
            {

                if (som4 == null)
                {
                    som4 = new WindowsMediaPlayer();
                    som4.URL = Application.StartupPath + @"\mp3\Morango.mp3";
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

        private void btManga_Click(object sender, EventArgs e)
        {
            
            label5.Visible = false;
            label5.Text = "Manga";
            label5.Visible = true;

            try
            {

                if (som5 == null)
                {
                    som5 = new WindowsMediaPlayer();
                    som5.URL = Application.StartupPath + @"\mp3\Manga.mp3";
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

        private void btLaranja_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label6.Text = "Laranja";
            label6.Visible = true;

            try
            {

                if (som6 == null)
                {
                    som6 = new WindowsMediaPlayer();
                    som6.URL = Application.StartupPath + @"\mp3\Laranja.mp3";
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

        private void btBanana_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label7.Text = "Banana";
            label7.Visible = true;

            try
            {

                if (som7 == null)
                {
                    som7 = new WindowsMediaPlayer();
                    som7.URL = Application.StartupPath + @"\mp3\Banana.mp3";
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

        private void btUva_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            label8.Text = "Uva";
            label8.Visible = true;

            try
            {

                if (som8 == null)
                {
                    som8 = new WindowsMediaPlayer();
                    som8.URL = Application.StartupPath + @"\mp3\Uva.mp3";
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

        private void btPera_Click(object sender, EventArgs e)
        {

            label9.Visible = false;
            label9.Text = "Pêra";
            label9.Visible = true;

            try
            {

                if (som9 == null)
                {
                    som9 = new WindowsMediaPlayer();
                    som9.URL = Application.StartupPath + @"\mp3\Pera.mp3";
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
        private void btMelancia_Click(object sender, EventArgs e)
        {

            label10.Visible = false;
            label10.Text = "Melancia";
            label10.Visible = true;

            try
            {

                if (som10 == null)
                {
                    som10 = new WindowsMediaPlayer();
                    som10.URL = Application.StartupPath + @"\mp3\Melancia.mp3";
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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
        }
    }
}


