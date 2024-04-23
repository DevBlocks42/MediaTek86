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
        private PersonnelAccess personnelAccess;
        public FrmAdministration()
        {
            InitializeComponent();
            personnelAccess = new PersonnelAccess();
        }
        private void FrmAdministration_Load(object sender, EventArgs e)
        {
            foreach(Personnel personnel in personnelAccess.getLesPersonnels())
            {
                LbxPersonnel.Items.Add(personnel.ToString());
            }
        }
    }
}
