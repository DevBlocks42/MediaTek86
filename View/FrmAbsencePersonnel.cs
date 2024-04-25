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
    public partial class FrmAbsencePersonnel : Form
    {
        private Personnel personnel;
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
        }

        private void BtnAddAbsence_Click(object sender, EventArgs e)
        {

        }
    }
}
