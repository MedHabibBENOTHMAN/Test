// identifier arret from ************* et le déclarer dans db machine_1_arret 
// label_nature_arret && label_value
// 2 boutton : arret ou pause 
// si boutton_arret pressed : public static int arret= count_arret > charger db parametre - liste_arrets > chosir ou add new > charger ligne dans db machine_1_arret
// si boutton_pause pressed : public static int pause= count_arret > charger db parametre - liste_pauses > chosir ou add new > charger ligne dans db machine_1_arret
// sinon  si nvo_arret >  
//      charger ligne dans db machine_1_arret avec : "arret non identifié" 
//      generer boutton_arret_non _dintifié et si boutton_arret_non _dintifié pressed > generer data grid view  with only arrets_non_identifiés && edit ligne 

/*
 * si il ya un arret:
 datagridview (select * from machine1_arret where "arret==arret non identifé"): couleur ligne (verte si en cours sinon defaut) tab.1: date-time / tab.2:durée(ou count arret sin en cours)
 double click on datagridview doubliclick envent charger datagridview_liste des arrets 
    double click on datagridview_liste des arrets >>>>>>>>>> edit liste  
 * sinon : affiche message ("il n'y a pas d'arret")

 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace TRS_DIMANCHE
{
    public partial class UCidentifieerarret : MetroFramework.Controls.MetroUserControl
    {
        string nature_arret;

        public string selected_arret_type;
        public string selected_arret;
        public int selected_arret_duree;
        public static int duree_pause=0;

        arretimprevu model = new arretimprevu();
        arretprevu model2 = new arretprevu();

        machine_1_arrets model_non_identifie = new machine_1_arrets();


        public UCidentifieerarret()
        {
            InitializeComponent();
            timer1_refresh.Start();
            PopulateDataGridView_arret_non_identifie();
            metroPanelarret.Visible = false;
            metroTilepause.Visible = false;
            metroTilearret.Visible = false;

            nature_arret = "";
        }

        private void UCidentifieerarret_Load(object sender, EventArgs e)
        {
            PopulateDataGridView_arret_non_identifie();
            //PopulateDataGridViewliste_arret();

        }

        public void label()
        {
            metroLabelduree.Text = Calcul_TRS.arrets.ToString();
        }

        private void metroTilepause_Click(object sender, EventArgs e) 
        {
            supprimer_arret(); // calcul
            PopulateDataGridView_arret_plannifie();

            metroPanelarret.Visible = true;
            dataGridViewlistearret.Visible = false;
            dataGridViewlistearret_prevu.Visible = true;
        }

        private void metroTilearret_Click(object sender, EventArgs e)//apparaitre datagridview (liste des arrets) & choisir la nature de l'arret selectionné
        {
            PopulateDataGridViewliste_arret();

            metroPanelarret.Visible=true;
            dataGridViewlistearret.Visible = true;
            dataGridViewlistearret_prevu.Visible = false;
        }

        void Clear()
        {
            nature_arret = "";
            model.id = 0;
            model2.id = 0;
        }

        void PopulateDataGridView_arret_non_identifie() // charger les arrets non identifiés
        {
            dataGridViewnonidentifie.AutoGenerateColumns = false;
            using (arrets_non_identifiés db = new arrets_non_identifiés())
            {
 
                string today= DateTime.Today.ToShortDateString();
                dataGridViewnonidentifie.DataSource = db.machine_1_arrets.
                    Where( x => x.date == today && x.of_1 == Calcul_TRS.OF_1 && x.of_2 == Calcul_TRS.OF_2 && x.arret == "arret non identifié" && DateTime.Compare((DateTime)x.debut, Calcul_TRS.date_debut) >0).//meme date meme OF 
                    ToList<machine_1_arrets>();
                // pas de fin travail si dgv n'est pas vide !!
            }
        }

        void PopulateDataGridViewliste_arret()// charger la liste des arrets imprévus
        {
            dataGridViewlistearret.AutoGenerateColumns = false;
            using (parametreEntities6 db = new parametreEntities6())
            {
                dataGridViewlistearret.DataSource = db.arretimprevu.ToList<arretimprevu>();
            }
        }


        void PopulateDataGridView_arret_plannifie() // charger les arrets non identifiés
        {
            dataGridViewlistearret_prevu.AutoGenerateColumns = false;
            using (arrets_prevus_Entities db = new arrets_prevus_Entities())
            {
                dataGridViewlistearret_prevu.DataSource = db.arretprevu.ToList<arretprevu>();
            }
        }

        public void selection_arret()
        {
            if (dataGridViewnonidentifie.CurrentRow.Index != -1)
            {
                model_non_identifie.id = Convert.ToInt32(dataGridViewnonidentifie.CurrentRow.Cells["id_non_identifié"].Value);
                using (arrets_non_identifiés db = new arrets_non_identifiés())
                {
                    model_non_identifie = db.machine_1_arrets.Where(x => x.id == model_non_identifie.id).FirstOrDefault();
                    selected_arret=model_non_identifie.arret;
                    selected_arret_duree= (int)model_non_identifie.duree;
                }
                metroTilepause.Visible = true;
                metroTilearret.Visible = true;
            }
        }

        public void selection_type_arret ()
        {
            if (dataGridViewlistearret.CurrentRow.Index != -1)
            {
                model.id = Convert.ToInt32(dataGridViewlistearret.CurrentRow.Cells["id"].Value);
                using (parametreEntities6 db = new parametreEntities6())
                {
                    model = db.arretimprevu.Where(x => x.id == model.id).FirstOrDefault();
                    selected_arret_type = model.arret;
                }
            }
        }

        public void selection_type_arret_prevu()
        {
            if (dataGridViewlistearret_prevu.CurrentRow.Index != -1)
            {
                model2.id = Convert.ToInt32(dataGridViewlistearret_prevu.CurrentRow.Cells["id_arret_prevu"].Value);
                using (arrets_prevus_Entities db = new arrets_prevus_Entities())
                {
                    model2 = db.arretprevu.Where(x => x.id == model2.id).FirstOrDefault();
                    selected_arret_type = model2.arret;
                }
            }
        }

        private void supprimer_arret() // utilisé lors des pauses seulement!!!!!!!!!!!!!!!!!
        {
            if (Calcul_TRS.etat_arret == 1) // pause en cours : la machine est en arret mais on va preciser qu'elle est en pause
            {
                Calcul_TRS.etat_pause = 1;
                Calcul_TRS.arrets -= Calcul_TRS.tempsdetection;
                Calcul_TRS.pauses += Calcul_TRS.tempsdetection;
                Calcul_TRS.count_pause += Calcul_TRS.tempsdetection;
                Calcul_TRS.count_arret = 0;
            }
            else // pause déja dans db
            {
                Calcul_TRS.arrets -= selected_arret_duree;
                Calcul_TRS.pauses += selected_arret_duree;
            }
        }

        private void metroTile_refresh_Click(object sender, EventArgs e)
        {
            PopulateDataGridView_arret_non_identifie();
        }

        private void metroTile_SELECT_Click(object sender, EventArgs e)//-------------------------------------------------------------------------------------------------------------
        {
            if (MetroFramework.MetroMessageBox.Show(this, " Vous valider ? ", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dataGridViewlistearret.Visible == true && dataGridViewlistearret_prevu.Visible == false) // arret non plannifié
                {
                    model_non_identifie.arret = model.arret;
                    model_non_identifie.type_arret = "arret non plannifie";
                }

                else if (dataGridViewlistearret_prevu.Visible==true && dataGridViewlistearret.Visible == false) // arret planniifié
                {
                    model_non_identifie.arret = model2.arret;
                    model_non_identifie.type_arret= "arret plannifie";
                }

                using (arrets_non_identifiés db = new arrets_non_identifiés())
                {
                    db.Entry(model_non_identifie).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            Clear();
            PopulateDataGridView_arret_non_identifie();
            metroPanelarret.Visible = false;
            metroTilearret.Visible = false;
            metroTilepause.Visible = false;
            metroTile_SELECT.Visible = false;

            dataGridViewlistearret.Visible = false;
            dataGridViewlistearret_prevu.Visible = false;
            Calcul_TRS.verif_arret--;

            if (model2.arret == "changement _equipe") // calculer les 2 SMED
            {
                Calcul_TRS.changement_equipe = 1;
            }


            if (model2.arret == "changement serie") // calculer les 2 SMED
            {
                Calcul_TRS.SMED();
            }


            if (Calcul_TRS.verif_arret==0)
            {
                // retrun to dashboard
                if (!Formmain.Instance.MetroContainer.Controls.ContainsKey("UCdashboard")) // // return to dashboard if there is any other breakdown
                {
                    UCdashboard uc = new UCdashboard();
                    uc.Dock = DockStyle.Fill;
                    Formmain.Instance.MetroContainer.Controls.Add(uc);
                }
                Formmain.Instance.MetroContainer.Controls["UCdashboard"].BringToFront();
                Formmain.Instance.MetroBack.Visible = true;
            }
        }

        private void timer1_refresh_Tick(object sender, EventArgs e)
        {
            //Calcul_TRS.verif_arret = dataGridViewnonidentifie.Rows.Count;

            if (Calcul_TRS.etat_arret==1)
            {
                PopulateDataGridView_arret_non_identifie(); //rafraichir liste des arrets non identifiés
                
                metroTile_arret.Visible = true;
                metroLabelarret.Visible = true;
                metroLabelduree.Visible = true;

                if (Calcul_TRS.type_arret == "")
                    metroLabelarret.Text = "arret non identifie";
                else
                    metroLabelarret.Text = Calcul_TRS.type_arret;
                metroLabelduree.Text = Calcul_TRS.count_arret.ToString() ;
            }
            else
            {
                metroTile_arret.Visible = false;
                metroLabelarret.Visible = false;
                metroLabelduree.Visible = false;
            }
        }

        private void dataGridViewnonidentifie_CellContentClick_1(object sender, DataGridViewCellEventArgs e) // select arret
        {
            selection_arret();
        }

        private void dataGridViewlistearret_CellClick(object sender, DataGridViewCellEventArgs e)// select from arrets non plannifés
        {
            metroTile_SELECT.Visible = true;
            selection_type_arret();
        }

        private void dataGridViewlistearret_prevu_CellClick(object sender, DataGridViewCellEventArgs e)// select from arrets plannifés
        {
            metroTile_SELECT.Visible = true;
            selection_type_arret_prevu();
        }

        public static void arret_non_identifie()
        {
            //Calcul_TRS.verif_arret = dataGridViewnonidentifie.Rows.Count;

        }

    }
}
