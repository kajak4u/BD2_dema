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
		public ExaminationsDetailWindow(int labExamID)//potrzebny jakiś param do określenia we frazie WHERE poniżej
		{
			InitializeComponent();
			using (var Db = new BD2_demaOkien.Data.BD2_2Db())
			{
				var data = from exam in Db.Examination_dictionary
						   join lab_exam in Db.LAB_examination on exam.Examination_code equals lab_exam.LAB_examination_code
						   join vis in Db.Visit on lab_exam.visit_id equals vis.visit_id
						   join pat in Db.Patient on vis.patient_id equals pat.Patient_id
						   join doc in Db.Worker on vis.doctor_id equals doc.Worker_id
						   join lab_work in Db.Worker on lab_exam.LAB_worker_id equals lab_work.Worker_id
						   join klab in Db.Worker on lab_exam.LAB_manager_id equals klab.Worker_id
						   where labExamID == lab_exam.LAB_examination_id
						   select new
						   {
							   //examType = exam.Examiantion_type,
							   examName = exam.Examination_name,
							   dateZle = vis.ending_date,
							   patientName = pat.First_name + " " + pat.Last_name,
							   examStatus = lab_exam.status,
							   doctor = doc.First_name + " " + doc.Last_name,
							   notes = lab_exam.doctor_notes,
							   labWorker = lab_work.First_name + " " + lab_work.Last_name,
							   labResult = lab_exam.LAB_examination_result,
							   labDate = lab_exam.commission_examination_date,
							   klabWorker = klab.First_name + " " + klab.Last_name,
							   klabNotes = lab_exam.LAB_manager_notes,
							   klabDate = lab_exam.LAB_examination_date
						   };

				textBox5.Text = data.Select(a => a.dateZle).ToString();
				textBox1.Text = data.Select(a => a.patientName).ToString();
				textBox3.Text = data.Select(a => a.examStatus).ToString();

				textBoxPatient.Text = data.Select(a => a.doctor).ToString();
				richTextBox1.Text = data.Select(a => a.notes).ToString();

				textBox4.Text = data.Select(a => a.labWorker).ToString();
				richTextBox2.Text = data.Select(a => a.labResult).ToString();
				textBox6.Text = data.Select(a => a.labDate).ToString();

				textBox8.Text = data.Select(a => a.klabWorker).ToString();
				richTextBox3.Text = data.Select(a => a.klabNotes).ToString();
				textBox7.Text = data.Select(a => a.klabDate).ToString();
			}

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
}
