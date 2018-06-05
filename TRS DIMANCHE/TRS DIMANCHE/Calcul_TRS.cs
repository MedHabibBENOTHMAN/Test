// cette classe :
// appelle la base
// fait le calcul TRS 
// affecte le TRS dans machine_1_trs
// sauvegarde les arrets dans machine_1_arret


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;


namespace TRS_DIMANCHE
{
    public class Calcul_TRS
    {
        public static int last_etat_changement_de_serie;
        public static int etat_changement_de_serie;
        public static double current_SMED;
        public static double SMED_0;
        public static double SMED_1;
        public static double SMED_2;

        public static DateTime date_debut;
        public static DateTime t_production;

        public static string last_team="";
        public static string current_team;

        public static int last_id;
        public static int last_id_trs;
        public static int last_id_rebut;
        public static int last_id_production;

        public static string machine="Machine 1";
        public static string utilisateur="";
        public static string equipe = "";

        public static int etat_arret=0;
        public static int etat_marche=0;
        public static int etat_pause = 0;
            
        // initialisation des variables
        public static int nvoproduit = 0; // DAQ ou boutton
        public static double nbre_produit_moule=0;
        public static double nbre_produit = 0;
        public static double temps_fonctionnement = 1; // compteur fonctionnement dans Main

        public static int tempsdetection = 0; // = compteur verification durée entre les "pics prosuit" 
        public static double temps_de_cycle ; // from parametre/table moule

        public static int arrets;
        public static int count_arret=0;
        public static int selected_arret; // selected in dgv in UCidentifierarret
        public static int pauses=0;
        public static int count_pause ;

        public static string type_arret;

        public static double temps_brut = 0; // disponibilité
        public static double temps_requis = 0;
        public static double disponibilité = 0;

        public static double cadence_theorique; 
        public static double cadence_reele ;
        public static double performance=100 ;

        public static string produit_rebuté;
        public static double rebut = 0;
        public static double qualité ;
        public static double accepte=0;

        public static double TRS ;

        public static int current_rebut_quantity;
        public static string current_rebut_quality;

        public static string matiere;
        public static string palette;
        public static string moule;
        public static int moule_empreinte;
        public static string description;

        //produit: produit_1 & produit_2-------------------------------------------------------------------------
        public static string reference = ""; // moule (commune)

        public static string produit_1 = ""; // produit_1
        public static string OF_1 = "";

        public static int produit_1_total;
        public static int produit_1_rebut;
        public static double produit_1_qualite;

        public static int produit_1_qualite_seuil_1;
        public static int produit_1_qualite_seuil_2;
        public static int produit_1_qualite_seuil_3;
        
        public static string produit_2 = ""; // produit_2
        public static string OF_2 = "";

        public static int produit_2_total;
        public static int produit_2_rebut;
        public static double produit_2_qualite;

        public static int produit_2_qualite_seuil_1;
        public static int produit_2_qualite_seuil_2;
        public static int produit_2_qualite_seuil_3;
        //
        public static int verif_arret;
        public static int changement_de_serie = 0;
        public static int changement_equipe = 0;
        public static int total_avant_changement_equipe;

        public static int get_matin ;
        public static int get_am ;
        public static int get_soir ;
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------


        public static void verif_equipe()
        {
            string current_time = DateTime.Now.ToShortTimeString(); // get time
            string[] values = current_time.Split(':'); //get hour
            int hours = int.Parse(values[0]);            // classer les valeus dans un tableau 'values'

            int current_time_hour = Convert.ToInt16(hours);
            if (current_time_hour >= 6 && current_time_hour < 14)
                Calcul_TRS.equipe = "MATIN";
            else if (current_time_hour >= 14 && current_time_hour < 22)
                Calcul_TRS.equipe = "A-M";
            else if (current_time_hour >= 22 && current_time_hour < 6)
                Calcul_TRS.equipe = "NUIT";

            // just pour tester avec checkbox
            //if (get_matin==1)
            //    Calcul_TRS.equipe = "MATIN";
            //else if (get_am==1)
            //    Calcul_TRS.equipe= "A-M";
            //else if (get_soir == 1)
            //    Calcul_TRS.equipe = "NUIT";
            //
            current_team = equipe;
            if (current_team != last_team) // changement : changement equipe ou nouveau travail
            {
                changement_equipe = 1;

                if (last_team!="") // changement equipe
                {
                    if(arrets>0)
                        update_db_arret();
                    update_db_TRS();
                    update_db_TRS_production();
                }

                //else 
                //{
                //    reset_TRS();
                //    insert_db_TRS();
                //}

                changement_equipe = 0;
            }
            last_team = current_team;
        }



        public static void verif() // detection arret 
        {

            verif_equipe();

            //if (Calcul_TRS.changement_equipe == 1)
            //{
            //    insert_db_production();
            //}
            tempsdetection++;
            if (nvoproduit == 1) // nouveau produit
                nvo_produit();
            if ((tempsdetection) >= (2*temps_de_cycle)) // temps de cycle/produit (from excel) 
            {
                if (etat_arret == 0)// début d'arret > ajouter nouveau arret
                {
                    verif_arret++;
                    arrets += tempsdetection;
                    count_arret += tempsdetection;
                    insert_db_arret(); // indice "insert_arret"==1; 
                }
                etat_arret = 1;
                etat_marche = 0;
                declarer_arrret();
            }
            else // (etat_arret == 1) pas d'arret detecté > machine en marche
            {
                declarer_marche();
                etat_arret = 0;
                etat_marche = 1;
            }
            //mail_to();

        }

        public static void declarer_marche()
        {

            etat_pause = 0;
            count_arret = 0;
            count_pause = 0;
        }

        public static void declarer_arrret()
        {
            if(etat_pause==1)
            {
                count_pause++;
                pauses++;
                update_db_arret();
            }
            else
            {
                count_arret++; // arret en cours
                arrets++; // total des arrets
                update_db_arret(); // update de l'arret en cours
            }
        }
  
        public static void nvo_produit() // nouveau produit
        {

            /*if (changement_equipe == 1 ) //pendant un changement d'equipe, on attend un nouveau produit  pour re
            {
                Calcul_TRS.reset_TRS();//TRS/dispo/preformance/qualite
                Calcul_TRS.insert_db_TRS();
                //Calcul_TRS.update_db_TRS();
                changement_equipe = 0;
            }*/

            produit_1_total += moule_empreinte / 2;
            produit_2_total += moule_empreinte / 2;
            nbre_produit_moule++;
            nbre_produit += moule_empreinte;
            tempsdetection = 0;
            t_production = DateTime.Now;// définit le début et la fin d'un arret

        }

        //calcul_TRS
        public static void calcul()
        {
            temps_fonctionnement++;
            verif(); // detection des arrets
            
            //calcul TRS: 
            
            temps_brut = temps_fonctionnement - pauses - arrets;//Disponibilté
            temps_requis = temps_fonctionnement - pauses;
            disponibilité = (temps_brut / temps_requis) * 100;

            cadence_reele = (nbre_produit_moule / temps_brut); // (produit/secondes) //Performance
            performance = (cadence_reele / cadence_theorique)*100; //cadence_theorique= 1/temps de cycle du produit
            if (temps_brut == 0)
                disponibilité = 0;
            if (nbre_produit_moule == 0)
                performance = 0;

            accepte = nbre_produit - rebut;//Qualité
            if (nbre_produit == 0) 
                qualité = 100;
            else
                qualité = ((nbre_produit - rebut) / nbre_produit) * 100;

            if (produit_1_total == 0) //Qualité
                produit_1_qualite = 0;
            else
                produit_1_qualite = (double)(produit_1_total - produit_1_rebut) / (double)produit_1_total;

            if (produit_2_total == 0) //Qualité
                produit_2_qualite = 0;
            else
                produit_2_qualite = (double)(produit_2_total - produit_2_rebut) / (double)produit_2_total;

            TRS = ((disponibilité / 100) * (performance / 100) * (qualité / 100)) * 100; //TRS

            update_db_TRS();
            update_db_TRS_production();
        }

        public static void reset_TRS()
        {


            temps_fonctionnement = 0;
            tempsdetection = 0;
            pauses = 0;
            arrets = 0;
            //temps_brut = 0;
            //temps_requis = 0;
            count_pause = 0;
            count_arret=0;

            cadence_reele = 0;

            produit_1_total = 0;
            produit_1_rebut = 0;
            produit_2_total = 0;
            produit_2_rebut = 0;

            rebut = 0;
            accepte = 0;
            nbre_produit = 0;
            nbre_produit_moule = 0;

            if (nbre_produit == 0)
                qualité = 0;
            if (produit_1_total == 0) //Qualité
                produit_1_qualite = 0;
            if (produit_2_total == 0) //Qualité
                produit_2_qualite = 0;

            //performance = 100;
            //disponibilité = 0;
            //TRS = 0;
        }


        public static void SMED()
        {
            SMED_2 = SMED_1;
            SMED_1 = SMED_0;
            SMED_0= current_SMED;
        }

        // Functions base de données..............................................................................

        public static void insert_db_TRS()  // event : appuyer sur boutton "demarrer un travail" dans UC_config
        {
            machine_1_trs model_machine_TRS = new machine_1_trs();
            //config travail
            model_machine_TRS.date=DateTime.Now ;
            model_machine_TRS.user = utilisateur;
            model_machine_TRS.equipe = equipe;

            //model_machine_TRS.of_1 = Calcul_TRS.OF_1;
            //model_machine_TRS.of_2 = Calcul_TRS.OF_2;
            //model_machine_TRS.produit_1 = Calcul_TRS.produit_1;
            //model_machine_TRS.produit_2 = Calcul_TRS.produit_2;

            //model_machine_TRS.moule =Calcul_TRS.moule;
            //model_machine_TRS.empreinte =Calcul_TRS.moule_empreinte;
            //model_machine_TRS.matiere =Calcul_TRS.matiere;
            //model_machine_TRS.palette =Calcul_TRS.palette;
            //calcul_TRS
            model_machine_TRS.temps_brut= Calcul_TRS.temps_brut;
            model_machine_TRS.temps_requis= Calcul_TRS.temps_requis;
            model_machine_TRS.disponibilite= Calcul_TRS.disponibilité;
            model_machine_TRS.qte_produite= Convert.ToInt32(Calcul_TRS.nbre_produit);
            model_machine_TRS.qte_acceptee= Convert.ToInt32(Calcul_TRS.accepte);
            model_machine_TRS.qualite= Calcul_TRS.qualité;
            model_machine_TRS.cadence_therorique= Calcul_TRS.cadence_theorique;
            model_machine_TRS.cadence_reele= Calcul_TRS.cadence_reele;
            model_machine_TRS.performance= Calcul_TRS.performance;
            model_machine_TRS.TRS= Calcul_TRS.TRS;

            model_machine_TRS.qualite_produit_1 = Calcul_TRS.produit_1_qualite;
            model_machine_TRS.qualite_produit_2 = Calcul_TRS.produit_2_qualite;

          using (trs_machineEntities2 db = new trs_machineEntities2())
            {
                db.machine_1_trs.Add(model_machine_TRS);
                db.SaveChanges();
            }
            last_id_trs= model_machine_TRS.id;
        }

        public static void update_db_TRS() // event void
        {
            var context = new trs_machineEntities2();
            var duree = from c in context.machine_1_trs
                        where c.id == last_id_trs
                        select c;
            var OEE = duree.FirstOrDefault();

            //OEE.user = Calcul_TRS.utilisateur;
            OEE.temps_brut = Calcul_TRS.temps_brut;
            OEE.temps_requis = Calcul_TRS.temps_requis;

            OEE.qte_produite = Convert.ToInt32(Calcul_TRS.nbre_produit);
            OEE.qte_acceptee = Convert.ToInt32(Calcul_TRS.accepte);
            OEE.qualite = Calcul_TRS.qualité;
            OEE.cadence_reele = Calcul_TRS.cadence_reele;
            OEE.cadence_therorique = Calcul_TRS.cadence_theorique;
            OEE.performance = Calcul_TRS.performance;

            OEE.qualite_produit_1 = Calcul_TRS.produit_1_qualite;
            OEE.qualite_produit_2 = Calcul_TRS.produit_2_qualite;


            OEE.disponibilite = Calcul_TRS.disponibilité;
            OEE.TRS = Calcul_TRS.TRS;

            context.SaveChanges();
        }

        public static void insert_db_production()  // event : appuyer sur boutton "demarrer un travail" dans UC_config
        {
            machine_1_production model_machine_production = new machine_1_production();
            //config travail
            model_machine_production.debut = DateTime.Now;
            model_machine_production.fin = DateTime.Now;

            model_machine_production.of_1 = OF_1;
            model_machine_production.ref_1 = produit_1;
            model_machine_production.ref_1_total = produit_1_total;
            model_machine_production.ref_1_rebut = produit_1_rebut;
            model_machine_production.ref_1_qualite = produit_1_qualite;

            model_machine_production.of_2 = OF_2;
            model_machine_production.ref_2 = produit_2;
            model_machine_production.ref_2_total = produit_2_total;
            model_machine_production.ref_2_rebut = produit_2_rebut;
            model_machine_production.ref_2_qualite = produit_2_qualite;

            model_machine_production.moule = moule;
            model_machine_production.empreinte = moule_empreinte;
            model_machine_production.description = description;
            model_machine_production.matiere = matiere;
            model_machine_production.palette = palette;
         
            using (machine_1_production_Entities db = new machine_1_production_Entities())
            {
                db.machine_1_production.Add(model_machine_production);
                db.SaveChanges();
            }
            last_id_production = model_machine_production.idmachine_1_production;
        }

        public static void update_db_TRS_production() // event void
        {
            var context = new machine_1_production_Entities();
            var prod = from c in context.machine_1_production
                        where c.idmachine_1_production == last_id_production
                        select c;
            var production = prod.FirstOrDefault();

            production.fin = DateTime.Now;

            production.ref_1_total = produit_1_total;
            production.ref_1_rebut = produit_1_rebut;
            production.ref_1_qualite = produit_1_qualite;

            production.ref_2_total = produit_2_total;
            production.ref_2_rebut = produit_2_rebut;
            production.ref_2_qualite = produit_2_qualite;

            context.SaveChanges();
        
        }


        public static void insert_db_arret()  // inserer nouvelle ligne dans machine_1_arret where : - date time: currenttime - OF=of - arret= arret non identifié - durée= count_arret;    
        {
            machine_1_arrets model_machine_arrets = new machine_1_arrets();

            model_machine_arrets.of_1 = Calcul_TRS.OF_1;
            model_machine_arrets.of_2 = Calcul_TRS.OF_2;

            model_machine_arrets.arret = "arret non identifié";
            model_machine_arrets.type_arret = "arret non plannifé";
            model_machine_arrets.duree = count_arret;

            model_machine_arrets.date = (DateTime.Now).ToShortDateString();
            model_machine_arrets.debut = t_production;
            model_machine_arrets.fin = DateTime.Now;

            using (arrets_non_identifiés db = new arrets_non_identifiés())
            {
                db.machine_1_arrets.Add(model_machine_arrets);
                db.SaveChanges();
            }

            last_id = model_machine_arrets.id;
        }

        public static void update_db_arret()
        {
            var context = new arrets_non_identifiés();
            var duree = from c in context.machine_1_arrets
                        where c.id == last_id
                        select c;
            var beakdown = duree.FirstOrDefault();

            if (etat_arret==1 && etat_pause==0)
                beakdown.duree = count_arret;
            else if (etat_arret==1 && etat_pause==1)
                beakdown.duree = count_pause;

            beakdown.fin = DateTime.Now;
            if (changement_de_serie == 1) // ucproduit : insertion automatique du changement de serie
            {
                beakdown.type_arret = "arret plannifie";
                beakdown.arret = "changement_serie";
            }
            if (beakdown.arret == "changement_serie")
            {
                current_SMED = (int)beakdown.duree;

                etat_changement_de_serie = 1;                
                if (last_etat_changement_de_serie != etat_changement_de_serie)
                    SMED();
                
            }
            else etat_changement_de_serie = 0;
            // mise a jour SMED en cours 
            last_etat_changement_de_serie = etat_changement_de_serie;


            context.SaveChanges();
        }

        public static void insert_db_rebut()  // inserer nouvelle ligne dans machine_1_rebut where : - date time: currenttime - OF=of - arret= arret non identifié - durée= count_arret;    
        {
            machine_1_rebut model_machine_rebut = new machine_1_rebut();

            model_machine_rebut.temps = DateTime.Now;
            if (produit_rebuté==produit_1)
                model_machine_rebut.of = Calcul_TRS.OF_1;
            else if (produit_rebuté == produit_2)
                model_machine_rebut.of = Calcul_TRS.OF_2;

            model_machine_rebut.produit = produit_rebuté;
            model_machine_rebut.quantité = current_rebut_quantity;
            model_machine_rebut.rebut = current_rebut_quality;


            using (rebut_machine_Entities db = new rebut_machine_Entities())
            {
                db.machine_1_rebut.Add(model_machine_rebut);
                db.SaveChanges();
            }

            last_id_rebut = model_machine_rebut.idmachine_1_rebut;
        }

        /*public static void alerte_mail(double produit_qualite,int seuil_1,int seuil_2,int seuil_3)
        {
            if (produit_qualite > seuil_1)
                mail_to(class_1);
            else if (produit_qualite > seuil_2 && produit_qualite < seuil_3)
                mail_to(class_2);
            else if (produit_qualite > seuil_3)
                mail_to(class_3);
        }

        public static void get_ist_mail()
        {

            // remplir 3 tableaux (class1 class2 class3 from db) au lancement de l'application  
            using (arrets_non_identifiés db = new arrets_non_identifiés())
            {
                Array class_mail_1.DataSource = db.arretimprevu.Where(x => x.destinataire_class == "1").ToArray<arretimprevu>();
            }
        }*/

        public static void mail_to(string class_qualite) // db parametres/tab mail_alerte/ distinataire_class : parcourir la table et identifier les classes
        {


            /*try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.soc-grp.net");
                mail.From = new MailAddress("alerts.it.tn@socomec.com");
                // boucle for 
                mail.To.Add("arbi.menzli@socomec.com"); // class_alerte
                //
                String computer = x.Substring(0, 10);
                mail.Subject = computer + " Was deleted";

                ;
                //Font font = new Font("Times New Roman", 16.0f,FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                mail.Body = "Hello, \n\n" + "The pc N° " + computer + " Is Deleted ! \n\n" + "IT Manger.";
                SmtpServer.Port = 25;
                SmtpServer.Credentials = new System.Net.NetworkCredential("alerts.it.tn", "MoncompteA");
                //SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                // MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
        }
    }  
}
