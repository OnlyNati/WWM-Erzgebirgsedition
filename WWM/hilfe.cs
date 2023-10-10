using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWM
{
    public partial class hilfe : Form
    {
        int id = 0;

        public hilfe()
        {
            InitializeComponent();
        }

        private void spielfelderkärungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = 3;
            pb_erklarung.Visible = true;
            pb_erklarung.Image = WWM.Properties.Resources.spielfeld_anleitung;

            lb_erklaerung.Text = 
                "1. beenden Knopf (unsichtbar)\n\n" +
                "2. vorwärts Knopf bzw. nächste Frage (unsichtbar)\n\n" +
                "3. rückwärts Knopf bzw. vorherige Frage (unsichtbar)\n\n" +
                "4. Publikumsjoker - einmal klicken zum aktivieren\n\n" +
                "5. 50:50 Joker - einmal klicken zum aktivieren, " +
                "es werden zwei Antworten weggestrichen\n\n" +
                "6. 'Versuchs nochmal' Joker - klicken zum Aktvieren, " +
                "anschließend kann eine Anwort ausgewählt werden, falls falsch " +
                "beantworter noch einmal Joker drücken und man kann erneut eine Antwort auswählen\n\n" +
                "7. Experten Joker - einmal klicken zum aktivieren\n\n" +
                "8. Fragenanzeige\n\n" +
                "9. Antwort A - einmal klicken zum einloggen - zweite mal klicken um Frage zu lösen\n\n" +
                "10. Antwort C - einmal klicken zum einloggen - zweite mal klicken um Frage zu lösen\n\n" +
                "11. Antwort B - einmal klicken zum einloggen - zweite mal klicken um Frage zu lösen\n\n" +
                "12. Antwort D - einmal klicken zum einloggen - zweite mal klicken um Frage zu lösen\n\n" +
                "13. Fortschrittsanzeige - Stufen werden mit jeder neuen Frage aktuallisiert";
        }

        //Erklärung Eingabe Fragen und Antworten
        private void spielfeldErklärungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = 1;
            bt_1.Visible = true;
            bt_1.Text = "Download Konfiguration";
            bt_2.Visible = true;
            bt_2.Text = "Bild - Datei extrahieren";
            bt_3.Visible = true;
            bt_3.Text = "Inhalt der Zip Datei";
            bt_4.Visible = true;
            bt_4.Text = "Bsp. Datei Inhalte";
            lb_erklaerung.Text = 
                "Um eigene Fragen und Antworten festlegen zu können, müssen Sie zunächst den Konfigurationsordner downloaden. " +
                "Dies können Sie entweder unten mit dem Button 'Download Konfiguration' tun oder Sie rufen selbst folgende Website auf. " +
                "http://dev.nhendel.de/wwm/download/wwm-config.zip.\n\n" +
                "Die heruntergeladene Datei 'wwm-config.zip' muss entpackt werden. Dafür einen Rechtsklick auf die Datei und " +
                "anschließend auf 'Alle extrahieren klicken'\n\n" +
                "Entpackten Ordner öffnen\n\n" +
                "Im Ordner 'config' befinden sich die Datein in denen die Fragen, Antwortmöglichkeiten, die Lösungen und die Information " +
                "für den 50:50 Joker.\n\n" +
                "Alle Datein sind vom Prinzip sehr gleich: Jede Frage ist eine neue Zeile.\n" +
                "Alle Antworten kommen sortiert nach A, B, C, D in die jeweiligen Datein. Wichtig jede Antwort muss in einer neuen Zeile beginnen | " +
                "Ein minus hinter einer antwort bedeutet: die Frage wird beim 50:50 Joker ausgeblendet. " +
                "Wichtig: hinter jede Antwort muss ein Zeichen sein.\n\n" +
                "In der Fragen Datei wird jede Frage ebenfalls in eine neue Zeile geschrieben.\n\n" +
                "In der Lösungsdatei wird in jeder Zeile der Buchstabe der richtigen Antwort hinterlegt.";
            pb_erklarung.Image = WWM.Properties.Resources.zip_ent;
            lb_erlaeuterung.Text = "Rechtsklick -> Alle extrahieren --> um wwm-config.zip zu entpacken";
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            switch (id)
            {
                case 1:
                    System.Diagnostics.Process.Start("http://dev.nhendel.de/wwm/download/wwm-config.zip");
                    break;
                default:
                    break;

            }
        }

        private void datenimportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = 2;
            bt_1.Visible = false;
            bt_2.Visible = false;
            bt_3.Visible = false;
            bt_4.Visible = false;
            pb_erklarung.Image = WWM.Properties.Resources.datenimport;
            lb_erklaerung.Text = "Achtung! Vor dem Import bitte alle Textdatein befüllen(Fragen, Antworten, Lösungen, etc.)\n\n" +
                "Um den Ordner mit den benöitigten Datein zu importieren bitte im Startmenu auf Datenimport klicken.\n\n" +
                "Anschließend auf die weise Zeile klicken und den config Ordner in Ihren Datein suchen und auswählen. Anschließend auf OK und Import.\n\n" +
                "Achtung: Wenn ein Ordner bereits importiert wurde schlägt ein weiterer Importvorgang fehl.\n\n" +
                "Sollte ein Import fehlschlagen, bitte den Config Ordner leeren\nDies funktioniert mit dem Config leeren Button.";
            lb_erlaeuterung.Text = "Klick auf Zeile -> Ordner auswählen -> OK -> Import";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            switch(id)
            {
                case 1:
                    pb_erklarung.Image = WWM.Properties.Resources.zip_ent;
                    lb_erlaeuterung.Text = "Rechtsklick -> Alle extrahieren --> um wwm-config.zip zu entpacken";
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            switch (id)
            {
                case 1:
                    pb_erklarung.Image = WWM.Properties.Resources.inhalt_zip;
                    lb_erlaeuterung.Text = "Ordner 'config' ist für Fragen, Antworten, Lösungen und 50:50 Antworten\n" +
                        "Ordner 'musik' ist für die Musik die wärend des Spiels an verschiedenen stellen abgespsielt wird.";
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }

        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            switch (id)
            {
                case 1:
                    pb_erklarung.Image = WWM.Properties.Resources.config_ordner_inhalte;
                    lb_erlaeuterung.Text = "1 - config Ordner\n2 - Bsp. Antwort A Datei\n3 - Bsp. Fragendatei\n4 - Bsp. Lösungsdatei";
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }

        }
    }
}
