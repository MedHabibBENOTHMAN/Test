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
    public partial class UCproduit : UserControl
    {

        produit model_produit = new produit();
        moule model_moule = new moule();

        public UCproduit()
        {
            InitializeComponent();
            Clear();
            PopulateDataGridView();
            metroTextBox_produit2.Visible = false;
            metroTextBoxOF_2.Visible = false;
            label9.Visible = false;
            label10.Visible = false;

            if (Formmain.DASHBOARD == 1)
            {
                metroTextBoxOF.Text = ""; // clear all
                metroTextBox_produit1.Text = "";
                metroTextBox_produit2.Text = "";
                //metroTextBox_moule.Text = "";
                metroTextBox_palette.Text = "";
                checkBox_matiere_1.Checked = false;
                checkBox_matiere_2.Checked = false;
            }
        }

        void PopulateDataGridView()
        {
            dataGridView_produit.AutoGenerateColumns = false;
            using (Entities_moule db = new Entities_moule())
            {
                dataGridView_produit.DataSource = db.moule.ToList<moule>();
            }
        }

        private void metroButton_cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            metroTextBox_produit.Text = metroTextBox_reference.Text = metroTextBox_tempsdecycle.Text = "" ;
            metroButton_save.Text = "Save";
            metroButton_delete.Enabled = false;
            model_produit.id = 0;
        }

        private void metroButton_save_Click(object sender, EventArgs e)
        {
            model_moule.produit = metroTextBox_produit.Text.Trim();
            model_produit.tempsdecycle = Convert.ToInt32(metroTextBox_tempsdecycle.Text.Trim());
            using (Entities_moule db = new Entities_moule())
            {
                if (model_moule.idmoule == 0)//Insert
                    db.moule.Add(model_moule);
                else //Update
                    db.Entry(model_moule).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");

            panel_addnew.Visible = false;
        }

        private void metroButton_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (Entities_moule db = new Entities_moule())
                {
                    var entry = db.Entry(model_produit);
                    if (entry.State == EntityState.Detached)
                        db.moule.Attach(model_moule);
                    db.moule.Remove(model_moule);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void dataGridView_produit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_produit.CurrentRow.Index != -1)
            {
                model_moule.idmoule = Convert.ToInt32(dataGridView_produit.CurrentRow.Cells["datagrid_id"].Value);
                using (Entities_moule db = new Entities_moule())
                {
                    model_moule = db.moule.Where(x => x.idmoule == model_moule.idmoule).FirstOrDefault();
                    if(metroTextBox_produit2.Enabled==false)
                        metroTextBox_produit1.Text = model_moule.produit;
                    else
                        metroTextBox_produit2.Text = model_moule.produit;
                    metroTextBox_tempsdecycle.Text = model_moule.temps_de_cycle.ToString();
                }
                metroButton_save.Text = "Update";
                metroButton_delete.Enabled = true;
            }
        }

        private void metroButton_ajouter_Click(object sender, EventArgs e)
        {
            panel_addnew.Visible = true;
        }

        private void metroButton_set_Click(object sender, EventArgs e)
        {

            if (MetroFramework.MetroMessageBox.Show(this, "Voulez vous choisir comme produit l'article " + model_produit.produit1 + " ?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Calcul_TRS.OF_1 = metroTextBoxOF.Text; // ordre de fabrication
                Calcul_TRS.OF_2 = metroTextBoxOF_2.Text; // ordre de fabrication

                char[] produit1 = metroTextBox_produit1.Text.ToCharArray();
                for (int i = 3; i <produit1.Length; i++)
                {
                    Calcul_TRS.produit_1 += produit1[i];
                }

                char[] produit2 = metroTextBox_produit2.Text.ToCharArray();
                for (int i = 3; i < produit2.Length; i++)
                {
                    Calcul_TRS.produit_2 += produit2[i];
                }
               
                if (checkBox_matiere_1.Checked) // matiere
                    Calcul_TRS.matiere = "matiere_1";
                else if (checkBox_matiere_2.Checked)
                    Calcul_TRS.matiere = "matiere_2";

                chercher_moule();
                if(Calcul_TRS.produit_2 !="")
                    charger_produit_2();
                
                if (Calcul_TRS.moule != "") //if (metroTextBox_moule.Text !="")
                    this.Dispose();
                else
                    MetroFramework.MetroMessageBox.Show(this, "veuillez verifier les information saisies", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Formmain.DASHBOARD==1) // changement de serie
                Calcul_TRS.insert_db_production();

            if (Calcul_TRS.etat_arret==1) // changement de serie en cours
                revision_calcul();
        }

        void chercher_moule()// en identifiant le moule, on déduit les parametres de travail  // add try catch
        {
            var context = new Entities_moule();
            var query_moule = from m in context.moule
                              where m.produit == metroTextBox_produit1.Text
                              select m;
            if (query_moule.SingleOrDefault() != null)
            {
                var ref_moule = query_moule.FirstOrDefault();
                Calcul_TRS.moule = ref_moule.reference;
                Calcul_TRS.moule_empreinte = (int)ref_moule.empreinte;
                Calcul_TRS.description = ref_moule.description;
                Calcul_TRS.temps_de_cycle = (double)ref_moule.temps_de_cycle* Calcul_TRS.moule_empreinte * 60;// moule/secondes
                Calcul_TRS.cadence_theorique = 1/((double)ref_moule.temps_de_cycle*60);
                Calcul_TRS.produit_1_qualite_seuil_1 = (int)ref_moule.qualite_seuil_1;
                Calcul_TRS.produit_1_qualite_seuil_2 = (int)ref_moule.qualite_seuil_2;
                Calcul_TRS.produit_1_qualite_seuil_3 = (int)ref_moule.qualite_seuil_3;
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Produit inexistant !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void charger_produit_2()// en identifiant le moule, on déduit les parametres de travail  // add try catch
        {
            var context = new Entities_moule();
            var query_moule = from m in context.moule
                              where m.produit == metroTextBox_produit2.Text
                              select m;
            if (query_moule.SingleOrDefault() != null)
            {
                var ref_moule = query_moule.FirstOrDefault();

                Calcul_TRS.produit_2_qualite_seuil_1 = (int)ref_moule.qualite_seuil_1;
                Calcul_TRS.produit_2_qualite_seuil_2 = (int)ref_moule.qualite_seuil_2;
                Calcul_TRS.produit_2_qualite_seuil_3 = (int)ref_moule.qualite_seuil_3;
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Produit 2 inexistant !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void clear_all()
        {

        }

        private void checkBox_matiere_1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_matiere_2.Enabled == false)
                checkBox_matiere_2.Enabled = true; 

            if (checkBox_matiere_1.Checked) //matiere 1 déja choisie
                checkBox_matiere_2.Enabled = false;
        }

        private void checkBox_matiere_2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_matiere_1.Enabled == false)
                checkBox_matiere_1.Enabled = true;

            if (checkBox_matiere_2.Checked) //matiere 2 déja choisie
                checkBox_matiere_1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel_produit.Visible == true)
            {
                panel_produit.Visible = false;
                panel_addnew.Visible = false;
            }
            else
                panel_produit.Visible = true;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label9.Visible = true;
                metroTextBoxOF_2.Visible = true;
                label10.Visible = true;
                metroTextBox_produit2.Visible = true;
                metroTextBox_produit2.Enabled = true;
                metroTextBoxOF_2.Enabled = true;

                metroTextBoxOF_2.Text = "";
                metroTextBox_produit2.Text = "";
            }
            else
            {
                label9.Visible = false;
                metroTextBoxOF_2.Visible = false;
                label10.Visible = false;
                metroTextBox_produit2.Visible = false;
                metroTextBox_produit2.Enabled = false;
                metroTextBoxOF_2.Enabled = false;
            }
        }
        public static void revision_calcul()// if (arret==1)
        {
            //Calcul_TRS.insert_db_TRS();
            //get last arret : changement de serie
            Calcul_TRS.changement_de_serie = 1;
            //update_arret where type nature 
            Calcul_TRS.update_db_arret();
            //Calcul_TRS.SMED();
            Calcul_TRS.changement_de_serie = 0;
            Formmain.DASHBOARD_state = 0;
            //calcul pause
            Calcul_TRS.count_pause += Calcul_TRS.tempsdetection;
            Calcul_TRS.pauses += Calcul_TRS.tempsdetection;
            Calcul_TRS.arrets -= Calcul_TRS.tempsdetection;
            Calcul_TRS.count_arret -= 0;
            Calcul_TRS.etat_pause = 1;
        }
    }
}
