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
    public partial class UCusername : UserControl
    {
        public UCusername()
        {
            InitializeComponent();
        }

        private void UCusername_Load(object sender, EventArgs e)
        {
            metroTextBoxusername.Focus();
        }


       
        private void metroTile_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextBoxusername.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "veuillez entrer votre identifiant", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroTextBoxusername.Focus();
                return;
            }
            try
            {
                using (parametreEntities db = new parametreEntities())
                {
                    var query = from u in db.users
                                where u.login == metroTextBoxusername.Text && u.password == metroTextBoxpassword.Text
                                select u;
                    if (query.SingleOrDefault() != null)
                    {
                        Calcul_TRS.utilisateur = metroTextBoxusername.Text;
                        MetroFramework.MetroMessageBox.Show(this, "Welcome  " + metroTextBoxusername.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "votre identifiant ou mot de passe est incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
