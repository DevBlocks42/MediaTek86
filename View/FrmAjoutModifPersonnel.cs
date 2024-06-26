﻿using MediaTek86.Controller;
using MediaTek86.Model;

namespace MediaTek86.View
{
    /// <summary>
    /// Vue de l'ajout et la modification des informations d'un personnel.
    /// </summary>
    public partial class FrmAjoutModifPersonnel : Form
    {
        private Personnel personnel = null;
        private FrmAjoutModifPersonnelController controller;
        private List<String> nomServices = new List<String>();
        /// <summary>
        /// Valorisation de la propriété privée et initialisation du contenu de certains éléments graphiques
        /// </summary>
        /// <param name="personnel"></param>
        public FrmAjoutModifPersonnel(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            if (this.personnel == null)
            {
                this.Text = "Administration - Ajout d'un personnel";
                LblTitreAjoutModif.Text = "Ajout de personnel";
                controller = new FrmAjoutModifPersonnelController(null);
            }
            else
            {
                this.Text = "Administration - Modification d'un personnel ";
                LblTitreAjoutModif.Text = "Modification de " + personnel.getPrenom() + " " + personnel.getNom();
                TbxNomPersonnel.Text = personnel.getNom();
                TbxPrenomPersonnel.Text = personnel.getPrenom();
                TbxTelPersonnel.Text = personnel.getTel();
                TbxMailPersonnel.Text = personnel.getMail();
                CbxServicePersonnel.Text = personnel.getService().getNom();
                controller = new FrmAjoutModifPersonnelController(personnel);
            }
            nomServices = controller.getNomServices();
            CbxServicePersonnel.Items.Clear();
            foreach (String nom in nomServices)
            {
                CbxServicePersonnel.Items.Add(nom);
            }
        }
        private void BtnEnregistrerPersonnel_Click(object sender, EventArgs e)
        {
            if (personnel == null) //Ajout d'un nouveau personnel
            {
                if (TbxPrenomPersonnel.Text.Length > 0 && TbxNomPersonnel.Text.Length > 0 && TbxTelPersonnel.Text.Length > 0 && TbxMailPersonnel.Text.Length > 0 && CbxServicePersonnel.SelectedIndex != -1)
                {
                    String nom = TbxNomPersonnel.Text;
                    String prenom = TbxPrenomPersonnel.Text;
                    String tel = TbxTelPersonnel.Text;
                    String mail = TbxMailPersonnel.Text;
                    int idService = CbxServicePersonnel.SelectedIndex + 1;
                    controller.ajouterPersonnel(nom, prenom, tel, mail, idService);
                    FrmAdministration frmAdministration = new FrmAdministration();
                    this.Close();
                    frmAdministration.Show();
                }
                else
                {
                    MessageBox.Show("Erreur, vous devez saisir toutes les informations du formulaire pour ajouter un nouveau personnel.");
                }
            }
            else //Modification d'un personnel existant
            {
                if (TbxPrenomPersonnel.Text.Length > 0 && TbxNomPersonnel.Text.Length > 0 && TbxTelPersonnel.Text.Length > 0 && TbxMailPersonnel.Text.Length > 0)
                {
                    String nom = TbxNomPersonnel.Text;
                    String prenom = TbxPrenomPersonnel.Text;
                    String tel = TbxTelPersonnel.Text;
                    String mail = TbxMailPersonnel.Text;
                    int idService = -1;
                    if (CbxServicePersonnel.SelectedIndex != -1)
                    {
                        idService = CbxServicePersonnel.SelectedIndex + 1;
                    }
                    else
                    {
                        idService = personnel.getService().getIdService();
                    }
                    DialogResult r = MessageBox.Show("Êtes-vous sur de vouloir modifier les informations de ce personnel ? Cette action est irreversible.", null, MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        controller.updatePersonnel(personnel.getIdPersonnel(), nom, prenom, tel, mail, idService);
                        FrmAdministration frmAdministration = new FrmAdministration();
                        this.Close();
                        frmAdministration.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Erreur, vous devez saisir toutes les informations du formulaire pour modifier ce personnel.");
                }
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