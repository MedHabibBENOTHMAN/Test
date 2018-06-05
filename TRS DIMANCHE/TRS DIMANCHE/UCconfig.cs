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
    public partial class UCconfig : MetroFramework.Controls.MetroUserControl
    {
        public static string user;

        public UCconfig()
        {
            InitializeComponent();
        }

        private void UCconfig_Load(object sender, EventArgs e)
        {

        }
        // démarrrer un travail - déclencher "compteur fonctionnement"
        private void metroTiledemarrer_Click(object sender, EventArgs e) 
        {
            Calcul_TRS.date_debut = DateTime.Now;

            if (Calcul_TRS.produit_1=="")
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez saisir l'ordre de fabrication à traiter ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!Formmain.Instance.MetroContainer.Controls.ContainsKey("UCdashboard"))
                {
                    UCdashboard uc = new UCdashboard();
                    uc.Dock = DockStyle.Fill;
                    Formmain.Instance.MetroContainer.Controls.Add(uc);
                    this.Dispose();
                }
                Formmain.Instance.MetroContainer.Controls["UCdashboard"].BringToFront();

                Formmain.Instance.MetroBack.Visible = false;
                Formmain.DASHBOARD = 1;
                Formmain.CONFIG = 0;
            }
            Calcul_TRS.verif_equipe();// get equipe
            Calcul_TRS.insert_db_TRS();
            Calcul_TRS.insert_db_production();
        }

        // select machine from 'db: parametre table: liste_machine'
        private void metroTilemachine_Click_1(object sender, EventArgs e)
        {
            if (!Formmain.Instance.MetroContainer.Controls.ContainsKey("UCmachine"))
            {
                UCmachine uc = new UCmachine();
                uc.Dock = DockStyle.Fill;
                Formmain.Instance.MetroContainer.Controls.Add(uc);
            }
            Formmain.Instance.MetroContainer.Controls["UCmachine"].BringToFront();
            Formmain.Instance.MetroBack.Visible = true;
        }

        // Login from 'db: parametre table: liste_user'
        private void metroTileusername_Click_1(object sender, EventArgs e)
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

        // select product from  'db: parametre table: liste_produit'
        // or scan OF & generate product_paraemtre
        private void metroTileproduit_Click(object sender, EventArgs e)
        {
         
            if (!Formmain.Instance.MetroContainer.Controls.ContainsKey("UCproduit"))
            {
                UCproduit uc = new UCproduit();
                uc.Dock = DockStyle.Fill;
                Formmain.Instance.MetroContainer.Controls.Add(uc);
            }
            Formmain.Instance.MetroContainer.Controls["UCproduit"].BringToFront();
            Formmain.Instance.MetroBack.Visible = true;
        }
        
        //public static void verif_time()
        //{
        //    string connecting_time = DateTime.Now.ToShortTimeString(); // get time
        //    string[] values = connecting_time.Split(':'); //get hour
        //    int hours = int.Parse(values[0]);            // classer les valeus dans un tableau 'values'

        //    int connecting_time_hour = Convert.ToInt16(hours);
        //    if (connecting_time_hour > 6 && connecting_time_hour <= 14)
        //        Calcul_TRS.equipe = "MATIN";
        //    else if (connecting_time_hour > 14 && connecting_time_hour <= 22)
        //        Calcul_TRS.equipe = "A-M";
        //    else if (connecting_time_hour > 22 && connecting_time_hour <= 6)
        //        Calcul_TRS.equipe = "NUIT";
        //}
    }

    }

