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
        private struct DBdataResult
        {
            public string examType;
            public string examName;
            public DateTime? dateZle;
            public string patientName;
            public string examStatus;
            public string doctor;
            public string notes;
            public string labWorker;
            public string labResult;
            public DateTime? labDate;
            public string klabWorker;
            public string klabNotes;
            public DateTime? klabDate;
        }

        public ExaminationsDetailWindow(int examinationId)
        {
            InitializeComponent();
            using (var Db = new BD2_demaOkien.Data.BD2_2Db())
            {
                var data = Db.LAB_examination
                    .Where(ex => ex.LAB_examination_id == examinationId)
                    .Select(ex => new
                    {
                        examType = ex.Examination_dictionary.Examiantion_type,
                        examName = ex.Examination_dictionary.Examination_name,
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

                Role role = MainWindow.userRole;
                switch (role)
                {
                    case Role.DOCTOR:
                        textBox5.ReadOnly = false;
                        textBox1.ReadOnly = false;
                        textBox3.ReadOnly = false;

                        textBoxPatient.ReadOnly = false;
                        richTextBox1.ReadOnly = false;

                        textBox4.ReadOnly = true;
                        richTextBox2.ReadOnly = true;
                        textBox6.ReadOnly = true;

                        textBox8.ReadOnly = true;
                        richTextBox3.ReadOnly = true;
                        textBox7.ReadOnly = true;
                        break;
                    case Role.LAB:
                        textBox5.ReadOnly = true;
                        textBox1.ReadOnly = true;
                        textBox3.ReadOnly = true;

                        textBoxPatient.ReadOnly = true;
                        richTextBox1.ReadOnly = true;

                        textBox4.ReadOnly = false;
                        richTextBox2.ReadOnly = false;
                        textBox6.ReadOnly = false;

                        textBox8.ReadOnly = true;
                        richTextBox3.ReadOnly = true;
                        textBox7.ReadOnly = true;
                        break;
                    case Role.KLAB:
                        textBox5.ReadOnly = true;
                        textBox1.ReadOnly = true;
                        textBox3.ReadOnly = true;

                        textBoxPatient.ReadOnly = true;
                        richTextBox1.ReadOnly = true;

                        textBox4.ReadOnly = true;
                        richTextBox2.ReadOnly = true;
                        textBox6.ReadOnly = true;

                        textBox8.ReadOnly = false;
                        richTextBox3.ReadOnly = false;
                        textBox7.ReadOnly = false;
                        break;
                    default:
                        textBox5.ReadOnly = true;
                        textBox1.ReadOnly = true;
                        textBox3.ReadOnly = true;

                        textBoxPatient.ReadOnly = true;
                        richTextBox1.ReadOnly = true;

                        textBox4.ReadOnly = true;
                        richTextBox2.ReadOnly = true;
                        textBox6.ReadOnly = true;

                        textBox8.ReadOnly = true;
                        richTextBox3.ReadOnly = true;
                        textBox7.ReadOnly = true;
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
