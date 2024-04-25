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
    public partial class FrmAjoutModifAbsence : Form
    {
        private Personnel personnel;
        private Absence absence;
        public FrmAjoutModifAbsence(Personnel personnel, Absence absence)
        {
            InitializeComponent();
            this.personnel = personnel;
            this.absence = absence; 
        }
    }
}
