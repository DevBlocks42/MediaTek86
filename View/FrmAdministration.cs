using MediaTek86.Controller;
using MediaTek86.DAL;
using MediaTek86.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.View
{
    public partial class FrmAdministration : Form
    {
        private readonly FrmAdministrationController controller;
        /// <summary>
        /// Valorisation de la propriété personnelAccess
        /// </summary>
        public FrmAdministration()
        {
            InitializeComponent();
            controller = new FrmAdministrationController();
        }
        private void FrmAdministration_Load(object sender, EventArgs e)
        {
            foreach (Personnel personnel in controller.getLesPersonnels())
            {
                LbxPersonnel.Items.Add(personnel.ToString());
            }
        }
        private void BtnAddPersonnel_Click(object sender, EventArgs e)
        {
            FrmAjoutModifPersonnel frmAjoutModifPersonnel = new FrmAjoutModifPersonnel(null);
            frmAjoutModifPersonnel.Show();
            this.Close();
        }
        private void BtnEditPersonnel_Click(object sender, EventArgs e)
        {
            if(LbxPersonnel.SelectedIndex != -1)
            {
                List<Personnel> lesPersonnels = controller.getLesPersonnels();
                Personnel p = lesPersonnels[LbxPersonnel.SelectedIndex];
                if (p != null)
                {
                    FrmAjoutModifPersonnel frmAjoutModifPersonnel = new FrmAjoutModifPersonnel(p);
                    frmAjoutModifPersonnel.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Erreur, vous devez d'abord séléctionner un personnel dans la liste pour modifier ses informations.");
            }
        }
        private void BtnDeletePersonnel_Click(object sender, EventArgs e)
        {
            if(LbxPersonnel.SelectedIndex != -1)
            {

            }
            else
            {
                MessageBox.Show("Erreur, vous devez d'abord séléctionner un personnel dans la liste pour le supprimer.");
            }
        }
        private void BtnAbsencePersonnel_Click(object sender, EventArgs e)
        {
            if (LbxPersonnel.SelectedIndex != -1)
            {

            }
            else
            {
                MessageBox.Show("Erreur, vous devez d'abord séléctionner un personnel dans la liste pour gérer ses absences.");
            }
        }
    }
}
