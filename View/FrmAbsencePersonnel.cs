using MediaTek86.Controller;
using MediaTek86.Model;

namespace MediaTek86.View
{
    /// <summary>
    /// Vue de l'absence des personnels
    /// </summary>
    public partial class FrmAbsencePersonnel : Form
    {
        private Personnel personnel;
        private FrmAbsencePersonnelController controller;
        /// <summary>
        /// Valorisation de la propriété privée
        /// </summary>
        /// <param name="personnel"></param>
        public FrmAbsencePersonnel(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            LbxAbsencesPersonnel.DataSource = personnel.getAbsences();
            LblAbsencePersonnel.Text = "Personnel : " + personnel.getPrenom() + " " + personnel.getNom();
            controller = new FrmAbsencePersonnelController();
        }
        private void BtnAddAbsence_Click(object sender, EventArgs e)
        {
            FrmAjoutModifAbsence frmAjoutModifAbsence = new FrmAjoutModifAbsence(this.personnel, null);
            this.Close();
            frmAjoutModifAbsence.Show();
        }
        private void BtnEditAbsence_Click(object sender, EventArgs e)
        {
            if (LbxAbsencesPersonnel.SelectedIndex != -1)
            {
                FrmAjoutModifAbsence frmAjoutModifAbsence = new FrmAjoutModifAbsence(personnel, (Absence)LbxAbsencesPersonnel.SelectedItem);
                this.Close();
                frmAjoutModifAbsence.Show();
            }
            else
            {
                MessageBox.Show("Erreur, vous devez séléctionner une absence dans la liste pour modifier ses informations.");
            }
        }
        private void BtnDeleteAbsence_Click(object sender, EventArgs e)
        {
            if (LbxAbsencesPersonnel.SelectedIndex != -1)
            {
                DialogResult r = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette absence ? Cette action est irréversible.", null, MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    controller.supprimerAbsence(personnel, (Absence)LbxAbsencesPersonnel.SelectedItem);
                    personnel.setAbsences(controller.getPersonnelAbsences(personnel.getIdPersonnel()));
                    FrmAbsencePersonnel frmAbsencePersonnel = new FrmAbsencePersonnel(personnel);
                    this.Close();
                    frmAbsencePersonnel.Show();
                }
            }
            else
            {
                MessageBox.Show("Erreur, vous devez séléctionner une absence dans la liste pour la supprimer.");
            }
        }
        private void BtnRetour_Click(object sender, EventArgs e)
        {
            FrmAdministration frmAdministration = new FrmAdministration();
            this.Close();
            frmAdministration.Show();   
        }
    }
}