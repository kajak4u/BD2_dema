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
    public partial class ExaminationsAddWindow : Form
    {
        public ExaminationsAddWindow(ExaminationMode mode)
        {
            InitializeComponent();
            InitControls(mode);
        }
        private void InitControls(ExaminationMode mode)
        {
            if (mode == ExaminationMode.LAB)
                label7.Text = "Notatki                      ";
            else
                label7.Text = "Wynik                        ";
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
