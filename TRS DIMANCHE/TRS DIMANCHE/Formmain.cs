using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;



namespace TRS_DIMANCHE
{
    public partial class Formmain : Form // Main
    //public partial class Formmain : MetroFramework.Forms.MetroForm // Main 
    {

        public static int last_non_conforme;
        public static int last_new_product;
        public static int CONFIG ; //boutton démarrer un travail (condition to switch from CONFIG_menu to DASHBOARD_menu) 
        public static int DASHBOARD;
        public static int DASHBOARD_state;

        static Formmain _instance;
             
        public static Formmain Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new Formmain();
                return _instance;
            }
        }

        public MetroFramework.Controls.MetroPanel MetroContainer // metropanel1 contient tout les menus (UCconfig,UCdashboard....)
        {
            get { return metroPanel1; }
            set { metroPanel1= value; }
        }

        public MetroFramework.Controls.MetroLink MetroBack // boutton return
        {
            get { return bouttonback; }
            set { bouttonback = value; }
        }

        public  Formmain ()
        {
            InitializeComponent();
            timertime.Start(); // to get current Time
            CONFIG = 1;
            DASHBOARD = 0;
            DASHBOARD_state = 0;

            //serialPortDAQ.Open();
            //timer1.Start();
        }

        private void Formmain_Load(object sender, EventArgs e) 
        {
            //bouttonback.Visible = false;
            _instance = this;
            UCconfig uc = new UCconfig();
            uc.Dock = DockStyle.Fill;
            metroPanel1.Controls.Add(uc);
        }

        private void bouttonback_Click(object sender, EventArgs e) // boutton return
        {
            //si on se trouve das le menu config (CONFIG==1) > boutton return nous retourne le menu config > plus besoin de config > on écrase son menu
            //si on est das le menu dashboard (DASHBOARD==1) > boutton return nous retourne le menu dashboard
            bouttonback.Visible = false;
        if  (CONFIG == 1)
                metroPanel1.Controls["UCconfig"].BringToFront();
        else if (DASHBOARD == 1)
            {
                metroPanel1.Controls["UCdashboard"].BringToFront();
                Formmain.DASHBOARD_state = 1;
                //UCidentifieerarret.timer1_refresh.Start();
            }
        }

        public void timer1_Tick(object sender, EventArgs e) // Get current time
        {
            labeldatetime.Text = DateTime.Now.ToString();
            color();
        }

        void color()
        {
            if (DASHBOARD == 1 && Calcul_TRS.etat_arret == 0 && Calcul_TRS.etat_marche == 0) //demarrage
            {
                labelstate.Text = "En marche";
                this.BackColor = System.Drawing.Color.LightSeaGreen;
                label_X.ForeColor= System.Drawing.Color.Black;
                label_.ForeColor = System.Drawing.Color.Black;
            }

            else if (Calcul_TRS.etat_arret == 1 && Calcul_TRS.etat_marche == 0) 
            {
                labelstate.Text = "En arret";
                this.BackColor = System.Drawing.Color.IndianRed;
                label_X.ForeColor = System.Drawing.Color.White;
                label_.ForeColor = System.Drawing.Color.White;
            }
            else if (Calcul_TRS.etat_arret == 0 && Calcul_TRS.etat_marche == 1)
            {
                labelstate.Text = "En marche";
                this.BackColor = System.Drawing.Color.LightSeaGreen;
                label_X.ForeColor = System.Drawing.Color.White;
                label_.ForeColor = System.Drawing.Color.White;
            }
        }

        private void label_X_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez vous quitter ? ", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label__Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Minimized;
        }


        //DAQ
        private void serialPortDAQ_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (DASHBOARD==1)
            {
                string sensor = serialPortDAQ.ReadLine();
                this.BeginInvoke(new sensorReceivedEvent(LineReceived), sensor);
            }
        }
        public delegate void sensorReceivedEvent(string sensor);
        public void LineReceived(string sensor)
        {

            // séparer la chaine envoyée 
            string[] values = sensor.Split('.');
            // classer les valeus dans un tableau 'values'
            int new_product = int.Parse(values[0]);
            //int non_conforme = int.Parse(values[1]);

            if (new_product == 1 && new_product!=last_new_product)// entrée produit / arduino pin2
                Calcul_TRS.nvo_produit();

            //if (non_conforme == 1 && non_conforme !=last_non_conforme)//entrée rebut / arduino pin4
            //    UCdashboard.nvo_rebut();

            last_new_product = new_product;
            //last_non_conforme = non_conforme;
        }
    }
}

