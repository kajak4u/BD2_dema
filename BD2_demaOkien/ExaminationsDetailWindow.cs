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
    /// <summary>
    /// Muszą być przekazane z wyboru dokonanego w Gridzie.
    /// </summary>

    public partial class ExaminationsDetailWindow : Form
    {
        private int examinationId;
        public ExaminationsDetailWindow(int examinationId)
        {
            this.examinationId = examinationId;
            InitializeComponent();
            using (var Db = new BD2_demaOkien.Data.BD2_2Db())
            {
                var data = Db.LAB_examination
                    .Where(ex => ex.LAB_examination_id == examinationId)
                    .Select(ex => new
                    {
                        examType = ex.Examination_dictionary.Examiantion_type,
                        examName = ex.Examination_dictionary.Examination_name,
                        examCode = ex.LAB_examination_code,
                        dateZle = ex.commission_examination_date,
                        patientName = ex.Visit.Patient.First_name + " " + ex.Visit.Patient.Last_name,
                        examStatus = ex.status,
                        doctor = ex.Visit.Doctor.First_name + " " + ex.Visit.Doctor.Last_name,
                        notes = ex.doctor_notes,
                        labWorker = ex.Worker.First_name + " " + ex.Worker.Last_name,
                        labResult = ex.LAB_examination_result,
                        labDate = ex.LAB_examination_date,
                        klabWorker = ex.Worker1.First_name + " " + ex.Worker1.Last_name,
                        klabNotes = ex.LAB_manager_notes,
                        klabDate = ex.LAB_examination_date
                    }).First();

                textBox5.Text = data.dateZle.ToString();
                textBox1.Text = data.patientName;
                string examType = data.examType;
                textBox3.Text = data.examStatus;

                textBoxPatient.Text = data.doctor;
                richTextBox1.Text = data.notes;

                textBox4.Text = data.labWorker;
                richTextBox2.Text = data.labResult;
                textBox6.Text = data.labDate.HasValue ? data.labDate.Value.ToString() : "";

                textBox8.Text = data.klabWorker;
                richTextBox3.Text = data.klabNotes;
                textBox7.Text = data.klabDate.HasValue ? data.klabDate.Value.ToString() : "";

                textBox2.Text = data.examName;
                textBox9.Text = data.examCode;

                Role role = MainWindow.userRole;
                switch (role)
                {
                    case Role.LAB:
                        tabControl1.SelectedTab = tabPage3;
                        break;
                    case Role.KLAB:
                        tabControl1.SelectedTab = tabPage4;
                        break;
                }

                switch(data.examStatus)
                {
                    case "ZLE":
                        tabControl1.TabPages.Remove(tabPage4);
                        if (role == Role.LAB)
                        {
                            richTextBox2.ReadOnly = false;
                            button2.Visible = true;
                            button3.Visible = true;
                        }
                        else
                            tabControl1.TabPages.Remove(tabPage3);
                        break;
                    case "AN_L":
                        tabControl1.TabPages.Remove(tabPage4);
                        break;
                    case "WYK":
                        if (role == Role.KLAB)
                        {
                            richTextBox3.ReadOnly = false;
                            button2.Visible = true;
                            button3.Visible = true;
                        }
                        else
                            tabControl1.TabPages.Remove(tabPage4);
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!MainWindow.ShowQuestion("Zatwierdzić badanie?", "Potwierdzenie"))
                return;
            switch(MainWindow.userRole)
            {
                case Role.LAB:
                    BizzLayer.LabExaminations.Perform(examinationId, MainWindow.userId, richTextBox2.Text);
                    break;
                case Role.KLAB:
                    BizzLayer.LabExaminations.Accept(examinationId, MainWindow.userId, richTextBox3.Text);
                    break;
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!MainWindow.ShowQuestion("Anulować badanie?", "Potwierdzenie"))
                return;
            switch (MainWindow.userRole)
            {
                case Role.LAB:
                    BizzLayer.LabExaminations.CancelLab(examinationId, MainWindow.userId, richTextBox2.Text);
                    break;
                case Role.KLAB:
                    BizzLayer.LabExaminations.CancelKlab(examinationId, MainWindow.userId, richTextBox2.Text);
                    break;
            }
            Close();
        }
    }
}
