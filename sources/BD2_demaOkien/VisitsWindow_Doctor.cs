using BD2_demaOkien.BizzLayer;
using BD2_demaOkien.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsCalendar;

namespace BD2_demaOkien
{
    public partial class VisitsWindow_Doctor : Form
    {
        private int? visitId;
        private DateTime date;
        public VisitsWindow_Doctor()
        {
            InitializeComponent();
            date = DateTime.Now;
        }

        private void VisitsWindow_Doctor_Load(object sender, EventArgs e)
        {
            ((MainWindow)this.MdiParent).RegisterMDI(this, OnDuplicateAction.CloseThis);
            setSchedulerDate(DateTime.Now);
            visitId = null;
        }

        private void setSchedulerDate(DateTime newDay)
        {
            daySchedulerMyVisits.SetViewRange(newDay, newDay);
            date = newDay;
//            int scroll = CalendarPanel.VerticalScroll.Value;
            RefreshData();
//            daySchedulerMyVisits.Focus();
//            CalendarPanel.VerticalScroll.Value = scroll;
        }
        private void RefreshData()
        { 
            var items = BizzLayer.Visits
                .Get(new VisitFilterParams
                {
                    dateFrom = date.Date,
                    dateTo = date.Date,
                    doctorID = MainWindow.userId
                })
                .Select(visit => new CalendarItem(daySchedulerMyVisits)
                    {
                        Text = "["+visit.status+"]   "+visit.Patient.First_name + " " + visit.Patient.Last_name,
                        StartDate = visit.ending_date.Value,
                        EndDate = visit.ending_date.Value.Add(new TimeSpan(0, 15, 0)),
                        BackgroundColor = (visit.status == "REJ" ? Color.Blue : visit.status == "ZAK" ? Color.Green : Color.Red),
                        Tag = visit.visit_id
                    }
                )
                .ToList();

            daySchedulerMyVisits.Items.Clear();
            daySchedulerMyVisits.Items.AddRange(items);
            daySchedulerMyVisits.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setSchedulerDate(dateTimeMyVisitsDate.Value);
        }

        private void buttonPerform_Click(object sender, EventArgs e)
        {
            if (!visitId.HasValue)
            {
                MainWindow.ShowError("Nie wybrano wizyty!");
                return;
            }
            new VisitsPerformWindow(visitId.Value).ShowDialog();
            RefreshData();
        }

        private void daySchedulerMyVisits_ItemCreating(object sender, CalendarItemCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void daySchedulerMyVisits_ItemFocusChanged(object sender, CalendarTimeEventArgs e)
        {
            visitId = null;
        }

        private void daySchedulerMyVisits_ItemSelected(object sender, CalendarItemEventArgs e)
        {
            if (e.Item != null)
                visitId = (int)e.Item.Tag;
        }

        private void buttonPatientData_Click(object sender, EventArgs e)
        {
            if (!visitId.HasValue)
            {
                MainWindow.ShowError("Nie wybrano wizyty!");
                return;
            }
            Visit visit = BizzLayer.Visits.GetByID(visitId.Value);
            new PatientDetailsWindow(ViewMode.VIEW_ONLY, visit.patient_id).ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (!visitId.HasValue)
            {
                MainWindow.ShowError("Nie wybrano wizyty!");
                return;
            }
            Visit visit = BizzLayer.Visits.GetByID(visitId.Value);

            if (BizzLayer.Visits.wasRegistered(visit.visit_id))
            {
                if (MainWindow.ShowQuestion("Jesteś pewny, że chcesz anulować wizytę: " + Environment.NewLine + visit.Patient.First_name + " " + visit.Patient.Last_name, "Anulowanie wizyty"))
                {
                    BizzLayer.Visits.Cancel(visit.visit_id);  
                }
            }
            else
            {
                MainWindow.ShowError("Można anulować tylko zarejestrowaną wizytę.");
            }
            RefreshData();
        }

        private void VisitsWindow_Doctor_Activated(object sender, EventArgs e)
        {
            this.dateTimeMyVisitsDate.Value = date;
        }
    }
}
