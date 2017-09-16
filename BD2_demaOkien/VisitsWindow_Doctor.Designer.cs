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
            this.label1 = new System.Windows.Forms.Label();
            this.CalendarPanel = new System.Windows.Forms.Panel();
            this.daySchedulerMyVisits = new BD2_demaOkien.DayScheduler();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPerform = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPatientData = new System.Windows.Forms.Button();
            this.DataPanel.SuspendLayout();
            this.CalendarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataPanel
            // 
            this.DataPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataPanel.Controls.Add(this.button1);
            this.DataPanel.Controls.Add(this.dateTimeMyVisitsDate);
            this.DataPanel.Controls.Add(this.label1);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataPanel.Location = new System.Drawing.Point(0, 0);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(696, 59);
            this.DataPanel.TabIndex = 26;
            // 
            // dateTimeMyVisitsDate
            // 
            this.dateTimeMyVisitsDate.Checked = false;
            this.dateTimeMyVisitsDate.CustomFormat = "";
            this.dateTimeMyVisitsDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::BD2_demaOkien.Properties.Settings.Default, "chosenDateTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimeMyVisitsDate.Location = new System.Drawing.Point(102, 17);
            this.dateTimeMyVisitsDate.Name = "dateTimeMyVisitsDate";
            this.dateTimeMyVisitsDate.Size = new System.Drawing.Size(190, 20);
            this.dateTimeMyVisitsDate.TabIndex = 31;
            this.dateTimeMyVisitsDate.Value = global::BD2_demaOkien.Properties.Settings.Default.chosenDateTime;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Data wizyty      ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.AutoScroll = true;
            this.CalendarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CalendarPanel.Controls.Add(this.daySchedulerMyVisits);
            this.CalendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalendarPanel.Location = new System.Drawing.Point(0, 59);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.Size = new System.Drawing.Size(696, 429);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Zmień";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPatientData);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonPerform);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 447);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(696, 41);
            this.panel1.TabIndex = 28;
            // 
            // buttonPerform
            // 
            this.buttonPerform.AutoSize = true;
            this.buttonPerform.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPerform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPerform.Location = new System.Drawing.Point(5, 5);
            this.buttonPerform.Name = "buttonPerform";
            this.buttonPerform.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.buttonPerform.Size = new System.Drawing.Size(110, 31);
            this.buttonPerform.TabIndex = 19;
            this.buttonPerform.Text = "Przeprowadź";
            this.buttonPerform.UseVisualStyleBackColor = true;
            this.buttonPerform.Click += new System.EventHandler(this.buttonPerform_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(115, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.buttonCancel.Size = new System.Drawing.Size(110, 31);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Odwołaj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPatientData
            // 
            this.buttonPatientData.AutoSize = true;
            this.buttonPatientData.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPatientData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPatientData.Location = new System.Drawing.Point(225, 5);
            this.buttonPatientData.Name = "buttonPatientData";
            this.buttonPatientData.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.buttonPatientData.Size = new System.Drawing.Size(120, 31);
            this.buttonPatientData.TabIndex = 21;
            this.buttonPatientData.Text = "Dane pacjenta";
            this.buttonPatientData.UseVisualStyleBackColor = true;
            // 
            // VisitsWindow_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CalendarPanel);
            this.Controls.Add(this.DataPanel);
            this.Name = "VisitsWindow_Doctor";
            this.Text = "Moje wizyty";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VisitsWindow_Doctor_Load);
            this.DataPanel.ResumeLayout(false);
            this.CalendarPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CalendarPanel;
        private DayScheduler daySchedulerMyVisits;
        private System.Windows.Forms.DateTimePicker dateTimeMyVisitsDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPatientData;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPerform;
    }
}