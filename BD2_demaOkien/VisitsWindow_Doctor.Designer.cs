namespace BD2_demaOkien
{
    partial class VisitsWindow_Doctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataPanel = new System.Windows.Forms.Panel();
            this.dateTimeMyVisitsDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalendarPanel = new System.Windows.Forms.Panel();
            this.daySchedulerMyVisits = new BD2_demaOkien.DayScheduler();
            this.comboBoxMyVisitsPatient = new System.Windows.Forms.ComboBox();
            this.DataPanel.SuspendLayout();
            this.CalendarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataPanel
            // 
            this.DataPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataPanel.Controls.Add(this.comboBoxMyVisitsPatient);
            this.DataPanel.Controls.Add(this.dateTimeMyVisitsDate);
            this.DataPanel.Controls.Add(this.label3);
            this.DataPanel.Controls.Add(this.label1);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataPanel.Location = new System.Drawing.Point(0, 0);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(696, 88);
            this.DataPanel.TabIndex = 26;
            // 
            // dateTimeMyVisitsDate
            // 
            this.dateTimeMyVisitsDate.Checked = false;
            this.dateTimeMyVisitsDate.CustomFormat = "";
            this.dateTimeMyVisitsDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::BD2_demaOkien.Properties.Settings.Default, "chosenDateTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimeMyVisitsDate.Location = new System.Drawing.Point(94, 46);
            this.dateTimeMyVisitsDate.Name = "dateTimeMyVisitsDate";
            this.dateTimeMyVisitsDate.Size = new System.Drawing.Size(190, 20);
            this.dateTimeMyVisitsDate.TabIndex = 31;
            this.dateTimeMyVisitsDate.Value = global::BD2_demaOkien.Properties.Settings.Default.chosenDateTime;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Termin           ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pacjent           ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.AutoScroll = true;
            this.CalendarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CalendarPanel.Controls.Add(this.daySchedulerMyVisits);
            this.CalendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalendarPanel.Location = new System.Drawing.Point(0, 88);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.Size = new System.Drawing.Size(696, 400);
            this.CalendarPanel.TabIndex = 27;
            // 
            // daySchedulerMyVisits
            // 
            this.daySchedulerMyVisits.AllowItemEdit = false;
            this.daySchedulerMyVisits.AllowNew = false;
            this.daySchedulerMyVisits.CalendarTimeFormat = WindowsFormsCalendar.CalendarTimeFormat.TwentyFourHour;
            this.daySchedulerMyVisits.dayBegin = System.TimeSpan.Parse("08:00:00");
            this.daySchedulerMyVisits.dayEnd = System.TimeSpan.Parse("16:00:00");
            this.daySchedulerMyVisits.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.daySchedulerMyVisits.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.daySchedulerMyVisits.ItemsBackgroundColor = System.Drawing.Color.RoyalBlue;
            this.daySchedulerMyVisits.ItemsFont = null;
            this.daySchedulerMyVisits.ItemsForeColor = System.Drawing.Color.Black;
            this.daySchedulerMyVisits.Location = new System.Drawing.Point(0, -780);
            this.daySchedulerMyVisits.Name = "daySchedulerMyVisits";
            this.daySchedulerMyVisits.Size = new System.Drawing.Size(672, 1518);
            this.daySchedulerMyVisits.TabIndex = 24;
            this.daySchedulerMyVisits.Text = "dayScheduler";
            this.daySchedulerMyVisits.TimeScale = WindowsFormsCalendar.CalendarTimeScale.FifteenMinutes;
            // 
            // comboBoxMyVisitsPatient
            // 
            this.comboBoxMyVisitsPatient.FormattingEnabled = true;
            this.comboBoxMyVisitsPatient.Location = new System.Drawing.Point(94, 16);
            this.comboBoxMyVisitsPatient.Name = "comboBoxMyVisitsPatient";
            this.comboBoxMyVisitsPatient.Size = new System.Drawing.Size(588, 21);
            this.comboBoxMyVisitsPatient.TabIndex = 32;
            // 
            // VisitsWindow_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 488);
            this.Controls.Add(this.CalendarPanel);
            this.Controls.Add(this.DataPanel);
            this.Name = "VisitsWindow_Doctor";
            this.Text = "Moje wizyty";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VisitsWindow_Doctor_Load);
            this.DataPanel.ResumeLayout(false);
            this.CalendarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.DateTimePicker dateTimeMyVisitsDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CalendarPanel;
        private DayScheduler daySchedulerMyVisits;
        private System.Windows.Forms.ComboBox comboBoxMyVisitsPatient;

    }
}