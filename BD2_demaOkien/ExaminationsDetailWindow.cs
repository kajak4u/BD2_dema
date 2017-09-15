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

		public ExaminationsDetailWindow(ParametersForExamDetails param, bool isLabExam)//potrzebny jakiś param do określenia we frazie WHERE poniżej
        {
            InitializeComponent();
            MessageBox.Show("To nie działa!!! :(");
            return;
			using (var Db = new BD2_demaOkien.Data.BD2_2Db())
			{
				DBdataResult data;
				if (isLabExam)
				{
					var lab_data = from exam in Db.Examination_dictionary
								   join lab_exam in Db.LAB_examination on exam.Examination_code equals lab_exam.LAB_examination_code
								   join vis in Db.Visit on lab_exam.visit_id equals vis.visit_id
								   join pat in Db.Patient on vis.patient_id equals pat.Patient_id
								   join doc in Db.Worker on vis.doctor_id equals doc.Worker_id
								   join lab_work in Db.Worker on lab_exam.LAB_worker_id equals lab_work.Worker_id
								   join klab in Db.Worker on lab_exam.LAB_manager_id equals klab.Worker_id
								   where param.visitId == vis.visit_id && param.labExamId == lab_exam.LAB_examination_id
								   select new DBdataResult
								   {
									   examType = exam.Examiantion_type,
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
					data = lab_data.First();
				}
				else
				{
					var phy_data = from exam in Db.Examination_dictionary
								   join phy_exam in Db.Physical_examination on exam.Examination_code equals phy_exam.Physical_examination_code
								   join vis in Db.Visit on phy_exam.visit_id equals vis.visit_id
								   join pat in Db.Patient on vis.patient_id equals pat.Patient_id
								   join doc in Db.Worker on vis.doctor_id equals doc.Worker_id
								   where param.visitId == vis.visit_id && param.phyExamId == phy_exam.Physical_examination_id
								   select new DBdataResult
                                   {
									   examType = exam.Examiantion_type,
									   examName = exam.Examination_name,
									   dateZle = vis.ending_date,
									   patientName = pat.First_name + " " + pat.Last_name,
									   examStatus = "n/d",
									   doctor = doc.First_name + " " + doc.Last_name,
									   notes = phy_exam.Result,
									   labWorker = String.Empty,
									   labResult = String.Empty,
									   labDate = DateTime.MinValue,
									   klabWorker = String.Empty,
									   klabNotes = String.Empty,
									   klabDate = (DateTime?)null
								   };
                    data = phy_data.First();
				}

                textBox5.Text = data.dateZle.HasValue ? data.dateZle.Value.ToString() : "";
                textBox1.Text = data.patientName;
                string examType = data.examType;
				textBox2.Text = examType == "L" ? "LABORATORYJNE" : "FIZYCZNE";
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
}
