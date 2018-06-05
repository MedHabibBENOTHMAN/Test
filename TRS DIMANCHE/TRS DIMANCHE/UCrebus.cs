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
    public partial class UCrebus : MetroFramework.Controls.MetroUserControl
    {
        liste_rebut model_rebut = new liste_rebut();


        double rebus_text =0;

        public UCrebus()
        {
            InitializeComponent();
            PopulatedataGridView_liste_anomalie();
            panel_selection_anomalie.Visible = false;
            checkBox_produit_1.Text = Calcul_TRS.produit_1;

            if (Calcul_TRS.produit_2 == "")
                checkBox_produit_2.Visible = false;
            else
                checkBox_produit_2.Text = Calcul_TRS.produit_2;
        }

        private void UCrebus_Load(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(Calcul_TRS.accepte>rebus_text)
                rebus_text++;
            metroLabelqte.Text = rebus_text.ToString();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if(rebus_text>0)
                rebus_text--;
            metroLabelqte.Text = rebus_text.ToString();
        }

        void PopulatedataGridView_liste_anomalie()// charger la liste des anomalies
        {
            dataGridView_liste_rebut.AutoGenerateColumns = false;
            using (parametreEntities_liste_anomalie db = new parametreEntities_liste_anomalie())
            {
                dataGridView_liste_rebut.DataSource = db.liste_rebut.ToList<liste_rebut>();
            }
        }

        private void selection_anomalie()
        {
            if (dataGridView_liste_rebut.CurrentRow.Index != -1)
            {
                model_rebut.idrebut = Convert.ToInt32(dataGridView_liste_rebut.CurrentRow.Cells["idrebut"].Value);
                using (parametreEntities_liste_anomalie db = new parametreEntities_liste_anomalie())
                {
                    model_rebut = db.liste_rebut.Where(x => x.idrebut == model_rebut.idrebut).FirstOrDefault();
                }
            }
        }

        private void dataGridView_liste_rebut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selection_anomalie();
        }


        private void checkBox_produit_1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_produit_2.Enabled == false)
                checkBox_produit_2.Enabled = true;

            if (checkBox_produit_1.Checked) //matiere 1 déja choisie
            {
                PopulatedataGridView_liste_anomalie();
                panel_selection_anomalie.Visible = true;
                checkBox_produit_2.Enabled = false;
                Calcul_TRS.produit_rebuté = Calcul_TRS.produit_1;
            }
        }

        private void checkBox_produit_2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_produit_1.Enabled == false)
                checkBox_produit_1.Enabled = true;

            if (checkBox_produit_2.Checked) //matiere 2 déja choisie
            {
                PopulatedataGridView_liste_anomalie();
                panel_selection_anomalie.Visible = true;
                checkBox_produit_1.Enabled = false;
                Calcul_TRS.produit_rebuté = Calcul_TRS.produit_2;
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            machine_1_rebut model_machine_rebut = new machine_1_rebut();
            if (metroLabelqte.Text == "0")
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez saisir la quantité ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                if (MetroFramework.MetroMessageBox.Show(this, "Voulez-vous saisir un rebus de " + metroLabelqte.Text + " articles ? pour " + model_rebut.rebut, "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Calcul_TRS.rebut += Convert.ToInt32(metroLabelqte.Text);
                    metroLabelqte.Text = null;
                rebus_text = 0;
                    Calcul_TRS.current_rebut_quality = model_rebut.rebut;
                    Calcul_TRS.current_rebut_quantity = (int)rebus_text;

                    if(checkBox_produit_1.Enabled)
                        Calcul_TRS.produit_1_rebut = Calcul_TRS.current_rebut_quantity;
                    else if(checkBox_produit_2.Enabled)
                        Calcul_TRS.produit_2_rebut = Calcul_TRS.current_rebut_quantity;

                    Calcul_TRS.insert_db_rebut();// inserer dans db

                    metroLabelqte.Text = null;
                    checkBox_produit_1.Checked = false;
                    checkBox_produit_2.Checked = false;
                    Calcul_TRS.current_rebut_quality = "";//reinitiatiliser
                    Calcul_TRS.current_rebut_quantity = 0;
                    panel_selection_anomalie.Visible = false;

                if (Calcul_TRS.produit_2 == "") // return to dashboard if there is any other product
                {
                    // retrun to dashboard
                    if (!Formmain.Instance.MetroContainer.Controls.ContainsKey("UCdashboard"))
                    {
                        UCdashboard uc = new UCdashboard();
                        uc.Dock = DockStyle.Fill;
                        Formmain.Instance.MetroContainer.Controls.Add(uc);
                    }
                    Formmain.Instance.MetroContainer.Controls["UCdashboard"].BringToFront();
                    Formmain.Instance.MetroBack.Visible = true;
                }
            }
        }
    }
}
