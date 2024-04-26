using MediaTek86.Controller;
using MediaTek86.Model;

namespace MediaTek86.View
{
    /// <summary>
    /// Vue du formulaire d'ajout et de modification d'une absence d'un personnel
    /// </summary>
    public partial class FrmAjoutModifAbsence : Form
    {
        private Personnel personnel;
        private Absence absence;
        private FrmAjoutModifAbsenceController controller;
        /// <summary>
        /// Valorisation des propriétés privées
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="absence"></param>
        public FrmAjoutModifAbsence(Personnel personnel, Absence absence)
        {
            InitializeComponent();
            LblPersonnelAbsence.Text = "Personnel : " + personnel.getPrenom() + " " + personnel.getNom();   
            this.personnel = personnel;
            this.absence = absence;
            this.controller = new FrmAjoutModifAbsenceController(this.personnel, this.absence);
            List<DateTime> datesDebut = new List<DateTime>();
            List<DateTime> datesFin = new List<DateTime>();
            DateTime start;
            DateTime end;
            CbxMotif.DataSource = controller.getAllMotifs();
            if (this.absence == null)
            {
                start = DateTime.Today;
                end = start.AddDays(250); //Plage limitée à 250 jours à partir d'aujourd'hui
                for (var dt = start; dt <= end; dt = dt.AddDays(1))
                {
                    datesDebut.Add(dt);
                    datesFin.Add(dt);
                }
                CbxDateDebut.DataSource = datesDebut;
                CbxDateFin.DataSource = datesFin;
            }
            else
            {
                start = this.absence.getDateDebut();
                end = start.AddDays(250); //Plage limitée à 250 jours après la date de début
                for (var dt = start; dt <= end; dt = dt.AddDays(1))
                {
                    datesDebut.Add(dt);
                    datesFin.Add(dt);
                }
                CbxDateDebut.DataSource = datesDebut;
                CbxDateFin.DataSource = datesFin;
                CbxDateDebut.SelectedItem = this.absence.getDateDebut();
                CbxDateFin.SelectedItem = this.absence.getDateFin();
                CbxMotif.SelectedIndex = this.absence.getMotif().getIdMotif() - 1;
            }
        }
        private void BtnEnregistrerPersonnel_Click(object sender, EventArgs e)
        {
            DateTime debut = DateTime.Parse(CbxDateDebut.SelectedItem.ToString());
            DateTime fin = DateTime.Parse(CbxDateFin.SelectedItem.ToString());
            Motif motif = (Motif)CbxMotif.SelectedItem;
            if (absence != null) //Modification d'une absence déjà présente
            {
                if (CbxDateDebut.SelectedItem != null && CbxDateFin.SelectedItem != null && CbxMotif.SelectedItem != null)
                {
                    if (debut < fin)
                    {
                        controller.updateAbsencePersonnel(debut, fin, motif);
                        personnel.setAbsences(controller.getPersonnelAbsences(personnel.getIdPersonnel()));
                        FrmAbsencePersonnel frmAbsencePersonnel = new FrmAbsencePersonnel(personnel);
                        this.Close();
                        frmAbsencePersonnel.Show();
                    }
                    else
                    {
                        MessageBox.Show("Erreur, la date de début ne peut pas excéder la date de fin.");
                    }
                }
                else
                {
                    MessageBox.Show("Erreur, vous devez saisir toutes les informations du formulaire pour ajouter une nouvelle absence.");
                }
            }
            else //Ajout d'une nouvelle absence
            {
                if (CbxDateDebut.SelectedItem != null && CbxDateFin.SelectedItem != null && CbxMotif.SelectedItem != null)
                {
                    if (debut < fin)
                    {
                        controller.ajouterAbsence(debut, fin, motif);
                        personnel.setAbsences(controller.getPersonnelAbsences(personnel.getIdPersonnel()));
                        FrmAbsencePersonnel frmAbsencePersonnel = new FrmAbsencePersonnel(personnel);
                        this.Close();
                        frmAbsencePersonnel.Show();
                    }
                    else
                    {
                        MessageBox.Show("Erreur, la date de début ne peut pas excéder la date de fin.");
                    }
                }
                else
                {
                    MessageBox.Show("Erreur, vous devez saisir toutes les informations du formulaire pour ajouter une nouvelle absence.");
                }
            }
        }
        private void BtnRetour_Click(object sender, EventArgs e)
        {
            personnel.setAbsences(personnel.getAbsences());
            FrmAbsencePersonnel frmAbsencePersonnel = new FrmAbsencePersonnel(personnel);
            this.Close();
            frmAbsencePersonnel.Show();
        }
    }
}