// TRS chart affiche()
// pie chart arrerts affiche()
// boutton : identifier arret - revision historique des arrets - déclarer rebus 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRS_DIMANCHE
{
    // dashboard principal: 
    // - dessiner les gauges pour le TRS - graphes - progress bar pour la productivité - pie chart pour les arrets du travail en cours
    // - déclarer rebus ou arret 
    // - mettre fin au travail en cours > extract & show stats
    public partial class UCdashboard : UserControl

    //public partial class UCdashboard : MetroFramework.Controls.MetroUserControl 
    {
        Color color_default = System.Drawing.Color.CadetBlue;
        Color color_alerte = System.Drawing.Color.IndianRed;

        public UCdashboard()
        {
            InitializeComponent();
            timerfonctionnement.Start();
            panelTRS.BackColor = panel_SMED.BackColor= panel_palette.BackColor=panel_moule.BackColor=panelproduit.BackColor = panelmachine.BackColor = paneluser.BackColor = panel1 .BackColor= paneltemps .BackColor= panelproduction.BackColor = panelmachine.BackColor = panelproduction.BackColor = Color.FromArgb(25, 248, 248, 255);
           
            //serialPortDAQ.Open();
        }
        private void labels ()
        {
            SMED_0.Text = Calcul_TRS.SMED_0.ToString();
            SMED_1.Text = Calcul_TRS.SMED_1.ToString();
            SMED_2.Text = Calcul_TRS.SMED_2.ToString();

            label_qualité1.Text = Calcul_TRS.produit_1_qualite.ToString();
            label_qualité2.Text = Calcul_TRS.produit_2_qualite.ToString();
            label_produit_1.Text = Calcul_TRS.produit_1+"_Qualité";
            label_produit_2.Text = Calcul_TRS.produit_2+ "_Qualité";

            metroLabel_moule.Text= Calcul_TRS.moule;
            metroLabel_empreinte.Text = Calcul_TRS.moule_empreinte.ToString();
            metroLabel_description.Text = Calcul_TRS.description;

            metroLabel_machine.Text = Calcul_TRS.machine;
            metroLabel_utilisateur.Text = Calcul_TRS.utilisateur;
            if (Calcul_TRS.produit_2!="")// affichage reference produit
                metroLabel_produit.Text = Calcul_TRS.produit_1 + " - " + Calcul_TRS.produit_2;
            else
                metroLabel_produit.Text = Calcul_TRS.produit_1;

            if(Calcul_TRS.OF_2!="")
                metroLabel_OF.Text = Calcul_TRS.OF_1 + " - " + Calcul_TRS.OF_2;
            else
                metroLabel_OF.Text = Calcul_TRS.OF_1;

            label_nonconforme.Text = Calcul_TRS.rebut.ToString();
            label11.Text = Calcul_TRS.nbre_produit.ToString();
            labeltpdecycle.Text=(Calcul_TRS.temps_de_cycle/60).ToString()+"   minutes";
            labeltpfonctionnement.Text = Calcul_TRS.temps_fonctionnement.ToString();//.ToString("HH:mm:ss.ffffff");
            labeltpbrut.Text= Calcul_TRS.temps_brut.ToString();
            labeltprequis.Text = Calcul_TRS.temps_requis.ToString();

            //UCidentifieerarret.label();
            metroLabeldetection.Text= (Calcul_TRS.tempsdetection).ToString();
            metroLabelpauses.Text= (Calcul_TRS.pauses).ToString();
            metroLabelarrets.Text= (Calcul_TRS.arrets).ToString();
            //metroLabeldisponibilite.Text= (Calcul_TRS.disponibilité).ToString() + "  %";
            if (Calcul_TRS.etat_arret==1) // alerte boutton arret en cours
            {
                if (Alerte_arret.BackColor == color_default)
                    Alerte_arret.BackColor = color_alerte;
                else Alerte_arret.BackColor = color_default;
            }
            else Alerte_arret.BackColor = color_default;

            if(checkBox_matin.Checked)
            {
                checkBox_am.Checked = false;
                checkBox_soir.Checked = false;
                Calcul_TRS.get_matin = 1;
                Calcul_TRS.get_am = 0;
                Calcul_TRS.get_soir = 0;

            }
            if (checkBox_am.Checked)
            {
                checkBox_matin.Checked = false;
                checkBox_soir.Checked = false;
                Calcul_TRS.get_matin = 0;
                Calcul_TRS.get_am = 1;
                Calcul_TRS.get_soir = 0;
            }
            if (checkBox_soir.Checked)
            {
                checkBox_am.Checked = false;
                checkBox_matin.Checked = false;
                Calcul_TRS.get_matin = 0;
                Calcul_TRS.get_am = 0;
                Calcul_TRS.get_soir = 1;
            }

            //chart_SMED
            //this.chart_SMED.Series["SMED"].Points.AddXY(Calcul_TRS.SMED_0);
            //this.chart_SMED.Series["SMED"].Points.AddXY(Calcul_TRS.SMED_1);
            //this.chart_SMED.Series["SMED"].Points.AddXY(Calcul_TRS.SMED_2);

        }

        private void UCdashboard_Load(object sender, EventArgs e)
        {
        } 

        private void timerfonctionnement_Tick_1(object sender, EventArgs e)
        {
            Calcul_TRS.calcul();
            labels();
            //progressbar_seuil_color(circularProgressBarqualite, Calcul_TRS.qualité);
            qualite();
            //progressbar____color(circularProgressBarqualite, Calcul_TRS.qualité);
            progressbar____color(circularProgressBardisponibilite,Calcul_TRS.disponibilité);
            progressbar____color(circularProgressBarperformance,Calcul_TRS.performance);
            progressbar____color(circularProgressBarTRS,Calcul_TRS.TRS);
        }

        public static void progressbar____color(CircularProgressBar.CircularProgressBar e, double v)

        {
            //value MIN-MAX
            e.Text = string.Format("{0:0.00}%", v).ToString();
            if (v < 100)
                e.Value = (int)v;
            else
                e.Value = 99;
            //color
            if (e.Value < 50)
                e.ProgressColor = System.Drawing.Color.IndianRed;
            else if (e.Value > 50 && e.Value < 70)
                e.ProgressColor = System.Drawing.Color.Orange;
            else if (e.Value > 70)
                e.ProgressColor = System.Drawing.Color.DarkSeaGreen;
        }


        public void qualite()
        {
            //value MIN-MAX
            circularProgressBarqualite.Text = string.Format("{0:0.00}%", Calcul_TRS.qualité).ToString();
            if (Calcul_TRS.qualité < 100)
                circularProgressBarqualite.Value = (int)Calcul_TRS.qualité;
            else
                circularProgressBarqualite.Value = 99;
            //
            if (Calcul_TRS.produit_2!="")
            {
                if (Calcul_TRS.rebut >= Math.Min(Calcul_TRS.produit_1_qualite_seuil_3, Calcul_TRS.produit_2_qualite_seuil_3))
                {
                    circularProgressBarqualite.ProgressColor = System.Drawing.Color.IndianRed;
                    //Calcul_TRS.mail_to(class_3);
                }
                else if (Calcul_TRS.rebut >= Math.Min(Calcul_TRS.produit_1_qualite_seuil_2, Calcul_TRS.produit_2_qualite_seuil_2))
                {
                    circularProgressBarqualite.ProgressColor = System.Drawing.Color.Orange;
                    //Calcul_TRS.mail_to(class_2);
                }
                else if (Calcul_TRS.rebut >= Math.Min(Calcul_TRS.produit_1_qualite_seuil_1, Calcul_TRS.produit_2_qualite_seuil_1))
                {
                    circularProgressBarqualite.ProgressColor = System.Drawing.Color.DodgerBlue; 
                    //Calcul_TRS.mail_to(class_1);
                }
            }
            else
            {
                if (Calcul_TRS.rebut >= Calcul_TRS.produit_1_qualite_seuil_3)
                {
                    circularProgressBarqualite.ProgressColor = System.Drawing.Color.IndianRed;
                    //Calcul_TRS.mail_to(class_3);
                }
                else if (Calcul_TRS.rebut >= Calcul_TRS.produit_1_qualite_seuil_2)
                {
                    circularProgressBarqualite.ProgressColor = System.Drawing.Color.Orange;
                    //Calcul_TRS.mail_to(class_2);
                }
                else if (Calcul_TRS.rebut >= Calcul_TRS.produit_1_qualite_seuil_1)
                {
                    circularProgressBarqualite.ProgressColor = System.Drawing.Color.DodgerBlue;
                    //Calcul_TRS.mail_to(class_1);
                }
            }

        }

        public static void progressbar_seuil_color(CircularProgressBar.CircularProgressBar e, double v)
        {
            //value MIN-MAX
            e.Text = string.Format("{0:0.00}%", v).ToString();
            if (v < 100)
                e.Value = (int)v;
            else
                e.Value = 99;
            //color
            if (((int)Calcul_TRS.produit_1_qualite_seuil_1<Calcul_TRS.rebut)&&(Calcul_TRS.rebut < (int)Calcul_TRS.produit_1_qualite_seuil_2))
                e.ProgressColor = System.Drawing.Color.DarkSeaGreen;
            else if (((int)Calcul_TRS.produit_1_qualite_seuil_2 < Calcul_TRS.rebut) && (Calcul_TRS.rebut < (int)Calcul_TRS.produit_1_qualite_seuil_3))
                e.ProgressColor = System.Drawing.Color.Orange;
            else if ((int)Calcul_TRS.produit_1_qualite_seuil_3 < Calcul_TRS.rebut) // alerte
                e.ProgressColor = System.Drawing.Color.IndianRed;
        }

        private void Fin_Travail_Click(object sender, EventArgs e)
        {
            if(Calcul_TRS.verif_arret !=0)
                MetroFramework.MetroMessageBox.Show(this, "veuillez identifier les arrets non identifiés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Voulez vous terminer ce travail ? ", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    timerfonctionnement.Stop();
                    Fin_Travail.Enabled = false;
                    //retour à uc config
                    Application.Restart();
                }
            }
        }

        // - déclarer produit non conforme
        // - - réviser le calacul_TRS : Qualité
        private void Rebut_Click(object sender, EventArgs e)
        {
            if (!Formmain.Instance.MetroContainer.Controls.ContainsKey("UCrebus"))
            {
                UCrebus uc = new UCrebus();
                uc.Dock = DockStyle.Fill;
                Formmain.Instance.MetroContainer.Controls.Add(uc);
            }
            Formmain.Instance.MetroContainer.Controls["UCrebus"].BringToFront();
            Formmain.Instance.MetroBack.Visible = true;
            Formmain.DASHBOARD_state = 0;
        }

        public static void nvo_rebut() // open UCrebut
        {
            if (!Formmain.Instance.MetroContainer.Controls.ContainsKey("UCrebus"))
            {
                UCrebus uc = new UCrebus();
                uc.Dock = DockStyle.Fill;
                Formmain.Instance.MetroContainer.Controls.Add(uc);
            }
            Formmain.Instance.MetroContainer.Controls["UCrebus"].BringToFront();
            Formmain.Instance.MetroBack.Visible = true;
        }

        // - déclarer un arret , sa nature ... > 
        // - l'inserer dans 'db: machine_TRS table: machine1_arret'
        // - réviser le calacul_TRS : Dsiponibilité
        private void Alerte_arret_Click(object sender, EventArgs e)
        {
            if (!Formmain.Instance.MetroContainer.Controls.ContainsKey("UCidentifieerarret"))
            {
                UCidentifieerarret uc = new UCidentifieerarret();
                uc.Dock = DockStyle.Fill;
                Formmain.Instance.MetroContainer.Controls.Add(uc);
            }
            Formmain.Instance.MetroContainer.Controls["UCidentifieerarret"].BringToFront();
            Formmain.Instance.MetroBack.Visible = true;
            Formmain.DASHBOARD_state = 0;
            //UCidentifieerarret.timer1_refresh.Start();
        }

        // historique des arrets , 'db: machine_TRS table : machine1_arret' qui génère le pie_chart des arrets
        private void Details_Click(object sender, EventArgs e)
        {
            if (!Formmain.Instance.MetroContainer.Controls.ContainsKey("UCarretloop"))
            {
                UCarretloop uc = new UCarretloop();
                uc.Dock = DockStyle.Fill;
                Formmain.Instance.MetroContainer.Controls.Add(uc);
            }
            Formmain.Instance.MetroContainer.Controls["UCarretloop"].BringToFront();
            Formmain.Instance.MetroBack.Visible = true;
            Formmain.DASHBOARD_state = 0;
        }

        private void New_Product_Click(object sender, EventArgs e)
        {
            Calcul_TRS.nvo_produit();
        }

        private void paneluser_Click(object sender, EventArgs e)
        {
            if (Calcul_TRS.utilisateur!="")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Voulez vous se deconnecter ? ", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Calcul_TRS.utilisateur = "";

                    if (!Formmain.Instance.MetroContainer.Controls.ContainsKey("UCusername"))
                    {
                        UCusername uc = new UCusername();
                        uc.Dock = DockStyle.Fill;
                        Formmain.Instance.MetroContainer.Controls.Add(uc);
                    }
                    Formmain.Instance.MetroContainer.Controls["UCusername"].BringToFront();
                    Formmain.Instance.MetroBack.Visible = true;
                }
                //Calcul_TRS.insert_db_TRS();
                Formmain.DASHBOARD_state = 0;
            }
            else
            {
                if (!Formmain.Instance.MetroContainer.Controls.ContainsKey("UCusername"))
                {
                    UCusername uc = new UCusername();
                    uc.Dock = DockStyle.Fill;
                    Formmain.Instance.MetroContainer.Controls.Add(uc);
                }
                Formmain.Instance.MetroContainer.Controls["UCusername"].BringToFront();
                Formmain.Instance.MetroBack.Visible = true;
            }
        }

        private void panelproduit_Click(object sender, EventArgs e) // changement de serie
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez vous modifier des paramètres ? ", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                reset_parametres_produit();
                if (!Formmain.Instance.MetroContainer.Controls.ContainsKey("UCproduit"))
                {
                    UCproduit uc = new UCproduit();
                    uc.Dock = DockStyle.Fill;
                    Formmain.Instance.MetroContainer.Controls.Add(uc);
                }
                Formmain.Instance.MetroContainer.Controls["UCproduit"].BringToFront();
                Formmain.Instance.MetroBack.Visible = true;
                Formmain.DASHBOARD_state = 0;
            }

            //sUCproduit.revision_calcul();

            /*Calcul_TRS.insert_db_TRS();
            //get last arret : changement de serie
            Calcul_TRS.changement_de_serie = 1;
            //update_arret where type nature 
            Calcul_TRS.update_db_arret();
            Calcul_TRS.changement_de_serie = 0;
            Formmain.DASHBOARD_state = 0;
            //calcul pause
            Calcul_TRS.count_pause += Calcul_TRS.tempsdetection;
            Calcul_TRS.pauses += Calcul_TRS.tempsdetection;
            Calcul_TRS.arrets -= Calcul_TRS.tempsdetection;
            Calcul_TRS.count_arret -= 0;
            Calcul_TRS.etat_pause = 1;*/
        }

        private void panelproduit_Paint(object sender, PaintEventArgs e)
        {

        }

        public static void reset_parametres_produit()
        {
            Calcul_TRS.produit_1 = "";
            Calcul_TRS.OF_1 = "";
            Calcul_TRS.produit_2 = "";
            Calcul_TRS.OF_2 = "";
            Calcul_TRS.matiere = "";
            //Calcul_TRS.lot = "";
            Calcul_TRS.palette = "";
            Calcul_TRS.moule = "";
        }

        private void paneluser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
