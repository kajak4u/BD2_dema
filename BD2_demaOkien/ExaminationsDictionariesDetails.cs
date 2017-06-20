using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_demaOkien
{
    public partial class ExaminationsDictionariesDetails : Form
    {
        public ExaminationsDictionariesDetails(ViewMode mode)
        {
            InitializeComponent();
            if (mode == ViewMode.CREATE)
                Text = "Dodaj badanie";
            else if (mode == ViewMode.EDIT)
                Text = "Edytuj badanie";
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
