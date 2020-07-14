using System;
using System.Threading;
using System.Windows.Forms;
using WMPLib;


namespace Colabore
{
    public partial class Alfabeto : Form

    {
        public Alfabeto()
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

        Thread nb;
        int x = 0;

        WindowsMediaPlayer som1, som2, som3, som4, som5, som6, som7, som8, som9, som10,
            som11, som12, som13, som14, som15, som16, som17, som18, som19, som20, som21,
            som22, som23, som24, som25, som26;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {


            nb = new Thread(returForm);
            nb.SetApartmentState(ApartmentState.STA);
            nb.Start();
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


        private void btReproduzir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "A" || textBox1.Text == "a")
            {

                try
                {

                    if (som1 == null)
                    {
                        som1 = new WindowsMediaPlayer();
                        som1.URL = Application.StartupPath + @"\mp3\A.mp3";
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

            if (textBox1.Text == "B" || textBox1.Text == "b")
            {

                try
                {

                    if (som2 == null)
                    {
                        som2 = new WindowsMediaPlayer();
                        som2.URL = Application.StartupPath + @"\mp3\B.mp3";
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

            if (textBox1.Text == "C" || textBox1.Text == "c")
            {

                try
                {

                    if (som3 == null)
                    {
                        som3 = new WindowsMediaPlayer();
                        som3.URL = Application.StartupPath + @"\mp3\C.mp3";
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

            if (textBox1.Text == "D" || textBox1.Text == "d")
            {

                try
                {

                    if (som4 == null)
                    {
                        som4 = new WindowsMediaPlayer();
                        som4.URL = Application.StartupPath + @"\mp3\D.mp3";
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

            if (textBox1.Text == "E" || textBox1.Text == "e")
            {

                try
                {

                    if (som5 == null)
                    {
                        som5 = new WindowsMediaPlayer();
                        som5.URL = Application.StartupPath + @"\mp3\E.mp3";
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

            if (textBox1.Text == "F" || textBox1.Text == "f")
            {

                try
                {

                    if (som6 == null)
                    {
                        som6 = new WindowsMediaPlayer();
                        som6.URL = Application.StartupPath + @"\mp3\F.mp3";
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

            if (textBox1.Text == "G" || textBox1.Text == "g")
            {

                try
                {

                    if (som7 == null)
                    {
                        som7 = new WindowsMediaPlayer();
                        som7.URL = Application.StartupPath + @"\mp3\G.mp3";
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
            if (textBox1.Text == "H" || textBox1.Text == "h")
            {

                try
                {

                    if (som8 == null)
                    {
                        som8 = new WindowsMediaPlayer();
                        som8.URL = Application.StartupPath + @"\mp3\H.mp3";
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

            if (textBox1.Text == "I" || textBox1.Text == "i")
            {

                try
                {

                    if (som9 == null)
                    {
                        som9 = new WindowsMediaPlayer();
                        som9.URL = Application.StartupPath + @"\mp3\I.mp3";
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

            if (textBox1.Text == "J" || textBox1.Text == "j")
            {

                try
                {

                    if (som10 == null)
                    {
                        som10 = new WindowsMediaPlayer();
                        som10.URL = Application.StartupPath + @"\mp3\J.mp3";
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
            if (textBox1.Text == "K" || textBox1.Text == "k")
            {

                try
                {

                    if (som11 == null)
                    {
                        som11 = new WindowsMediaPlayer();
                        som11.URL = Application.StartupPath + @"\mp3\K.mp3";
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

            if (textBox1.Text == "L" || textBox1.Text == "l")
            {

                try
                {

                    if (som12 == null)
                    {
                        som12 = new WindowsMediaPlayer();
                        som12.URL = Application.StartupPath + @"\mp3\L.mp3";
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

            if (textBox1.Text == "M" || textBox1.Text == "m")
            {

                try
                {

                    if (som13 == null)
                    {
                        som13 = new WindowsMediaPlayer();
                        som13.URL = Application.StartupPath + @"\mp3\M.mp3";
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

            if (textBox1.Text == "N" || textBox1.Text == "n")
            {

                try
                {

                    if (som14 == null)
                    {
                        som14 = new WindowsMediaPlayer();
                        som14.URL = Application.StartupPath + @"\mp3\N.mp3";
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

            if (textBox1.Text == "O" || textBox1.Text == "o")
            {

                try
                {

                    if (som15 == null)
                    {
                        som15 = new WindowsMediaPlayer();
                        som15.URL = Application.StartupPath + @"\mp3\O.mp3";
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

            if (textBox1.Text == "P" || textBox1.Text == "p")
            {

                try
                {

                    if (som16 == null)
                    {
                        som16 = new WindowsMediaPlayer();
                        som16.URL = Application.StartupPath + @"\mp3\P.mp3";
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

            if (textBox1.Text == "Q" || textBox1.Text == "q")
            {

                try
                {

                    if (som17 == null)
                    {
                        som17 = new WindowsMediaPlayer();
                        som17.URL = Application.StartupPath + @"\mp3\Q.mp3";
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

            if (textBox1.Text == "R" || textBox1.Text == "r")
            {

                try
                {

                    if (som18 == null)
                    {
                        som18 = new WindowsMediaPlayer();
                        som18.URL = Application.StartupPath + @"\mp3\R.mp3";
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

            if (textBox1.Text == "S" || textBox1.Text == "s")
            {

                try
                {

                    if (som19 == null)
                    {
                        som19 = new WindowsMediaPlayer();
                        som19.URL = Application.StartupPath + @"\mp3\S.mp3";
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

            if (textBox1.Text == "T" || textBox1.Text == "t")
            {

                try
                {

                    if (som20 == null)
                    {
                        som20 = new WindowsMediaPlayer();
                        som20.URL = Application.StartupPath + @"\mp3\T.mp3";
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

            if (textBox1.Text == "U" || textBox1.Text == "u")
            {

                try
                {

                    if (som21 == null)
                    {
                        som21 = new WindowsMediaPlayer();
                        som21.URL = Application.StartupPath + @"\mp3\U.mp3";
                        som21.controls.play();

                    }

                    if (som21 != null)
                    {
                        som21.controls.play();
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex);
                }
            }

            if (textBox1.Text == "V" || textBox1.Text == "v")
            {

                try
                {

                    if (som22 == null)
                    {
                        som22 = new WindowsMediaPlayer();
                        som22.URL = Application.StartupPath + @"\mp3\V.mp3";
                        som22.controls.play();

                    }

                    if (som22 != null)
                    {
                        som22.controls.play();
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex);
                }
            }

            if (textBox1.Text == "W" || textBox1.Text == "w")
            {

                try
                {

                    if (som23 == null)
                    {
                        som23 = new WindowsMediaPlayer();
                        som23.URL = Application.StartupPath + @"\mp3\W.mp3";
                        som23.controls.play();

                    }

                    if (som23 != null)
                    {
                        som23.controls.play();
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex);
                }
            }

            if (textBox1.Text == "X" || textBox1.Text == "x")
            {

                try
                {

                    if (som24 == null)
                    {
                        som24 = new WindowsMediaPlayer();
                        som24.URL = Application.StartupPath + @"\mp3\X.mp3";
                        som24.controls.play();

                    }

                    if (som24 != null)
                    {
                        som24.controls.play();
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex);
                }
            }

            if (textBox1.Text == "Y" || textBox1.Text == "y")
            {

                try
                {

                    if (som25 == null)
                    {
                        som25 = new WindowsMediaPlayer();
                        som25.URL = Application.StartupPath + @"\mp3\Y.mp3";
                        som25.controls.play();

                    }

                    if (som25 != null)
                    {
                        som25.controls.play();
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex);
                }
            }

            if (textBox1.Text == "Z" || textBox1.Text == "z")
            {

                try
                {

                    if (som26 == null)
                    {
                        som26 = new WindowsMediaPlayer();
                        som26.URL = Application.StartupPath + @"\mp3\Z.mp3";
                        som26.controls.play();

                    }

                    if (som26 != null)
                    {
                        som26.controls.play();
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex);
                }
            }
        }
    }

}
// Nesse Codigo contem as letras do Alfabeto de Aa - Zz
// e é composto por 26 variaveis de som cada numero a sua respectiva letra do Alfabeto