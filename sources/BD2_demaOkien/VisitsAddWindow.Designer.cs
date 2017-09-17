using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsCalendar;

namespace BD2_demaOkien
{
    partial class VisitsAddWindow
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
            this.CalendarPanel = new PanelNoScrollOnFocus();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.textBoxPatientName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimeVisitTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeVisitDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.buttonChooseDoctor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPatientPESEL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dayScheduler = new BD2_demaOkien.DayScheduler();
            this.CalendarPanel.SuspendLayout();
            this.ResultPanel.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.ViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.AutoScroll = true;
            this.CalendarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CalendarPanel.Controls.Add(this.dayScheduler);
            this.CalendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalendarPanel.Location = new System.Drawing.Point(0, 145);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.Size = new System.Drawing.Size(456, 273);
            this.CalendarPanel.TabIndex = 0;
            // 
            // ResultPanel
            // 
            this.ResultPanel.AutoSize = true;
            this.ResultPanel.Controls.Add(this.buttonCancel);
            this.ResultPanel.Controls.Add(this.buttonApply);
            this.ResultPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResultPanel.Location = new System.Drawing.Point(0, 418);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(456, 35);
            this.ResultPanel.TabIndex = 23;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(118, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Porzuć";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonApply.Location = new System.Drawing.Point(12, 2);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(100, 30);
            this.buttonApply.TabIndex = 18;
            this.buttonApply.Text = "Zatwierdź";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // DataPanel
            // 
            this.DataPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataPanel.Controls.Add(this.textBoxPatientName);
            this.DataPanel.Controls.Add(this.button1);
            this.DataPanel.Controls.Add(this.dateTimeVisitTime);
            this.DataPanel.Controls.Add(this.label4);
            this.DataPanel.Controls.Add(this.dateTimeVisitDate);
            this.DataPanel.Controls.Add(this.label3);
            this.DataPanel.Controls.Add(this.comboBoxDoctor);
            this.DataPanel.Controls.Add(this.buttonChooseDoctor);
            this.DataPanel.Controls.Add(this.label2);
            this.DataPanel.Controls.Add(this.textBoxPatientPESEL);
            this.DataPanel.Controls.Add(this.label1);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataPanel.Location = new System.Drawing.Point(0, 0);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(456, 145);
            this.DataPanel.TabIndex = 25;
            // 
            // textBoxPatientName
            // 
            this.textBoxPatientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPatientName.Enabled = false;
            this.textBoxPatientName.Location = new System.Drawing.Point(175, 17);
            this.textBoxPatientName.Name = "textBoxPatientName";
            this.textBoxPatientName.Size = new System.Drawing.Size(241, 20);
            this.textBoxPatientName.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Wyświetl godziny";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSetScheduler);
            // 
            // dateTimeVisitTime
            // 
            this.dateTimeVisitTime.CustomFormat = "HH:mm";
            this.dateTimeVisitTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::BD2_demaOkien.Properties.Settings.Default, "chosenDateTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimeVisitTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeVisitTime.Location = new System.Drawing.Point(94, 96);
            this.dateTimeVisitTime.Name = "dateTimeVisitTime";
            this.dateTimeVisitTime.ShowUpDown = true;
            this.dateTimeVisitTime.Size = new System.Drawing.Size(60, 20);
            this.dateTimeVisitTime.TabIndex = 30;
            this.dateTimeVisitTime.Value = global::BD2_demaOkien.Properties.Settings.Default.chosenDateTime;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Godzina          ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dateTimeVisitDate
            // 
            this.dateTimeVisitDate.Checked = false;
            this.dateTimeVisitDate.CustomFormat = "";
            this.dateTimeVisitDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::BD2_demaOkien.Properties.Settings.Default, "chosenDateTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimeVisitDate.Location = new System.Drawing.Point(94, 69);
            this.dateTimeVisitDate.Name = "dateTimeVisitDate";
            this.dateTimeVisitDate.Size = new System.Drawing.Size(207, 20);
            this.dateTimeVisitDate.TabIndex = 31;
            this.dateTimeVisitDate.Value = global::BD2_demaOkien.Properties.Settings.Default.chosenDateTime;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Data              ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(94, 42);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(322, 21);
            this.comboBoxDoctor.TabIndex = 27;
            // 
            // buttonChooseDoctor
            // 
            this.buttonChooseDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChooseDoctor.Location = new System.Drawing.Point(414, 41);
            this.buttonChooseDoctor.Name = "buttonChooseDoctor";
            this.buttonChooseDoctor.Size = new System.Drawing.Size(25, 23);
            this.buttonChooseDoctor.TabIndex = 28;
            this.buttonChooseDoctor.Text = "...";
            this.buttonChooseDoctor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonChooseDoctor.UseVisualStyleBackColor = true;
            this.buttonChooseDoctor.Click += new System.EventHandler(this.buttonChooseDoctor_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Lekarz           ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxPatientPESEL
            // 
            this.textBoxPatientPESEL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPatientPESEL.Enabled = false;
            this.textBoxPatientPESEL.Location = new System.Drawing.Point(94, 17);
            this.textBoxPatientPESEL.Name = "textBoxPatientPESEL";
            this.textBoxPatientPESEL.Size = new System.Drawing.Size(75, 20);
            this.textBoxPatientPESEL.TabIndex = 24;
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
            // ViewPanel
            // 
            this.ViewPanel.AutoSize = true;
            this.ViewPanel.Controls.Add(this.buttonEdit);
            this.ViewPanel.Controls.Add(this.buttonClose);
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ViewPanel.Location = new System.Drawing.Point(0, 453);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(456, 35);
            this.ViewPanel.TabIndex = 26;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.Location = new System.Drawing.Point(344, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 30);
            this.buttonEdit.TabIndex = 19;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.Location = new System.Drawing.Point(12, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 30);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "Powrót";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // dayScheduler
            // 
            this.dayScheduler.AllowItemEdit = false;
            this.dayScheduler.AllowItemResize = false;
            this.dayScheduler.AllowNew = false;
            this.dayScheduler.CalendarTimeFormat = WindowsFormsCalendar.CalendarTimeFormat.TwentyFourHour;
            this.dayScheduler.dayBegin = System.TimeSpan.Parse("08:00:00");
            this.dayScheduler.dayEnd = System.TimeSpan.Parse("16:00:00");
            this.dayScheduler.Enabled = false;
            this.dayScheduler.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dayScheduler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dayScheduler.ItemsBackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dayScheduler.ItemsFont = null;
            this.dayScheduler.ItemsForeColor = System.Drawing.Color.Black;
            this.dayScheduler.Location = new System.Drawing.Point(0, -780);
            this.dayScheduler.Name = "dayScheduler";
            this.dayScheduler.Size = new System.Drawing.Size(435, 1518);
            this.dayScheduler.TabIndex = 24;
            this.dayScheduler.Text = "dayScheduler";
            this.dayScheduler.TimeScale = WindowsFormsCalendar.CalendarTimeScale.FifteenMinutes;
            this.dayScheduler.ItemFocusChanged += new BD2_demaOkien.DayScheduler.CalendarTimeEventHandler(this.dayScheduler_ItemFocusChanged);
            this.dayScheduler.ItemCreating += new WindowsFormsCalendar.Calendar.CalendarItemCancelEventHandler(this.dayScheduler_ItemCreating);
            this.dayScheduler.ItemSelected += new WindowsFormsCalendar.Calendar.CalendarItemEventHandler(this.dayScheduler_ItemSelected);
            // 
            // VisitsAddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 488);
            this.Controls.Add(this.CalendarPanel);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.ViewPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisitsAddWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nowa wizyta";
            this.Load += new System.EventHandler(this.VisitDetailsWindow_Register_Load);
            this.CalendarPanel.ResumeLayout(false);
            this.ResultPanel.ResumeLayout(false);
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.ViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PanelNoScrollOnFocus CalendarPanel;
        private Panel ResultPanel;
        private Button buttonCancel;
        private Button buttonApply;
        private DayScheduler dayScheduler;
        private Panel DataPanel;
        private DateTimePicker dateTimeVisitDate;
        private DateTimePicker dateTimeVisitTime;
        private Label label3;
        private ComboBox comboBoxDoctor;
        private Button buttonChooseDoctor;
        private Label label2;
        private TextBox textBoxPatientPESEL;
        private Label label1;
        private Panel ViewPanel;
        private Button buttonEdit;
        private Button buttonClose;
        private Button button1;
        private Label label4;
        private TextBox textBoxPatientName;
    }
}