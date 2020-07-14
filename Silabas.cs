using Colabore;
using System;
using System.Threading;
using System.Windows.Forms;
using WMPLib;

namespace Silabas
{
    public partial class silabas : Form
    {
        

        public silabas()
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

        WindowsMediaPlayer som;

        private void btReproduzir_Click(object sender, EventArgs e)
        {


            try
            {
                while (tbSilabas != null)
                {

                    if (tbSilabas.Text.Equals("A") || tbSilabas.Text.Equals("a"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\A.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("E") || tbSilabas.Text.Equals("e"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\E.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("I") || tbSilabas.Text.Equals("i"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\I.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("O") || tbSilabas.Text.Equals("o"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\O.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("U") || tbSilabas.Text.Equals("u"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\U.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("ÃO") || tbSilabas.Text.Equals("Ão") || tbSilabas.Text.Equals("ão") || tbSilabas.Text.Equals("ãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\ÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("BA") || tbSilabas.Text.Equals("ba") || tbSilabas.Text.Equals("Ba") || tbSilabas.Text.Equals("bA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("BE") || tbSilabas.Text.Equals("be") || tbSilabas.Text.Equals("Be") || tbSilabas.Text.Equals("bE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("BI") || tbSilabas.Text.Equals("bi") || tbSilabas.Text.Equals("Bi") || tbSilabas.Text.Equals("bI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("BO") || tbSilabas.Text.Equals("bo") || tbSilabas.Text.Equals("Bo") || tbSilabas.Text.Equals("bO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("BU") || tbSilabas.Text.Equals("bu") || tbSilabas.Text.Equals("Bu") || tbSilabas.Text.Equals("bU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("BÃO") || tbSilabas.Text.Equals("bão") || tbSilabas.Text.Equals("Bão") || tbSilabas.Text.Equals("bÃo") || tbSilabas.Text.Equals("bãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CA") || tbSilabas.Text.Equals("ca") || tbSilabas.Text.Equals("Ca") || tbSilabas.Text.Equals("cA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CO") || tbSilabas.Text.Equals("co") || tbSilabas.Text.Equals("Co") || tbSilabas.Text.Equals("cO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CU") || tbSilabas.Text.Equals("cu") || tbSilabas.Text.Equals("Cu") || tbSilabas.Text.Equals("cU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CÃO") || tbSilabas.Text.Equals("cão") || tbSilabas.Text.Equals("Cão") || tbSilabas.Text.Equals("cÃo") || tbSilabas.Text.Equals("cãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("DA") || tbSilabas.Text.Equals("da") || tbSilabas.Text.Equals("Da") || tbSilabas.Text.Equals("dA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\DA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("DE") || tbSilabas.Text.Equals("de") || tbSilabas.Text.Equals("De") || tbSilabas.Text.Equals("dE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\DE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("DI") || tbSilabas.Text.Equals("di") || tbSilabas.Text.Equals("Di") || tbSilabas.Text.Equals("dI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\DI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("DO") || tbSilabas.Text.Equals("do") || tbSilabas.Text.Equals("Do") || tbSilabas.Text.Equals("dO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\DO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("DU") || tbSilabas.Text.Equals("du") || tbSilabas.Text.Equals("Du") || tbSilabas.Text.Equals("dU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\DU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("DÃO") || tbSilabas.Text.Equals("dão") || tbSilabas.Text.Equals("Dão") || tbSilabas.Text.Equals("dÃo") || tbSilabas.Text.Equals("dãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\DÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FA") || tbSilabas.Text.Equals("fa") || tbSilabas.Text.Equals("Fa") || tbSilabas.Text.Equals("fA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FE") || tbSilabas.Text.Equals("fe") || tbSilabas.Text.Equals("Fe") || tbSilabas.Text.Equals("fE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FI") || tbSilabas.Text.Equals("fi") || tbSilabas.Text.Equals("Fi") || tbSilabas.Text.Equals("fI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FO") || tbSilabas.Text.Equals("fo") || tbSilabas.Text.Equals("Fo") || tbSilabas.Text.Equals("fO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FU") || tbSilabas.Text.Equals("fu") || tbSilabas.Text.Equals("Fu") || tbSilabas.Text.Equals("fU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FÃO") || tbSilabas.Text.Equals("fão") || tbSilabas.Text.Equals("Fão") || tbSilabas.Text.Equals("fÃo") || tbSilabas.Text.Equals("fãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GA") || tbSilabas.Text.Equals("ga") || tbSilabas.Text.Equals("Ga") || tbSilabas.Text.Equals("gA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GO") || tbSilabas.Text.Equals("go") || tbSilabas.Text.Equals("Go") || tbSilabas.Text.Equals("gO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GU") || tbSilabas.Text.Equals("gu") || tbSilabas.Text.Equals("Gu") || tbSilabas.Text.Equals("gU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GÃO") || tbSilabas.Text.Equals("gão") || tbSilabas.Text.Equals("Gão") || tbSilabas.Text.Equals("gÃo") || tbSilabas.Text.Equals("gãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("HA") || tbSilabas.Text.Equals("ha") || tbSilabas.Text.Equals("Ha") || tbSilabas.Text.Equals("hA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\HA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("HE") || tbSilabas.Text.Equals("he") || tbSilabas.Text.Equals("He") || tbSilabas.Text.Equals("hE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\HE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("HI") || tbSilabas.Text.Equals("hi") || tbSilabas.Text.Equals("Hi") || tbSilabas.Text.Equals("hI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\HI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("HO") || tbSilabas.Text.Equals("ho") || tbSilabas.Text.Equals("Ho") || tbSilabas.Text.Equals("hO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\HO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("HU") || tbSilabas.Text.Equals("hu") || tbSilabas.Text.Equals("Hu") || tbSilabas.Text.Equals("hU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\HU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("HÃO") || tbSilabas.Text.Equals("hão") || tbSilabas.Text.Equals("Hão") || tbSilabas.Text.Equals("hÃo") || tbSilabas.Text.Equals("hãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\HÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("JA") || tbSilabas.Text.Equals("ja") || tbSilabas.Text.Equals("Ja") || tbSilabas.Text.Equals("jA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\JA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("JE") || tbSilabas.Text.Equals("je") || tbSilabas.Text.Equals("Je") || tbSilabas.Text.Equals("jE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\JE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("JI") || tbSilabas.Text.Equals("ji") || tbSilabas.Text.Equals("Ji") || tbSilabas.Text.Equals("jI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\JI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("JO") || tbSilabas.Text.Equals("jo") || tbSilabas.Text.Equals("Jo") || tbSilabas.Text.Equals("jO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\JO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("JU") || tbSilabas.Text.Equals("ju") || tbSilabas.Text.Equals("Ju") || tbSilabas.Text.Equals("jU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\JU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("JÃO") || tbSilabas.Text.Equals("jão") || tbSilabas.Text.Equals("Jão") || tbSilabas.Text.Equals("jÃo") || tbSilabas.Text.Equals("jãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\JÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("LA") || tbSilabas.Text.Equals("la") || tbSilabas.Text.Equals("La") || tbSilabas.Text.Equals("lA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\LA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("LE") || tbSilabas.Text.Equals("le") || tbSilabas.Text.Equals("Le") || tbSilabas.Text.Equals("lE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\LE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("LI") || tbSilabas.Text.Equals("li") || tbSilabas.Text.Equals("Li") || tbSilabas.Text.Equals("lI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\LI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("LO") || tbSilabas.Text.Equals("lo") || tbSilabas.Text.Equals("Lo") || tbSilabas.Text.Equals("lO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\LO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("LU") || tbSilabas.Text.Equals("lu") || tbSilabas.Text.Equals("Lu") || tbSilabas.Text.Equals("lU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\LU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("LÃO") || tbSilabas.Text.Equals("lão") || tbSilabas.Text.Equals("Lão") || tbSilabas.Text.Equals("lÃo") || tbSilabas.Text.Equals("lãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\LÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("MA") || tbSilabas.Text.Equals("ma") || tbSilabas.Text.Equals("Ma") || tbSilabas.Text.Equals("mA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\MA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("ME") || tbSilabas.Text.Equals("me") || tbSilabas.Text.Equals("Me") || tbSilabas.Text.Equals("mE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\ME.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("MI") || tbSilabas.Text.Equals("mi") || tbSilabas.Text.Equals("Mi") || tbSilabas.Text.Equals("mI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\MI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("MO") || tbSilabas.Text.Equals("mo") || tbSilabas.Text.Equals("Mo") || tbSilabas.Text.Equals("mO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\MO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("MU") || tbSilabas.Text.Equals("mu") || tbSilabas.Text.Equals("Mu") || tbSilabas.Text.Equals("mU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\MU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("MÃO") || tbSilabas.Text.Equals("mão") || tbSilabas.Text.Equals("Mão") || tbSilabas.Text.Equals("mÃo") || tbSilabas.Text.Equals("mãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\MÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("NA") || tbSilabas.Text.Equals("na") || tbSilabas.Text.Equals("Na") || tbSilabas.Text.Equals("nA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\NA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("NE") || tbSilabas.Text.Equals("ne") || tbSilabas.Text.Equals("Ne") || tbSilabas.Text.Equals("nE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\NE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("NI") || tbSilabas.Text.Equals("ni") || tbSilabas.Text.Equals("Ni") || tbSilabas.Text.Equals("nI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\NI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("NO") || tbSilabas.Text.Equals("no") || tbSilabas.Text.Equals("No") || tbSilabas.Text.Equals("nO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\NO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("NU") || tbSilabas.Text.Equals("nu") || tbSilabas.Text.Equals("Nu") || tbSilabas.Text.Equals("nU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\NU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("NÃO") || tbSilabas.Text.Equals("não") || tbSilabas.Text.Equals("Não") || tbSilabas.Text.Equals("nÃo") || tbSilabas.Text.Equals("nãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\NÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PA") || tbSilabas.Text.Equals("pa") || tbSilabas.Text.Equals("Pa") || tbSilabas.Text.Equals("pA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PE") || tbSilabas.Text.Equals("pe") || tbSilabas.Text.Equals("Pe") || tbSilabas.Text.Equals("pE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PI") || tbSilabas.Text.Equals("pi") || tbSilabas.Text.Equals("Pi") || tbSilabas.Text.Equals("pI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PO") || tbSilabas.Text.Equals("po") || tbSilabas.Text.Equals("Po") || tbSilabas.Text.Equals("pO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PU") || tbSilabas.Text.Equals("pu") || tbSilabas.Text.Equals("Pu") || tbSilabas.Text.Equals("pU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PÃO") || tbSilabas.Text.Equals("pão") || tbSilabas.Text.Equals("Pão") || tbSilabas.Text.Equals("pÃo") || tbSilabas.Text.Equals("pãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("QUA") || tbSilabas.Text.Equals("qua") || tbSilabas.Text.Equals("Qua") || tbSilabas.Text.Equals("qUa") || tbSilabas.Text.Equals("quA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\QUA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("QUO") || tbSilabas.Text.Equals("quo") || tbSilabas.Text.Equals("Quo") || tbSilabas.Text.Equals("qUo") || tbSilabas.Text.Equals("quO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\QUO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("QUÃO") || tbSilabas.Text.Equals("quão") || tbSilabas.Text.Equals("Quão") || tbSilabas.Text.Equals("qUão") || tbSilabas.Text.Equals("quÃo") || tbSilabas.Text.Equals("quãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\QUÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("RA") || tbSilabas.Text.Equals("ra") || tbSilabas.Text.Equals("Ra") || tbSilabas.Text.Equals("rA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\RA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("RE") || tbSilabas.Text.Equals("re") || tbSilabas.Text.Equals("Re") || tbSilabas.Text.Equals("rE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\RE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("RI") || tbSilabas.Text.Equals("ri") || tbSilabas.Text.Equals("Ri") || tbSilabas.Text.Equals("rI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\RI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("RO") || tbSilabas.Text.Equals("ro") || tbSilabas.Text.Equals("Ro") || tbSilabas.Text.Equals("rO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\RO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("RU") || tbSilabas.Text.Equals("ru") || tbSilabas.Text.Equals("Ru") || tbSilabas.Text.Equals("rU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\RU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("RÃO") || tbSilabas.Text.Equals("rão") || tbSilabas.Text.Equals("Rão") || tbSilabas.Text.Equals("rÃo") || tbSilabas.Text.Equals("rãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\RÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("SA") || tbSilabas.Text.Equals("sa") || tbSilabas.Text.Equals("Sa") || tbSilabas.Text.Equals("sA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\SA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("SE") || tbSilabas.Text.Equals("se") || tbSilabas.Text.Equals("Se") || tbSilabas.Text.Equals("sE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\SE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("SI") || tbSilabas.Text.Equals("si") || tbSilabas.Text.Equals("Si") || tbSilabas.Text.Equals("sI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\SI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("SO") || tbSilabas.Text.Equals("so") || tbSilabas.Text.Equals("So") || tbSilabas.Text.Equals("sO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\SO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("SU") || tbSilabas.Text.Equals("su") || tbSilabas.Text.Equals("Su") || tbSilabas.Text.Equals("sU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\SU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("SÃO") || tbSilabas.Text.Equals("são") || tbSilabas.Text.Equals("São") || tbSilabas.Text.Equals("sÃo") || tbSilabas.Text.Equals("sãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\SÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TA") || tbSilabas.Text.Equals("ta") || tbSilabas.Text.Equals("Ta") || tbSilabas.Text.Equals("tA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TE") || tbSilabas.Text.Equals("te") || tbSilabas.Text.Equals("Te") || tbSilabas.Text.Equals("tE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TI") || tbSilabas.Text.Equals("ti") || tbSilabas.Text.Equals("Ti") || tbSilabas.Text.Equals("tI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TO") || tbSilabas.Text.Equals("to") || tbSilabas.Text.Equals("To") || tbSilabas.Text.Equals("tO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TU") || tbSilabas.Text.Equals("tu") || tbSilabas.Text.Equals("Tu") || tbSilabas.Text.Equals("tU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TÃO") || tbSilabas.Text.Equals("tão") || tbSilabas.Text.Equals("Tão") || tbSilabas.Text.Equals("tÃo") || tbSilabas.Text.Equals("tãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VA") || tbSilabas.Text.Equals("va") || tbSilabas.Text.Equals("Va") || tbSilabas.Text.Equals("vA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VE") || tbSilabas.Text.Equals("ve") || tbSilabas.Text.Equals("Ve") || tbSilabas.Text.Equals("vE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VI") || tbSilabas.Text.Equals("vi") || tbSilabas.Text.Equals("Vi") || tbSilabas.Text.Equals("vI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VO") || tbSilabas.Text.Equals("vo") || tbSilabas.Text.Equals("Vo") || tbSilabas.Text.Equals("vO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VU") || tbSilabas.Text.Equals("vu") || tbSilabas.Text.Equals("Vu") || tbSilabas.Text.Equals("vU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VÃO") || tbSilabas.Text.Equals("vão") || tbSilabas.Text.Equals("Vão") || tbSilabas.Text.Equals("vÃo") || tbSilabas.Text.Equals("vãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("XA") || tbSilabas.Text.Equals("xa") || tbSilabas.Text.Equals("Xa") || tbSilabas.Text.Equals("xA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\XA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("XE") || tbSilabas.Text.Equals("xe") || tbSilabas.Text.Equals("Xe") || tbSilabas.Text.Equals("xE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\XE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("XI") || tbSilabas.Text.Equals("xi") || tbSilabas.Text.Equals("Xi") || tbSilabas.Text.Equals("xI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\XI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("XO") || tbSilabas.Text.Equals("xo") || tbSilabas.Text.Equals("Xo") || tbSilabas.Text.Equals("xO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\XO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("XU") || tbSilabas.Text.Equals("xu") || tbSilabas.Text.Equals("Xu") || tbSilabas.Text.Equals("xU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\XU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("XÃO") || tbSilabas.Text.Equals("xão") || tbSilabas.Text.Equals("Xão") || tbSilabas.Text.Equals("xÃo") || tbSilabas.Text.Equals("xãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\XÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("ZA") || tbSilabas.Text.Equals("za") || tbSilabas.Text.Equals("Za") || tbSilabas.Text.Equals("zA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\ZA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("ZE") || tbSilabas.Text.Equals("ze") || tbSilabas.Text.Equals("Ze") || tbSilabas.Text.Equals("zE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\ZE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("ZI") || tbSilabas.Text.Equals("zi") || tbSilabas.Text.Equals("Zi") || tbSilabas.Text.Equals("zI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\ZI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("ZO") || tbSilabas.Text.Equals("zo") || tbSilabas.Text.Equals("Zo") || tbSilabas.Text.Equals("zO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\ZO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("ZU") || tbSilabas.Text.Equals("zu") || tbSilabas.Text.Equals("Zu") || tbSilabas.Text.Equals("zU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\ZU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("ZÃO") || tbSilabas.Text.Equals("zão") || tbSilabas.Text.Equals("Zão") || tbSilabas.Text.Equals("zÃo") || tbSilabas.Text.Equals("zãO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\ZÃO.mp3";
                        som.controls.play();
                        return;
                    }

                    //Começo das sílabas complexas

                    if (tbSilabas.Text.Equals("BRA") || tbSilabas.Text.Equals("bra") || tbSilabas.Text.Equals("Bra") || tbSilabas.Text.Equals("bRa") || tbSilabas.Text.Equals("brA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BRA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("BRE") || tbSilabas.Text.Equals("bre") || tbSilabas.Text.Equals("Bre") || tbSilabas.Text.Equals("bRe") || tbSilabas.Text.Equals("brE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BRE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("BRI") || tbSilabas.Text.Equals("bri") || tbSilabas.Text.Equals("Bri") || tbSilabas.Text.Equals("bRi") || tbSilabas.Text.Equals("brI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BRI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("BRO") || tbSilabas.Text.Equals("bro") || tbSilabas.Text.Equals("Bro") || tbSilabas.Text.Equals("bRo") || tbSilabas.Text.Equals("brO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BRO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("BRU") || tbSilabas.Text.Equals("bru") || tbSilabas.Text.Equals("Bru") || tbSilabas.Text.Equals("bRu") || tbSilabas.Text.Equals("brU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BRU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CRA") || tbSilabas.Text.Equals("cra") || tbSilabas.Text.Equals("Cra") || tbSilabas.Text.Equals("cRa") || tbSilabas.Text.Equals("crA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CRA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CRE") || tbSilabas.Text.Equals("cre") || tbSilabas.Text.Equals("Cre") || tbSilabas.Text.Equals("cRe") || tbSilabas.Text.Equals("crE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CRE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CRI") || tbSilabas.Text.Equals("cri") || tbSilabas.Text.Equals("Cri") || tbSilabas.Text.Equals("cRi") || tbSilabas.Text.Equals("crI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CRI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CRO") || tbSilabas.Text.Equals("cro") || tbSilabas.Text.Equals("Cro") || tbSilabas.Text.Equals("cRo") || tbSilabas.Text.Equals("crO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CRO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CRU") || tbSilabas.Text.Equals("cru") || tbSilabas.Text.Equals("Cru") || tbSilabas.Text.Equals("cRu") || tbSilabas.Text.Equals("crU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CRU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("DRA") || tbSilabas.Text.Equals("dra") || tbSilabas.Text.Equals("Dra") || tbSilabas.Text.Equals("dRa") || tbSilabas.Text.Equals("drA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\DRA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("DRE") || tbSilabas.Text.Equals("dre") || tbSilabas.Text.Equals("Dre") || tbSilabas.Text.Equals("dRe") || tbSilabas.Text.Equals("drE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\DRE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("DRI") || tbSilabas.Text.Equals("dri") || tbSilabas.Text.Equals("Dri") || tbSilabas.Text.Equals("dRi") || tbSilabas.Text.Equals("drI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\DRI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("DRO") || tbSilabas.Text.Equals("dro") || tbSilabas.Text.Equals("Dro") || tbSilabas.Text.Equals("dRo") || tbSilabas.Text.Equals("drO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\DRO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("DRU") || tbSilabas.Text.Equals("dru") || tbSilabas.Text.Equals("Dru") || tbSilabas.Text.Equals("dRu") || tbSilabas.Text.Equals("drU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\DRU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FRA") || tbSilabas.Text.Equals("fra") || tbSilabas.Text.Equals("Fra") || tbSilabas.Text.Equals("fRa") || tbSilabas.Text.Equals("frA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FRA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FRE") || tbSilabas.Text.Equals("fre") || tbSilabas.Text.Equals("Fre") || tbSilabas.Text.Equals("fRe") || tbSilabas.Text.Equals("frE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FRE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FRI") || tbSilabas.Text.Equals("fri") || tbSilabas.Text.Equals("Fri") || tbSilabas.Text.Equals("fRi") || tbSilabas.Text.Equals("frI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FRI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FRO") || tbSilabas.Text.Equals("fro") || tbSilabas.Text.Equals("Fro") || tbSilabas.Text.Equals("fRo") || tbSilabas.Text.Equals("frO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FRO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FRU") || tbSilabas.Text.Equals("fru") || tbSilabas.Text.Equals("Fru") || tbSilabas.Text.Equals("fRu") || tbSilabas.Text.Equals("frU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FRU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GRA") || tbSilabas.Text.Equals("gra") || tbSilabas.Text.Equals("Gra") || tbSilabas.Text.Equals("gRa") || tbSilabas.Text.Equals("grA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GRA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GRE") || tbSilabas.Text.Equals("gre") || tbSilabas.Text.Equals("Gre") || tbSilabas.Text.Equals("gRe") || tbSilabas.Text.Equals("grE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GRE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GRI") || tbSilabas.Text.Equals("gri") || tbSilabas.Text.Equals("Gri") || tbSilabas.Text.Equals("gRi") || tbSilabas.Text.Equals("grI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GRI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GRO") || tbSilabas.Text.Equals("gro") || tbSilabas.Text.Equals("Gro") || tbSilabas.Text.Equals("gRo") || tbSilabas.Text.Equals("grO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GRO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GRU") || tbSilabas.Text.Equals("gru") || tbSilabas.Text.Equals("Gru") || tbSilabas.Text.Equals("gRu") || tbSilabas.Text.Equals("grU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GRU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PRA") || tbSilabas.Text.Equals("pra") || tbSilabas.Text.Equals("Pra") || tbSilabas.Text.Equals("pRa") || tbSilabas.Text.Equals("prA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PRA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PRE") || tbSilabas.Text.Equals("pre") || tbSilabas.Text.Equals("Pre") || tbSilabas.Text.Equals("pRe") || tbSilabas.Text.Equals("prE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PRE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PRI") || tbSilabas.Text.Equals("pri") || tbSilabas.Text.Equals("Pri") || tbSilabas.Text.Equals("pRi") || tbSilabas.Text.Equals("prI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PRI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PRO") || tbSilabas.Text.Equals("pro") || tbSilabas.Text.Equals("Pro") || tbSilabas.Text.Equals("pRo") || tbSilabas.Text.Equals("prO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PRO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PRU") || tbSilabas.Text.Equals("pru") || tbSilabas.Text.Equals("Pru") || tbSilabas.Text.Equals("pRu") || tbSilabas.Text.Equals("prU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PRU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TRA") || tbSilabas.Text.Equals("tra") || tbSilabas.Text.Equals("Tra") || tbSilabas.Text.Equals("tRa") || tbSilabas.Text.Equals("trA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TRA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TRE") || tbSilabas.Text.Equals("tre") || tbSilabas.Text.Equals("Tre") || tbSilabas.Text.Equals("tRe") || tbSilabas.Text.Equals("trE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TRE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TRI") || tbSilabas.Text.Equals("tri") || tbSilabas.Text.Equals("Tri") || tbSilabas.Text.Equals("tRi") || tbSilabas.Text.Equals("trI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TRI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TRO") || tbSilabas.Text.Equals("tro") || tbSilabas.Text.Equals("Tro") || tbSilabas.Text.Equals("tRo") || tbSilabas.Text.Equals("trO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TRO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TRU") || tbSilabas.Text.Equals("tru") || tbSilabas.Text.Equals("Tru") || tbSilabas.Text.Equals("tRu") || tbSilabas.Text.Equals("trU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TRU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VRA") || tbSilabas.Text.Equals("vra") || tbSilabas.Text.Equals("Vra") || tbSilabas.Text.Equals("vRa") || tbSilabas.Text.Equals("vrA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VRA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VRE") || tbSilabas.Text.Equals("vre") || tbSilabas.Text.Equals("Vre") || tbSilabas.Text.Equals("vRe") || tbSilabas.Text.Equals("vrE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VRE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VRI") || tbSilabas.Text.Equals("vri") || tbSilabas.Text.Equals("Vri") || tbSilabas.Text.Equals("vRi") || tbSilabas.Text.Equals("vrI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VRI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VRO") || tbSilabas.Text.Equals("vro") || tbSilabas.Text.Equals("Vro") || tbSilabas.Text.Equals("vRo") || tbSilabas.Text.Equals("vrO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VRO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VRU") || tbSilabas.Text.Equals("vru") || tbSilabas.Text.Equals("Vru") || tbSilabas.Text.Equals("vRu") || tbSilabas.Text.Equals("vrU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VRU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("BLA") || tbSilabas.Text.Equals("bla") || tbSilabas.Text.Equals("Bla") || tbSilabas.Text.Equals("bLa") || tbSilabas.Text.Equals("blA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BLA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("BLE") || tbSilabas.Text.Equals("ble") || tbSilabas.Text.Equals("Ble") || tbSilabas.Text.Equals("bLe") || tbSilabas.Text.Equals("blE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BLE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("BLI") || tbSilabas.Text.Equals("bli") || tbSilabas.Text.Equals("Bli") || tbSilabas.Text.Equals("bLi") || tbSilabas.Text.Equals("blI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BLI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("BLO") || tbSilabas.Text.Equals("blo") || tbSilabas.Text.Equals("Blo") || tbSilabas.Text.Equals("bLo") || tbSilabas.Text.Equals("blO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BLO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("BLU") || tbSilabas.Text.Equals("blu") || tbSilabas.Text.Equals("Blu") || tbSilabas.Text.Equals("bLu") || tbSilabas.Text.Equals("blU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\BLU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CLA") || tbSilabas.Text.Equals("cla") || tbSilabas.Text.Equals("Cla") || tbSilabas.Text.Equals("cLa") || tbSilabas.Text.Equals("clA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CLA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CLE") || tbSilabas.Text.Equals("cle") || tbSilabas.Text.Equals("Cle") || tbSilabas.Text.Equals("cLe") || tbSilabas.Text.Equals("clE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CLE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CLI") || tbSilabas.Text.Equals("cli") || tbSilabas.Text.Equals("Cli") || tbSilabas.Text.Equals("cLi") || tbSilabas.Text.Equals("clI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CLI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CLO") || tbSilabas.Text.Equals("clo") || tbSilabas.Text.Equals("Clo") || tbSilabas.Text.Equals("cLo") || tbSilabas.Text.Equals("clO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CLO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CLU") || tbSilabas.Text.Equals("clu") || tbSilabas.Text.Equals("Clu") || tbSilabas.Text.Equals("cLu") || tbSilabas.Text.Equals("clU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CLU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FLA") || tbSilabas.Text.Equals("fla") || tbSilabas.Text.Equals("Fla") || tbSilabas.Text.Equals("fLa") || tbSilabas.Text.Equals("flA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FLA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FLE") || tbSilabas.Text.Equals("fle") || tbSilabas.Text.Equals("Fle") || tbSilabas.Text.Equals("fLe") || tbSilabas.Text.Equals("flE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FLE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FLI") || tbSilabas.Text.Equals("fli") || tbSilabas.Text.Equals("Fli") || tbSilabas.Text.Equals("fLi") || tbSilabas.Text.Equals("flI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FLI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FLO") || tbSilabas.Text.Equals("flo") || tbSilabas.Text.Equals("Flo") || tbSilabas.Text.Equals("fLo") || tbSilabas.Text.Equals("flO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FLO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("FLU") || tbSilabas.Text.Equals("flu") || tbSilabas.Text.Equals("Flu") || tbSilabas.Text.Equals("fLu") || tbSilabas.Text.Equals("flU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\FLU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GLA") || tbSilabas.Text.Equals("gla") || tbSilabas.Text.Equals("Gla") || tbSilabas.Text.Equals("gLa") || tbSilabas.Text.Equals("glA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GLA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GLE") || tbSilabas.Text.Equals("gle") || tbSilabas.Text.Equals("Gle") || tbSilabas.Text.Equals("gLe") || tbSilabas.Text.Equals("glE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GLE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GLI") || tbSilabas.Text.Equals("gli") || tbSilabas.Text.Equals("Gli") || tbSilabas.Text.Equals("gLi") || tbSilabas.Text.Equals("glI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GLI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GLO") || tbSilabas.Text.Equals("glo") || tbSilabas.Text.Equals("Glo") || tbSilabas.Text.Equals("gLo") || tbSilabas.Text.Equals("glO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GLO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GLU") || tbSilabas.Text.Equals("glu") || tbSilabas.Text.Equals("Glu") || tbSilabas.Text.Equals("gLu") || tbSilabas.Text.Equals("glU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GLU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PLA") || tbSilabas.Text.Equals("pla") || tbSilabas.Text.Equals("Pla") || tbSilabas.Text.Equals("pLa") || tbSilabas.Text.Equals("plA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PLA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PLE") || tbSilabas.Text.Equals("ple") || tbSilabas.Text.Equals("Ple") || tbSilabas.Text.Equals("pLe") || tbSilabas.Text.Equals("plE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PLE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PLI") || tbSilabas.Text.Equals("pli") || tbSilabas.Text.Equals("Pli") || tbSilabas.Text.Equals("pLi") || tbSilabas.Text.Equals("plI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PLI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PLO") || tbSilabas.Text.Equals("plo") || tbSilabas.Text.Equals("Plo") || tbSilabas.Text.Equals("pLo") || tbSilabas.Text.Equals("plO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PLO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("PLU") || tbSilabas.Text.Equals("plu") || tbSilabas.Text.Equals("Plu") || tbSilabas.Text.Equals("pLu") || tbSilabas.Text.Equals("plU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\PLU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TLA") || tbSilabas.Text.Equals("tla") || tbSilabas.Text.Equals("Tla") || tbSilabas.Text.Equals("tLa") || tbSilabas.Text.Equals("tlA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TLA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TLE") || tbSilabas.Text.Equals("tle") || tbSilabas.Text.Equals("Tle") || tbSilabas.Text.Equals("tLe") || tbSilabas.Text.Equals("tlE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TLE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TLI") || tbSilabas.Text.Equals("tli") || tbSilabas.Text.Equals("Tli") || tbSilabas.Text.Equals("tLi") || tbSilabas.Text.Equals("tlI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TLI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TLO") || tbSilabas.Text.Equals("tlo") || tbSilabas.Text.Equals("Tlo") || tbSilabas.Text.Equals("tLo") || tbSilabas.Text.Equals("tlO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TLO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("TLU") || tbSilabas.Text.Equals("tlu") || tbSilabas.Text.Equals("Tlu") || tbSilabas.Text.Equals("tLu") || tbSilabas.Text.Equals("tlU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\TLU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VLA") || tbSilabas.Text.Equals("vla") || tbSilabas.Text.Equals("Vla") || tbSilabas.Text.Equals("vLa") || tbSilabas.Text.Equals("vlA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VLA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VLE") || tbSilabas.Text.Equals("vle") || tbSilabas.Text.Equals("Vle") || tbSilabas.Text.Equals("vLe") || tbSilabas.Text.Equals("vlE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VLE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VLI") || tbSilabas.Text.Equals("vli") || tbSilabas.Text.Equals("Vli") || tbSilabas.Text.Equals("vLi") || tbSilabas.Text.Equals("vlI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VLI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VLO") || tbSilabas.Text.Equals("vlo") || tbSilabas.Text.Equals("Vlo") || tbSilabas.Text.Equals("vLo") || tbSilabas.Text.Equals("vlO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VLO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("VLU") || tbSilabas.Text.Equals("vlu") || tbSilabas.Text.Equals("Vlu") || tbSilabas.Text.Equals("vLu") || tbSilabas.Text.Equals("vlU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\VLU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CHA") || tbSilabas.Text.Equals("cha") || tbSilabas.Text.Equals("Cha") || tbSilabas.Text.Equals("cHa") || tbSilabas.Text.Equals("chA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CHA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CHE") || tbSilabas.Text.Equals("che") || tbSilabas.Text.Equals("Che") || tbSilabas.Text.Equals("cHe") || tbSilabas.Text.Equals("chE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CHE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CHI") || tbSilabas.Text.Equals("chi") || tbSilabas.Text.Equals("Chi") || tbSilabas.Text.Equals("cHi") || tbSilabas.Text.Equals("chI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CHI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CHO") || tbSilabas.Text.Equals("cho") || tbSilabas.Text.Equals("Cho") || tbSilabas.Text.Equals("cHo") || tbSilabas.Text.Equals("chO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CHO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("CHU") || tbSilabas.Text.Equals("chu") || tbSilabas.Text.Equals("Chu") || tbSilabas.Text.Equals("cHu") || tbSilabas.Text.Equals("chU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\CHU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("AR") || tbSilabas.Text.Equals("ar") || tbSilabas.Text.Equals("Ar") || tbSilabas.Text.Equals("aR"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\AR.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("ER") || tbSilabas.Text.Equals("er") || tbSilabas.Text.Equals("Er") || tbSilabas.Text.Equals("eR"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\ER.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("IR") || tbSilabas.Text.Equals("ir") || tbSilabas.Text.Equals("Ir") || tbSilabas.Text.Equals("iR"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\IR.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("OR") || tbSilabas.Text.Equals("or") || tbSilabas.Text.Equals("Or") || tbSilabas.Text.Equals("oR"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\OR.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("UR") || tbSilabas.Text.Equals("ur") || tbSilabas.Text.Equals("Ur") || tbSilabas.Text.Equals("uR"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\UR.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("NHA") || tbSilabas.Text.Equals("nha") || tbSilabas.Text.Equals("Nha") || tbSilabas.Text.Equals("nHa") || tbSilabas.Text.Equals("nhA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\NHA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("NHE") || tbSilabas.Text.Equals("nhe") || tbSilabas.Text.Equals("Nhe") || tbSilabas.Text.Equals("nHe") || tbSilabas.Text.Equals("nhE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\NHE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("NHI") || tbSilabas.Text.Equals("nhi") || tbSilabas.Text.Equals("Nhi") || tbSilabas.Text.Equals("nHi") || tbSilabas.Text.Equals("nhI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\NHI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("NHO") || tbSilabas.Text.Equals("nho") || tbSilabas.Text.Equals("Nho") || tbSilabas.Text.Equals("nHo") || tbSilabas.Text.Equals("nhO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\NHO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("NHU") || tbSilabas.Text.Equals("nhu") || tbSilabas.Text.Equals("Nhu") || tbSilabas.Text.Equals("nHu") || tbSilabas.Text.Equals("nhU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\NHU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("LHA") || tbSilabas.Text.Equals("lha") || tbSilabas.Text.Equals("Lha") || tbSilabas.Text.Equals("lHa") || tbSilabas.Text.Equals("lhA"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\LHA.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("LHE") || tbSilabas.Text.Equals("lhe") || tbSilabas.Text.Equals("Lhe") || tbSilabas.Text.Equals("lHe") || tbSilabas.Text.Equals("lhE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\LHE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("LHI") || tbSilabas.Text.Equals("lhi") || tbSilabas.Text.Equals("Lhi") || tbSilabas.Text.Equals("lHi") || tbSilabas.Text.Equals("lhI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\LHI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("LHO") || tbSilabas.Text.Equals("lho") || tbSilabas.Text.Equals("Lho") || tbSilabas.Text.Equals("lHo") || tbSilabas.Text.Equals("lhO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\LHO.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("LHU") || tbSilabas.Text.Equals("lhu") || tbSilabas.Text.Equals("Lhu") || tbSilabas.Text.Equals("lHu") || tbSilabas.Text.Equals("lhU"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\LHU.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("AS") || tbSilabas.Text.Equals("as") || tbSilabas.Text.Equals("As") || tbSilabas.Text.Equals("aS"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\AS.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("ES") || tbSilabas.Text.Equals("es") || tbSilabas.Text.Equals("Es") || tbSilabas.Text.Equals("eS"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\ES.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("IS") || tbSilabas.Text.Equals("is") || tbSilabas.Text.Equals("Is") || tbSilabas.Text.Equals("iS"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\IS.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("OS") || tbSilabas.Text.Equals("os") || tbSilabas.Text.Equals("Os") || tbSilabas.Text.Equals("oS"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\OS.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("US") || tbSilabas.Text.Equals("us") || tbSilabas.Text.Equals("Us") || tbSilabas.Text.Equals("uS"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\US.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("AN") || tbSilabas.Text.Equals("an") || tbSilabas.Text.Equals("An") || tbSilabas.Text.Equals("aN"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\AN.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("EN") || tbSilabas.Text.Equals("en") || tbSilabas.Text.Equals("En") || tbSilabas.Text.Equals("eN"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\EN.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("IN") || tbSilabas.Text.Equals("in") || tbSilabas.Text.Equals("In") || tbSilabas.Text.Equals("iN"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\IN.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("ON") || tbSilabas.Text.Equals("on") || tbSilabas.Text.Equals("On") || tbSilabas.Text.Equals("oN"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\ON.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("UN") || tbSilabas.Text.Equals("un") || tbSilabas.Text.Equals("Un") || tbSilabas.Text.Equals("uN"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\UN.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("AL") || tbSilabas.Text.Equals("al") || tbSilabas.Text.Equals("Al") || tbSilabas.Text.Equals("aL"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\AL.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("EL") || tbSilabas.Text.Equals("el") || tbSilabas.Text.Equals("El") || tbSilabas.Text.Equals("eL"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\EL.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("IL") || tbSilabas.Text.Equals("il") || tbSilabas.Text.Equals("Il") || tbSilabas.Text.Equals("iL"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\IL.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("OL") || tbSilabas.Text.Equals("ol") || tbSilabas.Text.Equals("Ol") || tbSilabas.Text.Equals("oL"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\OL.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("UL") || tbSilabas.Text.Equals("ul") || tbSilabas.Text.Equals("Ul") || tbSilabas.Text.Equals("uL"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\UL.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GUE") || tbSilabas.Text.Equals("gue") || tbSilabas.Text.Equals("Gue") || tbSilabas.Text.Equals("gUe") || tbSilabas.Text.Equals("guE"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GUE.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GUI") || tbSilabas.Text.Equals("gui") || tbSilabas.Text.Equals("Gui") || tbSilabas.Text.Equals("gUi") || tbSilabas.Text.Equals("guI"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GUI.mp3";
                        som.controls.play();
                        return;
                    }

                    if (tbSilabas.Text.Equals("GUO") || tbSilabas.Text.Equals("guo") || tbSilabas.Text.Equals("Guo") || tbSilabas.Text.Equals("gUo") || tbSilabas.Text.Equals("guO"))
                    {
                        som = new WindowsMediaPlayer();
                        som.URL = Application.StartupPath + @"\mp3\GUO.mp3";
                        som.controls.play();
                        return;
                    }

                    else
                    {
                        MessageBox.Show("A sílaba não existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btVoltar_Click(object sender, EventArgs e)
        {

            nb = new Thread(retur1Form);
            nb.SetApartmentState(ApartmentState.STA);
            nb.Start();
            for (int i = 0; i <= 100000000; i++)
            {

            }
            this.Close();

        }
        public void retur1Form()
        {
            Application.Run(new paginainicial());
        }
    }
}
