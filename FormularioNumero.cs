using Colabore;
using System;
using System.Threading;
using System.Windows.Forms;
using WMPLib;



namespace Calculadora1
{
    public partial class numerosForm : Form
    {


        public numerosForm()
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

        Thread na;
        WindowsMediaPlayer som0, som1, som2, som3, som4, som5, som6, som7, som8, som9, som10;

        private void bt_num9_Click(object sender, EventArgs e)
        {
            lb_nove.Text = "Nove";
            lb_nove.Visible = true;
            try
            {

                if (som9 == null)
                {
                    som9 = new WindowsMediaPlayer();
                    som9.URL = Application.StartupPath + @"\mp3\Num9.mp3";
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

        private void bt_num10_Click(object sender, EventArgs e)
        {
            lb_dez.Text = "Dez";
            lb_dez.Visible = true;
            try
            {

                if (som10 == null)
                {
                    som10 = new WindowsMediaPlayer();
                    som10.URL = Application.StartupPath + @"\mp3\Num10.mp3";
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

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            lb_zero.Text = "";
            lb_um.Text = "";
            lb_dois.Text = "";
            lb_tres.Text = "";
            lb_quatro.Text = "";
            lb_cinco.Text = "";
            lb_seis.Text = "";
            lb_sete.Text = "";
            lb_oito.Text = "";
            lb_nove.Text = "";
            lb_dez.Text = "";
        }

        private void pl_FormNum_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            na = new Thread(ReturForm);
            na.SetApartmentState(ApartmentState.STA);
            na.Start();
            for (int i = 0; i <= 100000000; i++)
            {

            }
            this.Close();
        }

        private void ReturForm()
        {
            Application.Run(new paginainicial());
        }

        private void lb_zero_Click(object sender, EventArgs e)
        {

        }

        private void lb_quatro_Click(object sender, EventArgs e)
        {

        }

        private void bt_num8_Click(object sender, EventArgs e)
        {
            lb_oito.Text = "Oito";
            lb_oito.Visible = true;
            try
            {

                if (som8 == null)
                {
                    som8 = new WindowsMediaPlayer();
                    som8.URL = Application.StartupPath + @"\mp3\Num8.mp3";
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

        private void bt_num7_Click(object sender, EventArgs e)
        {
            lb_sete.Text = "Sete";
            lb_sete.Visible = true;
            try
            {

                if (som7 == null)
                {
                    som7 = new WindowsMediaPlayer();
                    som7.URL = Application.StartupPath + @"\mp3\Num7.mp3";
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

        private void bt_num6_Click(object sender, EventArgs e)
        {
            lb_seis.Text = "Seis";
            lb_seis.Visible = true;
            try
            {

                if (som6 == null)
                {
                    som6 = new WindowsMediaPlayer();
                    som6.URL = Application.StartupPath + @"\mp3\Num6.mp3";
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

        private void bt_num5_Click(object sender, EventArgs e)
        {
            lb_cinco.Text = "Cinco";
            lb_cinco.Visible = true;
            try
            {

                if (som5 == null)
                {
                    som5 = new WindowsMediaPlayer();
                    som5.URL = Application.StartupPath + @"\mp3\Num5.mp3";
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

        private void bt_num4_Click(object sender, EventArgs e)
        {
            lb_quatro.Text = "Quatro";
            lb_quatro.Visible = true;
            try
            {

                if (som4 == null)
                {
                    som4 = new WindowsMediaPlayer();
                    som4.URL = Application.StartupPath + @"\mp3\Num4.mp3";
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

        private void bt_num3_Click(object sender, EventArgs e)
        {
            lb_tres.Text = "Três";
            lb_tres.Visible = true;
            try
            {

                if (som3 == null)
                {
                    som3 = new WindowsMediaPlayer();
                    som3.URL = Application.StartupPath + @"\mp3\Num3.mp3";
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

        private void bt_num2_Click(object sender, EventArgs e)
        {
            lb_dois.Text = "Dois";
            lb_dois.Visible = true;
            try
            {

                if (som2 == null)
                {
                    som2 = new WindowsMediaPlayer();
                    som2.URL = Application.StartupPath + @"\mp3\Num2.mp3";
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

        private void bt_num1_Click(object sender, EventArgs e)
        {
            lb_um.Text = "Um";
            lb_um.Visible = true;

            try
            {

                if (som1 == null)
                {
                    som1 = new WindowsMediaPlayer();
                    som1.URL = Application.StartupPath + @"\mp3\Num1.mp3";
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

        private void bt_abrirCal_Click(object sender, EventArgs e)
        {
            CalculadoraForm abrir = new CalculadoraForm();
            abrir.Show();
        }

        private void bt_num0_Click(object sender, EventArgs e)
        {

            lb_zero.Text = "Zero";
            lb_zero.Visible = true;
            try
            {

                if (som0 == null)
                {
                    som0 = new WindowsMediaPlayer();
                    som0.URL = Application.StartupPath + @"\mp3\Num0.mp3";
                    som0.controls.play();
                }

                if (som0 != null)
                {
                    som0.controls.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }
    }
}


