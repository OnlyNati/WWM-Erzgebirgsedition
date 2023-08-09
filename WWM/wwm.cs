using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace WWM
{
    public partial class wwm : Form
    {

        //string programmpfad = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string programmpfad = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        Boolean halbehalbe;
        Boolean publikum;
        Boolean experte;
        Boolean nochmal;

        int stage = 1;

        string[] fragenliste = new string[17];
        string[] antwort_a = new string[16];
        string[] antwort_b = new string[16];
        string[] antwort_c = new string[16];
        string[] antwort_d = new string[16];
        string[] loesung = new string[16];
        int frage = 1;

        string aktantwort;
        int nochmalstatus = 1;

        int buttoncount = 1;




        

        public wwm()
        {
            InitializeComponent();


            


            if (!Directory.Exists(programmpfad + @"\WWM\"))
            {
                Directory.CreateDirectory(programmpfad + @"\WWM\");
                Directory.CreateDirectory(programmpfad + @"\WWM\config\");
                Directory.CreateDirectory(programmpfad + @"\WWM\musik\");
                MessageBox.Show("Die Ordner: " + programmpfad + @"\WWM\config\" + " und\n" + programmpfad + @"\WWM\musik\" + " müssen befüllt werden!");
                //Application.Exit();
                Environment.Exit(0);
                //Close();
            }

            if (!File.Exists(programmpfad + @"\WWM\config\fragen.txt"))
            {
                File.Create(programmpfad + @"\WWM\config\fragen.txt");
                MessageBox.Show("Keine Fragen in: " + programmpfad + @"\WWM\config\fragen.txt" + " hinterlegt!");

                if (!File.Exists(programmpfad + @"\WWM\config\antwort_a.txt"))
                {
                    File.Create(programmpfad + @"\WWM\config\antwort_a.txt");
                    MessageBox.Show("Keine Antworten in: " + programmpfad + @"\WWM\config\antwort_a.txt" + " hinterlegt!");

                    if (!File.Exists(programmpfad + @"\WWM\config\antwort_b.txt"))
                    {
                        File.Create(programmpfad + @"\WWM\config\antwort_b.txt");
                        MessageBox.Show("Keine Antworten in: " + programmpfad + @"\WWM\config\antwort_b.txt" + " hinterlegt!");

                        if (!File.Exists(programmpfad + @"\WWM\config\antwort_c.txt"))
                        {
                            File.Create(programmpfad + @"\WWM\config\antwort_c.txt");
                            MessageBox.Show("Keine Antworten in: " + programmpfad + @"\WWM\config\antwort_c.txt" + " hinterlegt!");

                            if (!File.Exists(programmpfad + @"\WWM\config\antwort_d.txt"))
                            {
                                File.Create(programmpfad + @"\WWM\config\antwort_d.txt");
                                MessageBox.Show("Keine Antworten in: " + programmpfad + @"\WWM\config\antwort_d.txt" + " hinterlegt!");

                                if (!File.Exists(programmpfad + @"\WWM\config\loesung.txt"))
                                {
                                    File.Create(programmpfad + @"\WWM\config\loesung.txt");            

                                    MessageBox.Show("Keine Lösungen in: " + programmpfad + @"\WWM\config\loesung.txt" + " hinterlegt!");
                                    //Application.Exit();
                                    Environment.Exit(0);
                                    //Close();
                                }

                            }
                        }

                    }
                }
            }
            try
            {
                StreamReader fragenreader = new StreamReader(programmpfad + @"\WWM\config\fragen.txt");
                StreamReader areader = new StreamReader(programmpfad + @"\WWM\config\antwort_a.txt");
                StreamReader breader = new StreamReader(programmpfad + @"\WWM\config\antwort_b.txt");
                StreamReader creader = new StreamReader(programmpfad + @"\WWM\config\antwort_c.txt");
                StreamReader dreader = new StreamReader(programmpfad + @"\WWM\config\antwort_d.txt");
                StreamReader loesungsreader = new StreamReader(programmpfad + @"\WWM\config\loesung.txt");

                bt_a.Visible = false;
                bt_b.Visible = false;
                bt_c.Visible = false;
                bt_d.Visible = false;

                int i = 0;
                string line;
                try
                {
                    //Einlesen Fragen
                    line = fragenreader.ReadLine();
                    while (line != null)
                    {
                        fragenliste[i] = line;
                        i++;
                        line = fragenreader.ReadLine();
                    }
                    i = 0;
                    //Einlesen A Antworten
                    line = areader.ReadLine();
                    while (line != null)
                    {
                        antwort_a[i] = line;
                        i++;
                        line = areader.ReadLine();
                    }
                    i = 0;
                    //Einlesen B Antworten
                    line = breader.ReadLine();
                    while (line != null)
                    {
                        antwort_b[i] = line;
                        i++;
                        line = breader.ReadLine();
                    }
                    i = 0;
                    //Einlesen C Antworten
                    line = creader.ReadLine();
                    while (line != null)
                    {
                        antwort_c[i] = line;
                        i++;
                        line = creader.ReadLine();
                    }
                    i = 0;
                    //Einlesen D Antworten
                    line = dreader.ReadLine();
                    while (line != null)
                    {
                        antwort_d[i] = line;
                        i++;
                        line = dreader.ReadLine();
                    }
                    i = 0;
                    //Einlesen Loesungen
                    line = loesungsreader.ReadLine();
                    while (line != null)
                    {
                        loesung[i] = line;
                        i++;
                        line = loesungsreader.ReadLine();
                    }
                }
                catch 
                {
                    MessageBox.Show("Konfigdatein konnten nicht eingelesen werden. Programm wird beendet.");
                    //Application.Exit();
                    Environment.Exit(0);
                }
                long arraylaenge = fragenliste.LongCount();
            }
            catch
            {
                MessageBox.Show("Konfigdatein wurden erst erstellt und müssen befüllt werden.");
                //Application.Exit();
                //Close();
                Environment.Exit(0);
            }
        }

        private void lb_frage_Click(object sender, EventArgs e)
        {

        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer background = new SoundPlayer(programmpfad + @"\WWM\musik\start.wav");
                background.Play();
            }
            catch
            {
                MessageBox.Show("File 'start.wav' fehlt.");
            }
            
            switch (stage)
            {
                case 0:
                    stage++;
                    break;
                case 1:
                    lb_01.ForeColor = Color.DarkOrange;
                    stage++;
                    break;
                case 2:
                    lb_02.ForeColor = Color.DarkOrange;
                    bt_zurueck.Enabled = true;
                    stage++;
                    break;
                case 3:
                    lb_03.ForeColor = Color.DarkOrange;
                    stage++;
                    break;
                case 4:
                    lb_04.ForeColor = Color.Yellow;
                    stage++;
                    break;
                case 5:
                    lb_05.ForeColor = Color.DarkOrange;
                    stage++;
                    break;
                case 6:
                    lb_06.ForeColor = Color.DarkOrange;
                    stage++;
                    break;
                case 7:
                    lb_07.ForeColor = Color.DarkOrange;
                    stage++;
                    break;
                case 8:
                    lb_08.ForeColor = Color.Yellow;
                    stage++;
                    break;
                case 9:
                    lb_09.ForeColor = Color.DarkOrange;
                    stage++;
                    break;
                case 10:
                    lb_10.ForeColor = Color.DarkOrange;
                    stage++;
                    break;
                case 11:
                    lb_11.ForeColor = Color.DarkOrange;
                    stage++;
                    break;
                case 12:
                    lb_12.ForeColor = Color.Yellow;
                    stage++;
                    break;
                case 13:
                    lb_13.ForeColor = Color.DarkOrange;
                    stage++;
                    break;
                case 14:
                    lb_14.ForeColor = Color.DarkOrange;
                    stage++;
                    break;
                case 15:
                    lb_15.ForeColor = Color.DarkOrange;
                    stage++;
                    break;
                case 16:
                    lb_16.ForeColor = Color.Yellow;
                    stage++;
                    break;
                default:
                    break;

            }
            if (halbehalbe == true)
            {
                bt_50_50.BackgroundImage = WWM.Properties.Resources._50_50_genommen;
            }
            if (publikum == true)
            {
                bt_publikum.BackgroundImage = WWM.Properties.Resources.DPublikum_genommen;
            }
            if (experte == true)
            {
                bt_experte.BackgroundImage = WWM.Properties.Resources.experte_genommen;
            }
            if (nochmal == true)
            {
                bt_nochmal.BackgroundImage = WWM.Properties.Resources.nochmal_genommen;
            }

            bt_a.ForeColor = Color.White;
            bt_b.ForeColor = Color.White;
            bt_c.ForeColor = Color.White;
            bt_d.ForeColor = Color.White;


            pb_kreuza.Visible = false;
            pb_kreuzb.Visible = false;
            pb_kreuzc.Visible = false;
            pb_kreuzd.Visible = false;

            try
            {
                SoundPlayer background2 = new SoundPlayer(programmpfad + @"\WWM\musik\fragen.wav");
                background2.Play();
            }
            catch
            {
                MessageBox.Show("File 'frage.wav' fehlt!");
            }

            bt_a.Enabled = true;
            bt_a.Visible = true;
            bt_b.Enabled = true;
            bt_b.Visible = true;    
            bt_c.Enabled = true;
            bt_c.Visible = true;
            bt_d.Enabled = true;
            bt_d.Visible = true;
            //bt_next.Text = "nächste Frage";

            string a;
            string b;
            string c;  
            string d;
            //if (fragenliste[frage - 1].ToString() == "Ende!")
            if (fragenliste[frage - 1] == null)
            //if (fragenliste[frage - 1].ToString() == string.IsNullOrWhiteSpace())
            //if (stage > 17)
            //if (string.IsNullOrWhiteSpace(fragenliste[frage - 1].ToString()) == true)
            {

                try
                {
                    SoundPlayer background2 = new SoundPlayer(programmpfad + @"\WWM\musik\endet.wav");
                    background2.Play();
                }
                catch
                {
                    MessageBox.Show("File 'endet.wav' fehlt!");
                }

                //MessageBox.Show("Ende Gelände");
                bt_a.Enabled = false;
                bt_b.Enabled = false;
                bt_c.Enabled = false;
                bt_d.Enabled = false;
                bt_next.Enabled = false;
                lb_frage.Visible = false;
                lb_ende.Visible = true;
                //Close();
                //Application.Exit();
                //Environment.Exit(0);
                /*
                DialogResult result;


                result = MessageBox.Show("Programm beenden?");

                if (result == DialogResult.OK)
                {
                    Close();
                    Environment.Exit(0);
                }
                */

            }
            else
            {

                lb_frage.Text = fragenliste[frage - 1].ToString();
                try
                {
                    a = antwort_a[frage - 1].ToString();
                    bt_a.Text = a.Substring(0, a.Length - 1);
                }
                catch
                {
                    MessageBox.Show("Ende Gelände");
                    bt_a.Enabled = false;
                    bt_b.Enabled = false;
                    bt_c.Enabled = false;
                    bt_d.Enabled = false;
                    bt_next.Enabled = false;
                    //Application.Exit();
                    Environment.Exit(0);
                    //Close();
                }

                b = antwort_b[frage - 1].ToString();
                bt_b.Text = b.Substring(0, b.Length - 1);
                c = antwort_c[frage - 1].ToString();
                bt_c.Text = c.Substring(0, c.Length - 1);
                d = antwort_d[frage - 1].ToString();
                bt_d.Text = d.Substring(0, d.Length - 1);
                frage++;

                if (nochmalstatus >= 2)
                {
                    bt_nochmal.Enabled = false;
                    //pb_deaknochmal.Visible = true;
                }
            }
        }

        private void bt_ende_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Environment.Exit(0);
            //Close();
        }

        private void bt_a_Click(object sender, EventArgs e)
        {
            aktantwort = "a";
            if (buttoncount == 1)
            {
                bt_a.ForeColor = Color.DarkOrange;
                buttoncount++;
                bt_b.Enabled = false;
                bt_c.Enabled = false;
                bt_d.Enabled = false;
            }
            else if (buttoncount == 2)
            {
                string antwort;
                antwort = "a";

                if (loesung[frage - 2].ToString() == antwort)
                {
                    //MessageBox.Show("Richtig!");
                    try
                    {
                        SoundPlayer success = new SoundPlayer(programmpfad + @"\WWM\musik\success.wav");
                        success.Play();
                    }
                    catch 
                    {
                        MessageBox.Show("File 'success.wav' fehlt!");
                    }

                    bt_a.ForeColor = Color.DarkGreen;

                    if (nochmalstatus >= 2)
                    {
                        bt_nochmal.Enabled = false;
                        //pb_deaknochmal.Visible = true;
                    }
                }
                else
                {
                    //MessageBox.Show("Falsche!");
                    bt_a.ForeColor = Color.DarkRed;
                    //bt_a.Enabled = false;
                }
                buttoncount = 1;
            }
        }

        private void bt_b_Click(object sender, EventArgs e)
        {
            aktantwort = "b";
            if (buttoncount == 1)
            {
                bt_b.ForeColor = Color.DarkOrange;
                buttoncount++;
                bt_a.Enabled = false;
                bt_c.Enabled = false;
                bt_d.Enabled = false;
            }
            else if (buttoncount == 2)
            {
                string antwort;
                antwort = "b";

                if (loesung[frage - 2].ToString() == antwort)
                {
                    try
                    {
                        SoundPlayer success = new SoundPlayer(programmpfad + @"\WWM\musik\success.wav");
                        success.Play();
                    }
                    catch
                    {
                        MessageBox.Show("File 'success.wav' fehlt!");
                    }
                    //MessageBox.Show("Richtig!");

                    bt_b.ForeColor = Color.DarkGreen;
                    

                    if (nochmalstatus >= 2)
                    {
                        bt_nochmal.Enabled = false;
                        //pb_deaknochmal.Visible = true;
                    }
                }
                else
                {
                    //MessageBox.Show("Falsche!");
                    bt_b.ForeColor = Color.DarkRed;
                    //bt_b.Enabled = false;
                }
                buttoncount = 1;
            }
        }

        private void bt_c_Click(object sender, EventArgs e)
        {
            aktantwort = "c";
            if (buttoncount == 1)
            {
                bt_c.ForeColor = Color.DarkOrange;
                buttoncount++;
                bt_a.Enabled = false;
                bt_b.Enabled = false;
                bt_d.Enabled = false;
            }
            else if (buttoncount == 2)
            {
                string antwort;
                antwort = "c";

                if (loesung[frage - 2].ToString() == antwort)
                {
                    try
                    {
                        SoundPlayer success = new SoundPlayer(programmpfad + @"\WWM\musik\success.wav");
                        success.Play();
                    }
                    catch
                    {
                        MessageBox.Show("File 'success.wav' fehlt!");
                    }

                    bt_c.ForeColor = Color.DarkGreen;
                    

                    if (nochmalstatus >= 2)
                    {
                        bt_nochmal.Enabled = false;
                        //pb_deaknochmal.Visible = true;
                    }
                }
                else
                {
                    //MessageBox.Show("Falsche!");
                    bt_c.ForeColor = Color.DarkRed;
                    //bt_c.Enabled = false;
                }
                buttoncount = 1;
            }
        }

        private void bt_d_Click(object sender, EventArgs e)
        {
            aktantwort = "d";
            if (buttoncount == 1)
            {
                bt_d.ForeColor = Color.DarkOrange;
                buttoncount++;
                bt_a.Enabled = false;
                bt_b.Enabled = false;
                bt_c.Enabled = false;
            }
            else if (buttoncount == 2)
            {
                string antwort;
                antwort = "d";

                if (loesung[frage - 2].ToString() == antwort)
                {
                    try
                    {
                        SoundPlayer success = new SoundPlayer(programmpfad + @"\WWM\musik\success.wav");
                        success.Play();
                    }
                    catch
                    {
                        MessageBox.Show("File 'success.wav' fehlt!");
                    }

                    bt_d.ForeColor = Color.DarkGreen;
                    

                    if (nochmalstatus >= 2)
                    {
                        bt_nochmal.Enabled = false;
                        //pb_deaknochmal.Visible = true;
                    }
                }
                else
                {
                    //MessageBox.Show("Falsche!");
                    bt_d.ForeColor = Color.DarkRed;
                    //bt_d.Enabled = false;
                }
                buttoncount = 1;
            }
        }

        private void bt_50_50_Click(object sender, EventArgs e)
        {
            //Close();
            bt_50_50.BackgroundImage = WWM.Properties.Resources._50_50_aktiviert;
            halbehalbe = true;
            bt_50_50.Enabled = false;   
            string a, b, c, d;
            a = antwort_a[frage - 2].ToString();
            if (a.Substring(a.Length - 1) == "-")
            {
                //lb_01.Text = a;
                bt_a.Enabled = false;
                pb_kreuza.Visible = true;
            }
            else {}

            b = antwort_b[frage - 2].ToString();
            if (b.Substring(b.Length - 1) == "-")
            {
                //lb_02.Text = b;
                bt_b.Enabled = false;
                pb_kreuzb.Visible = true;
            }
            else {}

            c = antwort_c[frage - 2].ToString();
            if (c.Substring(c.Length - 1) == "-")
            {
                //lb_03.Text = c;
                bt_c.Enabled = false;
                pb_kreuzc.Visible = true;
            }
            else { }

            d = antwort_d[frage - 2].ToString();
            if (d.Substring(d.Length - 1) == "-")
            {
                //lb_04.Text = d;
                bt_d.Enabled = false;
                pb_kreuzd.Visible = true;
            }
            else {}
        }

        private void bt_nochmal_Click(object sender, EventArgs e)
        {
            nochmal = true;
            bt_nochmal.BackgroundImage = WWM.Properties.Resources.nochmal_aktiviert;

            if (nochmalstatus == 1)
            {
                nochmalstatus = 2;
            }else if (nochmalstatus == 2)
            {
                if (aktantwort == "a")
                {
                    bt_a.Enabled = false;
                    bt_b.Enabled = true;
                    bt_c.Enabled = true;
                    bt_d.Enabled = true;
                }
                if (aktantwort == "b")
                {
                    bt_b.Enabled = false;
                    bt_a.Enabled = true;
                    bt_c.Enabled = true;
                    bt_d.Enabled = true;
                }
                if (aktantwort == "c")
                {
                    bt_c.Enabled = false;
                    bt_a.Enabled = true;
                    bt_b.Enabled = true;
                    bt_d.Enabled = true;
                }
                if (aktantwort == "d")
                {
                    bt_d.Enabled = false;
                    bt_a.Enabled = true;
                    bt_b.Enabled = true;
                    bt_c.Enabled = true;
                }
                bt_nochmal.Enabled = false;
                //pb_deaknochmal.Visible = true;
            }
        }

        private void bt_publikum_Click(object sender, EventArgs e)
        {
            publikum = true;
            bt_publikum.BackgroundImage = WWM.Properties.Resources.DPublikum_aktiviert;
            bt_publikum.Enabled = false;
        }

        private void bt_experte_Click(object sender, EventArgs e)
        {
            experte = true;
            bt_experte.BackgroundImage = WWM.Properties.Resources.experte_aktiviert;
            bt_experte.Enabled = false;
        }

        private void wwm_Load(object sender, EventArgs e)
        {

        }

        private void pb_start_Click(object sender, EventArgs e)
        {
            
            if (!File.Exists(programmpfad + @"\WWM\musik\start.wav"))
            {
                MessageBox.Show("File 'start.wav' fehlt.");
            }
            else
            {
                SoundPlayer background = new SoundPlayer(programmpfad + @"\WWM\musik\start.wav");
                background.Play();
                pb_start.BackgroundImage = WWM.Properties.Resources.start_1;
                pb_start.Refresh();
                Thread.Sleep(2 * 1000);
                pb_start.BackgroundImage = WWM.Properties.Resources.start_2;
                pb_start.Refresh();
                Thread.Sleep(4 * 1000);
                pb_start.BackgroundImage = WWM.Properties.Resources.start_3;
                pb_start.Refresh();
                Thread.Sleep(4 * 1000);
                pb_start.BackgroundImage = WWM.Properties.Resources.start_41;
                pb_start.Refresh();
                Thread.Sleep(3 * 1000);
                pb_start.BackgroundImage = WWM.Properties.Resources.start_51;
                pb_start.Refresh();
                Thread.Sleep(19 * 1000);
            }
            
            pb_start.Visible = false;
            pb_logo.Visible = true;
            lb_unterschrift.Visible = true;
            bt_zurueck.Visible = true;

            try
            {
                SoundPlayer background = new SoundPlayer(programmpfad + @"\WWM\musik\fragen.wav");
                background.Play();
            }
            catch
            {
                MessageBox.Show("File 'fragen.wav' fehlt.");
            }

        }

        private void bt_zurueck_Click(object sender, EventArgs e)
        {
            stage--;
            frage = frage - 2;
            if (frage > 0)
            {
                try
                {
                    SoundPlayer background = new SoundPlayer(programmpfad + @"\WWM\musik\start.wav");
                    background.Play();
                }
                catch
                {
                    MessageBox.Show("File 'start.wav' fehlt.");
                }

                switch (stage)
                {
                    case 0:
                        stage++;
                        break;
                    case 1:
                        lb_01.ForeColor = Color.White;
                        stage++;
                        break;
                    case 2:
                        lb_02.ForeColor = Color.White;
                        stage++;
                        break;
                    case 3:
                        lb_03.ForeColor = Color.White;
                        stage++;
                        break;
                    case 4:
                        lb_04.ForeColor = Color.White;
                        stage++;
                        break;
                    case 5:
                        lb_05.ForeColor = Color.White;
                        stage++;
                        break;
                    case 6:
                        lb_06.ForeColor = Color.White;
                        stage++;
                        break;
                    case 7:
                        lb_07.ForeColor = Color.White;
                        stage++;
                        break;
                    case 8:
                        lb_08.ForeColor = Color.White;
                        stage++;
                        break;
                    case 9:
                        lb_09.ForeColor = Color.White;
                        stage++;
                        break;
                    case 10:
                        lb_10.ForeColor = Color.White;
                        stage++;
                        break;
                    case 11:
                        lb_11.ForeColor = Color.White;
                        stage++;
                        break;
                    case 12:
                        lb_12.ForeColor = Color.White;
                        stage++;
                        break;
                    case 13:
                        lb_13.ForeColor = Color.White;
                        stage++;
                        break;
                    case 14:
                        lb_14.ForeColor = Color.White;
                        stage++;
                        break;
                    case 15:
                        lb_15.ForeColor = Color.White;
                        stage++;
                        break;
                    case 16:
                        lb_16.ForeColor = Color.White;
                        stage++;
                        break;
                    default:
                        break;

                }
                if (halbehalbe == true)
                {
                    bt_50_50.BackgroundImage = WWM.Properties.Resources._50_50_genommen;
                }
                if (publikum == true)
                {
                    bt_publikum.BackgroundImage = WWM.Properties.Resources.DPublikum_genommen;
                }
                if (experte == true)
                {
                    bt_experte.BackgroundImage = WWM.Properties.Resources.experte_genommen;
                }
                if (nochmal == true)
                {
                    bt_nochmal.BackgroundImage = WWM.Properties.Resources.nochmal_genommen;
                }

                bt_a.ForeColor = Color.White;
                bt_b.ForeColor = Color.White;
                bt_c.ForeColor = Color.White;
                bt_d.ForeColor = Color.White;


                pb_kreuza.Visible = false;
                pb_kreuzb.Visible = false;
                pb_kreuzc.Visible = false;
                pb_kreuzd.Visible = false;

                try
                {
                    SoundPlayer background2 = new SoundPlayer(programmpfad + @"\WWM\musik\fragen.wav");
                    background2.Play();
                }
                catch
                {
                    MessageBox.Show("File 'fragen.wav' fehlt!");
                }

                bt_a.Enabled = true;
                bt_a.Visible = true;
                bt_b.Enabled = true;
                bt_b.Visible = true;
                bt_c.Enabled = true;
                bt_c.Visible = true;
                bt_d.Enabled = true;
                bt_d.Visible = true;
                //bt_next.Text = "nächste Frage";

                string a;
                string b;
                string c;
                string d;
                //if (fragenliste[frage - 1].ToString() == "Ende!")
                if (fragenliste[frage - 1] == null)
                //if (fragenliste[frage - 1].ToString() == string.IsNullOrWhiteSpace())
                //if (stage > 17)
                //if (string.IsNullOrWhiteSpace(fragenliste[frage - 1].ToString()) == true)
                {
                    //MessageBox.Show("Ende Gelände");
                    bt_a.Enabled = false;
                    bt_b.Enabled = false;
                    bt_c.Enabled = false;
                    bt_d.Enabled = false;
                    bt_next.Enabled = false;
                    //lb_ende.Visible = true;

                    //Close();
                    //Application.Exit();
                    //Environment.Exit(0);

                }

                lb_frage.Text = fragenliste[frage - 1].ToString();
                try
                {
                    a = antwort_a[frage - 1].ToString();
                    bt_a.Text = a.Substring(0, a.Length - 1);
                }
                catch
                {
                    MessageBox.Show("Ende Gelände");
                    bt_a.Enabled = false;
                    bt_b.Enabled = false;
                    bt_c.Enabled = false;
                    bt_d.Enabled = false;
                    bt_next.Enabled = false;
                    //Application.Exit();
                    Environment.Exit(0);
                    //Close();
                }

                b = antwort_b[frage - 1].ToString();
                bt_b.Text = b.Substring(0, b.Length - 1);
                c = antwort_c[frage - 1].ToString();
                bt_c.Text = c.Substring(0, c.Length - 1);
                d = antwort_d[frage - 1].ToString();
                bt_d.Text = d.Substring(0, d.Length - 1);
                frage++;

                if (nochmalstatus >= 2)
                {
                    bt_nochmal.Enabled = false;
                    //pb_deaknochmal.Visible = true;
                }
                stage--;
            }
            else
            {
                frage++;
                MessageBox.Show("Weiter gehts nicht");
            }
        }
    }
}
